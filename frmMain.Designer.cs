
namespace PortTest
{
    partial class frmMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.rbTcpClient = new System.Windows.Forms.RadioButton();
            this.rbSocket = new System.Windows.Forms.RadioButton();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "计算机IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "端 口 号：";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(93, 10);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(158, 25);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.11.50";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(93, 38);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(158, 25);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "8088";
            // 
            // rbTcpClient
            // 
            this.rbTcpClient.AutoSize = true;
            this.rbTcpClient.Location = new System.Drawing.Point(284, 13);
            this.rbTcpClient.Name = "rbTcpClient";
            this.rbTcpClient.Size = new System.Drawing.Size(130, 19);
            this.rbTcpClient.TabIndex = 2;
            this.rbTcpClient.Text = "TcpClient检测";
            this.rbTcpClient.UseVisualStyleBackColor = true;
            this.rbTcpClient.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbSocket
            // 
            this.rbSocket.AutoSize = true;
            this.rbSocket.Location = new System.Drawing.Point(284, 37);
            this.rbSocket.Name = "rbSocket";
            this.rbSocket.Size = new System.Drawing.Size(106, 19);
            this.rbSocket.TabIndex = 2;
            this.rbSocket.Text = "Socket检测";
            this.rbSocket.UseVisualStyleBackColor = true;
            this.rbSocket.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(16, 78);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "检   测";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(333, 82);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "退   出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 114);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.rbSocket);
            this.Controls.Add(this.rbTcpClient);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "计算机端口检测";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.RadioButton rbTcpClient;
        private System.Windows.Forms.RadioButton rbSocket;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnQuit;
    }
}

