using TaskAPP.ViewModel;

namespace TaskAPP;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainVIewModel mainVIewModel)
	{
		InitializeComponent();
		BindingContext = mainVIewModel;
	}

	
}

