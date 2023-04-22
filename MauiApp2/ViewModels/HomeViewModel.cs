using MauiApp2.Models;
using MauiApp2.Services;
using MauiApp2.ViewModels.Base;
using MauiApp2.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Artalk.Xmpp.Client;
using Artalk.Xmpp.Im;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp2.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        ObservableCollection<User> _users;
        ObservableCollection<MessageDummy> _recentChat;

        //To będzie w LoginViewModel -->
        public string UserName { get; set; } = "t1";

        public string Hostname { get; set; } = "legion-y540";
        public string Password { get; set; } = "t1";

        public ArtalkXmppClient Client { get; set; }

        //To będzie w LoginViewModel <--

        public HomeViewModel()
        {
            Connect();
            LoadData();
        }

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<MessageDummy> RecentChat
        {
            get { return _recentChat; }
            set
            {
                _recentChat = value;
                OnPropertyChanged();
            }
        }

        public ICommand DetailCommand => new Command<object>(OnNavigate);

        void Connect() //To będzie w LoginViewModel
        {
            ClientService.Instance.Login(Hostname, UserName, Password);
            Client = ClientService.Instance.Client;

            Client.Message += MessageService.Instance.OnNewMessage;

            Client.Connect();
        }

        void LoadData()
        {
            Users = new ObservableCollection<User>(MessageService.Instance.GetUsers());
            RecentChat = new ObservableCollection<MessageDummy>(MessageService.Instance.GetChats());
        }

        void OnNavigate(object parameter)
        {
            NavigationService.Instance.NavigateToAsync<DetailViewModel>(parameter);
        }
    }
}