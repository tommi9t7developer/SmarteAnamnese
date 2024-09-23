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
        private bool operationMagenDarm;

        [ObservableProperty]
        private string tumor;

        [ObservableProperty]
        private string vorerkrankungenGenerell;

        [ObservableProperty]
        private bool blaehungen;



        [ObservableProperty]
        private Color beschwerdeNachInfektYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color beschwerdeNachInfektNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color vorerkrankungenBeschwerdenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color vorerkrankungenBeschwerdenNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color operationMagenDarmYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color operationMagenDarmNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color blaehungenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color blaehungenNoButtonColor = Colors.LightGray;



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
        public void OperationMagenDarmYes()
        {
            OperationMagenDarm = true;
            OperationMagenDarmYesButtonColor = Colors.Green;
            OperationMagenDarmNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void OperationMagenDarmNo()
        {
            OperationMagenDarm = false;
            OperationMagenDarmYesButtonColor = Colors.LightGray;
            OperationMagenDarmNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void BlaehungenYes()
        {
            Blaehungen = true;
            BlaehungenYesButtonColor = Colors.Green;
            BlaehungenNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void BlaehungenNo()
        {
            Blaehungen = false;
            BlaehungenYesButtonColor = Colors.LightGray;
            BlaehungenNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public async Task GoToFinalPage()
        {
            magendarm.BeschwerdeZeitraum = BeschwerdeZeitraum;
            magendarm.BeschwerdeNachInfekt = BeschwerdeNachInfekt;
            magendarm.VorerkrankungenBeschwerde = VorerekrankungenBeschwerde;
            magendarm.OperationMagenDarm = OperationMagenDarm;
            magendarm.Tumor = Tumor;
            magendarm.VorerkrankungenGenerell = VorerkrankungenGenerell;
            // MagenDarm als Anmnese setzen
            _dataService.Patient.Anamnese = magendarm;
            // Navigiere zur ErkältungsAnamnesePage
            await Shell.Current.GoToAsync(nameof(FinalPage));
        }
    }
}
