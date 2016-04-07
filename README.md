# Amazon.SimpleNotificationService.UtilExtensions
More parsing capabilities for Amazon

## Usage  ##
To deserialize an Event Notification Message , e.g. the MessageText property of an SNS message.

    var result = EventNotificationMessage.Parse(message);