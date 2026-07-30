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

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that the text is not empty
                if (!string.IsNullOrWhiteSpace(txtMessage.Text))
                {
                    // 1. Convert text to bytes
                    ASCIIEncoding aEncoding = new ASCIIEncoding();
                    byte[] sendingMessage = new byte[1500];
                    sendingMessage = aEncoding.GetBytes(txtMessage.Text);

                    // 2. Send data via Socket
                    sck.Send(sendingMessage);

                    // 3. Add a message bubble in FlowLayoutPanel
                    AddBubbleMessage(txtMessage.Text, true);

                    // 4. Unpack the textBox and refocus on it
                    txtMessage.Text = "";
                    txtMessage.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("First before sending, make sure to click on Connect!\n\nDetails: " + ex.Message,
                                "Sending Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}