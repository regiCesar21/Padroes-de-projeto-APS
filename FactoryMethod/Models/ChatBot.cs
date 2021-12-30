using System;
using ComunicationMethods;

namespace ChatBotComunicationMethod
{
    public class ChatBot : IComunicationMethods
    {
        private const string ChannelName = "ChatBot";
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
