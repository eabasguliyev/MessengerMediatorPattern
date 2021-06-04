using System;
using System.Collections.ObjectModel;

namespace MessengerMediatorPattern.Entities
{
    public class Client
    {
        public string Nickname { get; set; }

        public ObservableCollection<String> Chat { get; set; }

        public Client()
        {
            Chat = new ObservableCollection<string>();
        }

        public void Update(object sender, MessengerEventArgs eventArgs)
        {
            if (!(sender is Client client))
                throw new ArgumentNullException(nameof(sender));


            string message = String.Empty;


            if (eventArgs.MessengerEventType == MessengerEventType.SomeoneJoined)
            {
                message = client == this ? "You joined" : $"{client.Nickname} joined";
            }
            else if (eventArgs.MessengerEventType == MessengerEventType.SomeoneLeft)
            {
                message = $"{client.Nickname} left";
            }
            else if(eventArgs.MessengerEventType == MessengerEventType.SomeoneWrote)
            {
                message = client==this? $"You: {eventArgs.Message}":$"{client.Nickname}: {eventArgs.Message}";
            }

            Chat.Add(message);
        }
    }
}