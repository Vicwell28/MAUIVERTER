using MAUIVERTERDemo.MVVM.Views;

namespace MAUIVERTERDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MenuView());
	}
}
