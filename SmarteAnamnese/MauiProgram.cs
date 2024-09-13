using Microsoft.Extensions.Logging;

namespace SmarteAnamnese
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

            builder.Services.AddSingleton<DataService>();

            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<PersonalienPageViewModel>();
            builder.Services.AddSingleton<AnamneseSelectPageViewModel>();
            builder.Services.AddSingleton<ErkaeltungPageViewModel>();
            builder.Services.AddSingleton<MagenDarmPageViewModel>();
            builder.Services.AddSingleton<FinalPageViewModel>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
