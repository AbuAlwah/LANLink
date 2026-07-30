namespace LANLink
{
    partial class Form1
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
            this.panelHeader = new ReaLTaiizor.Controls.Panel();
            this.iconExit = new ReaLTaiizor.Controls.HopePictureBox();
            this.labelLANLink = new ReaLTaiizor.Controls.HeaderLabel();
            this.labelP2PNetworkMessenger = new ReaLTaiizor.Controls.LabelEdit();
            this.iconLANLink = new ReaLTaiizor.Controls.HopePictureBox();
            this.panelBottom = new ReaLTaiizor.Controls.Panel();
            this.buttonSend = new Guna.UI2.WinForms.Guna2Button();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelClientMe = new ReaLTaiizor.Controls.Panel();
            this.labelLocalPort = new ReaLTaiizor.Controls.LabelEdit();
            this.txtLocalPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLocalIp = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelLocalIp = new ReaLTaiizor.Controls.LabelEdit();
            this.labelLocalEndpoint = new ReaLTaiizor.Controls.LabelEdit();
            this.labelClientMe = new ReaLTaiizor.Controls.HeaderLabel();
            this.iconClientMe = new ReaLTaiizor.Controls.HopePictureBox();
            this.buttonConnect = new Guna.UI2.WinForms.Guna2Button();
            this.panelClientFriend = new ReaLTaiizor.Controls.Panel();
            this.labelRemotePort = new ReaLTaiizor.Controls.LabelEdit();
            this.txtRemotePort = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRemoteIp = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelRemoteIp = new ReaLTaiizor.Controls.LabelEdit();
            this.labelRemoteEndpoint = new ReaLTaiizor.Controls.LabelEdit();
            this.labelClientFriend = new ReaLTaiizor.Controls.HeaderLabel();
            this.iconClientFriend = new ReaLTaiizor.Controls.HopePictureBox();
            this.flowLayoutMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCenter = new ReaLTaiizor.Controls.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLANLink)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelClientMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClientMe)).BeginInit();
            this.panelClientFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClientFriend)).BeginInit();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.panelHeader.Controls.Add(this.iconExit);
            this.panelHeader.Controls.Add(this.labelLANLink);
            this.panelHeader.Controls.Add(this.labelP2PNetworkMessenger);
            this.panelHeader.Controls.Add(this.iconLANLink);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(5);
            this.panelHeader.Size = new System.Drawing.Size(1265, 98);
            this.panelHeader.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelHeader.TabIndex = 1;
            this.panelHeader.Text = "panel1";
            // 
            // iconExit
            // 
            this.iconExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.iconExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconExit.Image = global::LANLink.Properties.Resources._CITYPNG_COM_Blue_Round_Close_X_Icon_HD_PNG___700x700;
            this.iconExit.Location = new System.Drawing.Point(1111, 30);
            this.iconExit.Name = "iconExit";
            this.iconExit.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.iconExit.Size = new System.Drawing.Size(44, 42);
            this.iconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconExit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.iconExit.TabIndex = 4;
            this.iconExit.TabStop = false;
            this.iconExit.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // labelLANLink
            // 
            this.labelLANLink.AutoSize = true;
            this.labelLANLink.BackColor = System.Drawing.Color.Transparent;
            this.labelLANLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelLANLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelLANLink.Location = new System.Drawing.Point(188, 30);
            this.labelLANLink.Name = "labelLANLink";
            this.labelLANLink.Size = new System.Drawing.Size(88, 24);
            this.labelLANLink.TabIndex = 2;
            this.labelLANLink.Text = "LANLink";
            // 
            // labelP2PNetworkMessenger
            // 
            this.labelP2PNetworkMessenger.AutoSize = true;
            this.labelP2PNetworkMessenger.BackColor = System.Drawing.Color.Transparent;
            this.labelP2PNetworkMessenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelP2PNetworkMessenger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelP2PNetworkMessenger.Location = new System.Drawing.Point(188, 54);
            this.labelP2PNetworkMessenger.Name = "labelP2PNetworkMessenger";
            this.labelP2PNetworkMessenger.Size = new System.Drawing.Size(174, 18);
            this.labelP2PNetworkMessenger.TabIndex = 1;
            this.labelP2PNetworkMessenger.Text = "P2P Network Messenger";
            // 
            // iconLANLink
            // 
            this.iconLANLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.iconLANLink.Image = global::LANLink.Properties.Resources.link;
            this.iconLANLink.Location = new System.Drawing.Point(138, 30);
            this.iconLANLink.Name = "iconLANLink";
            this.iconLANLink.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.iconLANLink.Size = new System.Drawing.Size(44, 42);
            this.iconLANLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconLANLink.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.iconLANLink.TabIndex = 0;
            this.iconLANLink.TabStop = false;
            this.iconLANLink.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.panelBottom.Controls.Add(this.buttonSend);
            this.panelBottom.Controls.Add(this.txtMessage);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panelBottom.Location = new System.Drawing.Point(0, 805);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(5);
            this.panelBottom.Size = new System.Drawing.Size(1265, 117);
            this.panelBottom.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelBottom.TabIndex = 2;
            this.panelBottom.Text = "panel2";
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.buttonSend.BorderRadius = 10;
            this.buttonSend.BorderThickness = 1;
            this.buttonSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSend.FillColor = System.Drawing.Color.Green;
            this.buttonSend.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(1078, 21);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(77, 45);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Text = " ➤";
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.txtMessage.BorderRadius = 10;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Location = new System.Drawing.Point(137, 21);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PlaceholderText = "  Type a message...";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(924, 45);
            this.txtMessage.TabIndex = 9;
            // 
            // panelClientMe
            // 
            this.panelClientMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.panelClientMe.Controls.Add(this.labelLocalPort);
            this.panelClientMe.Controls.Add(this.txtLocalPort);
            this.panelClientMe.Controls.Add(this.txtLocalIp);
            this.panelClientMe.Controls.Add(this.labelLocalIp);
            this.panelClientMe.Controls.Add(this.labelLocalEndpoint);
            this.panelClientMe.Controls.Add(this.labelClientMe);
            this.panelClientMe.Controls.Add(this.iconClientMe);
            this.panelClientMe.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panelClientMe.Location = new System.Drawing.Point(137, 6);
            this.panelClientMe.Name = "panelClientMe";
            this.panelClientMe.Padding = new System.Windows.Forms.Padding(5);
            this.panelClientMe.Size = new System.Drawing.Size(499, 196);
            this.panelClientMe.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelClientMe.TabIndex = 0;
            this.panelClientMe.Text = "panel4";
            // 
            // labelLocalPort
            // 
            this.labelLocalPort.AutoSize = true;
            this.labelLocalPort.BackColor = System.Drawing.Color.Transparent;
            this.labelLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelLocalPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelLocalPort.Location = new System.Drawing.Point(261, 96);
            this.labelLocalPort.Name = "labelLocalPort";
            this.labelLocalPort.Size = new System.Drawing.Size(36, 18);
            this.labelLocalPort.TabIndex = 9;
            this.labelLocalPort.Text = "Port";
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.txtLocalPort.BorderRadius = 10;
            this.txtLocalPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalPort.DefaultText = "";
            this.txtLocalPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocalPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocalPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocalPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocalPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.txtLocalPort.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtLocalPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLocalPort.ForeColor = System.Drawing.Color.White;
            this.txtLocalPort.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtLocalPort.Location = new System.Drawing.Point(264, 132);
            this.txtLocalPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.PlaceholderText = "";
            this.txtLocalPort.SelectedText = "";
            this.txtLocalPort.Size = new System.Drawing.Size(202, 42);
            this.txtLocalPort.TabIndex = 8;
            // 
            // txtLocalIp
            // 
            this.txtLocalIp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.txtLocalIp.BorderRadius = 10;
            this.txtLocalIp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalIp.DefaultText = "";
            this.txtLocalIp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocalIp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocalIp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocalIp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocalIp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.txtLocalIp.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtLocalIp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLocalIp.ForeColor = System.Drawing.Color.White;
            this.txtLocalIp.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtLocalIp.Location = new System.Drawing.Point(24, 132);
            this.txtLocalIp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocalIp.Name = "txtLocalIp";
            this.txtLocalIp.PlaceholderText = "";
            this.txtLocalIp.SelectedText = "";
            this.txtLocalIp.Size = new System.Drawing.Size(202, 42);
            this.txtLocalIp.TabIndex = 7;
            // 
            // labelLocalIp
            // 
            this.labelLocalIp.AutoSize = true;
            this.labelLocalIp.BackColor = System.Drawing.Color.Transparent;
            this.labelLocalIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelLocalIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelLocalIp.Location = new System.Drawing.Point(21, 96);
            this.labelLocalIp.Name = "labelLocalIp";
            this.labelLocalIp.Size = new System.Drawing.Size(118, 18);
            this.labelLocalIp.TabIndex = 6;
            this.labelLocalIp.Text = "Local IP address";
            // 
            // labelLocalEndpoint
            // 
            this.labelLocalEndpoint.AutoSize = true;
            this.labelLocalEndpoint.BackColor = System.Drawing.Color.Transparent;
            this.labelLocalEndpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelLocalEndpoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelLocalEndpoint.Location = new System.Drawing.Point(75, 54);
            this.labelLocalEndpoint.Name = "labelLocalEndpoint";
            this.labelLocalEndpoint.Size = new System.Drawing.Size(104, 18);
            this.labelLocalEndpoint.TabIndex = 5;
            this.labelLocalEndpoint.Text = "Local endpoint";
            // 
            // labelClientMe
            // 
            this.labelClientMe.AutoSize = true;
            this.labelClientMe.BackColor = System.Drawing.Color.Transparent;
            this.labelClientMe.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelClientMe.Location = new System.Drawing.Point(74, 30);
            this.labelClientMe.Name = "labelClientMe";
            this.labelClientMe.Size = new System.Drawing.Size(114, 22);
            this.labelClientMe.TabIndex = 4;
            this.labelClientMe.Text = "Client 1 (Me)";
            // 
            // iconClientMe
            // 
            this.iconClientMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.iconClientMe.Image = global::LANLink.Properties.Resources.laptop__1_;
            this.iconClientMe.Location = new System.Drawing.Point(24, 30);
            this.iconClientMe.Name = "iconClientMe";
            this.iconClientMe.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.iconClientMe.Size = new System.Drawing.Size(44, 42);
            this.iconClientMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClientMe.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.iconClientMe.TabIndex = 3;
            this.iconClientMe.TabStop = false;
            this.iconClientMe.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.buttonConnect.BorderRadius = 10;
            this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonConnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonConnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonConnect.FillColor = System.Drawing.Color.Green;
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Location = new System.Drawing.Point(137, 219);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(1018, 45);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "🔗 Connect / Start Session";
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // panelClientFriend
            // 
            this.panelClientFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.panelClientFriend.Controls.Add(this.labelRemotePort);
            this.panelClientFriend.Controls.Add(this.txtRemotePort);
            this.panelClientFriend.Controls.Add(this.txtRemoteIp);
            this.panelClientFriend.Controls.Add(this.labelRemoteIp);
            this.panelClientFriend.Controls.Add(this.labelRemoteEndpoint);
            this.panelClientFriend.Controls.Add(this.labelClientFriend);
            this.panelClientFriend.Controls.Add(this.iconClientFriend);
            this.panelClientFriend.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panelClientFriend.Location = new System.Drawing.Point(656, 6);
            this.panelClientFriend.Name = "panelClientFriend";
            this.panelClientFriend.Padding = new System.Windows.Forms.Padding(5);
            this.panelClientFriend.Size = new System.Drawing.Size(499, 196);
            this.panelClientFriend.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelClientFriend.TabIndex = 3;
            this.panelClientFriend.Text = "panel5";
            // 
            // labelRemotePort
            // 
            this.labelRemotePort.AutoSize = true;
            this.labelRemotePort.BackColor = System.Drawing.Color.Transparent;
            this.labelRemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelRemotePort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelRemotePort.Location = new System.Drawing.Point(261, 96);
            this.labelRemotePort.Name = "labelRemotePort";
            this.labelRemotePort.Size = new System.Drawing.Size(36, 18);
            this.labelRemotePort.TabIndex = 9;
            this.labelRemotePort.Text = "Port";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.txtRemotePort.BorderRadius = 10;
            this.txtRemotePort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemotePort.DefaultText = "";
            this.txtRemotePort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRemotePort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRemotePort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRemotePort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRemotePort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.txtRemotePort.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtRemotePort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRemotePort.ForeColor = System.Drawing.Color.White;
            this.txtRemotePort.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtRemotePort.Location = new System.Drawing.Point(264, 132);
            this.txtRemotePort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.PlaceholderText = "";
            this.txtRemotePort.SelectedText = "";
            this.txtRemotePort.Size = new System.Drawing.Size(202, 42);
            this.txtRemotePort.TabIndex = 8;
            // 
            // txtRemoteIp
            // 
            this.txtRemoteIp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.txtRemoteIp.BorderRadius = 10;
            this.txtRemoteIp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemoteIp.DefaultText = "";
            this.txtRemoteIp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRemoteIp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRemoteIp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRemoteIp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRemoteIp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.txtRemoteIp.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtRemoteIp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRemoteIp.ForeColor = System.Drawing.Color.White;
            this.txtRemoteIp.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtRemoteIp.Location = new System.Drawing.Point(24, 132);
            this.txtRemoteIp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemoteIp.Name = "txtRemoteIp";
            this.txtRemoteIp.PlaceholderText = "";
            this.txtRemoteIp.SelectedText = "";
            this.txtRemoteIp.Size = new System.Drawing.Size(202, 42);
            this.txtRemoteIp.TabIndex = 7;
            // 
            // labelRemoteIp
            // 
            this.labelRemoteIp.AutoSize = true;
            this.labelRemoteIp.BackColor = System.Drawing.Color.Transparent;
            this.labelRemoteIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelRemoteIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelRemoteIp.Location = new System.Drawing.Point(21, 96);
            this.labelRemoteIp.Name = "labelRemoteIp";
            this.labelRemoteIp.Size = new System.Drawing.Size(135, 18);
            this.labelRemoteIp.TabIndex = 6;
            this.labelRemoteIp.Text = "Remote IP address";
            // 
            // labelRemoteEndpoint
            // 
            this.labelRemoteEndpoint.AutoSize = true;
            this.labelRemoteEndpoint.BackColor = System.Drawing.Color.Transparent;
            this.labelRemoteEndpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelRemoteEndpoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelRemoteEndpoint.Location = new System.Drawing.Point(75, 54);
            this.labelRemoteEndpoint.Name = "labelRemoteEndpoint";
            this.labelRemoteEndpoint.Size = new System.Drawing.Size(121, 18);
            this.labelRemoteEndpoint.TabIndex = 5;
            this.labelRemoteEndpoint.Text = "Remote endpoint";
            // 
            // labelClientFriend
            // 
            this.labelClientFriend.AutoSize = true;
            this.labelClientFriend.BackColor = System.Drawing.Color.Transparent;
            this.labelClientFriend.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientFriend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelClientFriend.Location = new System.Drawing.Point(74, 30);
            this.labelClientFriend.Name = "labelClientFriend";
            this.labelClientFriend.Size = new System.Drawing.Size(140, 22);
            this.labelClientFriend.TabIndex = 4;
            this.labelClientFriend.Text = "Client 2 (Friend)";
            // 
            // iconClientFriend
            // 
            this.iconClientFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.iconClientFriend.Image = global::LANLink.Properties.Resources.hotspot;
            this.iconClientFriend.Location = new System.Drawing.Point(24, 30);
            this.iconClientFriend.Name = "iconClientFriend";
            this.iconClientFriend.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.iconClientFriend.Size = new System.Drawing.Size(44, 42);
            this.iconClientFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClientFriend.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.iconClientFriend.TabIndex = 3;
            this.iconClientFriend.TabStop = false;
            this.iconClientFriend.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // flowLayoutMessage
            // 
            this.flowLayoutMessage.AutoScroll = true;
            this.flowLayoutMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.flowLayoutMessage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutMessage.Location = new System.Drawing.Point(137, 284);
            this.flowLayoutMessage.Name = "flowLayoutMessage";
            this.flowLayoutMessage.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutMessage.Size = new System.Drawing.Size(1018, 423);
            this.flowLayoutMessage.TabIndex = 4;
            this.flowLayoutMessage.WrapContents = false;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.panelCenter.Controls.Add(this.flowLayoutMessage);
            this.panelCenter.Controls.Add(this.panelClientFriend);
            this.panelCenter.Controls.Add(this.buttonConnect);
            this.panelCenter.Controls.Add(this.panelClientMe);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.panelCenter.Location = new System.Drawing.Point(0, 98);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Padding = new System.Windows.Forms.Padding(5);
            this.panelCenter.Size = new System.Drawing.Size(1265, 707);
            this.panelCenter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelCenter.TabIndex = 3;
            this.panelCenter.Text = "panel3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1265, 922);
            this.ControlBox = false;
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLANLink)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelClientMe.ResumeLayout(false);
            this.panelClientMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClientMe)).EndInit();
            this.panelClientFriend.ResumeLayout(false);
            this.panelClientFriend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClientFriend)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopePictureBox iconLANLink;
        private ReaLTaiizor.Controls.Panel panelHeader;
        private ReaLTaiizor.Controls.Panel panelBottom;
        private ReaLTaiizor.Controls.HeaderLabel labelLANLink;
        private ReaLTaiizor.Controls.LabelEdit labelP2PNetworkMessenger;
        private Guna.UI2.WinForms.Guna2Button buttonSend;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private ReaLTaiizor.Controls.Panel panelClientMe;
        private ReaLTaiizor.Controls.LabelEdit labelLocalPort;
        private Guna.UI2.WinForms.Guna2TextBox txtLocalPort;
        private Guna.UI2.WinForms.Guna2TextBox txtLocalIp;
        private ReaLTaiizor.Controls.LabelEdit labelLocalIp;
        private ReaLTaiizor.Controls.LabelEdit labelLocalEndpoint;
        private ReaLTaiizor.Controls.HeaderLabel labelClientMe;
        private ReaLTaiizor.Controls.HopePictureBox iconClientMe;
        private Guna.UI2.WinForms.Guna2Button buttonConnect;
        private ReaLTaiizor.Controls.Panel panelClientFriend;
        private ReaLTaiizor.Controls.LabelEdit labelRemotePort;
        private Guna.UI2.WinForms.Guna2TextBox txtRemotePort;
        private Guna.UI2.WinForms.Guna2TextBox txtRemoteIp;
        private ReaLTaiizor.Controls.LabelEdit labelRemoteIp;
        private ReaLTaiizor.Controls.LabelEdit labelRemoteEndpoint;
        private ReaLTaiizor.Controls.HeaderLabel labelClientFriend;
        private ReaLTaiizor.Controls.HopePictureBox iconClientFriend;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMessage;
        private ReaLTaiizor.Controls.Panel panelCenter;
        private ReaLTaiizor.Controls.HopePictureBox iconExit;
    }
}

