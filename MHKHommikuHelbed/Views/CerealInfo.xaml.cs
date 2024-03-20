using MHKHommikuHelbed.models;

namespace Views;

public partial class CerealInfo : ContentPage
{

    public CerealInfo(Helbed helbed)
	{
		InitializeComponent();
      
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();


    }
}