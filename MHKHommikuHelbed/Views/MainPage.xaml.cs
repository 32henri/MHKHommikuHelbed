namespace MHKHommikuHelbed;

using Views;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        kukkumine();
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

    private async Task kukkumine()
    {
        while (true)
        {

            var parentAnimation = new Animation();
            var moveDownAnimation = new Animation(v => lusikaskukub.TranslationY = v, -lusikaskukub.Height, 0);
            var moveDownAnimation1 = new Animation(v => lusikaskukub1.TranslationY = v, -lusikaskukub1.Height, 0);
            var moveDownAnimation2 = new Animation(v => lusikaskukub2.TranslationY = v, -lusikaskukub2.Height, 0);
            var moveDownAnimation3 = new Animation(v => lusikaskukub3.TranslationY = v, -lusikaskukub3.Height, 0);
            var moveDownAnimation4 = new Animation(v => lusikaskukub4.TranslationY = v, -lusikaskukub4.Height, 0);
            var moveDownAnimation5 = new Animation(v => lusikaskukub5.TranslationY = v, -lusikaskukub5.Height, 0);

            parentAnimation.Add(0, 1, moveDownAnimation);
            parentAnimation.Add(0, 1, moveDownAnimation1);
            parentAnimation.Add(0, 1, moveDownAnimation2);
            parentAnimation.Add(0, 1, moveDownAnimation3);
            parentAnimation.Add(0, 1, moveDownAnimation4);
            parentAnimation.Add(0, 1, moveDownAnimation5);

            parentAnimation.Commit(lusikaskukub, "kukkumine", length: 3000, repeat: () => true);
            parentAnimation.Commit(lusikaskukub1, "kukkumine", length: 3000, repeat: () => true);
            parentAnimation.Commit(lusikaskukub2, "kukkumine", length: 3000, repeat: () => true);
            parentAnimation.Commit(lusikaskukub3, "kukkumine", length: 3000, repeat: () => true);
            parentAnimation.Commit(lusikaskukub4, "kukkumine", length: 3000, repeat: () => true);
            parentAnimation.Commit(lusikaskukub5, "kukkumine", length: 3000, repeat: () => true);


            await Task.Delay(3000); 
        }
    }


}


