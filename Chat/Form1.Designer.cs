namespace Chat
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
            this.ipAddress = new System.Windows.Forms.Label();
            this.friendIpAddress = new System.Windows.Forms.Label();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.textFriendsIp = new System.Windows.Forms.TextBox();
            this.port1 = new System.Windows.Forms.Label();
            this.port2 = new System.Windows.Forms.Label();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textFriendsPort = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipAddress
            // 
            this.ipAddress.AutoSize = true;
            this.ipAddress.Location = new System.Drawing.Point(66, 49);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(61, 13);
            this.ipAddress.TabIndex = 0;
            this.ipAddress.Text = "IP Address:";
            // 
            // friendIpAddress
            // 
            this.friendIpAddress.AutoSize = true;
            this.friendIpAddress.Location = new System.Drawing.Point(66, 75);
            this.friendIpAddress.Name = "friendIpAddress";
            this.friendIpAddress.Size = new System.Drawing.Size(93, 13);
            this.friendIpAddress.TabIndex = 1;
            this.friendIpAddress.Text = "Friend IP Address:";
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(190, 46);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(161, 20);
            this.textLocalIp.TabIndex = 2;
            // 
            // textFriendsIp
            // 
            this.textFriendsIp.Location = new System.Drawing.Point(190, 72);
            this.textFriendsIp.Name = "textFriendsIp";
            this.textFriendsIp.Size = new System.Drawing.Size(161, 20);
            this.textFriendsIp.TabIndex = 3;
            // 
            // port1
            // 
            this.port1.AutoSize = true;
            this.port1.Location = new System.Drawing.Point(430, 49);
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(29, 13);
            this.port1.TabIndex = 4;
            this.port1.Text = "Port:";
            // 
            // port2
            // 
            this.port2.AutoSize = true;
            this.port2.Location = new System.Drawing.Point(430, 75);
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(29, 13);
            this.port2.TabIndex = 5;
            this.port2.Text = "Port:";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(465, 46);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(124, 20);
            this.textLocalPort.TabIndex = 6;
            // 
            // textFriendsPort
            // 
            this.textFriendsPort.Location = new System.Drawing.Point(465, 72);
            this.textFriendsPort.Name = "textFriendsPort";
            this.textFriendsPort.Size = new System.Drawing.Size(124, 20);
            this.textFriendsPort.TabIndex = 7;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(69, 115);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(520, 41);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(514, 389);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 11;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(69, 163);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(520, 186);
            this.listMessage.TabIndex = 12;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(69, 356);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(520, 20);
            this.textMessage.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textFriendsPort);
            this.Controls.Add(this.textLocalPort);
            this.Controls.Add(this.port2);
            this.Controls.Add(this.port1);
            this.Controls.Add(this.textFriendsIp);
            this.Controls.Add(this.textLocalIp);
            this.Controls.Add(this.friendIpAddress);
            this.Controls.Add(this.ipAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipAddress;
        private System.Windows.Forms.Label friendIpAddress;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.TextBox textFriendsIp;
        private System.Windows.Forms.Label port1;
        private System.Windows.Forms.Label port2;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textFriendsPort;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox textMessage;
    }
}

