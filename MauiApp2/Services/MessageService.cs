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

        public void OnNewMessage(object sender, MessageEventArgs e)
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




    }
}