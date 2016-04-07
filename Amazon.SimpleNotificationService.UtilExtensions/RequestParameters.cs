using Newtonsoft.Json;

namespace Amazon.SimpleNotificationService.UtilExtensions
{
    public class RequestParameters
    {
        [JsonProperty(PropertyName = "sourceIPAddress")]
        public string SourceIpAddress { get; set; } 
    }
}