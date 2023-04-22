using Artalk.Xmpp.Client;
using MauiApp2.ViewModels;

namespace MauiApp2.Views;

public partial class HomeView : ContentPage
{

	public HomeView()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        BindingContext = new HomeViewModel();
    }
}