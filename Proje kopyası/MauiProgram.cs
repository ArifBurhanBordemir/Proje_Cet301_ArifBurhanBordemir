using Microsoft.Extensions.Logging;

namespace Proje;

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
            });
        builder.Services.AddSingleton<DbService>();
        builder.Services.AddTransient<Story>();
        builder.Services.AddTransient<Etkinlik_Sayfası>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}