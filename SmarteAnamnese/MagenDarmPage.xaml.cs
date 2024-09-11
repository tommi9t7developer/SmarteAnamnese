namespace SmarteAnamnese;

public partial class MagenDarmPage : ContentPage
{
	public MagenDarmPage()
	{
        InitializeComponent();
        BindingContext = ServiceHelper.GetService<MagenDarmPageViewModel>();
    }
}