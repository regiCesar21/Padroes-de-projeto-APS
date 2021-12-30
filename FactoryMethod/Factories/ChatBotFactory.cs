using System;
using ComunicationMethods;
using ComunicationFactory;
using ChatBotComunicationMethod;

namespace ChatbotComunicationMethodFactory
{
    public class ChatBotFactory : Factory
    {
        public override IComunicationMethods getInfoComunicationChannel()
        {
            return new ChatBot();
        }

    }
}