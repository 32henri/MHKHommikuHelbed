namespace Views;

public partial class KitPage : ContentPage
{
	public KitPage()
	{
		InitializeComponent();
	}

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

    }

}