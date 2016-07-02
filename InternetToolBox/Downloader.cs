using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InternetToolBox
{
    class Downloader 
    {

        private string url;         public string Url{get{return url;}}
        private string localDir;    public string LocalDir { get { return localDir; } }
        private string fileName;    public string FileName { get { return fileName; } }

        private ThreadStart threadStart;
        private Thread thread;
        private Tools tools;

        public Downloader(string url, string localDir, string fileName, bool waitToDownload, Tools tools)
        {
            this.tools = tools;
            this.url = url;
            this.localDir = localDir;
            this.fileName = fileName;
            
            threadStart = new ThreadStart(startDownload);
            thread = new Thread(threadStart);
            if (waitToDownload == false)
                thread.Start();
        }

        public void start()
        {
            thread.Start();
        }

        private void startDownload()
        {
            tools.downloadFile(url, localDir + fileName);
        }

        public bool isAlive()
        {
            return thread.IsAlive;
        }

        public void join()
        {
            if(thread.IsAlive)
                thread.Join();
        }
    }
}
