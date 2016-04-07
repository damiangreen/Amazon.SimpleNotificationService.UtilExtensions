﻿using Newtonsoft.Json;

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

    public class S3
    {
        [JsonProperty(PropertyName = "s3SchemaVersion")]
        public float S3SchemaVersion { get; set; }

        [JsonProperty(PropertyName = "configurationId")]
        public string ConfigurationId { get; set; }

        [JsonProperty(PropertyName = "object")]
        public Object Object { get; set; }

        [JsonProperty(PropertyName = "bucket")]
        public Bucket Bucket { get; set; }
    }
}