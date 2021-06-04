using System;
using System.Collections.Generic;

namespace MessengerMediatorPattern.Entities
{
    public class Server
    {
        private List<Client> _clients;

        private event EventHandler<MessengerEventArgs> ServerEvent;

        public Server()
        {
            _clients = new List<Client>();
        }
        private void AddClient(Client client)
        {
            _clients.Add(client);

            ServerEvent += client.Update;
        }

        private void RemoveClient(Client client)
        {
            _clients.Remove(client);

            ServerEvent -= client.Update;
        }

        public void Notify(object sender, MessengerEventArgs eventArgs)
        {
            if (eventArgs.MessengerEventType == MessengerEventType.SomeoneJoined)
            {
                AddClient(sender as Client);
            }
            else if (eventArgs.MessengerEventType == MessengerEventType.SomeoneLeft)
            {
                
                RemoveClient(sender as Client);
            }

            ServerEvent?.Invoke(sender, eventArgs);
        }
    }
}