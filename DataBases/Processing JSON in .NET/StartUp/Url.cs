using Newtonsoft.Json;

namespace ProcessingJSON
{
    internal class Url
    {
        [JsonProperty("@rel")]
        internal string Rel { get; set; }
        [JsonProperty("@href")]
        internal string Href { get; set; }
    }
}