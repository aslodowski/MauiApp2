using MauiApp2.Models;
using MauiApp2.Services;
using MauiApp2.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp2.ViewModels
{
    public class DetailViewModel : ViewModelBase
    {
        User _user;
        ObservableCollection<MessageDummy> _messages;

        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<MessageDummy> Messages
        {
            get { return _messages; }
            set
            {
                _messages = value;
                OnPropertyChanged();
            }
        }

        public ICommand BackCommand => new Command(OnBack);

        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is MessageDummy message)
            {
                User = message.Sender;
                Messages = new ObservableCollection<MessageDummy>(MessageService.Instance.GetMessages(User));
            }

            return base.InitializeAsync(navigationData);
        }

        void OnBack()
        {
            NavigationService.Instance.NavigateBackAsync();
        }
    }
}
