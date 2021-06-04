using System.Windows;
using MessengerMediatorPattern.Entities;

namespace MessengerMediatorPattern.Commands
{
    public class LeftMessengerCommand : BaseCommand
    {
        private Server _server;
        private Client _client; 
        public LeftMessengerCommand(Server server, Client client)
        {
            _server = server;
            _client = client;
        }

        public override void Execute(object parameter)
        {
            if (parameter is Window window)
                window.Close();


            _server.Notify(_client, new MessengerEventArgs()
            {
                MessengerEventType = MessengerEventType.SomeoneLeft,
            });
        }
    }
}