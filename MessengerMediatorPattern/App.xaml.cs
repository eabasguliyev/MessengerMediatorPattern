using System.Windows;
using MessengerMediatorPattern.Entities;
using MessengerMediatorPattern.ViewModels;
using MessengerMediatorPattern.Views;

namespace MessengerMediatorPattern
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            Server server = new Server();


            Window mainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(server)
            };

            mainWindow.Show();

            //Window messengerWindow = new MessengerView()
            //{
            //    DataContext = new MessengerViewModel(),
            //};

            //messengerWindow.ShowDialog();
            base.OnStartup(e);
        }
    }
}
