using Newtonsoft.Json;

namespace Amazon.SimpleNotificationService.UtilExtensions
{
    public class Object
    {
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }

        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; } 

        [JsonProperty(PropertyName = "sequencer")]
        public string Sequencer { get; set; }
    }
}