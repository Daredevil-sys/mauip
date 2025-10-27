using Microsoft.Extensions.Logging;

namespace CatalogoTelefonos
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
                    fonts.AddFont("RobotoFlex.ttf", "RobotoFlex");
                    fonts.AddFont("Oswald.ttf", "oswald");
                    fonts.AddFont("Jersey-Regular.ttf", "jersey");
                


                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
