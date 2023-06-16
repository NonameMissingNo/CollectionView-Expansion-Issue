namespace MauiApp7;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void CollectionCodeClick(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CollectionCode());
    }

    private void CollectionDesignClick(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CollectionDesign());
    }

    private void ListCodeClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListCode());
    }

    private void ListDesignClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListDesign());
    }
}

