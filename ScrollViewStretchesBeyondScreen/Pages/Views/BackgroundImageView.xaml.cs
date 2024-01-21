namespace ScrollViewStrechesBeyondScreen.Pages.Views;

public partial class BackgroundImageView : ContentView
{
	public BackgroundImageView()
	{
		InitializeComponent();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        if (BackgroundImage == null)
        {
            return;
        }

#if IOS
        if (height > 0)
        {
            BackgroundImage.HeightRequest = height * 0.7;
        }
#endif
#if ANDROID
        if (height > width)
        {
            BackgroundImage.HeightRequest = height * 0.7;
        }
        else
        {
            BackgroundImage.HeightRequest = height;
        }
#endif
    }
}