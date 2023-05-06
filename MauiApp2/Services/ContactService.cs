using Artalk.Xmpp.Client;
using Artalk.Xmpp.Im;

namespace MauiApp2.Services
{
    public class ContactService
    {
        static ContactService _instance;
        public static ContactService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ContactService();
                return _instance;
            }
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
    }
}
