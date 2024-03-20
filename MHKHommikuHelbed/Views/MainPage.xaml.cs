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
            // all down animations
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

            // all up animations
            var parentAnimation10 = new Animation();
            var moveDownAnimation11 = new Animation(v => lusikaskukub11.TranslationY = v, -lusikaskukub11.Height, 0);
            var moveDownAnimation22 = new Animation(v => lusikaskukub22.TranslationY = v, -lusikaskukub22.Height, 0);
            var moveDownAnimation33 = new Animation(v => lusikaskukub33.TranslationY = v, -lusikaskukub33.Height, 0);
            var moveDownAnimation44 = new Animation(v => lusikaskukub44.TranslationY = v, -lusikaskukub44.Height, 0);
            var moveDownAnimation55 = new Animation(v => lusikaskukub55.TranslationY = v, -lusikaskukub55.Height, 0);
            var moveDownAnimation66 = new Animation(v => lusikaskukub66.TranslationY = v, -lusikaskukub66.Height, 0);

            parentAnimation10.Add(0, 1, moveDownAnimation11);
            parentAnimation10.Add(0, 1, moveDownAnimation22);
            parentAnimation10.Add(0, 1, moveDownAnimation33);
            parentAnimation10.Add(0, 1, moveDownAnimation44);
            parentAnimation10.Add(0, 1, moveDownAnimation55);
            parentAnimation10.Add(0, 1, moveDownAnimation66);

            parentAnimation10.Commit(lusikaskukub11, "kukkumine", length: 3000, repeat: () => true);
            parentAnimation10.Commit(lusikaskukub22, "kukkumine", length: 3000, repeat: () => true);
            parentAnimation10.Commit(lusikaskukub33, "kukkumine", length: 3000, repeat: () => true);
            parentAnimation10.Commit(lusikaskukub44, "kukkumine", length: 3000, repeat: () => true);
            parentAnimation10.Commit(lusikaskukub55, "kukkumine", length: 3000, repeat: () => true);
            parentAnimation10.Commit(lusikaskukub66, "kukkumine", length: 3000, repeat: () => true);

            await Task.Delay(3000); // Wait for the full animation cycle to complete
        }
    }


    private async Task kukkumine1()
    {
        while (true)
        {
            var parentAnimation = new Animation();
            var moveDownAnimation11 = new Animation(v => lusikaskukub11.TranslationY = v, -lusikaskukub11.Height, -200);
            var moveDownAnimation22 = new Animation(v => lusikaskukub22.TranslationY = v, -lusikaskukub22.Height, -200);
            var moveDownAnimation33 = new Animation(v => lusikaskukub33.TranslationY = v, -lusikaskukub33.Height, -200);
            var moveDownAnimation44 = new Animation(v => lusikaskukub44.TranslationY = v, -lusikaskukub44.Height, -200);
            var moveDownAnimation55 = new Animation(v => lusikaskukub55.TranslationY = v, -lusikaskukub55.Height, -200);
            var moveDownAnimation66 = new Animation(v => lusikaskukub66.TranslationY = v, -lusikaskukub66.Height, -200);

            parentAnimation.Add(0, 1, moveDownAnimation11);
            parentAnimation.Add(0, 1, moveDownAnimation22);
            parentAnimation.Add(0, 1, moveDownAnimation33);
            parentAnimation.Add(0, 1, moveDownAnimation44);
            parentAnimation.Add(0, 1, moveDownAnimation55);
            parentAnimation.Add(0, 1, moveDownAnimation66);

            parentAnimation.Commit(lusikaskukub11, "kukkumine", length: 4000, repeat: () => true);
            parentAnimation.Commit(lusikaskukub22, "kukkumine", length: 4100, repeat: () => true);
            parentAnimation.Commit(lusikaskukub33, "kukkumine", length: 4200, repeat: () => true);
            parentAnimation.Commit(lusikaskukub44, "kukkumine", length: 4300, repeat: () => true);
            parentAnimation.Commit(lusikaskukub55, "kukkumine", length: 4400, repeat: () => true);
            parentAnimation.Commit(lusikaskukub66, "kukkumine", length: 4500, repeat: () => true);

            await Task.Delay(4000);
        }
    }
}


