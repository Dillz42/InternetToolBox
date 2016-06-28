using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using BackendToolBox;


namespace InternetToolBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }            
        
        public void setTopRedditWallpaper_Button_Click(object sender, EventArgs e)
            { setTopRedditWallpaper_Button_Click(); }

        public void setTopRedditWallpaper_Button_Click()
        {
            ThreadStart setTopRedditWallpaper = new ThreadStart(setTopRedditWallpaper_Button_Click_Thread);
            Thread setTopRedditWallpaper_thread = new Thread(setTopRedditWallpaper);
            setTopRedditWallpaper_thread.Start();
        }
        public void setTopRedditWallpaper_Button_Click_Thread()
        {
            setTopRedditWallpaper_Button_Enabled(false);
            string webResponse = Tools.httpRequest("http://www.reddit.com/r/wallpaper.json");
            JObject rWallpaper = JObject.Parse(webResponse);

            string imageUrl = rWallpaper["data"]["children"][0]["data"]["url"].ToString();
            Tools.downloadFile(imageUrl, @"C:\Users\Dillon\Desktop\Reddit Wallpapers\test.jpg");
            Wallpaper.Set(@"C:\Users\Dillon\Desktop\Reddit Wallpapers\test.jpg");
            Console.WriteLine("Desktop wallpaper has been changed!");
            setTopRedditWallpaper_Button_Enabled(true);
        }
    }
}
