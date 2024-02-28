using MHKHommikuHelbed.models;
using Services;
using Views;

namespace MHKHommikuHelbed;

public partial class MainPage : ContentPage
{

    public List<Helbed> Helbeds { get; set; }

    public MainPage()
	{
		InitializeComponent();
        Helbeds = HelbedService.GetAllHelbed();
        HelbedListView.ItemsSource = Helbeds;
    }

    private void GetAllHelbed_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }
    private void Helbed_Clicked(System.Object sender, System.EventArgs e)
    {

    }

    private async void OnButtonClickedCereal(object sender, EventArgs e)

    {
        await Navigation.PushAsync(new CerealInfo());
    }
}

