using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace InternetToolBox
{
    public class ChanThread
    {
        private Tools tools;

        private const int SLEEP_TIME_DEFAULT = 20000;
        private const int SLEEP_TIME_MAX = 300000;
        private const int SLEEP_TIME_STEP = 10000;
        private int sleepTime = SLEEP_TIME_DEFAULT; public int SleepTime { get { return sleepTime; } }

        private int threadId;   public int ThreadId { get { return threadId; } }
        private string board;   public string Board { get { return board; } }
        private string path;    public string Path { get { return path; } }
        
        public ChanThread(int threadId, string board, Tools tools)
        {
            this.tools = tools;
            this.threadId = threadId;
            this.board = board;

            JObject jsonObject = null;
            try
            {
                jsonObject = JObject.Parse(tools.httpRequest(
                        "http://a.4cdn.org/" + board + "/thread/" + threadId + ".json"));
            }
            catch (Exception e)
            {
                tools.log("Error: " + e.Message);
                tools.log("Error: " + e.StackTrace);
                return;
            }

            path = "D:\\Downloads\\PicsAndVids\\FromChan\\" + board + "-" + threadId + "-" + jsonObject["posts"][0]["semantic_url"] + "\\";
            if(Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
        }

        public void run()
        {
            while (true)
            {
                try
                {
                    JObject jsonObject = JObject.Parse(tools.httpRequest("http://a.4cdn.org/" + board + "/thread/" + threadId + ".json"));
                    File.WriteAllText(path + "thread.json", jsonObject.ToString());

                    List<Downloader> downloaderList = new List<Downloader>();
                    for (int i = 0; i < ((JArray)jsonObject["posts"]).Count; i++)
                    {
                        if (jsonObject["posts"][i]["tim"] != null)
                        {
                            Downloader downloader = new Downloader(
                                "http://i.4cdn.org/" + board + "/" +
                                    jsonObject["posts"][i]["tim"] +
                                    jsonObject["posts"][i]["ext"],
                                path,
                                jsonObject["posts"][i]["tim"] + "-" +
                                    jsonObject["posts"][i]["filename"] +
                                    jsonObject["posts"][i]["ext"],
                                true, tools);
                            downloaderList.Add(downloader);
                        }
                    }

                    if (downloaderList.Count == 0)
                    {
                        switch (board)
                        {
                            case "b":
                                sleepTime += SLEEP_TIME_STEP/2;
                                if (sleepTime > SLEEP_TIME_MAX/5)
                                    sleepTime = SLEEP_TIME_MAX/5;
                                break;
                            default:
                                sleepTime += SLEEP_TIME_STEP;
                                if (sleepTime > SLEEP_TIME_MAX)
                                    sleepTime = SLEEP_TIME_MAX;
                                break;
                        }
                    }
                    else
                    {
                        sleepTime = SLEEP_TIME_DEFAULT;
                        foreach (Downloader downloader in downloaderList)
                        {
                            if (File.Exists(downloader.LocalDir + downloader.FileName) == false)
                            {
                                downloader.start();
                            }
                        }
                        foreach (Downloader downloader in downloaderList)
                        {
                            downloader.join();
                        }
                    }
                    tools.log("Thread " + board + "-" + threadId + " updated");
                    Thread.Sleep(sleepTime);
                }
                catch (Exception e)
                {
                    tools.log("Error: " + e.Message);
                    tools.log("Error: " + e.StackTrace);
                    return;
                }
            }
        }
    }
}
