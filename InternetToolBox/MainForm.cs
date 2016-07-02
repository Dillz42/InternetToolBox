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

namespace InternetToolBox
{
    public partial class MainForm : Form
    {
        public Tools tools;

        public MainForm()
        {
            InitializeComponent();
            tools = new Tools(this);
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
            string webResponse = tools.httpRequest("http://www.reddit.com/r/wallpaper.json");
            JObject rWallpaper = JObject.Parse(webResponse);

            string imageUrl = rWallpaper["data"]["children"][0]["data"]["url"].ToString();
            tools.downloadFile(imageUrl, @"C:\Users\Dillon\Desktop\Reddit Wallpapers\test.jpg");
            Wallpaper.Set(@"C:\Users\Dillon\Desktop\Reddit Wallpapers\test.jpg");
            tools.log("Desktop wallpaper has been changed!");
            setTopRedditWallpaper_Button_Enabled(true);
        }

        private List<ChanThread> chanThreadList = new List<ChanThread>();

        private void chanAddWatch_Button_Click(object sender, EventArgs e)
        {
            ChanThread chanThread = new ChanThread(int.Parse(chanThreadId_TextBox.Text), chanBoard_TextBox.Text, tools);
            chanThreadList.Add(chanThread);
            ThreadStart threadStart = new ThreadStart(chanThread.run);
            Thread thread = new Thread(threadStart);
            thread.Start();
            chanThreadId_TextBox.Text = "";
        }
    }
}
