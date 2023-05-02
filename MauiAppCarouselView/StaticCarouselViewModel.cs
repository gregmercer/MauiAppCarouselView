using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiAppCarouselView;

public class StaticCarouselViewModel : ObservableObject
{
    public int AppearingCount = 0;
    public ObservableCollection<string> ItemList { get; set; }

    public StaticCarouselViewModel()
    {
        ItemList = new ObservableCollection<string>
        {
            "One",
            "Two",
            "Three"
        };
    }

    public void UpdateCarousel()
    { 
    }
}
