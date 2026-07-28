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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMyIP = new System.Windows.Forms.Label();
            this.lstPeers = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lstChat = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.Label();
            this.lblSelectedPeer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbExit);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 81);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.btnAttachFile);
            this.panel2.Controls.Add(this.txtInput);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstPeers);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 451);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPort);
            this.panel4.Controls.Add(this.lblMyIP);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 116);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblSelectedPeer);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(286, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(811, 70);
            this.panel5.TabIndex = 3;
            // 
            // lblMyIP
            // 
            this.lblMyIP.AutoSize = true;
            this.lblMyIP.Location = new System.Drawing.Point(49, 25);
            this.lblMyIP.Name = "lblMyIP";
            this.lblMyIP.Size = new System.Drawing.Size(87, 17);
            this.lblMyIP.TabIndex = 0;
            this.lblMyIP.Text = "My Ip: 192...";
            // 
            // lstPeers
            // 
            this.lstPeers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPeers.FormattingEnabled = true;
            this.lstPeers.ItemHeight = 16;
            this.lstPeers.Location = new System.Drawing.Point(0, 116);
            this.lstPeers.Name = "lstPeers";
            this.lstPeers.Size = new System.Drawing.Size(286, 335);
            this.lstPeers.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(97, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lstChat
            // 
            this.lstChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstChat.FormattingEnabled = true;
            this.lstChat.ItemHeight = 16;
            this.lstChat.Location = new System.Drawing.Point(286, 151);
            this.lstChat.Name = "lstChat";
            this.lstChat.Size = new System.Drawing.Size(811, 381);
            this.lstChat.TabIndex = 4;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(286, 19);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(640, 42);
            this.txtInput.TabIndex = 1;
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Location = new System.Drawing.Point(943, 29);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(58, 32);
            this.btnAttachFile.TabIndex = 2;
            this.btnAttachFile.Text = "📎";
            this.btnAttachFile.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1027, 29);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(58, 32);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "✉️";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbTitle.Location = new System.Drawing.Point(193, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(719, 36);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "🟢 LANLink - Local Network Messenger & File Transfer";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Red;
            this.lbExit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbExit.ForeColor = System.Drawing.Color.White;
            this.lbExit.Location = new System.Drawing.Point(1043, 30);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(22, 24);
            this.lbExit.TabIndex = 1;
            this.lbExit.Text = "X";
            // 
            // txtPort
            // 
            this.txtPort.AutoSize = true;
            this.txtPort.Location = new System.Drawing.Point(52, 70);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(75, 17);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "Port: 8080";
            // 
            // lblSelectedPeer
            // 
            this.lblSelectedPeer.AutoSize = true;
            this.lblSelectedPeer.Location = new System.Drawing.Point(84, 25);
            this.lblSelectedPeer.Name = "lblSelectedPeer";
            this.lblSelectedPeer.Size = new System.Drawing.Size(83, 17);
            this.lblSelectedPeer.TabIndex = 0;
            this.lblSelectedPeer.Text = "Chat with:...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 632);
            this.Controls.Add(this.lstChat);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lstPeers;
        private System.Windows.Forms.Label lblMyIP;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstChat;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label txtPort;
        private System.Windows.Forms.Label lblSelectedPeer;
    }
}

