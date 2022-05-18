using MauiBlazorTest.Blazor.Shared.Interfaces;
using MauiBlazorTest.Maui.ServiceImplementations;

namespace MauiBlazorTest.Maui;

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

		// Todo:
        //builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri("https://localhost:44371/") });
        builder.Services.AddHttpClient("Api", client => client.BaseAddress = new Uri("https://localhost:44371/"));
        builder.Services.AddScoped<IPersistentComponentState, MauiPersistentComponentState>();

		builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        return builder.Build();
	}
}
