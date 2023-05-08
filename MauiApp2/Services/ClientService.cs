using Artalk.Xmpp.Client;

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

        public void Login(string host, string userName, string password)
        {
            Client = new ArtalkXmppClient(host, userName, password);
        }

        public void Logout()
        {
            Client.Close();
            //Client.Dispose();
        } //test
    }
}