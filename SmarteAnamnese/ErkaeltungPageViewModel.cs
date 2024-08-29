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
        private bool ohrenschmerzen;

        [ObservableProperty]
        private bool hoeren;

        [ObservableProperty]
        private bool husten;

        [ObservableProperty]
        private bool hustenTrocken = false;

        [ObservableProperty]
        private bool hustenFest = false;

        [ObservableProperty]
        private bool hustenLoesend = false;

        [ObservableProperty]
        private bool hustenAuswurf = false;

        [ObservableProperty]
        private string hustenAuswurfFarbe;

        [ObservableProperty]
        private bool atemnot;

        [ObservableProperty]
        private bool fehlendeBelastbarkeit;

        [ObservableProperty]
        private bool atemGeraeusche;

        [ObservableProperty]
        private bool schmerzen;

        [ObservableProperty]
        private bool magenDarm = false;

        [ObservableProperty]
        private bool durchfall = false;

        [ObservableProperty]
        private bool uebelkeit = false;

        [ObservableProperty]
        private bool erbrechen = false;

        [ObservableProperty]
        private string sonstigeBeschwerden;

        [ObservableProperty]
        private bool hautsymptome;

        //CORONASCHNELLTEST STRUCT positiv negativ FEHLT
        [ObservableProperty]
        private bool coronaSchnelltest;

        [ObservableProperty]
        private string positivNegativ;

        [ObservableProperty]
        private bool grippeImpfung;

        [ObservableProperty]
        private bool grippeCoronaErkrankung;

        [ObservableProperty]
        private bool antibiotika;

        [ObservableProperty]
        private bool lungenvorerkrankung;

        [ObservableProperty]
        private bool raucher;

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
        private Color ohrenschmerzenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color ohrenschmerzenNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hoerenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hoerenNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hustenNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hustenTrockenButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hustenFestButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hustenLoesendButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hustenAuswurfButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color atemnotYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color atemnotNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color fehlendeBelastbarkeitYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color fehlendeBelastbarkeitNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color atemGeraeuscheYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color atemGeraeuscheNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color schmerzenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color schmerzenNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color magenDarmNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color durchfallYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color uebelkeitYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color erbrechenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hautSymptomeYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hautSymptomeNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color coronaSchnelltestYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color coronaSchnelltestNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color grippeImpfungYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color grippeImpfungNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color grippeCoronaErkrankungYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color grippeCoronaErkrankungNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color antibiotikaYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color antibiotikaNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color lungenvorerkrankungYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color lungenvorerkrankungNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color smokerYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color smokerNoButtonColor = Colors.LightGray;


       

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
        public void OhrenschmerzenYes()
        {
            Ohrenschmerzen = true;
            OhrenschmerzenYesButtonColor = Colors.Green;
            OhrenschmerzenNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void OhrenschmerzenNo()
        {
            Ohrenschmerzen = false;
            OhrenschmerzenYesButtonColor = Colors.LightGray;
            OhrenschmerzenNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void HoerenYes()
        {
            Hoeren = true;
            HoerenYesButtonColor = Colors.Green;
            HoerenNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void HoerenNo()
        {
            Hoeren = false;
            HoerenYesButtonColor = Colors.LightGray;
            HoerenNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void HustenNo()
        {
            Husten = false;
            HustenTrockenButtonColor = Colors.LightGray;
            HustenFestButtonColor = Colors.LightGray;
            HustenLoesendButtonColor = Colors.LightGray;
            HustenAuswurfButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void HustenTrockenYes()
        {
            if (HustenTrocken == false)
            {
                HustenTrocken = true;
                HustenTrockenButtonColor = Colors.Green;
            }
            else
            {
                HustenTrocken = false;
                HustenTrockenButtonColor = Colors.LightGray;
            }
        }

        [RelayCommand]
        public void HustenFestYes()
        {
            if (HustenFest == false)
            {
                HustenFest = true;
                HustenFestButtonColor = Colors.Green;
            }
            else
            {
                HustenFest = false;
                HustenFestButtonColor = Colors.LightGray;
            }
        }

        [RelayCommand]
        public void HustenLoesendYes()
        {
            if (HustenLoesend == false)
            {
                HustenLoesend = true;
                HustenLoesendButtonColor = Colors.Green;
            }
            else
            {
                HustenLoesend = false;
                HustenLoesendButtonColor = Colors.LightGray;
            }
        }
        [RelayCommand]
        public void HustenAuswurfYes()
        {
            if (HustenAuswurf == false)
            {
                HustenAuswurf = true;
                HustenAuswurfButtonColor = Colors.Green;
            }
            else
            {
                HustenAuswurf= false;
                HustenAuswurfButtonColor = Colors.LightGray;
            }
        }


        [RelayCommand]
        public void AtemnotYes()
        {
            Atemnot = true;
            AtemnotYesButtonColor = Colors.Green;
            AtemnotNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void AtemnotNo()
        {
            Atemnot = false;
            AtemnotYesButtonColor = Colors.LightGray;
            AtemnotNoButtonColor = Colors.Green;
        }


        [RelayCommand]
        public void FehlendeBelastbarkeitYes()
        {
            FehlendeBelastbarkeit = true;
            FehlendeBelastbarkeitYesButtonColor = Colors.Green;
            FehlendeBelastbarkeitNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void FehlendeBelastbarkeitNo()
        {
            FehlendeBelastbarkeit = false;
            FehlendeBelastbarkeitYesButtonColor = Colors.LightGray;
            FehlendeBelastbarkeitNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void AtemGeraeuscheYes()
        {
            AtemGeraeusche = true;
            AtemGeraeuscheYesButtonColor = Colors.Green;
            AtemGeraeuscheNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void AtemGeraeuscheNo()
        {
            AtemGeraeusche = false;
            AtemGeraeuscheYesButtonColor = Colors.LightGray;
            AtemGeraeuscheNoButtonColor = Colors.Green;
        }


        [RelayCommand]
        public void SchmerzenYes()
        {
            Schmerzen = true;
            SchmerzenYesButtonColor = Colors.Green;
            SchmerzenNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void SchmerzenNo()
        {
            Schmerzen = false;
            SchmerzenYesButtonColor = Colors.LightGray;
            SchmerzenNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void MagenDarmNo()
        {
            MagenDarm = false;
            DurchfallYesButtonColor = Colors.LightGray;
            ErbrechenYesButtonColor = Colors.LightGray;
            UebelkeitYesButtonColor = Colors.LightGray;
        }


        [RelayCommand]
        public void DurchfallYes()
        {
            if (Durchfall == false)
            {
                Durchfall = true;
                DurchfallYesButtonColor = Colors.Green;
            }
            else
            {
                Durchfall = false;
                DurchfallYesButtonColor = Colors.LightGray;
            }
        }

        [RelayCommand]
        public void UebelkeitYes()
        {
            if (Uebelkeit == false)
            {
                Uebelkeit = true;
                UebelkeitYesButtonColor = Colors.Green;
            }
            else
            {
                Uebelkeit = false;
                UebelkeitYesButtonColor = Colors.LightGray;
            }
        }


        [RelayCommand]
        public void ErbrechenYes()
        {
            if (Erbrechen == false)
            {
                Erbrechen = true;
                ErbrechenYesButtonColor = Colors.Green;
            }
            else
            {
                Erbrechen = false;
                ErbrechenYesButtonColor = Colors.LightGray;
            }
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
        public void CoronaSchnelltestYes()
        {
            CoronaSchnelltest = true;
            CoronaSchnelltestYesButtonColor = Colors.Green;
            CoronaSchnelltestNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void CoronaSchnelltestNo()
        {
            CoronaSchnelltest = false;
            CoronaSchnelltestYesButtonColor = Colors.LightGray;
            CoronaSchnelltestNoButtonColor = Colors.Green;
            PositivNegativ = null;
        }

        [RelayCommand]
        public void GrippeImpfungYes()
        {
            GrippeImpfung = true;
            GrippeImpfungYesButtonColor = Colors.Green;
            GrippeImpfungNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void GrippeImpfungNo()
        {
            GrippeImpfung = false;
            GrippeImpfungYesButtonColor = Colors.LightGray;
            GrippeImpfungNoButtonColor = Colors.Green;
        }


        [RelayCommand]
        public void GrippeCoronaErkrankungYes()
        {
            GrippeCoronaErkrankung = true;
            GrippeCoronaErkrankungYesButtonColor = Colors.Green;
            GrippeCoronaErkrankungNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void GrippeCoronaErkrankungNo()
        {
            GrippeCoronaErkrankung = false;
            GrippeCoronaErkrankungYesButtonColor = Colors.LightGray;
            GrippeCoronaErkrankungNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void AntibiotikaYes()
        {
            Antibiotika = true;
            AntibiotikaYesButtonColor = Colors.Green;
            AntibiotikaNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void AntibiotikaNo()
        {
            Antibiotika = false;
            AntibiotikaYesButtonColor = Colors.LightGray;
            AntibiotikaNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void LungenvorerkrankungYes()
        {
            Lungenvorerkrankung = true;
            LungenvorerkrankungNoButtonColor = Colors.LightGray;
            LungenvorerkrankungYesButtonColor = Colors.Green;
        }
        [RelayCommand]
        public void LungenvorerkrankungNo()
        {
            Lungenvorerkrankung = false;
            LungenvorerkrankungYesButtonColor = Colors.LightGray;
            LungenvorerkrankungNoButtonColor = Colors.Green;
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
        public async Task  SaveErkaeltung()
        {
            erkaeltung.BeschwerdeZeitraum = BeschwerdeZeitraum;
            erkaeltung.PloetzlicherBeginn = PloetzlicherBeginn;
            erkaeltung.Fieber = Fieber;
            erkaeltung.FieberHoehe = FieberHoehe;
            erkaeltung.Nachtschweiß = Nachtschweiß;
            erkaeltung.HalsSchmerzen = HalsSchmerzen;
            erkaeltung.SchluckBeschwerden = SchluckBeschwerden;
            erkaeltung.VerlegteNasenAtmung = VerlegteNasenAtmung;
            erkaeltung.Druck = Druck;
            erkaeltung.Ohrenschmerzen = Ohrenschmerzen;
            erkaeltung.Hoeren = Hoeren;
            erkaeltung.Husten = Husten;
            erkaeltung.Atemnot = Atemnot;
            erkaeltung.FehlendeBelastbarkeit = FehlendeBelastbarkeit;
            erkaeltung.AtemGeraeusche = AtemGeraeusche;
            erkaeltung.Schmerzen = Schmerzen;
            erkaeltung.Hautsymptome = Hautsymptome;
            erkaeltung.CoronaSchnelltest = CoronaSchnelltest;
            erkaeltung.PositivNegativ = PositivNegativ;
            erkaeltung.GrippeImpfung = GrippeImpfung;
            erkaeltung.GrippeCoronaErkrankung = GrippeCoronaErkrankung;
            erkaeltung.Antibiotika = Antibiotika;
            erkaeltung.Lungenvorerkrankung = Lungenvorerkrankung;
            erkaeltung.Raucher = Raucher;
            erkaeltung.SonstigeBeschwerden = SonstigeBeschwerden;

            // Zuordnung für die Husten-Eigenschaften
            erkaeltung.HustenDetails.Trocken = HustenTrocken;
            erkaeltung.HustenDetails.Fest = HustenFest;
            erkaeltung.HustenDetails.Loesend = HustenLoesend;
            erkaeltung.HustenDetails.Auswurf = HustenAuswurf;
            erkaeltung.HustenDetails.AuswurfFarbe = HustenAuswurfFarbe;

            // Zuordnung für die Magen-Darm-Eigenschaften
            erkaeltung.MagenDarmDetails.MagenDarm = MagenDarm;
            erkaeltung.MagenDarmDetails.Durchfall = Durchfall;
            erkaeltung.MagenDarmDetails.Uebelkeit = Uebelkeit;
            erkaeltung.MagenDarmDetails.Erbrechen = Erbrechen;

            await Application.Current.MainPage.DisplayAlert("Titel", erkaeltung.BeschwerdeZeitraum, "OK");
        }

        [RelayCommand]
        public async Task GoToMainPage()
        {
                await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
