using System.Collections.Generic;
using MessengerMediatorPattern.Commands;
using MessengerMediatorPattern.Entities;

namespace MessengerMediatorPattern.ViewModels
{
    public class MessengerViewModel
    {
        public Client Client { get; set; }

        public LeftMessengerCommand LeftMessengerCommand { get; set; }
        public SendMessageCommand SendMessageCommand { get; set; }

        public MessengerViewModel(Server server, Client client)
        {
            Client = client;
            LeftMessengerCommand = new LeftMessengerCommand(server, Client);
            SendMessageCommand = new SendMessageCommand(server, client);
        }
    }
}