using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingJSON
{
    internal class Video
    {
        [JsonProperty("title")]
        internal string Title{get; set;}
        [JsonProperty("link")]
        private Url Url
        {
            get; set;
        }
        internal string LinkAddress
        {
            get
            {
                return this.Url.Href;
            }
            set
            {
                this.LinkAddress = this.Url.Href;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Title: {this.Title}");
            sb.AppendLine($"URL: {this.LinkAddress}");
            return sb.ToString();
        }
    }
}
