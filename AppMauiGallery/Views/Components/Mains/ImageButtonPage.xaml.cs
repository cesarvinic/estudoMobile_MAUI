namespace MauiGallery.Views.Components.Mains;

public partial class ImageButtonPage : ContentPage
{
	private bool buttonState = false;
	public ImageButtonPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		//Nega o estado do botão.. se tiver negativo, torna positivo e vice-versa.
		this.buttonState = !buttonState;

		var poweroff = "poweroff.png";
        var poweron = "poweron.png";

		var button = (ImageButton)sender;
		button.Source = (buttonState == false) ? ImageSource.FromFile(poweroff) : ImageSource.FromFile(poweron);
    }
}