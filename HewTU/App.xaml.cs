using HewTU.DescriptionMenu;

namespace HewTU;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		//MainPage = new StorePage();
		//MainPage = new LoginPage();
		//MainPage = new AddStorePage();
		//MainPage = new Thaitea();
		MainPage = new NavigationPage(new LoginPage());
		//MainPage = new NavigationPage(new MenuPage());

	}
}
