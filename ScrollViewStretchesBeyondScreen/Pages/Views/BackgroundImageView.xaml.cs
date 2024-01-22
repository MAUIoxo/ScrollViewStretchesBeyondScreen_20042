namespace ScrollViewStrechesBeyondScreen.Pages.Views;

public partial class BackgroundImageView : ContentView
{
	public BackgroundImageView()
	{
		InitializeComponent();
	}

    protected override Size ArrangeOverride(Rect bounds)
    {
        if (BackgroundImage == null)
        {
            return base.ArrangeOverride(bounds);
        }

#if IOS
        if (this.Height > 0)
        {
            BackgroundImage.HeightRequest = this.Height * 0.7;
        }
#endif
#if ANDROID
        if (this.Height > this.Width)
        {
            BackgroundImage.HeightRequest = this.Height * 0.7;
        }
        else
        {
            BackgroundImage.HeightRequest = this.Height;
        }
#endif

        return base.ArrangeOverride(bounds);
    }
}