namespace SmarteAnamnese;

public partial class FinalPage : ContentPage
{
	public FinalPage()
	{
		InitializeComponent();
        BindingContext = ServiceHelper.GetService<FinalPageViewModel>();
    }
}