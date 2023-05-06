using Artalk.Xmpp.Im;
using System.Collections.ObjectModel;

namespace MauiApp2.Models
{
    public class ContactsModel
    {
        public ObservableCollection<RosterItem> ContactsCollection { get; set; } = new();
    }
}
