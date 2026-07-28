using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace LANLink
{
    public class SimpleChat
    {
        private TcpListener listener;
        private Thread listenThread;
        public Action<string> OnMessageReceived; 

        public void StartListening(int port)
        {
            listenThread = new Thread(() =>
            {
                try
                {
                    listener = new TcpListener(IPAddress.Any, port);
                    listener.Start();

                    while (true)
                    {
                        TcpClient client = listener.AcceptTcpClient();
                        StreamReader reader = new StreamReader(client.GetStream());
                        string message = reader.ReadLine();

                        if (!string.IsNullOrEmpty(message))
                        {
                            OnMessageReceived?.Invoke(message);
                        }
                        client.Close();
                    }
                }
                catch
                {
                }
            });

            listenThread.IsBackground = true;
            listenThread.Start();
        }

        public static void SendMessage(string ip, int port, string message)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(ip, port);
                    using (StreamWriter writer = new StreamWriter(client.GetStream()))
                    {
                        writer.WriteLine(message);
                        writer.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("تعذر الإرسال: " + ex.Message);
            }
        }

        public void Stop()
        {
            listener?.Stop();
            listenThread?.Abort();
        }
    }
}