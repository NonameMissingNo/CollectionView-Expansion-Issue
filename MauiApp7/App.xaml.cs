namespace MauiApp7;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var navigation = new NavigationPage(new MainPage());

		MainPage = /*new NavigationPage(new AppShell());*/ navigation;
	}
}
