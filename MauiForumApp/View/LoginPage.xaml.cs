using MauiForumApp.ViewModel;

namespace MauiForumApp.View;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginView)
	{
		BindingContext = loginView;
		InitializeComponent();
	}
}