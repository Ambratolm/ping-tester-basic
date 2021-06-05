using System;
using System.Windows.Forms;
using PingTesterBasic.Properties;
using System.Drawing;

namespace PingTesterBasic
{
    public partial class Form_Main : Form
    {
        private PingManager _pingManager = new PingManager();
        private string _text;

        public Form_Main()
        {
            InitializeComponent();
            _text = this.Text;
            foreach (Control control in this.Controls) control.Text = string.Empty;
            timer_main.Start();
        }

        public Image GetPingStatusBackgroundImage(PingStatus pingStatus)
        {
            return Resources.ResourceManager.GetObject(string.Format(
                "background_{0}", pingStatus.Message.ToLower())) as Image;
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            PingStatus pingStatus = _pingManager.GetPingStatus();

            this.Text = string.Format("{0} | {1}", pingStatus.Message, _text);

            button_message.Text = pingStatus.Message.ToUpper();
            button_message.FlatAppearance.BorderColor = pingStatus.Color;
            button_message.BackgroundImage = GetPingStatusBackgroundImage(pingStatus);

            button_time.Text = pingStatus.TimeString;
            button_time.ForeColor = pingStatus.Color;

            progressBar_main.Value = (pingStatus.Time > 0) ? (int)pingStatus.Time : progressBar_main.Maximum;
            progressBar_main.ForeColor = pingStatus.Color;

            label_host.Text = _pingManager.HostName + Environment.NewLine + _pingManager.HostIPAddress;
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_panel_Click(object sender, EventArgs e)
        {

        }

        private void button_time_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_main_Click(object sender, EventArgs e)
        {

        }
    }
}
