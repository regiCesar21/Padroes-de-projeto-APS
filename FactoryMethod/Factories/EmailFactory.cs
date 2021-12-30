using System;
using ComunicationMethods;
using ComunicationFactory;
using EmailComunicationMethod;

namespace EmailComunicationMethodFactory
{
    public class EmailFactory : Factory
    {
        public override IComunicationMethods getInfoComunicationChannel()
        {
            return new Email();
        }

    }
}