using MauiForumApp.Models;
using MauiForumApp.ViewModel;

namespace MauiForumApp.View;

public partial class DetailsPage : ContentPage
{
    public TopicModel Topic { get; set; }
    public DetailsPage(DetailsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(MainPage), true);
    }
}