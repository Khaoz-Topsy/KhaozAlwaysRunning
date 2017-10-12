using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KhaozAlwaysRunning.Communications
{
    public static class SlackRepository
    {
        //FFA500 //Orange
        //0000FF //Blue

        public static async void SendToSlackChannel(string title, string text, string link,
            string color = "#FF0000", string SlackURL = "https://hooks.slack.com/services/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")
        {
            var messageContent = new
            {
                attachments = new[]
                { new {
                    color = color,
                    title_link = link,
                    title = title,
                    text = text,
                    ts = (int)(DateTime.Now.ToUniversalTime() - (new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc))).TotalSeconds
                    }
                }
            };

            string messageContentJSON = JsonConvert.SerializeObject(messageContent);
            await SendMessage(SlackURL, messageContentJSON);
        }


        private static async Task<bool> SendMessage(string webHookURL, string msgContent)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(webHookURL);
                request.ContentType = "application/json";
                request.Method = "POST";
                var stream = await request.GetRequestStreamAsync();
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write(msgContent);
                    writer.Flush();
                    writer.Dispose();
                }

                var response = await request.GetResponseAsync();
                var respStream = response.GetResponseStream();

                using (StreamReader sr = new StreamReader(respStream))
                {
                    Console.WriteLine("Slack message sent");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("\t{0}", ex.Message));
                return false;
            }
        }
        
    }
}
