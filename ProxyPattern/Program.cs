using System;
using System.Threading;
using Proxy;


namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientProxy clientProxy = new ClientProxy();


            Console.WriteLine(clientProxy.getName());
            Console.WriteLine(clientProxy.getAmount());
            Console.WriteLine(clientProxy.setAmount(5000));
            Console.WriteLine(clientProxy.getAmount());

            Console.ReadKey();
        }
    }
}
