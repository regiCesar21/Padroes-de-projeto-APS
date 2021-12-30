using System;
using IClientInterface;
using ClientConcreteClass;

namespace Proxy{

public class ClientProxy : IClient
    {
        Client client = new Client();

        public string getName()
        {
            var clientName = client.getName();

            return $"The account's owner is {clientName}.";
        }

        public string getAmount()
        {
            var clientAmount = client.getAmount();
            
            return $"The Current Amount for {client.getName()} is ${clientAmount}.";
        }

        public string setAmount(int value)
        {
            var newAmount = client.setAmount(value);
            var clientName = client.getName();

            return $"Adding {value} to {clientName}'s account. The Current Amount is ${newAmount}.";
        }

        public string getCompleteClientData()
        {
            var completeData = $"Name: {client.getName()} \nAmount: {client.getAmount()}";

            return completeData;
        }
        
    }
}