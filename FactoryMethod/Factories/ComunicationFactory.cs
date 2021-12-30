using System;
using ComunicationMethods;

namespace ComunicationFactory
{
    public abstract class Factory
    {
        public abstract IComunicationMethods getInfoComunicationChannel();

        public string getChannelName()
        {
            var comunication = getInfoComunicationChannel();

            var message = $"the complain  was received by {comunication.GetChannelName()}";
            return message;
        }

        public string setMessageReceived(string message)
        {
            var comunication = getInfoComunicationChannel();

            return comunication.setMessageReceived(message);
        }
    }
}
