using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiAppCarouselView;

public class CarouselViewModel : ObservableObject
{
    public int AppearingCount = 0;
    public ObservableCollection<string> ItemList { get; set; }

    public CarouselViewModel()
    {
        ItemList = new ObservableCollection<string>
        {
            "One"
        };
    }

    public void UpdateCarousel()
    {
        if (AppearingCount == 1)
        {
            ItemList.Add("Two");
        }
        if (AppearingCount == 2)
        {
            ItemList.Add("Three");
        }
        AppearingCount++;
    }
}
