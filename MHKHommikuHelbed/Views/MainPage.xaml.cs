using MHKHommikuHelbed.models;
using Services;
using System.Numerics;
using Views;

namespace MHKHommikuHelbed;

public partial class MainPage : ContentPage
{

    public List<Helbed> Helbeds { get; set; }
    public KitPage KitPage { get; set; }

    public MainPage()
	{
		InitializeComponent();
        KitPage = new KitPage();
        Helbeds = HelbedService.GetAllHelbed();
    }

    private void GetAllHelbed_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    async void Cini_Clicked(System.Object sender, System.EventArgs e)
    {
        var ciniPage = new CiniPage();
        await Navigation.PushAsync(ciniPage);
    }

    async void Nes_Clicked(System.Object sender, System.EventArgs e)
    {
        var nesPage = new NesPage();
        await Navigation.PushAsync(nesPage);
    }
    private async void Kit_Clicked(object sender, EventArgs e)
    {
        var kitPage = new KitPage();
        await Navigation.PushAsync(kitPage);
    }

    async void Corn_Clicked(System.Object sender, System.EventArgs e)
    {
        var cornPage = new CornPage();
        await Navigation.PushAsync(cornPage);
    }

}

