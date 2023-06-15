using Microsoft.Extensions.Logging;
using TaskAPP.ViewModel;

namespace TaskAPP;

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

		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
		
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainVIewModel>();

		builder.Services.AddTransient<DetailsPage>();
		builder.Services.AddTransient<DetailsPageViewModel>();
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
