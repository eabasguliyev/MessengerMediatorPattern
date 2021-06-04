using System;
using System.Windows.Input;

namespace MessengerMediatorPattern.Commands
{
    public abstract class BaseCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);

    }
}