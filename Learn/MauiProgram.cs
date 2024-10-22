using AppActions.Icons.Maui;
using Microsoft.Extensions.Logging;
namespace Learn;

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
            })
            .ConfigureEssentials(essential =>
            {
                essential.UseAppActionIcons()
                .AddAppAction("home_sc", "Home", icon: AppActionIcon.Home)
                .OnAppAction(App.HandleAppActions);
            });
            

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }


}

  
     

