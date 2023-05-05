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
                _instance ??= new ClientService();

                return _instance;
            }
        }

        public void Login(string hostman, string userName, string password)
        {
            Client = new ArtalkXmppClient(hostman, userName, password);
        }

        public void Logout()
        {
            Client.Dispose();
        } //test
    }
}