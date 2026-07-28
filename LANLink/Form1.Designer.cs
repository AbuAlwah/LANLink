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
            this.lblMyIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMyIP
            // 
            this.lblMyIP.AutoSize = true;
            this.lblMyIP.Location = new System.Drawing.Point(61, 41);
            this.lblMyIP.Name = "lblMyIP";
            this.lblMyIP.Size = new System.Drawing.Size(42, 17);
            this.lblMyIP.TabIndex = 0;
            this.lblMyIP.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 583);
            this.Controls.Add(this.lblMyIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyIP;
    }
}

