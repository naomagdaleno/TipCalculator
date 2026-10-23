using TipCalculator.Maui.ViewsModels;

namespace TipCalculator.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewsModel();
	}
}