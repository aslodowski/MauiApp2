using Artalk.Xmpp.Client;
using MauiApp2.Services;
using MauiApp2.ViewModels.Base;
using System.Windows.Input;

namespace MauiApp2.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        private string _host;

        public string Host
        {
            get { return _host; }
            set
            {
                _host = value;
                OnPropertyChanged();
            }
        }

        public ArtalkXmppClient Client { get; set; }

        public ICommand ConnectCommand => new Command<object>(Connect);

        public LoginViewModel()
        {
        }

        void Connect(object parameter)
        {
            ClientService.Instance.Login(Host, UserName, Password);
            Client = ClientService.Instance.Client;

            Client.Message += MessageService.Instance.OnNewMessage;

            Client.Connect();

            NavigationService.Instance.NavigateToAsync<HomeViewModel>(parameter);
        }
    }
}