﻿namespace ServerCTech
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Log = new System.Windows.Forms.ListBox();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel_Move = new System.Windows.Forms.Panel();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELLCOME TO SERVER";
            // 
            // lst_Log
            // 
            this.lst_Log.BackColor = System.Drawing.SystemColors.WindowText;
            this.lst_Log.ForeColor = System.Drawing.Color.Lime;
            this.lst_Log.FormattingEnabled = true;
            this.lst_Log.Location = new System.Drawing.Point(164, 248);
            this.lst_Log.Name = "lst_Log";
            this.lst_Log.ScrollAlwaysVisible = true;
            this.lst_Log.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_Log.Size = new System.Drawing.Size(493, 108);
            this.lst_Log.TabIndex = 1;
            // 
            // btn_quit
            // 
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Location = new System.Drawing.Point(13, 332);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(111, 23);
            this.btn_quit.TabIndex = 2;
            this.btn_quit.Text = "-Quit-";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Location = new System.Drawing.Point(13, 187);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(111, 55);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restart.Location = new System.Drawing.Point(12, 248);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(111, 55);
            this.btn_Restart.TabIndex = 4;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(164, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Account";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel_Move
            // 
            this.panel_Move.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel_Move.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Move.Location = new System.Drawing.Point(0, 0);
            this.panel_Move.Name = "panel_Move";
            this.panel_Move.Size = new System.Drawing.Size(670, 29);
            this.panel_Move.TabIndex = 9;
            this.panel_Move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Move_MouseDown);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(395, 205);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(190, 20);
            this.txtSend.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(592, 204);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbxClient
            // 
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(258, 204);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(121, 21);
            this.cbxClient.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServerCTech.Properties.Resources._thumbnail;
            this.pictureBox1.Location = new System.Drawing.Point(258, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(670, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxClient);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.panel_Move);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.lst_Log);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lst_Log;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Move;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

