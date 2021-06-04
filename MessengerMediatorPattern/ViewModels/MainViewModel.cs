using MessengerMediatorPattern.Commands;
using MessengerMediatorPattern.Entities;

namespace MessengerMediatorPattern.ViewModels
{
    public class MainViewModel
    {
        private Server _server;
        public JoinMessengerCommand JoinMessengerCommand { get; set; }

        public MainViewModel(Server server)
        {
            _server = server;
            JoinMessengerCommand = new JoinMessengerCommand(_server);
        }
    }
}