using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Configuration;

namespace ServerCTech
{
    
    public partial class Main : Form
    {
        int online = 0; //Number client online
        byte[] data = new byte[1024];
        int size = 1024;
        int sttServer = 0; //Status server 0-Close 1-Open
        IPAddress ip;
        IPEndPoint ie;
        Socket server, client;
        //Move form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Main()
        {
            InitializeComponent();
        }
        private void panel_Move_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ip = IPAddress.Parse(ConfigurationManager.AppSettings["IPServer"]);
            int port = int.Parse(ConfigurationManager.AppSettings["Port"]);
            ie = new IPEndPoint(ip, port);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if(sttServer==0)
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(ie);
                server.Listen(10);
                lst_Log.Items.Add("Waiting client connect.......\t"+ DateTime.Now);
                sttServer = 1;
                btn_Start.Text = "Stop";
                server.BeginAccept(new AsyncCallback(AcceptConn), server);
            }
            else
            {
                
                if(online>0 )
                {
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                    online = 0;
                }
                sttServer = 0;
                server.Close();
                btn_Start.Text = "Start";
                sttServer = 0;
                lst_Log.Items.Add("--------------Server shutdown--------------\t"+DateTime.Now);
            }
            
        }
        void AcceptConn(IAsyncResult iar)
        {
            if (sttServer == 1)
            {
                Socket oldserver = (Socket)iar.AsyncState;
                client = oldserver.EndAccept(iar);
                online = online + 1;
                lst_Log.Invoke(new Action(() => lst_Log.Items.Add("Connected to: " + client.RemoteEndPoint.ToString())));
                lst_Log.Invoke(new Action(() => lst_Log.Items.Add("Number client online: " + online)));
                string stringData = "WELLCOME TO CTECH. GOOD DAY";
                byte[] message1 = Encoding.UTF8.GetBytes(stringData);
                client.BeginSend(message1, 0, message1.Length, SocketFlags.None, new
                                            AsyncCallback(SendData), client);
                server.BeginAccept(new AsyncCallback(AcceptConn), server);
            }
        }
        void SendData(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            int sent = client.EndSend(iar);
            client.BeginReceive(data, 0, size, SocketFlags.None, new
                                    AsyncCallback(ReceiveData), client);
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            lst_Log.Items.Clear();
        }

        void ReceiveData(IAsyncResult iar)
        {
            if(sttServer==1)
            {
                Socket client = (Socket)iar.AsyncState;
                int recv = client.EndReceive(iar);
                if (recv == 0)
                {
                    online = online - 1;
                    client.Close();
                    lst_Log.Invoke(new Action(() => lst_Log.Items.Add("Number client online: " + online)));
                    server.BeginAccept(new AsyncCallback(AcceptConn), server);
                    return;
                }
                string receivedData = Encoding.UTF8.GetString(data, 0, recv);
                lst_Log.Invoke(new Action(() => lst_Log.Items.Add("Received from: " + client.RemoteEndPoint + " =" + receivedData)));
                if (receivedData.Equals("/exit"))
                {
                    byte[] exit = Encoding.UTF8.GetBytes("exit-ok");
                    lst_Log.Invoke(new Action(() => lst_Log.Items.Add("Client: " + client.RemoteEndPoint + " đã ngắt kết nối!!!")));
                    client.BeginSend(exit, 0, exit.Length, SocketFlags.None, new AsyncCallback(SendData), client);
                }
                else
                {
                    ServerCommand command = new ServerCommand(server);
                    byte[] message2 = Encoding.UTF8.GetBytes(command.code(receivedData));
                    client.BeginSend(message2, 0, message2.Length, SocketFlags.None, new AsyncCallback(SendData), client);
                }
            }
        }


    }
}
