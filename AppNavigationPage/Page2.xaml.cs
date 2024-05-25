namespace AppNavigationPage;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void onButtonNext_Clicked(object sender, EventArgs e)
    {
        //Navega para pr�xima p�gina
		Navigation.PushAsync(new Page3());
    }

    private void OnButtonPrevious_Clicked(object sender, EventArgs e)
    {
        //Remove a p�gina atual
        Navigation.PopAsync();

        //Navigation.PopModalAsync(); //Fecha um modal atual. 
        //Navigation.PopToRootAsync() //Volta para a p�gina inicial, exemplo se estamos na p�gina 3 voltaria para a 1
        //Evita utilizar o PopAsync v�rias vezes. 

        //Remove as p�ginas - No navigationStack remove pelo indice. 
        //Navigation.RemovePage(this);
        //Navigation.RemovePage(Navigation.NavigationStack[1]);

        //For�a inserir uma p�gina antes da outra
        //Navigation.InsertPageBefore(new Page3(), new Page2());

        this.lbContador.Text = Navigation.NavigationStack.Count().ToString("D2");
    }
}