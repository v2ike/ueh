using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;

// Bọc using trong preprocessor directive để chỉ áp dụng cho Android
#if ANDROID
using Android.Content.Res;
#endif

namespace UEHtheTeam;

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

        

        return builder.Build();
    }
}