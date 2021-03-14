namespace ChartService
{
    partial class ServiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            this.btnServicStart = new System.Windows.Forms.Button();
            this.textboMsg = new System.Windows.Forms.TextBox();
            this.textBoxSendMsg = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.listBoxCoustomerList = new System.Windows.Forms.ListBox();
            this.btnSendSnak = new System.Windows.Forms.Button();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.btnAllSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "状态";
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(72, 31);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(0, 12);
            this.labStatus.TabIndex = 1;
            // 
            // btnServicStart
            // 
            this.btnServicStart.Location = new System.Drawing.Point(271, 26);
            this.btnServicStart.Name = "btnServicStart";
            this.btnServicStart.Size = new System.Drawing.Size(75, 23);
            this.btnServicStart.TabIndex = 2;
            this.btnServicStart.Text = "启动服务监听";
            this.btnServicStart.UseVisualStyleBackColor = true;
            this.btnServicStart.Click += new System.EventHandler(this.btnServicStart_Click);
            // 
            // textboMsg
            // 
            this.textboMsg.Location = new System.Drawing.Point(194, 60);
            this.textboMsg.Multiline = true;
            this.textboMsg.Name = "textboMsg";
            this.textboMsg.Size = new System.Drawing.Size(348, 243);
            this.textboMsg.TabIndex = 3;
            // 
            // textBoxSendMsg
            // 
            this.textBoxSendMsg.Location = new System.Drawing.Point(14, 309);
            this.textBoxSendMsg.Multiline = true;
            this.textBoxSendMsg.Name = "textBoxSendMsg";
            this.textBoxSendMsg.Size = new System.Drawing.Size(332, 58);
            this.textBoxSendMsg.TabIndex = 4;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(352, 309);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 5;
            this.btnSendMsg.Text = "发送消息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // listBoxCoustomerList
            // 
            this.listBoxCoustomerList.FormattingEnabled = true;
            this.listBoxCoustomerList.ItemHeight = 12;
            this.listBoxCoustomerList.Location = new System.Drawing.Point(12, 60);
            this.listBoxCoustomerList.Name = "listBoxCoustomerList";
            this.listBoxCoustomerList.ScrollAlwaysVisible = true;
            this.listBoxCoustomerList.Size = new System.Drawing.Size(176, 244);
            this.listBoxCoustomerList.TabIndex = 6;
            // 
            // btnSendSnak
            // 
            this.btnSendSnak.Location = new System.Drawing.Point(352, 344);
            this.btnSendSnak.Name = "btnSendSnak";
            this.btnSendSnak.Size = new System.Drawing.Size(75, 23);
            this.btnSendSnak.TabIndex = 7;
            this.btnSendSnak.Text = "发送震动";
            this.btnSendSnak.UseVisualStyleBackColor = true;
            this.btnSendSnak.Click += new System.EventHandler(this.btnSendSnak_Click);
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(14, 28);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(174, 21);
            this.textBox_ip.TabIndex = 8;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(194, 28);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(58, 21);
            this.textBox_port.TabIndex = 9;
            // 
            // btnAllSend
            // 
            this.btnAllSend.Location = new System.Drawing.Point(433, 309);
            this.btnAllSend.Name = "btnAllSend";
            this.btnAllSend.Size = new System.Drawing.Size(75, 23);
            this.btnAllSend.TabIndex = 10;
            this.btnAllSend.Text = "群发给客服端";
            this.btnAllSend.UseVisualStyleBackColor = true;
            this.btnAllSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 382);
            this.Controls.Add(this.btnAllSend);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.btnSendSnak);
            this.Controls.Add(this.listBoxCoustomerList);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.textBoxSendMsg);
            this.Controls.Add(this.textboMsg);
            this.Controls.Add(this.btnServicStart);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.label1);
            this.Name = "ServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Button btnServicStart;
        private System.Windows.Forms.TextBox textboMsg;
        private System.Windows.Forms.TextBox textBoxSendMsg;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.ListBox listBoxCoustomerList;
        private System.Windows.Forms.Button btnSendSnak;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button btnAllSend;
    }
}

