namespace AppNavigationPage;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void onButtonNext_Clicked(object sender, EventArgs e)
    {
        //Navega para próxima página
		Navigation.PushAsync(new Page3());
    }

    private void OnButtonPrevious_Clicked(object sender, EventArgs e)
    {
        //Remove a página atual
        Navigation.PopAsync();

        //Navigation.PopModalAsync(); //Fecha um modal atual. 
        //Navigation.PopToRootAsync() //Volta para a página inicial, exemplo se estamos na página 3 voltaria para a 1
        //Evita utilizar o PopAsync várias vezes. 

        //Remove as páginas - No navigationStack remove pelo indice. 
        //Navigation.RemovePage(this);
        //Navigation.RemovePage(Navigation.NavigationStack[1]);

        //Força inserir uma página antes da outra
        //Navigation.InsertPageBefore(new Page3(), new Page2());

        this.lbContador.Text = Navigation.NavigationStack.Count().ToString("D2");
    }
}