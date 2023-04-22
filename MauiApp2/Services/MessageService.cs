using MauiApp2.Models;

namespace MauiApp2.Services
{
    public class MessageService
    {
        static MessageService _instance;
        
        //zrobić metode OnMessage();

        public static MessageService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MessageService();

                return _instance;
            }
        }

        readonly User user1 = new User
        {
            Name = "Maciek Maciek",
            Color = Color.FromArgb("#FFE0EC")
        };
        readonly User user2 = new()
        {
            Name = "Ziutek Ziutek",
            Image = "emoji2.png",
            Color = Color.FromArgb("#BFE9F2")
        };
        readonly User user3 = new()
        {
            Name = "Ania Ania",
            Image = "emoji3.png",
            Color = Color.FromArgb("#FFD6C4")
        };
        readonly User user4 = new()
        {
            Name = "Roman Roman",
            Image = "emoji4.png",
            Color = Color.FromArgb("#C3C1E6")
        };
        readonly User user5 = new()
        {
            Name = "Justyna Justyna",
            Image = "emoji5.png",
            Color = Color.FromArgb("#FFE0EC")
        };
        readonly User user6 = new()
        {
            Name = "James Bond",
            Image = "emoji6.png",
            Color = Color.FromArgb("#FFE5A6")
        };
        readonly User user7 = new()
        {
            Name = "Gerard Kowalski",
            Image = "emoji7.png",
            Color = Color.FromArgb("#FFE0EC")
        };
        readonly User user8 = new()
        {
            Name = "Antoni Whitney",
            Image = "emoji8.png",
            Color = Color.FromArgb("#FFE0EC")
        };
        readonly User user9 = new()
        {
            Name = "Jaime Zuniga",
            Image = "emoji9.png",
            Color = Color.FromArgb("#C3C1E6")
        };
        readonly User user10 = new()
        {
            Name = "Barbara Cherry",
            Image = "emoji10.png",
            Color = Color.FromArgb("#FF95A2")
        };

        public List<User> GetUsers()
        {
            return new List<User>
            {
                user1, user2, user3, user4, user5, user6, user7, user8, user9, user10
            };
        }
        public List<MessageDummy> GetChats()
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

        public List<MessageDummy> GetMessages(User sender)
        {
            return new List<MessageDummy> {
              new MessageDummy
              {
                Sender = null,
                Time = "18:42",
                Text = "Lubisz to?",
              },
              new MessageDummy
              {
                Sender = sender,
                Time = "18:39",
                Text = "Ciężko powiedzieć.",
              },
              new MessageDummy
              {
                Sender = sender,
                Time = "18:39",
                Text =
                    "hahahha",
              },
              new MessageDummy
              {
                Sender = null,
                Time = "18:36",
                Text = "Nic nie robię, jak zawsze",
              },
              new MessageDummy
              {
                Sender= sender,
                Time = "18:35",
                Text= "Eloszka.",
              },
            };
        }
    }
}
