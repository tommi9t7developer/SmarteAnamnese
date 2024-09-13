using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarteAnamnese
{
    public partial class MagenDarmPageViewModel : ObservableObject
    {
        private readonly DataService _dataService;
        private MagenDarmModel magendarm;

        public MagenDarmPageViewModel(DataService dataService)
        {
            _dataService = dataService;
            magendarm = new MagenDarmModel();
        }

        [ObservableProperty]
        private string beschwerdeZeitraum;

        [ObservableProperty]
        private bool beschwerdeNachInfekt;

        [ObservableProperty]
        private bool vorerekrankungenBeschwerde;



        [ObservableProperty]
        private Color beschwerdeNachInfektYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color beschwerdeNachInfektNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color vorerkrankungenBeschwerdenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color vorerkrankungenBeschwerdenNoButtonColor = Colors.LightGray;



        [RelayCommand]
        public void BeschwerdeNachInfektYes()
        {
            BeschwerdeNachInfekt = true;
            BeschwerdeNachInfektYesButtonColor = Colors.Green;
            BeschwerdeNachInfektNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void BeschwerdeNachInfektNo()
        {
            BeschwerdeNachInfekt = false;
            BeschwerdeNachInfektYesButtonColor = Colors.LightGray;
            BeschwerdeNachInfektNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void VorerkrankungenBeschwerdenYes()
        {
            VorerekrankungenBeschwerde = true;
            VorerkrankungenBeschwerdenYesButtonColor = Colors.Green;
            VorerkrankungenBeschwerdenNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void VorerkrankungenBeschwerdenNo()
        {
            VorerekrankungenBeschwerde = false;
            VorerkrankungenBeschwerdenYesButtonColor = Colors.LightGray;
            VorerkrankungenBeschwerdenNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public async Task GoToFinalPage()
        {
            magendarm.BeschwerdeZeitraum = BeschwerdeZeitraum;
            magendarm.BeschwerdeNachInfekt = BeschwerdeNachInfekt;
            magendarm.VorerkrankungenBeschwerde = VorerekrankungenBeschwerde;
            _dataService.Patient.Anamnese = magendarm;
            // Navigiere zur ErkältungsAnamnesePage
            await Shell.Current.GoToAsync(nameof(FinalPage));
        }
    }
}
