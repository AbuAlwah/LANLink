using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LANLink
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get user IP
            txtLocalIp.Text = GetLocalIP();
            txtRemoteIp.Text = GetLocalIP();

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(txtLocalIp.Text), Convert.ToInt32(txtLocalPort.Text));
            sck.Bind(epLocal);

            // Connecting to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(txtRemoteIp.Text), Convert.ToInt32(txtRemotePort.Text));
            sck.Connect(epRemote);

            // Listening the specific port 
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
{

            };
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            byte[] receiveData = new byte[1500];
            receiveData = (byte[])aResult.AsyncState;

            // Converting byte[] to string
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            string receivedMessage = aEncoding.GetString(receiveData);
        }
    }
}