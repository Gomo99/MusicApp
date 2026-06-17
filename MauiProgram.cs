using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MusciApp.ViewModels;
using CommunityToolkit.Maui;

namespace MusciApp;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().UseMauiCommunityToolkitMediaElement() // Only MediaElement, no meta-package
        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<MainPage>();
        return builder.Build();
    }
}