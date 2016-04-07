using Newtonsoft.Json;

namespace Amazon.SimpleNotificationService.UtilExtensions
{
    public class Identity
    {
        [JsonProperty(PropertyName = "principalid")]
        public string Principalid { get; set; }
    }
}
