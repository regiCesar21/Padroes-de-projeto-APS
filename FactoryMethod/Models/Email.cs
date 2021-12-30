using System;
using ComunicationMethods;

namespace EmailComunicationMethod
{
    public class Email : IComunicationMethods
    {
        private const string ChannelName = "Email";
        private string Message;

        public string GetChannelName()
        {
            return ChannelName;
        }

        public string getMessageReceived()
        {
            return Message;
        }

        public string setMessageReceived(string message)
        {
            Message = message;

            return Message;
        }
    }
}
