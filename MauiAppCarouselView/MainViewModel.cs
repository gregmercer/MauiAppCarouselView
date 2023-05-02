using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppCarouselView;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
    }

    [RelayCommand]
    protected async Task DoAdd()
    {
        await App.Current.MainPage.Navigation.PushAsync(App.CarouselPage);
    }

    [RelayCommand]
    protected async Task GoToStatic()
    {
        await App.Current.MainPage.Navigation.PushAsync(App.StaticCarouselPage);
    }
}
