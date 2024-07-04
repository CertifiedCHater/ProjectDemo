using Microsoft.Extensions.Logging;
using ProjectDemo.Service;
using ProjectDemo.View;
using ProjectDemo.ViewModel;

namespace ProjectDemo
{
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<ASCService>();

            builder.Services.AddSingleton<MainPage>();

            builder.Services.AddSingleton<ArtsViewModel>();

            return builder.Build();
        }
    }
}
