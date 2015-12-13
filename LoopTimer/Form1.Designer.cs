namespace LoopTimer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tbMinutes = new System.Windows.Forms.TextBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.cbLoop = new System.Windows.Forms.CheckBox();
			this.lblMinutes = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblHours = new System.Windows.Forms.Label();
			this.tbHours = new System.Windows.Forms.TextBox();
			this.tbSeconds = new System.Windows.Forms.TextBox();
			this.btnPause = new System.Windows.Forms.Button();
			this.lblSeconds = new System.Windows.Forms.Label();
			this.lblHr = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblMin = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblSec = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.SuspendLayout();
			// 
			// tbMinutes
			// 
			this.tbMinutes.Location = new System.Drawing.Point(83, 41);
			this.tbMinutes.Name = "tbMinutes";
			this.tbMinutes.Size = new System.Drawing.Size(44, 20);
			this.tbMinutes.TabIndex = 2;
			this.tbMinutes.Text = "0";
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(228, 9);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(54, 23);
			this.btnGo.TabIndex = 4;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// cbLoop
			// 
			this.cbLoop.AutoSize = true;
			this.cbLoop.Location = new System.Drawing.Point(228, 67);
			this.cbLoop.Name = "cbLoop";
			this.cbLoop.Size = new System.Drawing.Size(56, 17);
			this.cbLoop.TabIndex = 6;
			this.cbLoop.Text = "Loop?";
			this.cbLoop.UseVisualStyleBackColor = true;
			// 
			// lblMinutes
			// 
			this.lblMinutes.AutoSize = true;
			this.lblMinutes.Location = new System.Drawing.Point(76, 19);
			this.lblMinutes.Name = "lblMinutes";
			this.lblMinutes.Size = new System.Drawing.Size(44, 13);
			this.lblMinutes.TabIndex = 5;
			this.lblMinutes.Text = "Minutes";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblHours
			// 
			this.lblHours.AutoSize = true;
			this.lblHours.Location = new System.Drawing.Point(12, 19);
			this.lblHours.Name = "lblHours";
			this.lblHours.Size = new System.Drawing.Size(35, 13);
			this.lblHours.TabIndex = 6;
			this.lblHours.Text = "Hours";
			// 
			// tbHours
			// 
			this.tbHours.Location = new System.Drawing.Point(12, 41);
			this.tbHours.Name = "tbHours";
			this.tbHours.Size = new System.Drawing.Size(44, 20);
			this.tbHours.TabIndex = 1;
			this.tbHours.Text = "0";
			// 
			// tbSeconds
			// 
			this.tbSeconds.Location = new System.Drawing.Point(154, 41);
			this.tbSeconds.Name = "tbSeconds";
			this.tbSeconds.Size = new System.Drawing.Size(44, 20);
			this.tbSeconds.TabIndex = 3;
			this.tbSeconds.Text = "0";
			// 
			// btnPause
			// 
			this.btnPause.Enabled = false;
			this.btnPause.Location = new System.Drawing.Point(228, 38);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(54, 23);
			this.btnPause.TabIndex = 5;
			this.btnPause.Text = "Pause";
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// lblSeconds
			// 
			this.lblSeconds.AutoSize = true;
			this.lblSeconds.Location = new System.Drawing.Point(149, 19);
			this.lblSeconds.Name = "lblSeconds";
			this.lblSeconds.Size = new System.Drawing.Size(49, 13);
			this.lblSeconds.TabIndex = 11;
			this.lblSeconds.Text = "Seconds";
			// 
			// lblHr
			// 
			this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHr.Location = new System.Drawing.Point(25, 110);
			this.lblHr.Name = "lblHr";
			this.lblHr.Size = new System.Drawing.Size(50, 30);
			this.lblHr.TabIndex = 12;
			this.lblHr.Text = "00";
			this.lblHr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(92, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 30);
			this.label2.TabIndex = 13;
			this.label2.Text = ":";
			// 
			// lblMin
			// 
			this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMin.Location = new System.Drawing.Point(124, 110);
			this.lblMin.Name = "lblMin";
			this.lblMin.Size = new System.Drawing.Size(50, 30);
			this.lblMin.TabIndex = 14;
			this.lblMin.Text = "00";
			this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(191, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(15, 30);
			this.label4.TabIndex = 15;
			this.label4.Text = ":";
			// 
			// lblSec
			// 
			this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSec.Location = new System.Drawing.Point(223, 110);
			this.lblSec.Name = "lblSec";
			this.lblSec.Size = new System.Drawing.Size(50, 30);
			this.lblSec.TabIndex = 16;
			this.lblSec.Text = "00";
			this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipText = "Timer complete!";
			this.notifyIcon1.BalloonTipTitle = "Timer";
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Loop Timer";
			this.notifyIcon1.Visible = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 173);
			this.Controls.Add(this.lblSec);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblMin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblHr);
			this.Controls.Add(this.lblSeconds);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.tbSeconds);
			this.Controls.Add(this.tbHours);
			this.Controls.Add(this.lblHours);
			this.Controls.Add(this.lblMinutes);
			this.Controls.Add(this.cbLoop);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.tbMinutes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Loop Timer";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckBox cbLoop;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.TextBox tbSeconds;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

