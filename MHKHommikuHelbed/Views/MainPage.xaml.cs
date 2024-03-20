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
            var moveDownAnimation = new Animation(v => lusikaskukub.TranslationY = v, -lusikaskukub.Height, 1200);
            var moveDownAnimation1 = new Animation(v => lusikaskukub1.TranslationY = v, -lusikaskukub1.Height, 1200);

            parentAnimation.Add(0, 1, moveDownAnimation);
            parentAnimation.Add(0, 1, moveDownAnimation1);

            parentAnimation.Commit(lusikaskukub, "kukkumine", length: 3000, repeat: () => true);
            parentAnimation.Commit(lusikaskukub1, "kukkumine", length: 3000, repeat: () => true);

            await Task.Delay(4000); // Wait for the animation to finish before restarting
        }
    }
    private async Task kukkumine1()
    {
        while (true)
        {
            var parentAnimation = new Animation();
            var moveDownAnimation = new Animation(v => lusikaskukub.TranslationY = v, -lusikaskukub.Height, 1200);

            parentAnimation.Add(0, 1, moveDownAnimation);

            parentAnimation.Commit(lusikaskukub, "kukkumine", length: 200, repeat: () => true);

            await Task.Delay(4000); // Wait for the animation to finish before restarting
        }
    }
}


