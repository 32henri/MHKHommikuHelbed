using MHKHommikuHelbed.models;

namespace Views;

public partial class CerealInfo : ContentPage
{

    public CerealInfo()
	{
		InitializeComponent();
      
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();


    }
}