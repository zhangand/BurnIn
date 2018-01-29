namespace BurnIn
{
    partial class frm_server
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnBeginListen = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsgSend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOnline = new System.Windows.Forms.ListBox();
            this.btnSendToAll = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtSelectFile = new System.Windows.Forms.TextBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP  :";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(680, 16);
            this.txtIp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(120, 22);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "192.168.2.27";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "PORT:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(680, 60);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(120, 22);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "8088";
            // 
            // btnBeginListen
            // 
            this.btnBeginListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginListen.Location = new System.Drawing.Point(649, 259);
            this.btnBeginListen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBeginListen.Name = "btnBeginListen";
            this.btnBeginListen.Size = new System.Drawing.Size(111, 28);
            this.btnBeginListen.TabIndex = 2;
            this.btnBeginListen.Text = "Start Server";
            this.btnBeginListen.UseVisualStyleBackColor = true;
            this.btnBeginListen.Click += new System.EventHandler(this.btnBeginListen_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.White;
            this.txtMsg.Location = new System.Drawing.Point(9, 60);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(607, 168);
            this.txtMsg.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(649, 333);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(111, 30);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsgSend
            // 
            this.txtMsgSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgSend.Location = new System.Drawing.Point(9, 247);
            this.txtMsgSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMsgSend.Name = "txtMsgSend";
            this.txtMsgSend.Size = new System.Drawing.Size(466, 27);
            this.txtMsgSend.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "在线列表";
            // 
            // lbOnline
            // 
            this.lbOnline.FormattingEnabled = true;
            this.lbOnline.ItemHeight = 16;
            this.lbOnline.Location = new System.Drawing.Point(628, 112);
            this.lbOnline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbOnline.Name = "lbOnline";
            this.lbOnline.Size = new System.Drawing.Size(172, 116);
            this.lbOnline.TabIndex = 7;
            // 
            // btnSendToAll
            // 
            this.btnSendToAll.Location = new System.Drawing.Point(649, 295);
            this.btnSendToAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendToAll.Name = "btnSendToAll";
            this.btnSendToAll.Size = new System.Drawing.Size(111, 30);
            this.btnSendToAll.TabIndex = 8;
            this.btnSendToAll.Text = "群发消息";
            this.btnSendToAll.UseVisualStyleBackColor = true;
            this.btnSendToAll.Click += new System.EventHandler(this.btnSendToAll_Click);
            // 
            // txtSelectFile
            // 
            this.txtSelectFile.BackColor = System.Drawing.Color.White;
            this.txtSelectFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectFile.Location = new System.Drawing.Point(9, 308);
            this.txtSelectFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelectFile.Name = "txtSelectFile";
            this.txtSelectFile.ReadOnly = true;
            this.txtSelectFile.Size = new System.Drawing.Size(466, 27);
            this.txtSelectFile.TabIndex = 19;
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(649, 371);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(111, 30);
            this.btnSendFile.TabIndex = 18;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click_1);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(506, 308);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(108, 27);
            this.btnSelectFile.TabIndex = 17;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Log";
            // 
            // frm_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 419);
            this.Controls.Add(this.txtSelectFile);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnSendToAll);
            this.Controls.Add(this.lbOnline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMsgSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnBeginListen);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_server";
            this.Text = "Debug Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnBeginListen;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsgSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbOnline;
        private System.Windows.Forms.Button btnSendToAll;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtSelectFile;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label4;
    }
}

