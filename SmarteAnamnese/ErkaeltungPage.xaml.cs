namespace SmarteAnamnese;

public partial class ErkaeltungPage : ContentPage
{
	public ErkaeltungPage()
	{
		InitializeComponent();
        BindingContext = ServiceHelper.GetService<ErkaeltungPageViewModel>();
    }

  

    private void OnLungenvorerkrankungYesButtonClicked(object sender, EventArgs e)
    {
        LungenvorerkrankungYesButton.BackgroundColor = Colors.Green;
        LungenvorerkrankungNoButton.BackgroundColor = Colors.LightGray;
    }

    private void OnLungenvorerkrankungNoButtonClicked(object sender, EventArgs e)
    {
        LungenvorerkrankungNoButton.BackgroundColor = Colors.Green;
        LungenvorerkrankungYesButton.BackgroundColor = Colors.LightGray;
    }

    private void OnAntibiotikaYesButtonClicked(object sender, EventArgs e)
    {
        AntibiotikaYesButton.BackgroundColor = Colors.Green;
        AntibiotikaNoButton.BackgroundColor = Colors.LightGray;
    }

    private void OnAntibiotikaNoButtonClicked(object sender, EventArgs e)
    {
        AntibiotikaNoButton.BackgroundColor = Colors.Green;
        AntibiotikaYesButton.BackgroundColor = Colors.LightGray;
    }

    private void OnGrippeYesButtonClicked(object sender, EventArgs e)
    {
        GrippeYesButton.BackgroundColor = Colors.Green;
        GrippeNoButton.BackgroundColor = Colors.LightGray;
    }

    private void OnGrippeNoButtonClicked(object sender, EventArgs e)
    {
        GrippeNoButton.BackgroundColor = Colors.Green;
        GrippeYesButton.BackgroundColor = Colors.LightGray;
    }

    private void OnGrippeimpfungYesButtonClicked(object sender, EventArgs e)
    {
        GrippeimpfungYesButton.BackgroundColor = Colors.Green;
        GrippeimpfungNoButton.BackgroundColor = Colors.LightGray;
    }

    private void OnGrippeimpfungNoButtonClicked(object sender, EventArgs e)
    {
        GrippeimpfungNoButton.BackgroundColor = Colors.Green;
        GrippeimpfungYesButton.BackgroundColor = Colors.LightGray;
    }

    private void OnCoronaYesButtonClicked(object sender, EventArgs e)
    {
        CoronaYesButton.BackgroundColor = Colors.Green;
        CoronaNoButton.BackgroundColor = Colors.LightGray;
    }

    private void OnCoronaNoButtonClicked(object sender, EventArgs e)
    {
        CoronaNoButton.BackgroundColor = Colors.Green;
        CoronaYesButton.BackgroundColor = Colors.LightGray;
    }



    private void OnUebelkeitButtonClicked(object sender, EventArgs e)
    {
        UebelkeitButton.BackgroundColor = Colors.Green;
    }

    private void OnErbrechenButtonClicked(object sender, EventArgs e)
    {
        ErbrechenButton.BackgroundColor = Colors.Green;
    }
    private void OnDurchfallButtonClicked(object sender, EventArgs e)
    {
        DurchfallButton.BackgroundColor = Colors.Green;
    }

}