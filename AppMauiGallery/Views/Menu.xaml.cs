using MauiGallery.Repositories;

namespace AppMauiGallery.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();

		var categories = new CategoryRepository().GetCategories();

		foreach (var item in categories)
		{
            var lblCategory = new Label();
			lblCategory.Text = item.Name;
			lblCategory.FontFamily = "OpenSansSemibold";

			lblCategory.FontSize = 16;
			lblCategory.TextColor = new Color(0, 0, 0);

			this.MenuContainer.Children.Add(lblCategory);

			foreach (var component in item.Components)
			{
				//Monta o menu baseado na lista de Componentes adicionados à lista. 
				var tap = new TapGestureRecognizer();
				tap.CommandParameter = component.Page;
				tap.Tapped += OnTapComponent_Tapped;

				var lblComponentTitle = new Label();
				lblComponentTitle.Text = component.Title;
				lblComponentTitle.FontFamily = "OpenSansSemibold";
				lblComponentTitle.Margin = new Thickness(20, 10, 0, 0);
				lblComponentTitle.FontSize = 14;
				lblComponentTitle.TextColor = new Color(20, 95, 212);
                lblComponentTitle.GestureRecognizers.Add(tap);

				var lblComponentDescription = new Label();
				lblComponentDescription.Text = component.Description;
				lblComponentDescription.Margin = new Thickness(20, 0, 0, 0 );
                lblComponentDescription.FontSize = 12;
                lblComponentDescription.TextColor = new Color(78, 78, 78);
                lblComponentDescription.GestureRecognizers.Add(tap);

                this.MenuContainer.Children.Add(lblComponentTitle);
                this.MenuContainer.Children.Add(lblComponentDescription);
            }
        }
    }

	private void OnTapComponent_Tapped(object sender, EventArgs e)
	{ 
		var label = (Label)sender;
		var tap = (TapGestureRecognizer)label.GestureRecognizers[0];
        //var page = (Page)tap.CommandParameter;
        var page = (Type)tap.CommandParameter;

        //Faz a mudança de página.
        //((FlyoutPage)App.Current.MainPage).Detail = page;
		//Activator.CreateInstance - Resolve o problema de memória causado pela instância direta da página.
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page));

        //Recolhe o menu
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;

    }

    private void OnTapInicio_Tapped(object sender, TappedEventArgs e)
    {
		
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new AppMauiGallery.Views.MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}