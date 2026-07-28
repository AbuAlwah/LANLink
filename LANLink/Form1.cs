using System;
using System.Drawing;
using System.Windows.Forms;

namespace LANLink
{
    public partial class Form1 : Form
    {
        private SimpleChat chatServer;

        public Form1()
        {
            InitializeComponent();
        }

        // 1️⃣ عند فتح البرنامج
        private void Form1_Load(object sender, EventArgs e)
        {
            // جلب الـ IP الخاص بك
            string myIP = NetworkManager.GetLocalIPAddress();
            lblMyIP.Text = $"My IP: {myIP}";

            // المنفذ الافتراضي
            txtPort.Text = "8080";

            // تشغيل سيرفر الاستماع للرسائل القادمة
            StartChatServer();
        }

        // 2️⃣ تشغيل سيرفر استقبال الرسائل
        private void StartChatServer()
        {
            if (int.TryParse(txtPort.Text, out int myPort))
            {
                chatServer?.Stop();
                chatServer = new SimpleChat();
                chatServer.OnMessageReceived = MessageReceivedHandler;
                chatServer.StartListening(myPort);
            }
        }

        // 3️⃣ استقبال الرسائل القادمة وعرضها في قائمة الشات
        private void MessageReceivedHandler(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MessageReceivedHandler(message)));
                return;
            }

            string time = DateTime.Now.ToString("hh:mm tt");
            lstChat.Items.Add($"[{time}] Peer: {message}");
        }

        // 4️⃣ زر الإرسال (Send)
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text)) return;

            // نحدد الـ IP والـ Port للجهاز المراد مراسلته (للتجربة المحلية نرسل لنفسنا أو لنافذة أخرى)
            string targetIP = "127.0.0.1";

            // يمكنك تغيير المنفذ هنا للتجربة بين نافذتين (مثلاً 8080 أو 8081)
            int targetPort = 8080;

            try
            {
                // إرسال النص عبر TCP
                SimpleChat.SendMessage(targetIP, targetPort, txtInput.Text);

                // إضافة النص في شاشتك
                string time = DateTime.Now.ToString("hh:mm tt");
                lstChat.Items.Add($"[{time}] Me: {txtInput.Text}");

                // مسح خانة النص
                txtInput.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("تعذر الإرسال: " + ex.Message, "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5️⃣ إيقاف السيرفر عند إغلاق البرنامج
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            chatServer?.Stop();
        }
    }
}