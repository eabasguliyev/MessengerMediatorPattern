using System;

namespace MessengerMediatorPattern.Entities
{
    public class MessengerEventArgs : EventArgs
    {
        public MessengerEventType MessengerEventType { get; set; }
        public string Message { get; set; }
    }
}