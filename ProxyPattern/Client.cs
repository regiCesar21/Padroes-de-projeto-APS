using System;
using ClientModel;

namespace ClientConcreteClass
{
    public class Client
    {
        private ClientModelClass ClientMock = new ClientModelClass
        {
            ClientName = "John Doe",
            ClientID = Guid.NewGuid().ToString(),
            ClientAmount = 1000
        };
        
        public Client()
        {
            Console.WriteLine($"Welcome, {ClientMock.ClientName}");
        }

        public String getName()
        {
            return ClientMock.ClientName;
        }

        public int getAmount()
        {
            return ClientMock.ClientAmount;
        }

        public int setAmount(int value)
        {
            return ClientMock.ClientAmount += value;
        }
    }

}