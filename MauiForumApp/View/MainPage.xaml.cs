using MauiForumApp.View;
using MauiForumApp.ViewModel;

namespace MauiForumApp;

public partial class MainPage : ContentPage
{
	public MainPage(TopicViewModel viewModel)	
	{
		InitializeComponent();
        BindingContext = viewModel;
		viewModel.GetTopicsCommand.Execute(this);

    }
    bool IsAuth;
    protected override void OnAppearing()
    {
        if (IsAuth is false)
        {
            IsAuth = true;
            Shell.Current.GoToAsync(nameof(LoginTemplate), true);
        }
    }
}

