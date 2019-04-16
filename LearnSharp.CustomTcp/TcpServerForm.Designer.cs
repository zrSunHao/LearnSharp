namespace LearnSharp.CustomTcp
{
    partial class TcpServerForm
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
            this.ipText = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.startListenBtn = new System.Windows.Forms.Button();
            this.endListenBtn = new System.Windows.Forms.Button();
            this.sendText = new System.Windows.Forms.TextBox();
            this.clearMsgBtn = new System.Windows.Forms.Button();
            this.receiveBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.ReceivelistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(62, 23);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(41, 12);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP地址";
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(121, 20);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(189, 21);
            this.ipText.TabIndex = 1;
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(526, 20);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(197, 21);
            this.portText.TabIndex = 2;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(449, 23);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(41, 12);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "端口号";
            // 
            // startListenBtn
            // 
            this.startListenBtn.Location = new System.Drawing.Point(170, 68);
            this.startListenBtn.Name = "startListenBtn";
            this.startListenBtn.Size = new System.Drawing.Size(75, 23);
            this.startListenBtn.TabIndex = 4;
            this.startListenBtn.Text = "开始监听";
            this.startListenBtn.UseVisualStyleBackColor = true;
            this.startListenBtn.Click += new System.EventHandler(this.startListenBtn_Click);
            // 
            // endListenBtn
            // 
            this.endListenBtn.Location = new System.Drawing.Point(559, 68);
            this.endListenBtn.Name = "endListenBtn";
            this.endListenBtn.Size = new System.Drawing.Size(75, 23);
            this.endListenBtn.TabIndex = 5;
            this.endListenBtn.Text = "结束监听";
            this.endListenBtn.UseVisualStyleBackColor = true;
            this.endListenBtn.Click += new System.EventHandler(this.endListenBtn_Click);
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(64, 306);
            this.sendText.Multiline = true;
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(659, 83);
            this.sendText.TabIndex = 7;
            // 
            // clearMsgBtn
            // 
            this.clearMsgBtn.Location = new System.Drawing.Point(426, 261);
            this.clearMsgBtn.Name = "clearMsgBtn";
            this.clearMsgBtn.Size = new System.Drawing.Size(75, 23);
            this.clearMsgBtn.TabIndex = 8;
            this.clearMsgBtn.Text = "清空消息";
            this.clearMsgBtn.UseVisualStyleBackColor = true;
            this.clearMsgBtn.Click += new System.EventHandler(this.clearMsgBtn_Click);
            // 
            // receiveBtn
            // 
            this.receiveBtn.Location = new System.Drawing.Point(627, 261);
            this.receiveBtn.Name = "receiveBtn";
            this.receiveBtn.Size = new System.Drawing.Size(75, 23);
            this.receiveBtn.TabIndex = 9;
            this.receiveBtn.Text = "接收";
            this.receiveBtn.UseVisualStyleBackColor = true;
            this.receiveBtn.Click += new System.EventHandler(this.receiveBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(426, 413);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.disconnectBtn.TabIndex = 10;
            this.disconnectBtn.Text = "断开连接";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(627, 413);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 11;
            this.sendBtn.Text = "发送";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // ReceivelistBox
            // 
            this.ReceivelistBox.FormattingEnabled = true;
            this.ReceivelistBox.ItemHeight = 12;
            this.ReceivelistBox.Location = new System.Drawing.Point(64, 104);
            this.ReceivelistBox.Name = "ReceivelistBox";
            this.ReceivelistBox.Size = new System.Drawing.Size(659, 148);
            this.ReceivelistBox.TabIndex = 12;
            // 
            // TcpServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReceivelistBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.receiveBtn);
            this.Controls.Add(this.clearMsgBtn);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.endListenBtn);
            this.Controls.Add(this.startListenBtn);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.ipLabel);
            this.Name = "TcpServerForm";
            this.Text = "Tcp服务端";
            this.Load += new System.EventHandler(this.TcpServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button startListenBtn;
        private System.Windows.Forms.Button endListenBtn;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Button clearMsgBtn;
        private System.Windows.Forms.Button receiveBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.ListBox ReceivelistBox;
    }
}

