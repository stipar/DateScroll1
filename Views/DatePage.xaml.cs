using MauiApp3.ViewModel;

namespace MauiApp3.Views;

public partial class DatePage : ContentPage
{
	public DatePage()
	{
		InitializeComponent();
		BindingContext = new DatePageVM();
	}
}