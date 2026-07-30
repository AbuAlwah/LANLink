using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
               // 1. End receive operation to get the actual number of bytes received 
                int size = sck.EndReceiveFrom(aResult, ref epRemote);

                if (size > 0)
                {
                    byte[] receiveData = (byte[])aResult.AsyncState;

                    // 2. Convert ONLY received bytes to string, not the entire 1500 buffer
                    ASCIIEncoding aEncoding = new ASCIIEncoding();
                    string receivedMessage = aEncoding.GetString(receiveData, 0, size);

                    // 3. Add message to the UI thread
                    this.Invoke(new MethodInvoker(delegate
                    {
                        AddBubbleMessage(receivedMessage, false);
                    }));
                }

                // 4. Re-listen for the next incoming message
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                // Ignore errors if the Socket is closed
            }
        }

        private void AddBubbleMessage(string messageText, bool isMe)
        {
            // 1. Calculate available width inside flowLayoutMessage
            int containerWidth = flowLayoutMessage.ClientSize.Width - 25;
            if (containerWidth < 100) containerWidth = 300;

            // 2. Create outer container for the row
            Panel rowPanel = new Panel();
            rowPanel.Width = containerWidth;
            rowPanel.BackColor = Color.Transparent;
            rowPanel.Margin = new Padding(0, 3, 0, 3);

            // 3. Create main card panel
            Panel mainCard = new Panel();
            mainCard.BackColor = Color.Transparent;

            // 4. Header label (Sender Name & Timestamp)
            Label lblHeader = new Label();
            lblHeader.Text = $"{(isMe ? "Me" : "Friend")}  {DateTime.Now.ToString("hh:mm tt")}";
            lblHeader.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblHeader.ForeColor = isMe ? Color.FromArgb(200, 230, 255) : Color.FromArgb(46, 204, 113);
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.TextAlign = ContentAlignment.MiddleLeft; 
            lblHeader.Padding = new Padding(2, 0, 0, 2);

            // 5. Message label
            Label lblMessage = new Label();
            lblMessage.Text = messageText;
            lblMessage.Font = new Font("Segoe UI", 9.5F);
            lblMessage.ForeColor = Color.White;
            lblMessage.AutoSize = true;
            lblMessage.MaximumSize = new Size((int)(containerWidth * 0.65), 0);
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.BackColor = Color.Transparent;

            // 6. Colored bubble container
            Panel textBubble = new Panel();
            Color bubbleColor = isMe ? Color.FromArgb(0, 122, 204) : Color.FromArgb(45, 48, 62);
            textBubble.BackColor = Color.Transparent;
            textBubble.Padding = new Padding(12, 6, 12, 6); 
            textBubble.Dock = DockStyle.Top;
            textBubble.AutoSize = true;

            // Render rounded corners
            textBubble.Paint += (s, pe) =>
            {
                Graphics g = pe.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                int radius = 12; 
                Rectangle rect = new Rectangle(0, 0, textBubble.Width - 1, textBubble.Height - 1);

                using (GraphicsPath path = GetRoundedPath(rect, radius))
                using (SolidBrush brush = new SolidBrush(bubbleColor))
                {
                    g.FillPath(brush, path);
                }
            };

            // Add message text to the colored bubble
            textBubble.Controls.Add(lblMessage);

            // Assemble controls inside the main card
            mainCard.Controls.Add(textBubble);
            mainCard.Controls.Add(lblHeader);

            // Calculate exact width without fixed minimum size (shrinks for small texts)
            Size textSize = TextRenderer.MeasureText(messageText, lblMessage.Font);
            int bubbleWidth = Math.Min(textSize.Width + 28, (int)(containerWidth * 0.65));

            // Ensure enough width for header if message text is shorter than header
            Size headerSize = TextRenderer.MeasureText(lblHeader.Text, lblHeader.Font);
            int finalWidth = Math.Max(bubbleWidth, headerSize.Width + 10);

            mainCard.Size = new Size(finalWidth, lblHeader.Height + textBubble.PreferredSize.Height + 2);

            // Set placement & alignment (Far Right for 'Me' / Far Left for 'Friend')
            if (isMe)
            {
                mainCard.Location = new Point(containerWidth - mainCard.Width - 10, 0);
            }
            else
            {
                mainCard.Location = new Point(5, 0);
            }

            rowPanel.Height = mainCard.Height + 2;
            rowPanel.Controls.Add(mainCard);

            // Add row to FlowLayoutPanel and scroll to bottom
            flowLayoutMessage.Controls.Add(rowPanel);
            flowLayoutMessage.ScrollControlIntoView(rowPanel);
        }

        // Helper function to draw rounded corners
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2F;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

    }
}