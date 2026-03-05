using MauiShopMVVMExample.ViewModels;
using MauiShopMVVMExample.Views;

namespace MauiShopMVVMExample
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

            // Add Singleton & Transient services
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<ProductViewModel>();

            var app = builder.Build();
            return app;
        }
	}
}
