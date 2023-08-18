using System;
using System.Windows.Forms;

namespace LoopTimer
{
    public partial class Form1 : Form
    {
        private TimerLogic timerLogic;

        public Form1()
        {
            InitializeComponent();
            timerLogic = new TimerLogic();
            timerLogic.TimeUpdated += UpdateUI; // Subscribe to event
            cbLoop.CheckedChanged += cbLoop_CheckedChanged;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (btnGo.Text == "Go")
            {
                if (ValidateHours(tbHours.Text, out int hours) &&
                    ValidateMinutesOrSeconds(tbMinutes.Text, out int minutes) &&
                    ValidateMinutesOrSeconds(tbSeconds.Text, out int seconds))
                {
                    timerLogic.SetTime(hours, minutes, seconds);
                    timerLogic.Start();
                    timer1.Interval = 1000;
                    timer1.Enabled = true; // Enable the timer control
                    btnGo.Text = "Stop";
                    btnPause.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please enter valid time values.");
                }
            }
            else
            {
                timerLogic.Reset();
                timer1.Enabled = false; // Disable the timer control
                btnGo.Text = "Go";
                btnPause.Enabled = false;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timerLogic.Pause();
            btnPause.Text = timerLogic.Paused ? "Resume" : "Pause";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timerLogic.Reset();
            // Update UI as needed
            tbSeconds.Text = "0";
            tbMinutes.Text = "0";
            tbHours.Text = "0";
            lblSec.Text = "0";
            lblMin.Text = "0";
            lblHr.Text = "0";
            btnGo.Text = "Go";
            timer1.Enabled = false;
            btnPause.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLogic.Tick();
        }

        private void UpdateUI()
        {
            lblHr.Text = timerLogic.Hours.ToString("D2"); // Format as two digits
            lblMin.Text = timerLogic.Minutes.ToString("D2"); // Format as two digits
            lblSec.Text = timerLogic.Seconds.ToString("D2"); // Format as two digits
        }

        private bool ValidateHours(string input, out int value)
        {
            value = 0;
            return int.TryParse(input, out value) && value >= 0 && value < 24;
        }

        private bool ValidateMinutesOrSeconds(string input, out int value)
        {
            value = 0;
            return int.TryParse(input, out value) && value >= 0 && value < 60;
        }
        private void tbHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string input = tbHours.Text + e.KeyChar;
            if (!ValidateHours(input, out _))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid hour (0-23).");
            }
        }

        private void tbMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string input = tbMinutes.Text + e.KeyChar;
            if (!ValidateMinutesOrSeconds(input, out _))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid minute (0-59).");
            }
        }
        private void tbSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string input = tbSeconds.Text + e.KeyChar;
            if (!ValidateMinutesOrSeconds(input, out _))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid second (0-59).");
            }
        }

        private void cbLoop_CheckedChanged(object sender, EventArgs e)
        {
            timerLogic.Looping = cbLoop.Checked;
        }
    }
}