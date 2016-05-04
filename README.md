# Amazon.SimpleNotificationService.UtilExtensions
More parsing capabilities for Amazon

[![Build status](https://ci.appveyor.com/api/projects/status/ov2e5r1456lkhvg8?svg=true)](https://ci.appveyor.com/project/damiangreen/amazon-simplenotificationservice-utilextensions)
## Usage  ##
To deserialize an Event Notification Message , e.g. the MessageText property of an SNS message.

    var result = EventNotificationMessage.Parse(message);