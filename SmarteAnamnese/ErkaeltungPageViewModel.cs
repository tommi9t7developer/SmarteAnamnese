using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SmarteAnamnese
{
    public partial class ErkaeltungPageViewModel : ObservableObject
    {
        private readonly DataService _dataService;
        private ErkaeltungModel erkaeltung;
        public ErkaeltungPageViewModel(DataService dataService)
        {
            _dataService = dataService;
            erkaeltung = new ErkaeltungModel();
        }

        [ObservableProperty]
        private string beschwerdeZeitraum;

        [ObservableProperty]
        private bool raucher;

        [ObservableProperty]
        private bool ploetzlicherBeginn;

        [ObservableProperty]
        private bool fieber;

        [ObservableProperty]
        private string fieberHoehe;

        [ObservableProperty]
        private bool nachtschweiß;

        [ObservableProperty]
        private bool halsSchmerzen;

        [ObservableProperty]
        private bool schluckBeschwerden;

        [ObservableProperty]
        private bool verlegteNasenAtmung;

        [ObservableProperty]
        private bool druck;

        [ObservableProperty]
        private bool hautsymptome;

        [ObservableProperty]
        private Color ploetzlicherBeginnYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color ploetzlicherBeginnNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color fieberYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color fieberNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color nachtschweißYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color nachtschweißNoButtonColor = Colors.LightGray;


        [ObservableProperty]
        private Color halsSchmerzenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color halsSchmerzenNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color schluckBeschwerdenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color schluckBeschwerdenNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color verlegteNasenAtmungYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color verlegteNasenAtmungNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color druckYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color druckNoButtonColor = Colors.LightGray;



        [ObservableProperty]
        private Color smokerYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color smokerNoButtonColor = Colors.LightGray;


        [ObservableProperty]
        private Color hautSymptomeYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hautSymptomeNoButtonColor = Colors.LightGray;

        [RelayCommand]
        public void PloetzlicherBeginnYes()
        {
            PloetzlicherBeginn = true;
            PloetzlicherBeginnYesButtonColor = Colors.Green;
            PloetzlicherBeginnNoButtonColor = Colors.LightGray;      
        }

        [RelayCommand]
        public void PloetzlicherBeginnNo()
        {
            PloetzlicherBeginn = false;
            PloetzlicherBeginnYesButtonColor = Colors.LightGray;
            PloetzlicherBeginnNoButtonColor = Colors.Green;
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
        public void NachtschweißYes()
        {
            Nachtschweiß = true;
            NachtschweißYesButtonColor = Colors.Green;
            NachtschweißNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void NachtschweißNo()
        {
            Nachtschweiß = false;
            NachtschweißYesButtonColor = Colors.LightGray;
            NachtschweißNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void HalsSchmerzenYes()
        {
            HalsSchmerzen = true;
            HalsSchmerzenYesButtonColor = Colors.Green;
            HalsSchmerzenNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void HalsSchmerzenNo()
        {
            HalsSchmerzen = false;
            HalsSchmerzenYesButtonColor = Colors.LightGray;
            HalsSchmerzenNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void SchluckBeschwerdenYes()
        {
            SchluckBeschwerden = true;
            SchluckBeschwerdenYesButtonColor = Colors.Green;
            SchluckBeschwerdenNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void SchluckBeschwerdenNo()
        {
            SchluckBeschwerden = false;
            SchluckBeschwerdenYesButtonColor = Colors.LightGray;
            SchluckBeschwerdenNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void VerlegteNasenAtmungYes()
        {
            VerlegteNasenAtmung = true;
            VerlegteNasenAtmungYesButtonColor = Colors.Green;
            VerlegteNasenAtmungNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void VerlegteNasenAtmungNo()
        {
            VerlegteNasenAtmung = false;
            VerlegteNasenAtmungYesButtonColor = Colors.LightGray;
            VerlegteNasenAtmungNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void DruckYes()
        {
            Druck = true;
            DruckYesButtonColor = Colors.Green;
            DruckNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void DruckNo()
        {
            Druck = false;
            DruckYesButtonColor = Colors.LightGray;
            DruckNoButtonColor = Colors.Green;
        }

        [RelayCommand]

        public  void SmokerYes()
        {
            Raucher = true;
            SmokerNoButtonColor = Colors.LightGray;
            SmokerYesButtonColor = Colors.Green;
        }
        [RelayCommand]
        public void SmokerNo()
        {
            Raucher = false;
            SmokerYesButtonColor = Colors.LightGray;
            SmokerNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void HautSymptomeYes()
        {
            Hautsymptome = true;
            HautSymptomeYesButtonColor = Colors.Green;
            HautSymptomeNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void HautSymptomeNo()
        {
            Hautsymptome = false;
            HautSymptomeYesButtonColor = Colors.LightGray;
            HautSymptomeNoButtonColor = Colors.Green;
        }


        [RelayCommand]
        public async Task  SaveErkaeltung()
        {
            erkaeltung.BeschwerdeZeitraum = BeschwerdeZeitraum;
            //erkaeltung.FieberHoehe = FieberHoehe;
            await Application.Current.MainPage.DisplayAlert("Titel", erkaeltung.BeschwerdeZeitraum, "OK");
        }

        [RelayCommand]
        public async Task GoToMainPage()
        {
                await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
