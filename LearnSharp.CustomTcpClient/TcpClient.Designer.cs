namespace LearnSharp.CustomTcpClient
{
    partial class TcpClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ipLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.receivelistBox = new System.Windows.Forms.ListBox();
            this.sendText = new System.Windows.Forms.TextBox();
            this.startListenBtn = new System.Windows.Forms.Button();
            this.clearMsgBtn = new System.Windows.Forms.Button();
            this.receiveBtn = new System.Windows.Forms.Button();
            this.disConnectBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(58, 39);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(41, 12);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP地址";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(442, 39);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(41, 12);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "端口号";
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(139, 30);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(195, 21);
            this.ipText.TabIndex = 2;
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(525, 30);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(213, 21);
            this.portText.TabIndex = 3;
            // 
            // receivelistBox
            // 
            this.receivelistBox.FormattingEnabled = true;
            this.receivelistBox.ItemHeight = 12;
            this.receivelistBox.Location = new System.Drawing.Point(60, 138);
            this.receivelistBox.Name = "receivelistBox";
            this.receivelistBox.Size = new System.Drawing.Size(678, 136);
            this.receivelistBox.TabIndex = 4;
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(60, 335);
            this.sendText.Multiline = true;
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(678, 69);
            this.sendText.TabIndex = 5;
            // 
            // startListenBtn
            // 
            this.startListenBtn.Location = new System.Drawing.Point(139, 96);
            this.startListenBtn.Name = "startListenBtn";
            this.startListenBtn.Size = new System.Drawing.Size(75, 23);
            this.startListenBtn.TabIndex = 6;
            this.startListenBtn.Text = "开始监听";
            this.startListenBtn.UseVisualStyleBackColor = true;
            this.startListenBtn.Click += new System.EventHandler(this.startListenBtn_Click);
            // 
            // clearMsgBtn
            // 
            this.clearMsgBtn.Location = new System.Drawing.Point(480, 295);
            this.clearMsgBtn.Name = "clearMsgBtn";
            this.clearMsgBtn.Size = new System.Drawing.Size(75, 23);
            this.clearMsgBtn.TabIndex = 8;
            this.clearMsgBtn.Text = "清空消息";
            this.clearMsgBtn.UseVisualStyleBackColor = true;
            this.clearMsgBtn.Click += new System.EventHandler(this.clearMsgBtn_Click);
            // 
            // receiveBtn
            // 
            this.receiveBtn.Location = new System.Drawing.Point(646, 295);
            this.receiveBtn.Name = "receiveBtn";
            this.receiveBtn.Size = new System.Drawing.Size(75, 23);
            this.receiveBtn.TabIndex = 9;
            this.receiveBtn.Text = "接收";
            this.receiveBtn.UseVisualStyleBackColor = true;
            this.receiveBtn.Click += new System.EventHandler(this.receiveBtn_Click);
            // 
            // disConnectBtn
            // 
            this.disConnectBtn.Location = new System.Drawing.Point(587, 96);
            this.disConnectBtn.Name = "disConnectBtn";
            this.disConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.disConnectBtn.TabIndex = 10;
            this.disConnectBtn.Text = "断开连接";
            this.disConnectBtn.UseVisualStyleBackColor = true;
            this.disConnectBtn.Click += new System.EventHandler(this.disConnectBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(646, 415);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 11;
            this.sendBtn.Text = "发送";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // TcpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.disConnectBtn);
            this.Controls.Add(this.receiveBtn);
            this.Controls.Add(this.clearMsgBtn);
            this.Controls.Add(this.startListenBtn);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.receivelistBox);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipLabel);
            this.Name = "TcpClient";
            this.Text = "TCP客户端";
            this.Load += new System.EventHandler(this.TcpClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.ListBox receivelistBox;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Button startListenBtn;
        private System.Windows.Forms.Button clearMsgBtn;
        private System.Windows.Forms.Button receiveBtn;
        private System.Windows.Forms.Button disConnectBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

