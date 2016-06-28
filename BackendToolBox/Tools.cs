using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace BackendToolBox
{
    public class Tools
    {
        static void Main(string[] args)
        {
            Wallpaper.Set("C:\\Users\\Dillon\\Desktop\\Reddit Wallpapers\\test.jpg");
        }

        public static string httpRequest(string uri)
        {
            WebRequest request = WebRequest.Create(uri);
            ((HttpWebRequest)request).UserAgent = ".NET Framework Example Client";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();

            string responseMessage = "";
            char ch = (char)dataStream.ReadByte();
            while ((byte)ch != 255)
            {
                responseMessage += ch;
                ch = (char)dataStream.ReadByte();
            }

            return responseMessage;
        }

        public static void downloadFile(string url, string fileName)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, fileName);
        }
    }
}
