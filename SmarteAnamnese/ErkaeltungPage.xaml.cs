namespace SmarteAnamnese;

public partial class ErkaeltungPage : ContentPage
{
	public ErkaeltungPage()
	{
		InitializeComponent();
        BindingContext = ServiceHelper.GetService<ErkaeltungPageViewModel>();
    }
}