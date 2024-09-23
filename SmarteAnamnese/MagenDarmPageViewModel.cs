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
        private bool verstopfung;

        [ObservableProperty]
        private bool bauchkraempfe;

        [ObservableProperty]
        private bool nachtschweiss;

        [ObservableProperty]
        private bool durchfall;

        [ObservableProperty]
        private bool fieber;

        [ObservableProperty]
        private string fieberHoehe;

        [ObservableProperty]
        private string weitereVeraenderungen;

        [ObservableProperty]
        private bool kopfschmerzen;

        [ObservableProperty]
        private bool muedigkeit;

        [ObservableProperty]
        private bool abgeschlagenheit;

        [ObservableProperty]
        private bool gewichtsverlust;

        [ObservableProperty]
        private string gewichtVerloren;

        [ObservableProperty]
        private string gewicht;

        [ObservableProperty]
        private string groesse;





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

        [ObservableProperty]
        private Color verstopfungYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color verstopfungNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color bauchkraempfeYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color bauchkraempfeNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color nachtschweissYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color nachtschweissNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color fieberYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color fieberNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color durchfallYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color durchfallNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color kopfschmerzenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color kopfschmerzenNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color muedigkeitYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color muedigkeitNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color abgeschlagenheitYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color abgeschlagenheitNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color gewichtsverlustYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color gewichtsverlustNoButtonColor = Colors.LightGray;



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
        public void VerstopfungYes()
        {
            Verstopfung = true;
            VerstopfungYesButtonColor = Colors.Green;
            VerstopfungNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void VerstopfungNo()
        {
            Verstopfung = false;
            VerstopfungYesButtonColor = Colors.LightGray;
            VerstopfungNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void BauchkraempfeYes()
        {
            Bauchkraempfe = true;
            BauchkraempfeYesButtonColor = Colors.Green;
            BauchkraempfeNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void BauchkraempfeNo()
        {
            Bauchkraempfe = false;
            BauchkraempfeYesButtonColor = Colors.LightGray;
            BauchkraempfeNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void NachtschweissYes()
        {
            Nachtschweiss = true;
            NachtschweissYesButtonColor = Colors.Green;
            NachtschweissNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void NachtschweissNo()
        {
            Nachtschweiss = false;
            NachtschweissYesButtonColor = Colors.LightGray;
            NachtschweissNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void FieberYes()
        {
            Fieber = true;
            FieberYesButtonColor = Colors.Green;
            FieberNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void FieberNo()
        {
            Fieber = false;
            FieberYesButtonColor = Colors.LightGray;
            FieberNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void DurchfallYes()
        {
            Durchfall = true;
            DurchfallYesButtonColor = Colors.Green;
            DurchfallNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void DurchfallNo()
        {
            Durchfall = false;
            DurchfallYesButtonColor = Colors.LightGray;
            DurchfallNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void KopfschmerzenYes()
        {
            Kopfschmerzen = true;
            KopfschmerzenYesButtonColor = Colors.Green;
            KopfschmerzenNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void KopfschmerzenNo()
        {
            Kopfschmerzen = false;
            KopfschmerzenYesButtonColor = Colors.LightGray;
            KopfschmerzenNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void MuedigkeitYes()
        {
            Muedigkeit = true;
            MuedigkeitYesButtonColor = Colors.Green;
            MuedigkeitNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void MuedigkeitNo()
        {
            Muedigkeit = false;
            MuedigkeitYesButtonColor = Colors.LightGray;
            MuedigkeitNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void AbgeschlagenheitYes()
        {
            Abgeschlagenheit = true;
            AbgeschlagenheitYesButtonColor = Colors.Green;
            AbgeschlagenheitNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void AbgeschlagenheitNo()
        {
            Abgeschlagenheit = false;
            AbgeschlagenheitYesButtonColor = Colors.LightGray;
            AbgeschlagenheitNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void GewichtsverlustYes()
        {
            Gewichtsverlust = true;
            GewichtsverlustYesButtonColor = Colors.Green;
            GewichtsverlustNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void GewichtsverlustNo()
        {
            Gewichtsverlust = false;
            GewichtsverlustYesButtonColor = Colors.LightGray;
            GewichtsverlustNoButtonColor = Colors.Green;
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
            magendarm.Blaehungen = Blaehungen;
            magendarm.Verstopfung = Verstopfung;
            magendarm.Bauchkraempfe = Bauchkraempfe;
            magendarm.Nachtschweiss = Nachtschweiss;
            magendarm.Durchfall = Durchfall;
            magendarm.Fieber = Fieber;
            magendarm.FieberHoehe = FieberHoehe;
            magendarm.WeitereVeraenderungen = WeitereVeraenderungen;
            magendarm.Kopfschmerzen = Kopfschmerzen;
            magendarm.Muedigkeit = Muedigkeit;
            magendarm.Abgeschlagenheit = Abgeschlagenheit;
            magendarm.Gewichtsverlust = Gewichtsverlust;
            magendarm.GewichtVerloren = GewichtVerloren;
            magendarm.Gewicht = Gewicht;
            magendarm.Groesse = Groesse;
            // MagenDarm als Anmnese setzen
            _dataService.Patient.Anamnese = magendarm;
            // Navigiere zur ErkältungsAnamnesePage
            await Shell.Current.GoToAsync(nameof(FinalPage));
        }
    }
}
