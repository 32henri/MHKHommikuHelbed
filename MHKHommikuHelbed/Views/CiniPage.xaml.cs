namespace Views;

public partial class CiniPage : ContentPage
{
	public CiniPage()
	{
		InitializeComponent();
	}

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();


    }
}