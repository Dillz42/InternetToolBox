namespace InternetToolBox
{
    partial class MainForm
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
            this.setTopRedditWallpaper_Button = new System.Windows.Forms.Button();
            this.chanThreadId_TextBox = new System.Windows.Forms.TextBox();
            this.chanAddWatch_Button = new System.Windows.Forms.Button();
            this.chanBoard_TextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // setTopRedditWallpaper_Button
            // 
            this.setTopRedditWallpaper_Button.Location = new System.Drawing.Point(12, 12);
            this.setTopRedditWallpaper_Button.Name = "setTopRedditWallpaper_Button";
            this.setTopRedditWallpaper_Button.Size = new System.Drawing.Size(141, 23);
            this.setTopRedditWallpaper_Button.TabIndex = 1;
            this.setTopRedditWallpaper_Button.Text = "Set top reddit wallpaper";
            this.setTopRedditWallpaper_Button.UseVisualStyleBackColor = true;
            this.setTopRedditWallpaper_Button.Click += new System.EventHandler(this.setTopRedditWallpaper_Button_Click);
            // 
            // chanThreadId_TextBox
            // 
            this.chanThreadId_TextBox.Location = new System.Drawing.Point(64, 41);
            this.chanThreadId_TextBox.Name = "chanThreadId_TextBox";
            this.chanThreadId_TextBox.Size = new System.Drawing.Size(100, 20);
            this.chanThreadId_TextBox.TabIndex = 2;
            // 
            // chanAddWatch_Button
            // 
            this.chanAddWatch_Button.Location = new System.Drawing.Point(170, 39);
            this.chanAddWatch_Button.Name = "chanAddWatch_Button";
            this.chanAddWatch_Button.Size = new System.Drawing.Size(75, 23);
            this.chanAddWatch_Button.TabIndex = 3;
            this.chanAddWatch_Button.Text = "Watch";
            this.chanAddWatch_Button.UseVisualStyleBackColor = true;
            this.chanAddWatch_Button.Click += new System.EventHandler(this.chanAddWatch_Button_Click);
            // 
            // chanBoard_TextBox
            // 
            this.chanBoard_TextBox.Location = new System.Drawing.Point(12, 41);
            this.chanBoard_TextBox.Name = "chanBoard_TextBox";
            this.chanBoard_TextBox.Size = new System.Drawing.Size(46, 20);
            this.chanBoard_TextBox.TabIndex = 4;
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(251, 12);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(341, 215);
            this.logTextBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 240);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.chanBoard_TextBox);
            this.Controls.Add(this.chanAddWatch_Button);
            this.Controls.Add(this.chanThreadId_TextBox);
            this.Controls.Add(this.setTopRedditWallpaper_Button);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button setTopRedditWallpaper_Button;
        public void setTopRedditWallpaper_Button_Enabled(bool enabled)
        {
            if (InvokeRequired)
            {
                setTopRedditWallpaper_Button.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate ()
                { this.setTopRedditWallpaper_Button.Enabled = enabled; });
                return;
            }
            setTopRedditWallpaper_Button.Enabled = enabled;
        }

        private System.Windows.Forms.TextBox chanThreadId_TextBox;
        private System.Windows.Forms.Button chanAddWatch_Button;
        private System.Windows.Forms.TextBox chanBoard_TextBox;

        private System.Windows.Forms.TextBox logTextBox;
        public void logTextBox_AddLine(string line)
        {
            if (InvokeRequired)
            {
                setTopRedditWallpaper_Button.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate ()
                { this.logTextBox.AppendText(line + "\n"); });
                return;
            }
            logTextBox.AppendText(line + "\n");
        }
    }
}

