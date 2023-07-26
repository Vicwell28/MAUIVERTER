using MAUIVERTERDemo.MVVM.ViewModels;

namespace MAUIVERTERDemo.MVVM.Views;

public partial class ConvertView : ContentPage
{
	private ConvertViewModel ConvertViewModel { get; set; }
	public ConvertView(string quantityName)
	{
		InitializeComponent();
		this.ConvertViewModel = new ConvertViewModel(quantityName);
		this.BindingContext = this.ConvertViewModel;
	}

	private void Picker_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.ConvertViewModel.Convert();
	}
}