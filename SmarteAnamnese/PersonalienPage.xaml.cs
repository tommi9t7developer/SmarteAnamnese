namespace SmarteAnamnese;

public partial class PersonalienPage : ContentPage
{
    public PersonalienPage()
	{
		InitializeComponent();
        var dataService = new DataService();   // besser DI?
        // Initialisiere hier den DataService, z.B. mit Daten
        BindingContext = new PersonalienPageViewModel(dataService);
    }
}