using Microsoft.Extensions.Logging;

namespace AppJogoForca
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

              // Configuração da SplashScreen
//            builder.ConfigureMauiHandlers(handlers =>
//            {
//#if ANDROID
//            handlers.AddHandler(typeof(SplashScreen), typeof(MySplashScreenHandler));
//#endif
//            });

            return builder.Build();
        }
    }
}
