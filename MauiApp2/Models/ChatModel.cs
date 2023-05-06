using System.Collections.ObjectModel;

namespace MauiApp2.Models
{
    public class ChatModel
    {
        public ObservableCollection<MessageModel> ChatRoom { get; set; } = new();
    }
}
