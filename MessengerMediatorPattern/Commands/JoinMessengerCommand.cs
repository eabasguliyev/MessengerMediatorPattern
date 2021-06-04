using System.Windows;
using MessengerMediatorPattern.Entities;
using MessengerMediatorPattern.ViewModels;
using MessengerMediatorPattern.Views;

namespace MessengerMediatorPattern.Commands
{
    public class JoinMessengerCommand:BaseCommand
    {
        private readonly Server _server;

        public JoinMessengerCommand(Server server)
        {
            _server = server;
        }

        public override void Execute(object parameter)
        {
            Client client = CreateNewClient(parameter as string);
         
            Window newWindow = new MessengerView()
            {
                DataContext = new MessengerViewModel(_server, client)
            };
            
            _server.Notify(client, new MessengerEventArgs()
            {
                MessengerEventType = MessengerEventType.SomeoneJoined,
            });

            newWindow.Show();
        }

        private Client CreateNewClient(string nickname)
        {

            Client client = new Client()
            {
                Nickname = nickname
            };

            return client;
        }
    }
}