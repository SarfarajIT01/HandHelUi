using System.Reflection;
using HandHeldUi.Shared.Services;
using HandHelUi.Services;
using HandHelUi.Shared.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HandHelUi
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
                });

            builder.Services.AddMauiBlazorWebView();

            // Load appsettings.json from embedded resource
            var a = Assembly.GetExecutingAssembly();
            // Verify the Resource Name
            var names = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            foreach (var name in names)
                System.Diagnostics.Debug.WriteLine(name);
            
            using var stream = a.GetManifestResourceStream("HandHelUi.appsettings.json");
            var config = new ConfigurationBuilder().AddJsonStream(stream).Build();

            // Register API BaseUrl from config
            var baseUrl = config["ApiSettings:BaseUrl"];
            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(baseUrl!)
            });

            //builder.Services.AddScoped<ApiService>();
            builder.Services.AddSingleton<UserState>();


            builder.Services.AddSingleton<ILoginService, LoginService>();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
            
            return builder.Build();
        }
    }
}


