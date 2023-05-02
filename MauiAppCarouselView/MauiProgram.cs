using Microsoft.Maui.LifecycleEvents;
using CommunityToolkit.Maui;

namespace MauiAppCarouselView;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        MauiAppBuilder mauiAppBuilder = MauiApp.CreateBuilder();

        mauiAppBuilder
            .UseMauiApp<App>()
			.UseMauiCommunityToolkit();

        return mauiAppBuilder.Build();
	}
}
