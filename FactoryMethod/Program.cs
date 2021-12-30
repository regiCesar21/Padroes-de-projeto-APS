using System;
using EmailComunicationMethodFactory;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new EmailFactory();
            Console.WriteLine(teste.setMessageReceived("Good Product!"));
        }
    }
}
