using MauiForumApp.Services;
using MauiForumApp.View;
using MauiForumApp.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiForumApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("RobotoSlab-VariableFont_wght.ttf", "Roboto");
                fonts.AddFont("SourceSerifPro - SemiBold", "Serif");
                
            });

#if DEBUG
		
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<TopicService>();
        builder.Services.AddSingleton<TopicViewModel>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<DetailsPageViewModel>();
        builder.Services.AddTransient<DetailsPage>();
        builder.Services.AddTransient<LoginPage>();
		builder.Services.AddTransient<LoginViewModel>();
        return builder.Build();
	}
}
