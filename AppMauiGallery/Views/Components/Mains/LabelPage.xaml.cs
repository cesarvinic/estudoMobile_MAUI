using System.Windows.Input;

namespace MauiGallery.Views.Components.Mains;

public partial class LabelPage : ContentPage
{
    public ICommand clique {  get; private set; }

	public LabelPage()
	{
		InitializeComponent();
        clique = new Command(OnCommandTapped);
	}

    private void OnSpanTapped(object sender, TappedEventArgs e)
    {
        // Ação a ser realizada quando o Span for clicado
        DisplayAlert("Span Clicked", "Você clicou no texto sublinhado!", "OK");
    }

    private void OnCommandTapped()
    {
        // Ação a ser realizada quando o Span for clicado
        DisplayAlert("Span Clicked", "Você clicou no texto sublinhado!", "OK");
    }
}