using Artalk.Xmpp.Im;
using MauiApp2.Services;
using MauiApp2.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp2.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        ObservableCollection<RosterItem> _contactsCollection;
        // public ContactsModel Contacts { get; set; } = new();
        public ObservableCollection<RosterItem> ContactsCollection
        {
            get { return _contactsCollection; }
            set
            {
                _contactsCollection = value;
                OnPropertyChanged();
            }
        }

        public HomeViewModel()
        {
            LoadData();
        }

        public ICommand DetailCommand => new Command<object>(OnNavigate);
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
        void LoadData()
        {
            //MessageService.Instance.Client = ClientService.Instance.Client;

            ContactsCollection = new ObservableCollection<RosterItem>
                (ContactService.Instance.GetContacts(ClientService.Instance.Client));
        }
    }
}