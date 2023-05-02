namespace MauiAppCarouselView;

public partial class CarouselPage : ContentPage
{
	CarouselViewModel carouselViewModel = new CarouselViewModel();

    public CarouselPage()
	{
		InitializeComponent();
		BindingContext = carouselViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        carouselViewModel.UpdateCarousel();
    }
}
