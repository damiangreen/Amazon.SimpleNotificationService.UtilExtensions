using System;
using System.Linq;
using NUnit.Framework;

namespace Amazon.SimpleNotificationService.UtilExtensions.Tests
{
    [TestFixture]
    public class EventNotificationMessageTests
    {
        [Test]
        public void CanDeserialize()
        {
            const string input = "{\"Records\":[{\"eventVersion\":\"2.0\",\"eventSource\":\"aws:s3\",\"awsRegion\":\"eu-west-1\",\"eventTime\":\"2016-04-06T15: 11:23.383Z\",\"eventName\":\"ObjectCreated:Put\",\"userIdentity\":{\"principalId\":\"AWS:AIDAJQADEJSWGM7NFFLVU\"},\"requestParameters\":{\"sourceIPAddress\":\"119.148.208.90\"},\"responseElements\":{\"x-amz-request-id\":\"44CC12B04449FEA6\",\"x-amz-id-2\":\"HloHKd2qhmQwhL5EocvMJH+n/3pkYWp/S1KrTfPWAhVRlHgpUyvgaFAXALtzSrTU1UD7MbgA=\"},\"s3\":{\"s3SchemaVersion\":\"1.0\",\"configurationId\":\"Y2ZmZTcxZjEtMzE5Mi00OTlhLWEwZjAtNWY1MmY1OTU0ZGU4\",\"bucket\":{\"name\":\"hits\",\"ownerIdentity\":{\"principalId\":\"AK2824BX0CDIU\"},\"arn\":\"arn:aws:s3:::hits\"},\"object\":{\"key\":\"CALL+BTCC% 21.txt\",\"size\":122,\"eTag\":\"7ef62a59d723c625730ecd480fe28c37\",\"sequencer\":\"005705271B456AC786\"}}}]}";

            var result = EventNotificationMessage.Parse(input);

            Assert.AreEqual(1, result.Records.Count);
            var firstRecord = result.Records.First();
            Assert.AreEqual("eu-west-1", firstRecord.AwsRegion);
            Assert.AreEqual("ObjectCreated:Put", firstRecord.EventName);
            Assert.AreEqual("aws:s3", firstRecord.EventSource);
            //Assert.AreEqual(Convert.ToDateTime("2016-04-06T15:11:23.383Z"), firstRecord.EventTime);
            Assert.AreEqual(2.0, firstRecord.EventVersion);
            Assert.AreEqual("119.148.208.90", firstRecord.RequestParameters.SourceIpAddress);
            Assert.AreEqual("44CC12B04449FEA6", firstRecord.ResponseElements.XAmzRequestId);
            Assert.AreEqual("HloHKd2qhmQwhL5EocvMJH+n/3pkYWp/S1KrTfPWAhVRlHgpUyvgaFAXALtzSrTU1UD7MbgA=", firstRecord.ResponseElements.XAmzId2);
            Assert.AreEqual(1.0, firstRecord.S3.S3SchemaVersion);
            Assert.AreEqual("Y2ZmZTcxZjEtMzE5Mi00OTlhLWEwZjAtNWY1MmY1OTU0ZGU4", firstRecord.S3.ConfigurationId);
            Assert.AreEqual("hits", firstRecord.S3.Bucket.Name);
            Assert.AreEqual("AK2824BX0CDIU", firstRecord.S3.Bucket.OwnerIdentity.Principalid);
            Assert.AreEqual("arn:aws:s3:::hits", firstRecord.S3.Bucket.Arn);
            Assert.AreEqual("CALL+BTCC% 21.txt", firstRecord.S3.Object.Key);
        }
    }
}
