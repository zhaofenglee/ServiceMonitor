namespace ServiceMonitor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMssqlStatus = new System.Windows.Forms.Label();
            this.lblRedisStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartService = new System.Windows.Forms.Button();
            this.btnRestartService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMssqlStatus
            // 
            this.lblMssqlStatus.AutoSize = true;
            this.lblMssqlStatus.Font = new System.Drawing.Font("宋体", 12F);
            this.lblMssqlStatus.ForeColor = System.Drawing.Color.Black;
            this.lblMssqlStatus.Location = new System.Drawing.Point(105, 44);
            this.lblMssqlStatus.Name = "lblMssqlStatus";
            this.lblMssqlStatus.Size = new System.Drawing.Size(15, 16);
            this.lblMssqlStatus.TabIndex = 0;
            this.lblMssqlStatus.Text = "-";
            // 
            // lblRedisStatus
            // 
            this.lblRedisStatus.AutoSize = true;
            this.lblRedisStatus.Font = new System.Drawing.Font("宋体", 12F);
            this.lblRedisStatus.Location = new System.Drawing.Point(105, 98);
            this.lblRedisStatus.Name = "lblRedisStatus";
            this.lblRedisStatus.Size = new System.Drawing.Size(15, 16);
            this.lblRedisStatus.TabIndex = 1;
            this.lblRedisStatus.Text = "-";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(347, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(428, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "结束";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(37, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Redis：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "MSSQL：";
            // 
            // btnStartService
            // 
            this.btnStartService.Location = new System.Drawing.Point(40, 145);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(75, 23);
            this.btnStartService.TabIndex = 6;
            this.btnStartService.Text = "启动";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.StartService_Click);
            // 
            // btnRestartService
            // 
            this.btnRestartService.Location = new System.Drawing.Point(138, 145);
            this.btnRestartService.Name = "btnRestartService";
            this.btnRestartService.Size = new System.Drawing.Size(75, 23);
            this.btnRestartService.TabIndex = 7;
            this.btnRestartService.Text = "重启";
            this.btnRestartService.UseVisualStyleBackColor = true;
            this.btnRestartService.Click += new System.EventHandler(this.RestartService_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 198);
            this.Controls.Add(this.btnRestartService);
            this.Controls.Add(this.btnStartService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRedisStatus);
            this.Controls.Add(this.lblMssqlStatus);
            this.Name = "MainForm";
            this.Text = "服务检测";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMssqlStatus;
        private System.Windows.Forms.Label lblRedisStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.Button btnRestartService;
    }
}

