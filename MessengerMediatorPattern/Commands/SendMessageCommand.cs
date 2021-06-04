using MessengerMediatorPattern.Entities;

namespace MessengerMediatorPattern.Commands
{
    public class SendMessageCommand:BaseCommand
    {
        private Server _server;
        private Client _client;

        public SendMessageCommand(Server server, Client client)
        {
            _server = server;
            _client = client;
        }

        public override void Execute(object parameter)
        {
            _server.Notify(_client, new MessengerEventArgs()
            {
                MessengerEventType = MessengerEventType.SomeoneWrote, 
                Message = parameter as string
            });
        }
    }
}