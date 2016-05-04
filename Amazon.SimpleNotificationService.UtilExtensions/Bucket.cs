using Newtonsoft.Json;

namespace Amazon.SimpleNotificationService.UtilExtensions
{
    public class Bucket
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public Identity OwnerIdentity { get; set; }

        [JsonProperty(PropertyName = "arn")]
        public string Arn { get; set; }
    }
}