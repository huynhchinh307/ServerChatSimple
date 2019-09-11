using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerCTech
{
    class ServerCommand
    {
        Socket Server;
        public ServerCommand(Socket server)
        {
            Server = server;
        }
        public string code(string cmd)
        {
            switch (cmd)
            {
                case "Xin chào":
                    {
                        // A array of result
                        string[] result = {"Chào bạn, tôi có thể giúp gì cho bạn?", "Chào", "Nice to meet you", "Hello !!!", "Hi there" };
                        // Create a Random object
                        Random rand = new Random();
                        // Generate a random index less than the size of the array.  
                        int index = rand.Next(result.Length);
                        // Return the result.  
                        return result[index];
                        break;
                    };
                case "hi":
                    {
                        // A array of result
                        string[] result = { "Chào bạn, tôi có thể giúp gì cho bạn?", "Chào", "Nice to meet you", "Hello !!!", "Hi there" };
                        // Create a Random object
                        Random rand = new Random();
                        // Generate a random index less than the size of the array.  
                        int index = rand.Next(result.Length);
                        // Return the result.  
                        return result[index];
                        break;
                    };
                case "xin chào":
                    {
                        // A array of result
                        string[] result = { "Chào bạn, tôi có thể giúp gì cho bạn?", "Chào", "Nice to meet you", "Hello !!!", "Hi there" };
                        // Create a Random object
                        Random rand = new Random();
                        // Generate a random index less than the size of the array.  
                        int index = rand.Next(result.Length);
                        // Return the result.  
                        return result[index];
                        break;
                    };
                case "hello":
                    {
                        // A array of result
                        string[] result = { "Chào bạn, tôi có thể giúp gì cho bạn?", "Chào", "Nice to meet you", "Hello !!!", "Hi there" };
                        // Create a Random object
                        Random rand = new Random();
                        // Generate a random index less than the size of the array.  
                        int index = rand.Next(result.Length);
                        // Return the result.  
                        return result[index];
                        break;
                    };
                case "Hello":
                    {
                        // A array of result
                        string[] result = { "Chào bạn, tôi có thể giúp gì cho bạn?", "Chào", "Nice to meet you", "Hello !!!", "Hi there" };
                        // Create a Random object
                        Random rand = new Random();
                        // Generate a random index less than the size of the array.  
                        int index = rand.Next(result.Length);
                        // Return the result.  
                        return result[index];
                        break;
                    };
                case "/time": {
                        return "Hiện tại là " +DateTime.Now.ToShortTimeString();
                        break; };
                case "/date":
                    {
                        return "Hiện tại là "+ DateTime.Now.ToShortDateString();
                        break;
                    }
                default: return "Lệnh chưa được cập nhật trên server";
            }
        }
        public string CountOnline()
        {
            return Server.Available.ToString();
        }
    }
}
