namespace InternetToolBox
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
            this.setTopRedditWallpaper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setTopRedditWallpaper
            // 
            this.setTopRedditWallpaper.Location = new System.Drawing.Point(12, 12);
            this.setTopRedditWallpaper.Name = "setTopRedditWallpaper";
            this.setTopRedditWallpaper.Size = new System.Drawing.Size(141, 23);
            this.setTopRedditWallpaper.TabIndex = 0;
            this.setTopRedditWallpaper.Text = "Set top reddit wallpaper";
            this.setTopRedditWallpaper.UseVisualStyleBackColor = true;
            this.setTopRedditWallpaper.Click += new System.EventHandler(this.setTopRedditWallpaper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 240);
            this.Controls.Add(this.setTopRedditWallpaper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setTopRedditWallpaper;
    }
}

