namespace Views;

public partial class CornPage : ContentPage
{
	public CornPage()
	{
		InitializeComponent();
	}

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();


    }
}