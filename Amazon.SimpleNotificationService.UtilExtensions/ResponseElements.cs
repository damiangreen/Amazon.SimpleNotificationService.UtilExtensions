using Newtonsoft.Json;

namespace Amazon.SimpleNotificationService.UtilExtensions
{
    public class ResponseElements
    {
        [JsonProperty(PropertyName = "x-amz-request-id")]
        public string XAmzRequestId { get; set; }

        [JsonProperty(PropertyName = "x-amz-id-2")]
        public string XAmzId2 { get; set; }
    }
}