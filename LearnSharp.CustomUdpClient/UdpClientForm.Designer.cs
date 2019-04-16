namespace LearnSharp.CustomUdpClient
{
    partial class UdpClientForm
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
            this.localIpText = new System.Windows.Forms.TextBox();
            this.localPortText = new System.Windows.Forms.TextBox();
            this.sendIpText = new System.Windows.Forms.TextBox();
            this.sendPortText = new System.Windows.Forms.TextBox();
            this.contentText = new System.Windows.Forms.TextBox();
            this.msgListView = new System.Windows.Forms.ListBox();
            this.localIpLabel = new System.Windows.Forms.Label();
            this.localIpColonLabel = new System.Windows.Forms.Label();
            this.sendIpLabel = new System.Windows.Forms.Label();
            this.sendIpColonLabel = new System.Windows.Forms.Label();
            this.contentLabel = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.receiveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // localIpText
            // 
            this.localIpText.Location = new System.Drawing.Point(130, 27);
            this.localIpText.Name = "localIpText";
            this.localIpText.Size = new System.Drawing.Size(313, 21);
            this.localIpText.TabIndex = 0;
            // 
            // localPortText
            // 
            this.localPortText.Location = new System.Drawing.Point(529, 27);
            this.localPortText.Name = "localPortText";
            this.localPortText.Size = new System.Drawing.Size(214, 21);
            this.localPortText.TabIndex = 1;
            // 
            // sendIpText
            // 
            this.sendIpText.Location = new System.Drawing.Point(130, 75);
            this.sendIpText.Name = "sendIpText";
            this.sendIpText.Size = new System.Drawing.Size(313, 21);
            this.sendIpText.TabIndex = 2;
            // 
            // sendPortText
            // 
            this.sendPortText.Location = new System.Drawing.Point(529, 75);
            this.sendPortText.Name = "sendPortText";
            this.sendPortText.Size = new System.Drawing.Size(214, 21);
            this.sendPortText.TabIndex = 3;
            // 
            // contentText
            // 
            this.contentText.Location = new System.Drawing.Point(130, 116);
            this.contentText.Multiline = true;
            this.contentText.Name = "contentText";
            this.contentText.Size = new System.Drawing.Size(467, 62);
            this.contentText.TabIndex = 4;
            // 
            // msgListView
            // 
            this.msgListView.FormattingEnabled = true;
            this.msgListView.ItemHeight = 12;
            this.msgListView.Location = new System.Drawing.Point(51, 230);
            this.msgListView.Name = "msgListView";
            this.msgListView.Size = new System.Drawing.Size(703, 184);
            this.msgListView.TabIndex = 5;
            // 
            // localIpLabel
            // 
            this.localIpLabel.AutoSize = true;
            this.localIpLabel.Location = new System.Drawing.Point(67, 30);
            this.localIpLabel.Name = "localIpLabel";
            this.localIpLabel.Size = new System.Drawing.Size(53, 12);
            this.localIpLabel.TabIndex = 6;
            this.localIpLabel.Text = "本地IP：";
            // 
            // localIpColonLabel
            // 
            this.localIpColonLabel.AutoSize = true;
            this.localIpColonLabel.Location = new System.Drawing.Point(466, 30);
            this.localIpColonLabel.Name = "localIpColonLabel";
            this.localIpColonLabel.Size = new System.Drawing.Size(41, 12);
            this.localIpColonLabel.TabIndex = 7;
            this.localIpColonLabel.Text = "  ：  ";
            // 
            // sendIpLabel
            // 
            this.sendIpLabel.AutoSize = true;
            this.sendIpLabel.Location = new System.Drawing.Point(67, 75);
            this.sendIpLabel.Name = "sendIpLabel";
            this.sendIpLabel.Size = new System.Drawing.Size(53, 12);
            this.sendIpLabel.TabIndex = 8;
            this.sendIpLabel.Text = "发送到：";
            // 
            // sendIpColonLabel
            // 
            this.sendIpColonLabel.AutoSize = true;
            this.sendIpColonLabel.Location = new System.Drawing.Point(466, 75);
            this.sendIpColonLabel.Name = "sendIpColonLabel";
            this.sendIpColonLabel.Size = new System.Drawing.Size(41, 12);
            this.sendIpColonLabel.TabIndex = 9;
            this.sendIpColonLabel.Text = "  ：  ";
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(67, 129);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(41, 12);
            this.contentLabel.TabIndex = 10;
            this.contentLabel.Text = "内容：";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(643, 138);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 11;
            this.sendBtn.Text = "发送";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(69, 194);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "清空";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(181, 194);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 13;
            this.stopBtn.Text = "停止";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // receiveBtn
            // 
            this.receiveBtn.Location = new System.Drawing.Point(643, 194);
            this.receiveBtn.Name = "receiveBtn";
            this.receiveBtn.Size = new System.Drawing.Size(75, 23);
            this.receiveBtn.TabIndex = 14;
            this.receiveBtn.Text = "接收";
            this.receiveBtn.UseVisualStyleBackColor = true;
            this.receiveBtn.Click += new System.EventHandler(this.receiveBtn_Click);
            // 
            // UdpClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiveBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.sendIpColonLabel);
            this.Controls.Add(this.sendIpLabel);
            this.Controls.Add(this.localIpColonLabel);
            this.Controls.Add(this.localIpLabel);
            this.Controls.Add(this.msgListView);
            this.Controls.Add(this.contentText);
            this.Controls.Add(this.sendPortText);
            this.Controls.Add(this.sendIpText);
            this.Controls.Add(this.localPortText);
            this.Controls.Add(this.localIpText);
            this.Name = "UdpClientForm";
            this.Text = "UDP客户端";
            this.Load += new System.EventHandler(this.UdpClientView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox localIpText;
        private System.Windows.Forms.TextBox localPortText;
        private System.Windows.Forms.TextBox sendIpText;
        private System.Windows.Forms.TextBox sendPortText;
        private System.Windows.Forms.TextBox contentText;
        private System.Windows.Forms.ListBox msgListView;
        private System.Windows.Forms.Label localIpLabel;
        private System.Windows.Forms.Label localIpColonLabel;
        private System.Windows.Forms.Label sendIpLabel;
        private System.Windows.Forms.Label sendIpColonLabel;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button receiveBtn;
    }
}

