using System;


namespace R5T.T0001
{
    public class Message
    {
        #region Static

        public static Message New(DateTime timestampUtc, MessageType messageType, string messageValue)
        {
            var message = new Message(timestampUtc, messageType, messageValue);
            return message;
        }

        public static Message NewError(DateTime timestampUtc, string messageValue)
        {
            var message = new Message(timestampUtc, MessageType.Error, messageValue);
            return message;
        }

        public static Message NewOutput(DateTime timestampUtc, string messageValue)
        {
            var message = new Message(timestampUtc, MessageType.Output, messageValue);
            return message;
        }

        #endregion


        public DateTime TimestampUtc { get; }
        public MessageType MessageType { get; }
        public string Value { get; }


        public Message(DateTime timestampUtc, MessageType messageType, string value)
        {
            this.TimestampUtc = timestampUtc;
            this.MessageType = MessageType;
            this.Value = value;
        }
    }
}
