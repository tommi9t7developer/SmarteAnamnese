﻿namespace SmarteAnamnese
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
           InitializeComponent();
           BindingContext = new MainPageViewModel();
        }

    }

}
