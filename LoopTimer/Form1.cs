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
		public int seconds = 0; // Seconds.
		public int minutes = 0; // Minutes.
		public int hours = 0;   // Hours.
		public bool paused = false; // State of the timer [PAUSED/WORKING].

		public Form1()
		{
			InitializeComponent();
			this.tbMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeconds_KeyDown);
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
			if (btnGo.Text == "Go")
			{
				timer1.Enabled = true;
				paused = false;
				btnGo.Text = "Stop";
				seconds = System.Convert.ToInt32(tbSeconds.Text);
				minutes = System.Convert.ToInt32(tbMinutes.Text);
				hours = System.Convert.ToInt32(tbHours.Text);
				btnPause.Enabled = true;
			}
			else
			{
				btnGo.Text = "Go";
				timer1.Enabled = false;
				seconds = 0;
				minutes = 0;
				hours = 0;
				btnPause.Enabled = false;
			}
		}

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

		private void timer1_Tick(object sender, EventArgs e)
		{
			if ((minutes == 0) && (hours == 0) && (seconds == 0))
			{
				if (cbLoop.Checked == true)
				{
					seconds = System.Convert.ToInt32(tbSeconds.Text);
					minutes = System.Convert.ToInt32(tbMinutes.Text);
					hours = System.Convert.ToInt32(tbHours.Text);
					notifyIcon1.ShowBalloonTip(60000);
					return;
				}
				timer1.Enabled = false;
				btnGo.Enabled = true;
				notifyIcon1.ShowBalloonTip(60000);
			}
			else
			{
				if (seconds < 1)
				{
					seconds = 59;
					if (minutes == 0)
					{
						minutes = 59;
						if (hours != 0)
							hours -= 1;

					}
					else
					{
						minutes -= 1;
					}
				}
				else
				{
					seconds -= 1;
				}
					
				lblHr.Text = hours.ToString();
				lblMin.Text = minutes.ToString();
				lblSec.Text = seconds.ToString();
			}            
		}
	}
}
