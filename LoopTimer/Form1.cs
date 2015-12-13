using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoopTimer
{
	public partial class Form1 : Form
	{
		public Int64 seconds = 0; // Seconds.
		public Int64 minutes = 0; // Minutes.
		public Int64 hours = 0;   // Hours.
		public bool paused = false; // State of the timer [PAUSED/WORKING].

		public Form1()
		{
            //event handlers to deal with attempts to enter non-integer values into the text boxes
			InitializeComponent();
			this.tbSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeconds_KeyDown);
			this.tbMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinutes_KeyDown);
			this.tbHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHours_KeyDown);
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			if (FormWindowState.Minimized == WindowState)
			{
				Hide();
			}
		}

		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
            //Change display text on the go and pause buttons when go is pressed
            //also initialize the time variables.  enable the pause button.
            //start the timer.
			if (btnGo.Text == "Go")
			{
				timer1.Enabled = true;
				paused = false;
				btnGo.Text = "Stop";
				seconds = Convert.ToInt64(tbSeconds.Text);
				minutes = Convert.ToInt64(tbMinutes.Text);
				hours = Convert.ToInt64(tbHours.Text);
				btnPause.Enabled = true;
			}
			else
			{
                //if the button is currently set to "stop" then flip it to go and halt the timer
                //also set all the time variables to 0 and disable the pause button
				btnGo.Text = "Go";
				timer1.Enabled = false;
				seconds = 0;
				minutes = 0;
				hours = 0;
				btnPause.Enabled = false;
			}
		}

        //these will prevent uses from entering anything but positive integers into the 
        //time text boxes
		private void tbSeconds_KeyDown(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
		}

		private void tbMinutes_KeyDown(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
		}

		private void tbHours_KeyDown(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
		}

        //handle clicking the pause button.  pauses the timer and flips text on the button itself.
		private void btnPause_Click(object sender, EventArgs e)
		{
			if (paused == false)
			{
				timer1.Enabled = false;
				paused = true;
				btnGo.Enabled = false;
				btnPause.Text = "Resume";
			}
			else
			{
				timer1.Enabled = true;
				paused = false;
				btnGo.Enabled = true;
				btnPause.Text = "Pause";
			}
		}

        //handle decrementing the timer for each of its ticks.
		private void timer1_Tick(object sender, EventArgs e)
		{
			if ((minutes == 0) && (hours == 0) && (seconds == 0))
			{
				if (cbLoop.Checked == true)
				{
					seconds = Convert.ToInt64(tbSeconds.Text);
					minutes = Convert.ToInt64(tbMinutes.Text);
					hours = Convert.ToInt64(tbHours.Text);
					notifyIcon1.ShowBalloonTip(60000); //balloon tip for when the timer finishes its current countdown
					return;
				}

				timer1.Enabled = false;
				btnGo.Enabled = true;
				notifyIcon1.ShowBalloonTip(60000);
			}
			else //handle the math as time counts down, converting minutes, seconds, etc. and update the labels
			{
				if (seconds < 1)
				{
					seconds = 59;
					if (minutes == 0)
					{
						minutes = 59;
						if (hours != 0)
							hours--;
					}
					else
					{
						minutes--;
					}
				}
				else
				{
					seconds--;
				}
					
				lblHr.Text = hours.ToString();
				lblMin.Text = minutes.ToString();
				lblSec.Text = seconds.ToString();
			}            
		}

        //reset all time values and labels to 0, stop the timer, and reset the buttons to their starting values
        private void btnReset_Click(object sender, EventArgs e)
        {
            seconds = 0;
            minutes = 0;
            hours = 0;

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
    }
}