using MauiApp2.ViewModels;

namespace MauiApp2.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
		BindingContext = new LoginViewModel();
    }
}