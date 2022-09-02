namespace MauiApp3;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility.Hosting;
#if IOS
using Platforms.iOS.Renderers;
#endif

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCompatibility()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
		    .ConfigureMauiHandlers(handlers =>
            {
#if IOS
				handlers.AddCompatibilityRenderer(typeof(WebView), typeof(CustomWebViewRenderer));
#endif

            });

        return builder.Build();
	}
}
