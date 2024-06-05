namespace MauiGallery.Views.Components.Mains;

public partial class ImagePage : ContentPage
{
	public ImagePage()
	{
		InitializeComponent();

        /*
         * ImageSoucre pode ter 4 valores. 
		 * this.imgPinguin.Source = ImageSource.FromUri(new Uri(http://...))
		 * this.imgPinguin.Source = ImageSource.FromStream
		 * this.imgPinguin.Source = ImageSource.FromResource
		 * this.imgPinguin.Source = ImageSource.FromFile
		*/
    }
}