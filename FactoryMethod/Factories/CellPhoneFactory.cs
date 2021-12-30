using System;
using ComunicationMethods;
using ComunicationFactory;
using CellPhoneComunicationMethod;

namespace CellPhoneComunicationMethodFactory
{
    public class CellPhoneFactory : Factory
    {
        public override IComunicationMethods getInfoComunicationChannel()
        {
            return new CellPhone();
        }
    }
}