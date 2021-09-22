namespace WMSPharmacy.Forms
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.circleProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartTimer
            // 
            this.startTimer.Interval = 10;
            this.startTimer.Tick += new System.EventHandler(this.StartTimerTick);
            // 
            // CircleProgressBar
            // 
            this.circleProgressBar.animated = true;
            this.circleProgressBar.animationIterval = 1;
            this.circleProgressBar.animationSpeed = 1;
            this.circleProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circleProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleProgressBar.BackgroundImage")));
            this.circleProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circleProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleProgressBar.LabelVisible = false;
            this.circleProgressBar.LineProgressThickness = 8;
            this.circleProgressBar.LineThickness = 8;
            this.circleProgressBar.Location = new System.Drawing.Point(324, 143);
            this.circleProgressBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circleProgressBar.MaxValue = 100;
            this.circleProgressBar.Name = "CircleProgressBar";
            this.circleProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(86)))), ((int)(((byte)(82)))));
            this.circleProgressBar.Size = new System.Drawing.Size(135, 135);
            this.circleProgressBar.TabIndex = 16;
            this.circleProgressBar.Value = 0;
            // 
            // ProgressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressLabel.ForeColor = System.Drawing.Color.Gray;
            this.progressLabel.Location = new System.Drawing.Point(179, 79);
            this.progressLabel.Name = "ProgressLabel";
            this.progressLabel.Size = new System.Drawing.Size(437, 31);
            this.progressLabel.TabIndex = 17;
            this.progressLabel.Text = "Загрузка, пожалуйста подождите";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.circleProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SplashLoad);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SplashPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer startTimer;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleProgressBar;
        private System.Windows.Forms.Label progressLabel;
    }
}