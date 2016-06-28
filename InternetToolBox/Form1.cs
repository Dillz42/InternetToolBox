using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using BackendToolBox;

namespace InternetToolBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setTopRedditWallpaper_Click(object sender, EventArgs e)
        {
            string webResponse = Tools.httpRequest("http://www.reddit.com/r/wallpaper.json");
            JObject rWallpaper = JObject.Parse(webResponse);

            string imageUrl = rWallpaper["data"]["children"][0]["data"]["url"].ToString();
            Tools.downloadFile(imageUrl, @"C:\Users\Dillon\Desktop\Reddit Wallpapers\test.jpg");

            Wallpaper.Set(@"C:\Users\Dillon\Desktop\Reddit Wallpapers\test.jpg");
        }
    }
}
