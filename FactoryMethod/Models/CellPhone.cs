using System;
using ComunicationMethods;

namespace CellPhoneComunicationMethod
{
    public class CellPhone : IComunicationMethods
    {
        private const string ChannelName = "CellPhone";
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
