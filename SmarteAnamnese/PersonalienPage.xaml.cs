namespace SmarteAnamnese;

public partial class PersonalienPage : ContentPage
{
    public PersonalienPage()
	{
		InitializeComponent();
        BindingContext = ServiceHelper.GetService<PersonalienPageViewModel>();
    }
}