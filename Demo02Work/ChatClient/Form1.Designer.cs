namespace ChatClient
{
    partial class Form1
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
            this.btnSendSnak = new System.Windows.Forms.Button();
            this.listBoxCoustomerList = new System.Windows.Forms.ListBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.textBoxSendMsg = new System.Windows.Forms.TextBox();
            this.textboMsg = new System.Windows.Forms.TextBox();
            this.btnServicStart = new System.Windows.Forms.Button();
            this.labStatus = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendSnak
            // 
            this.btnSendSnak.Location = new System.Drawing.Point(370, 340);
            this.btnSendSnak.Name = "btnSendSnak";
            this.btnSendSnak.Size = new System.Drawing.Size(75, 23);
            this.btnSendSnak.TabIndex = 15;
            this.btnSendSnak.Text = "发送震动";
            this.btnSendSnak.UseVisualStyleBackColor = true;
            // 
            // listBoxCoustomerList
            // 
            this.listBoxCoustomerList.FormattingEnabled = true;
            this.listBoxCoustomerList.ItemHeight = 12;
            this.listBoxCoustomerList.Location = new System.Drawing.Point(30, 56);
            this.listBoxCoustomerList.Name = "listBoxCoustomerList";
            this.listBoxCoustomerList.Size = new System.Drawing.Size(190, 244);
            this.listBoxCoustomerList.TabIndex = 14;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(370, 305);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 13;
            this.btnSendMsg.Text = "发送消息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // textBoxSendMsg
            // 
            this.textBoxSendMsg.Location = new System.Drawing.Point(32, 305);
            this.textBoxSendMsg.Multiline = true;
            this.textBoxSendMsg.Name = "textBoxSendMsg";
            this.textBoxSendMsg.Size = new System.Drawing.Size(332, 58);
            this.textBoxSendMsg.TabIndex = 12;
            // 
            // textboMsg
            // 
            this.textboMsg.Location = new System.Drawing.Point(226, 56);
            this.textboMsg.Multiline = true;
            this.textboMsg.Name = "textboMsg";
            this.textboMsg.Size = new System.Drawing.Size(334, 243);
            this.textboMsg.TabIndex = 11;
            // 
            // btnServicStart
            // 
            this.btnServicStart.Location = new System.Drawing.Point(485, 25);
            this.btnServicStart.Name = "btnServicStart";
            this.btnServicStart.Size = new System.Drawing.Size(75, 23);
            this.btnServicStart.TabIndex = 10;
            this.btnServicStart.Text = "连接到服务器";
            this.btnServicStart.UseVisualStyleBackColor = true;
            this.btnServicStart.Click += new System.EventHandler(this.btnServicStart_Click);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(90, 27);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(0, 12);
            this.labStatus.TabIndex = 9;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(391, 32);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 12);
            this.labelStatus.TabIndex = 8;
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(139, 27);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(117, 21);
            this.textBoxIp.TabIndex = 16;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(323, 27);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(62, 21);
            this.textBoxPort.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "连接的服务器ip：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "端口：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIp);
            this.Controls.Add(this.btnSendSnak);
            this.Controls.Add(this.listBoxCoustomerList);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.textBoxSendMsg);
            this.Controls.Add(this.textboMsg);
            this.Controls.Add(this.btnServicStart);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.labelStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendSnak;
        private System.Windows.Forms.ListBox listBoxCoustomerList;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox textBoxSendMsg;
        private System.Windows.Forms.TextBox textboMsg;
        private System.Windows.Forms.Button btnServicStart;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

