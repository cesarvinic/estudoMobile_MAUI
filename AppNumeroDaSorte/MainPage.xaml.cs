namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void btnLuckNumber_Clicked(object sender, EventArgs e)
    {
		OnGenerateLuckNumbers();
        var set = GenerateLuckNubers();

        this.lbLuckNumber01.Text = set.ElementAt(0).ToString();
        this.lbLuckNumber02.Text = set.ElementAt(1).ToString();
        this.lbLuckNumber03.Text = set.ElementAt(2).ToString();
        this.lbLuckNumber04.Text = set.ElementAt(3).ToString();
        this.lbLuckNumber05.Text = set.ElementAt(4).ToString();
        this.lbLuckNumber06.Text = set.ElementAt(5).ToString();
    }

    private void OnGenerateLuckNumbers()
    {
        this.lbNameApp.IsVisible = false;
        this.vslContainerLuckNumbers.IsVisible = true;
    }

    private SortedSet<int> GenerateLuckNubers()
    {
        //SortedSet
        var SetList = new SortedSet<int>();
        while (SetList.Count < 6)
        {
            var random = new Random();
            var luckNumber = random.Next(1, 60);

            SetList.Add(luckNumber);
        }
        return SetList;
    }

}