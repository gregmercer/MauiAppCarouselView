namespace MauiAppCarouselView;

public partial class App : Application
{
    public static CarouselPage CarouselPage { get; set; }
	public static StaticCarouselPage StaticCarouselPage { get; set; }

    public App()
	{
		InitializeComponent();

		//Routing.RegisterRoute(nameof(CarouselPage), typeof(CarouselPage));

		App.CarouselPage = new CarouselPage();
		App.StaticCarouselPage = new StaticCarouselPage();

        MainPage = new NavigationPage(new MainPage());
	}
}
