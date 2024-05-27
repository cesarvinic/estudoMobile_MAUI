namespace AppFlyoutPage;

public partial class Menu : ContentPage
{
    public Menu()
    {
        InitializeComponent();
    }

    private void btnPagina1_Clicked(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page1());
    }

    private void btnPagina2_Clicked(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page2());
    }

    private void btnPagina3_Clicked(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page3());
    }
}