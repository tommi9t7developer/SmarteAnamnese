namespace SmarteAnamnese
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ErkaeltungPage), typeof(ErkaeltungPage));

            // Setze die MainPage als Startseite
            Items.Add(new ShellContent
            {
                ContentTemplate = new DataTemplate(typeof(MainPage))
            });
        }
    }
}
