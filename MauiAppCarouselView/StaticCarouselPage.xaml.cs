namespace MauiAppCarouselView;

public partial class StaticCarouselPage : ContentPage
{
    StaticCarouselViewModel staticCarouselViewModel = new StaticCarouselViewModel();

    public StaticCarouselPage()
    {
        InitializeComponent();
        BindingContext = staticCarouselViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        staticCarouselViewModel.UpdateCarousel();
    }
}
