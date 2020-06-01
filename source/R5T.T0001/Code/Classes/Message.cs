using System;


namespace R5T.T0001
{
    public class Message
    {
        #region Static

        public static Message New(DateTime timestampUtc, MessageType messageType, string message)
        {
            var output = new Message(timestampUtc, messageType, message);
            return output;
        }

        public static Message NewError(DateTime timestampUtc, string errorMessage)
        {
            var message = new Message(timestampUtc, MessageType.Error, errorMessage);
            return message;
        }

        public static Message NewOutput(DateTime timestampUtc, string outputMessage)
        {
            var message = new Message(timestampUtc, MessageType.Output, outputMessage);
            return message;
        }

        #endregion


        public DateTime TimestampUtc { get; }
        public MessageType MessageType { get; }
        public string Value { get; }


        public Message(DateTime timestampUtc, MessageType messageType, string value)
        {
            this.TimestampUtc = timestampUtc;
            this.MessageType = messageType;
            this.Value = value;
        }
    }
}
