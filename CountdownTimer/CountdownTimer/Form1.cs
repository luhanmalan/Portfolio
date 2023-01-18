using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class countdownTimer : Form
    {
        public countdownTimer()
        {
            InitializeComponent();
        }
        int timeleft = 60;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeleft > 0)
            {
                timeleft = timeleft - 1;
                timerLabel.Text = timeleft + " seconds";
            }
            else
            {
                timer.Stop();
                timerLabel.Text = "Time is up!";
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeleft = 60;
            timerLabel.Text = timeleft + " seconds";
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            timeleft = timeleft + 5;
            timerLabel.Text = timeleft.ToString() + " seconds";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            timeleft = timeleft - 5;
            timerLabel.Text = timeleft.ToString() + " seconds";
        }
    }
}
