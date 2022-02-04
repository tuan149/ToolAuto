using System;
using System.Windows.Forms;

namespace AutoKeyTomoto
{
    public partial class AutoKeyTomoto : Form
    {
        public AutoKeyTomoto()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Set default time at 1 second
            this.numberTime.Value = 1;

            this.labelVer.Text = "Beta version by:";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                // Get time value from input 
                int interval = (int)numberTime.Value;
                // If value < 2 show alert
                if (numberTime.Value < 2)
                {
                    this.numberTime.Value = 1;
                    if (MessageBox.Show("Time too small you can't use Stop Button - Continue ??", "Alert", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                }
                // change time miliseconds to seconds
                timerDelay.Interval = interval < 1 ? 1000 : interval * 1000;
                timerDelay.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error: Time input not valid !!");
                return;
            }
            this.txtKey.Enabled = false;
            this.numberTime.Enabled = false;
            this.btnPlay.Enabled = false;

            // Run ProgressBar
            progressBarStatus.Style = ProgressBarStyle.Marquee;
            progressBarStatus.MarqueeAnimationSpeed = 100;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Stop ProgressBar
            progressBarStatus.Style = ProgressBarStyle.Marquee;
            progressBarStatus.MarqueeAnimationSpeed = 0;
            progressBarStatus.Refresh();
            
            this.txtKey.Enabled = true;
            this.btnPlay.Enabled = true;
            this.numberTime.Enabled = true;
            // Stop time loop
            timerDelay.Enabled = false;
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(txtKey.Text);
        }

        private void labelTomoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/tuan0998");
        }

    }
}
