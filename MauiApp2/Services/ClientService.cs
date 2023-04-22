using Artalk.Xmpp.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Services
{
    internal class ClientService
    {
        static ClientService _instance;

        public ArtalkXmppClient Client { get; set; }


        public static ClientService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClientService();

                return _instance;
            }
        }
    }
}
