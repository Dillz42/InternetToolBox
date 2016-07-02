using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace InternetToolBox
{
    public class Tools
    {
        private MainForm mainForm;
        public Tools(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public string httpRequest(string uri)
        {
            try
            {
                WebRequest request = WebRequest.Create(uri);
                ((HttpWebRequest)request).UserAgent = "";
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();

                string responseMessage = "";
                char ch = (char)dataStream.ReadByte();
                while ((byte)ch != 255)
                {
                    responseMessage += ch;
                    ch = (char)dataStream.ReadByte();
                }
                dataStream.Close();
                response.Close();
                return responseMessage;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void log(string message)
        {
            Console.WriteLine(DateTime.Now.ToString() + ": " + message);
            mainForm.logTextBox_AddLine(DateTime.Now.ToString() + ": " + message);
        }
        
        public void downloadFile(string url, string fileName)
        {
            log(string.Format("Downloading: {0} => {1}", url, fileName));
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, fileName);
        }
    }
}
