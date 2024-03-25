namespace Views;

public partial class NesPage : ContentPage
{
	public NesPage()
	{
		InitializeComponent();
	}
    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

    }
}