using System;

namespace ComunicationMethods
{
    public interface IComunicationMethods
    {
        public string GetChannelName();

        public string getMessageReceived();

        public string setMessageReceived(string message);
    }
}
