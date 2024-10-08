﻿namespace SmarteAnamnese
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {

            InitializeComponent();
            Routing.RegisterRoute(nameof(PersonalienPage), typeof(PersonalienPage));
            Routing.RegisterRoute(nameof(AnamneseSelectPage), typeof(AnamneseSelectPage));
            Routing.RegisterRoute(nameof(ErkaeltungPage), typeof(ErkaeltungPage));
            Routing.RegisterRoute(nameof(MagenDarmPage), typeof(MagenDarmPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(FinalPage), typeof(FinalPage));


            // Setze die MainPage als Startseite
            Items.Add(new ShellContent
            {
                ContentTemplate = new DataTemplate(typeof(MainPage))
            });
        }
    }
}
