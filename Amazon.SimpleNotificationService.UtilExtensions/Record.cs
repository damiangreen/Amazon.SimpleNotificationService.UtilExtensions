using System;
using Newtonsoft.Json;

namespace Amazon.SimpleNotificationService.UtilExtensions
{
    public class Record
    {
        [JsonProperty(PropertyName = "awsRegion")]
        public string AwsRegion { get; set; }

        [JsonProperty(PropertyName = "eventName")]
        public string EventName { get; set; }

        [JsonProperty(PropertyName = "eventSource")]
        public string EventSource { get; set; }

        [JsonProperty(PropertyName = "eventTime")]
        public DateTime EventTime { get; set; }

        [JsonProperty(PropertyName = "eventVersion")]
        public float EventVersion { get; set; }

        [JsonProperty(PropertyName = "requestParameters")]
        public RequestParameters RequestParameters { get; set; }

        [JsonProperty(PropertyName = "responseElements")]
        public ResponseElements ResponseElements { get; set; }

        [JsonProperty(PropertyName = "s3")]
        public S3 S3 { get; set; }

        [JsonProperty(PropertyName = "userIdentity")]
        public Identity Identity { get; set; }
    }
}