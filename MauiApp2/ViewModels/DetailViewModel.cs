using Artalk.Xmpp.Im;
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

        private RosterItem _contact;

        public RosterItem Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
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

        string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public ICommand BackCommand => new Command(OnBack);
        public ICommand SendCommand => new Command(SendMessage);

        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is MessageDummy message)
            {
                User = message.Sender;
                //Messages = new ObservableCollection<MessageDummy>(MessageService.Instance.GetMessages());

                MessageService.Instance.Messages = Messages;
            }

            return base.InitializeAsync(navigationData);
        }

        public void SendMessage()
        {
            if (Message is null || Contact is null) return;

            var client = ClientService.Instance.Client;

            client.SendMessage(Contact.Jid, Message);

            Messages.Add(new MessageDummy()
            {
                Sender = null,
                Text = Message,
                Time = DateTime.Now.ToString()
            });
        }

        void OnBack()
        {
            NavigationService.Instance.NavigateBackAsync();
        }
    }
}