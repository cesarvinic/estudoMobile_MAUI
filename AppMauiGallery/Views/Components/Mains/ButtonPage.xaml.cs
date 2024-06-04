namespace MauiGallery.Views.Components.Mains;

public partial class ButtonPage : ContentPage
{
	public ButtonPage()
	{
		InitializeComponent();
	}

    private void Button_Pressed(object sender, EventArgs e)
    {
        this.lbLog.Text += $"\r\nPressionado: {DateTime.Now}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.lbLog.Text += $"\r\nClicado: {DateTime.Now}";
    }

    private void Button_Released(object sender, EventArgs e)
    {
        this.lbLog.Text += $"\r\nLiberado: {DateTime.Now}";
    }
}