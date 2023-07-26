using MAUIVERTERDemo.MVVM.Views;
namespace MAUIVERTERDemo.MVVM.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
	}

	private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		Grid grid = sender as Grid;

		if (grid == null)
			return;

		string quantityName = (grid.Children.LastOrDefault() as Label).Text;

		await Navigation.PushAsync(new ConvertView(quantityName));


	}
}