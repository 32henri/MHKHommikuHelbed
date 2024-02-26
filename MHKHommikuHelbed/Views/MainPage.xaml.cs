using MHKHommikuHelbed.models;
using Views;

namespace MHKHommikuHelbed;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnButtonClickedCereal(object sender, EventArgs e)

    {
        await Navigation.PushAsync(new CerealInfo());
    }
}

