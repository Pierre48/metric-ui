using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using metric_ui.Services;

namespace metric_ui
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

            return builder.RegisterAppServices()
                        .RegisterViewModels()
                        .Build();
        }

        public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MetricScrapperService>();
            return builder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<ViewModels.MainViewModel>();

            return mauiAppBuilder;
        }
    }
}