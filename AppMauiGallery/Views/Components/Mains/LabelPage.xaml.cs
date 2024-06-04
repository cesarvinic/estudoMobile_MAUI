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
        // A��o a ser realizada quando o Span for clicado
        DisplayAlert("Span Clicked", "Voc� clicou no texto sublinhado!", "OK");
    }

    private void OnCommandTapped()
    {
        // A��o a ser realizada quando o Span for clicado
        DisplayAlert("Span Clicked", "Voc� clicou no texto sublinhado!", "OK");
    }
}