using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    public class MessageModel
    {
        public string Username { get; set; }
        public string Message { get; set; }
        public string UserColor { get; set; }
        public DateTime MessageDateTime { get; set; }


        public MessageModel(string username, string message, string userColor, DateTime messageDateTime)
        {
            Username = username;
            Message = message;
            UserColor = userColor;
            MessageDateTime = messageDateTime;
        }
    }
}
