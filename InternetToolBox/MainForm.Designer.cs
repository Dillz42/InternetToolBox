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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 240);
            this.Controls.Add(this.setTopRedditWallpaper_Button);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

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
    }
}

