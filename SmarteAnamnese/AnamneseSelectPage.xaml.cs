namespace SmarteAnamnese;

public partial class AnamneseSelectPage : ContentPage
{
	public AnamneseSelectPage()
	{
		InitializeComponent();
		BindingContext = ServiceHelper.GetService<AnamneseSelectPageViewModel>();
	}
}