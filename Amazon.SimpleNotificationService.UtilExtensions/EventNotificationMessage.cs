using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amazon.SimpleNotificationService.UtilExtensions
{
    public class EventNotificationMessage
    {
        public List<Record> Records { get; set; }

        public static EventNotificationMessage Parse(string message)
        {
            return JsonConvert.DeserializeObject<EventNotificationMessage>(message);
        }
    }
}