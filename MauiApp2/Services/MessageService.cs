using Artalk.Xmpp;
using Artalk.Xmpp.Client;
using Artalk.Xmpp.Im;
using MauiApp2.Models;
using System.Collections.ObjectModel;

namespace MauiApp2.Services
{
    public class MessageService
    {
        static MessageService _instance;

        public static MessageService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MessageService();

                return _instance;
            }
        }

        public ObservableCollection<MessageDummy> Messages { get; set; }

        public void OnNewMessage(object? sender, MessageEventArgs e)
        {
            Jid userJid = e.Jid; //Tutaj Jid usera który przysłał
            string message = e.Message.Body; //Tutaj przysłana wiadomość

            var user = new User() //Zamienić na RosterItem
            {
                Name = userJid.ToString()
            };

            Messages.Add(new MessageDummy()
            {
                Sender = user,
                Text = message,
                Time = DateTime.Now.ToString()
            });

            //TODO do przetestowania i debugowania
        }

        public List<RosterItem> GetContacts(ArtalkXmppClient client)
        {
            var contacts = new List<RosterItem>();
            foreach (var rosterItem in client.GetRoster())
            {
                contacts.Add(rosterItem);
            }

            return contacts;
        }

        public List<User> GetUsers() //Do wyjebania
        {
            return new List<User>
            {
                user1, user2, user3, user4, user5, user6, user7, user8, user9, user10
            };
        }

        public List<MessageDummy> GetChats() //do wyjebania
        {
            return new List<MessageDummy>
            {
                new MessageDummy
                {
                  Sender = user6,
                  Time = "18:32",
                  Text = "Siema, co tam?",
                },
              new MessageDummy
              {
                Sender = user1,
                Time = "14:05",
                Text = "Nie mam czasu.",
              },
              new MessageDummy
              {
                Sender = user3,
                Time = "14:00",
                Text = "Nie wiem.",
              },
              new MessageDummy
              {
                Sender = user2,
                Time = "13:35",
                Text = "Lubisz placki?",
              },
              new MessageDummy
              {
                Sender = user4,
                Time= "12:11",
                Text= "Nie dzięki.",
              },
            };
        }

        public List<MessageDummy> GetMessages()
        {
            return new List<MessageDummy>
            {
                //new MessageDummy
                //{
                //  Sender = null,
                //  Time = "18:42",
                //  Text = "Lubisz to?",
                //},
                //new MessageDummy
                //{
                //  Sender = sender,
                //  Time = "18:39",
                //  Text = "Ciężko powiedzieć.",
                //},
                //new MessageDummy
                //{
                //  Sender = sender,
                //  Time = "18:39",
                //  Text =
                //      "hahahha",
                //},
                //new MessageDummy
                //{
                //  Sender = null,
                //  Time = "18:36",
                //  Text = "Nic nie robię, jak zawsze",
                //},
                //new MessageDummy
                //{
                //  Sender= sender,
                //  Time = "18:35",
                //  Text= "Eloszka.",
                //},
            };
        }

        readonly User user1 = new User //do wyjebania
        {
            Name = "Maciek Maciek",
            Color = Color.FromArgb("#FFE0EC")
        };

        readonly User user2 = new() //do wyjebania
        {
            Name = "Ziutek Ziutek",
            Image = "emoji2.png",
            Color = Color.FromArgb("#BFE9F2")
        };

        readonly User user3 = new() //do wyjebania
        {
            Name = "Ania Ania",
            Image = "emoji3.png",
            Color = Color.FromArgb("#FFD6C4")
        };

        readonly User user4 = new() //do wyjebania
        {
            Name = "Roman Roman",
            Image = "emoji4.png",
            Color = Color.FromArgb("#C3C1E6")
        };

        readonly User user5 = new() //do wyjebania
        {
            Name = "Justyna Justyna",
            Image = "emoji5.png",
            Color = Color.FromArgb("#FFE0EC")
        };

        readonly User user6 = new() //do wyjebania
        {
            Name = "James Bond",
            Image = "emoji6.png",
            Color = Color.FromArgb("#FFE5A6")
        };

        readonly User user7 = new() //do wyjebania
        {
            Name = "Gerard Kowalski",
            Image = "emoji7.png",
            Color = Color.FromArgb("#FFE0EC")
        };

        readonly User user8 = new() //do wyjebania
        {
            Name = "Antoni Whitney",
            Image = "emoji8.png",
            Color = Color.FromArgb("#FFE0EC")
        };

        readonly User user9 = new() //do wyjebania
        {
            Name = "Jaime Zuniga",
            Image = "emoji9.png",
            Color = Color.FromArgb("#C3C1E6")
        };

        readonly User user10 = new() //do wyjebania
        {
            Name = "Barbara Cherry",
            Image = "emoji10.png",
            Color = Color.FromArgb("#FF95A2")
        };
    }
}