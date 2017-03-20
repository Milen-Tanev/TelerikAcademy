using System;
using System.Net;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace ProcessingJSON
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Download RSS programatically
            var url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            var saveFile = "../../../TelerikFeed.xml";
            WebClient feedDownloader = new WebClient();
            feedDownloader.DownloadFile(url, saveFile);

            // Parse XML to JSON
            XmlDocument doc = new XmlDocument();
            doc.Load(saveFile);

            string json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);

            JObject rss = JObject.Parse(json);
            var videos = rss["feed"]["entry"];
            File.WriteAllText("../../../Videos.json", videos.ToString());
            var titlesList =
                from names in videos
                select names["title"];

            foreach (var title in titlesList)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            // Parse videos to POCO
            var videosList = File.ReadAllText("../../../Videos.json");

            var videosObjectsList = JsonConvert.DeserializeObject<List<Video>>(videosList);

            foreach (var item in videosObjectsList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            // VideoHTML - The iframes' content cannot be viewed in Chrome, Mozilla and Edge for security reasons
            // If you open it in Edge, it gives you the possibility to open it in new tab. Haven't tested other browsers
            StringBuilder htmlTemplate = new StringBuilder();
            htmlTemplate.Append("<!DOCTYPE html><html><head><title></title><meta charset=\"utf-8\"><meta name=\"viewport\"></head><body><ul>");
            foreach (Video video in videosObjectsList)
            {
                htmlTemplate.Append($"<li>Title: {video.Title}<br><iframe width=\"420\" height=\"315\" src=\"{video.LinkAddress}\" frameborder=\"0\" allowfullscreen></iframe></li>");
            }
            htmlTemplate.Append("<ul></body></html>");
            File.WriteAllText("../../../Videos.html", htmlTemplate.ToString());   
        }
    }
}
