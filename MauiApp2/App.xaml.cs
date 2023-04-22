﻿using Artalk.Xmpp.Client;
using MauiApp2.ViewModels;
using MauiApp2.Views;

namespace MauiApp2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new LoginView());
    }
}
