using TaskAPP.ViewModel;

namespace TaskAPP;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}