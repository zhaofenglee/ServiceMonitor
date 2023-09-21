using System;
using System.Windows.Forms;
using System.ServiceProcess;

namespace ServiceMonitor
{
    public partial class MainForm : Form
    {
        private ServiceController mssqlServiceController;
        private ServiceController redisServiceController;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 初始化ServiceController对象，分别对应MSSQL和Redis服务
            mssqlServiceController = new ServiceController("MSSQLSERVER"); // 根据您的MSSQL服务名称修改
            redisServiceController = new ServiceController("Redis"); // 根据您的Redis服务名称修改
            btnStart_Click(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 检测MSSQL服务状态并更新UI
            UpdateServiceStatus(mssqlServiceController, lblMssqlStatus);

            // 检测Redis服务状态并更新UI
            UpdateServiceStatus(redisServiceController, lblRedisStatus);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 启动定时器，开始检测服务状态
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // 停止定时器，停止检测服务状态
            timer1.Stop();
        }

        private void UpdateServiceStatus(ServiceController serviceController, Label label)
        {
            try
            {
                serviceController.Refresh();
                var status = serviceController.Status;
                label.Text = $"服务状态: {status}";
                if (serviceController.Status == ServiceControllerStatus.Stopped)
                {
                    label.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label.ForeColor = System.Drawing.Color.DarkBlue;
                }
                   
            }
            catch (Exception ex)
            {
                label.Text = $"服务状态: 无法检测 ({ex.Message})";
                label.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void StartService_Click(object sender, EventArgs e)
        {
            // 启动MSSQL服务
            //StartService(mssqlServiceController);
            // 启动Redis服务
            StartService(redisServiceController);
        }

        private void RestartService_Click(object sender, EventArgs e)
        {
            // 重启MSSQL服务
            RestartService(mssqlServiceController);
            // 重启Redis服务
            RestartService(redisServiceController);
        }

        private void StartService(ServiceController serviceController)
        {
            try
            {
                if (serviceController.Status == ServiceControllerStatus.Stopped)
                {
                    serviceController.Start();
                    serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                    MessageBox.Show("服务已成功启动！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //MessageBox.Show("服务已经在运行中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"启动服务时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestartService(ServiceController serviceController)
        {
            try
            {
                serviceController.Stop();
                serviceController.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30));

                // 确保服务已停止后再启动
                if (serviceController.Status == ServiceControllerStatus.Stopped)
                {
                    serviceController.Start();
                    serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                    MessageBox.Show("服务已成功重启！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"重启服务时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
