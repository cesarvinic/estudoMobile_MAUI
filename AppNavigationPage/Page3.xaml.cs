namespace AppNavigationPage;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private void OnButtonPrevious_Clicked(object sender, EventArgs e)
    {
        //Remove a p�gina atual
        Navigation.PopAsync();
    }
}