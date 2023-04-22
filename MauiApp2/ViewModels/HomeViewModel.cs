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
        ObservableCollection<User> _users; //do wyjebania
        ObservableCollection<MessageDummy> _recentChat;
        public ObservableCollection<RosterItem> _contactsCollection;

        public HomeViewModel()
        {
            LoadData();
        }

        public ObservableCollection<RosterItem> ContactsCollection
        {
            get { return _contactsCollection; }
            set
            {
                _contactsCollection = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<User> Users //To prawdopodobnie do wyjebania
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

        void LoadData()
        {
            //MessageService.Instance.Client = ClientService.Instance.Client;

            ContactsCollection = new ObservableCollection<RosterItem>(MessageService.Instance.GetContacts(ClientService.Instance.Client));

            Users = new ObservableCollection<User>(MessageService.Instance.GetUsers()); //Do wyjebania
            RecentChat = new ObservableCollection<MessageDummy>(MessageService.Instance.GetChats());
        }

        void OnNavigate(object parameter)
        {
            NavigationService.Instance.NavigateToAsync<DetailViewModel>(parameter);
        }

        public ICommand LogoutCommand => new Command<object>(Logout);
        void Logout(object parameter)
        {
            ClientService.Instance.Logout();


            NavigationService.Instance.NavigateToAsync<LoginViewModel>(parameter);
        }
    }
}