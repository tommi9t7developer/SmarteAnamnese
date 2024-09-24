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
        private bool stuhlGangTaeglich = false;

        [ObservableProperty]
        private bool stuhlGangAllePaarTage = false;

        [ObservableProperty]
        private bool stuhlGangWoechentlich = false;

        [ObservableProperty]
        private bool stuhlKonsistenzNormal = false;

        [ObservableProperty]
        private bool stuhlKonsistenzSchleimig = false;

        [ObservableProperty]
        private bool stuhlKonsistenzBlutig = false;

        [ObservableProperty]
        private bool stuhlKonsistenzFluessig = false;

        [ObservableProperty]
        private bool stuhlKonsistenzSehrFest = false;

        [ObservableProperty]
        private string imAusland;

        [ObservableProperty]
        private string chronischeFamilienDarmErkrankungen;

        [ObservableProperty]
        private bool augenErkrankung;

        [ObservableProperty]
        private bool hautVeraenderungen;

        [ObservableProperty]
        private bool gelenkSchmerzen;

        [ObservableProperty]
        private string getreideBeschwerdeZeit;

        [ObservableProperty]
        private string milchBeschwerdeZeit;

        [ObservableProperty]
        private string fruchtZuckerBeschwerdeZeit;

        [ObservableProperty]
        private string histamineBeschwerdeZeit;

        [ObservableProperty]
        private string allergien;

        [ObservableProperty]
        private bool glutenFrei;

        [ObservableProperty]
        private bool spezielleKost;

        [ObservableProperty]
        private bool vorBefundeLaborErgebnisse;

        [ObservableProperty]
        private bool blutArmut;

        [ObservableProperty]
        private bool erhoehteLeberWerte;

        [ObservableProperty]
        private bool osteoporose;

        [ObservableProperty]
        private bool vitaminDMangel;

        [ObservableProperty]
        private bool vitaminB12Mangel;

        [ObservableProperty]
        private bool schildDruesenErkrankung;

        [ObservableProperty]
        private bool typ1Diabetes;

        [ObservableProperty]
        private bool andereImmunErkrankung;










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

        [ObservableProperty]
        private Color stuhlGangTaeglichButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color stuhlGangAllePaarTageButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color stuhlGangWoechentlichButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color konsistenzNormalButtonColor = Colors.LightGray;
        [ObservableProperty]
        private Color konsistenzSchleimigButtonColor = Colors.LightGray;
        [ObservableProperty]
        private Color konsistenzBlutigButtonColor = Colors.LightGray;
        [ObservableProperty]
        private Color konsistenzFluessigButtonColor = Colors.LightGray;
        [ObservableProperty]
        private Color konsistenzSehrFestButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color augenErkrankungYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color augenErkrankungNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hautVeraenderungenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color hautVeraenderungenNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color gelenkSchmerzenYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color gelenkSchmerzenNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color glutenFreiYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color glutenFreiNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color spezielleKostYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color spezielleKostNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color vorBefundeLaborErgebnisseYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color vorBefundeLaborErgebnisseNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color blutArmutYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color blutArmutNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color erhoehteLeberWerteYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color erhoehteLeberWerteNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color osteoporoseYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color osteoporoseNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color vitaminDMangelYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color vitaminDMangelNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color vitaminB12MangelYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color vitaminB12MangelNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color schildDruesenErkrankungYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color schildDruesenErkrankungNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color typ1DiabetesYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color typ1DiabetesNoButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color andereImmunErkrankungYesButtonColor = Colors.LightGray;

        [ObservableProperty]
        private Color andereImmunErkrankungNoButtonColor = Colors.LightGray;





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
        public void StuhlGangTaeglichYes()
        {
            StuhlGangTaeglich = true;
            StuhlGangAllePaarTage = false;
            StuhlGangWoechentlich = false;
            StuhlGangTaeglichButtonColor = Colors.Green;
            StuhlGangAllePaarTageButtonColor = Colors.LightGray;
            StuhlGangWoechentlichButtonColor = Colors.LightGray;

        }

        [RelayCommand]
        public void StuhlGangAllePaarTageYes()
        {
            StuhlGangTaeglich = false;
            StuhlGangAllePaarTage = true;
            StuhlGangWoechentlich = false;
            StuhlGangTaeglichButtonColor = Colors.LightGray;
            StuhlGangAllePaarTageButtonColor = Colors.Green;
            StuhlGangWoechentlichButtonColor = Colors.LightGray;

        }

        [RelayCommand]
        public void StuhlGangWoechentlichYes()
        {
            StuhlGangTaeglich = false;
            StuhlGangAllePaarTage = false;
            StuhlGangWoechentlich = true;
            StuhlGangTaeglichButtonColor = Colors.LightGray;
            StuhlGangAllePaarTageButtonColor = Colors.LightGray;
            StuhlGangWoechentlichButtonColor = Colors.Green;

        }

        [RelayCommand]
        public void KonsistenzNormalYes()
        {
           StuhlKonsistenzNormal = true;
           StuhlKonsistenzSchleimig = false;
           StuhlKonsistenzBlutig = false;
           StuhlKonsistenzFluessig = false;
           StuhlKonsistenzSehrFest = false;
           KonsistenzNormalButtonColor = Colors.Green;
           KonsistenzSchleimigButtonColor = Colors.LightGray;
           KonsistenzBlutigButtonColor = Colors.LightGray;
           KonsistenzFluessigButtonColor = Colors.LightGray;
           KonsistenzSehrFestButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void KonsistenzSchleimigYes()
        {
            StuhlKonsistenzNormal = false;
            StuhlKonsistenzSchleimig = true;
            KonsistenzNormalButtonColor = Colors.LightGray;
            KonsistenzSchleimigButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void KonsistenzBlutigYes()
        {
            StuhlKonsistenzNormal = false;
            StuhlKonsistenzBlutig = true;
            KonsistenzNormalButtonColor = Colors.LightGray;
            KonsistenzBlutigButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void KonsistenzFluessigYes()
        {
            StuhlKonsistenzNormal = false;
            StuhlKonsistenzFluessig = true;
            KonsistenzNormalButtonColor = Colors.LightGray;
            KonsistenzFluessigButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void KonsistenzSehrFestYes()
        {
            StuhlKonsistenzNormal = false;
            StuhlKonsistenzSehrFest = true;
            KonsistenzNormalButtonColor = Colors.LightGray;
            KonsistenzSehrFestButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void AugenErkrankungYes()
        {
            AugenErkrankung = true;
            AugenErkrankungYesButtonColor = Colors.Green;
            AugenErkrankungNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void AugenErkrankungNo()
        {
            AugenErkrankung = false;
            AugenErkrankungYesButtonColor = Colors.LightGray;
            AugenErkrankungNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void HautVeraenderungenYes()
        {
            HautVeraenderungen = true;
            HautVeraenderungenYesButtonColor = Colors.Green;
            HautVeraenderungenNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void HautVeraenderungenNo()
        {
            HautVeraenderungen = false;
            HautVeraenderungenYesButtonColor = Colors.LightGray;
            HautVeraenderungenNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void GelenkSchmerzenYes()
        {
            GelenkSchmerzen = true;
            GelenkSchmerzenYesButtonColor = Colors.Green;
            GelenkSchmerzenNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void GelenkSchmerzenNo()
        {
            GelenkSchmerzen = false;
            GelenkSchmerzenYesButtonColor = Colors.LightGray;
            GelenkSchmerzenNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void GlutenFreiYes()
        {
            GlutenFrei = true;
            GlutenFreiYesButtonColor = Colors.Green;
            GlutenFreiNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void GlutenFreiNo()
        {
            GlutenFrei = false;
            GlutenFreiYesButtonColor = Colors.LightGray;
            GlutenFreiNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void SpezielleKostYes()
        {
            SpezielleKost = true;
            SpezielleKostYesButtonColor = Colors.Green;
            SpezielleKostNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void SpezielleKostNo()
        {
            SpezielleKost = false;
            SpezielleKostYesButtonColor = Colors.LightGray;
            SpezielleKostNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void VorBefundeLaborErgebnisseYes()
        {
            VorBefundeLaborErgebnisse = true;
            VorBefundeLaborErgebnisseYesButtonColor = Colors.Green;
            VorBefundeLaborErgebnisseNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void VorBefundeLaborErgebnisseNo()
        {
            VorBefundeLaborErgebnisse = false;
            VorBefundeLaborErgebnisseYesButtonColor = Colors.LightGray;
            VorBefundeLaborErgebnisseNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void BlutArmutYes()
        {
            BlutArmut = true;
            BlutArmutYesButtonColor = Colors.Green;
            BlutArmutNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void BlutArmutNo()
        {
            BlutArmut = false;
            BlutArmutYesButtonColor = Colors.LightGray;
            BlutArmutNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void ErhoehteLeberWerteYes()
        {
            ErhoehteLeberWerte = true;
            ErhoehteLeberWerteYesButtonColor = Colors.Green;
            ErhoehteLeberWerteNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void ErhoehteLeberWerteNo()
        {
            ErhoehteLeberWerte = false;
            ErhoehteLeberWerteYesButtonColor = Colors.LightGray;
            ErhoehteLeberWerteNoButtonColor = Colors.Green;
        }


        [RelayCommand]
        public void OsteoporoseYes()
        {
            Osteoporose = true;
            OsteoporoseYesButtonColor = Colors.Green;
            OsteoporoseNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void OsteoporoseNo()
        {
            Osteoporose = false;
            OsteoporoseYesButtonColor = Colors.LightGray;
            OsteoporoseNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void VitaminDMangelYes()
        {
            VitaminDMangel = true;
            VitaminDMangelYesButtonColor = Colors.Green;
            VitaminDMangelNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void VitaminDMangelNo()
        {
            VitaminDMangel = false;
            VitaminDMangelYesButtonColor = Colors.LightGray;
            VitaminDMangelNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void VitaminB12MangelYes()
        {
            VitaminB12Mangel = true;
            VitaminB12MangelYesButtonColor = Colors.Green;
            VitaminB12MangelNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void VitaminB12MangelNo()
        {
            VitaminB12Mangel = false;
            VitaminB12MangelYesButtonColor = Colors.LightGray;
            VitaminB12MangelNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void SchildDrüsenErkrankungYes()
        {
            SchildDruesenErkrankung = true;
            SchildDruesenErkrankungYesButtonColor = Colors.Green;
            SchildDruesenErkrankungNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void SchildDrüsenErkrankungNo()
        {
            SchildDruesenErkrankung = false;
            SchildDruesenErkrankungYesButtonColor = Colors.LightGray;
            SchildDruesenErkrankungNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void Typ1DiabetesYes()
        {
            Typ1Diabetes = true;
            Typ1DiabetesYesButtonColor = Colors.Green;
            Typ1DiabetesNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void Typ1DiabetesNo()
        {
            Typ1Diabetes = false;
            Typ1DiabetesYesButtonColor = Colors.LightGray;
            Typ1DiabetesNoButtonColor = Colors.Green;
        }

        [RelayCommand]
        public void AndereImmunErkrankungYes()
        {
            AndereImmunErkrankung = true;
            AndereImmunErkrankungYesButtonColor = Colors.Green;
            AndereImmunErkrankungNoButtonColor = Colors.LightGray;
        }

        [RelayCommand]
        public void AndereImmunErkrankungNo()
        {
            AndereImmunErkrankung = false;
            AndereImmunErkrankungYesButtonColor = Colors.LightGray;
            AndereImmunErkrankungNoButtonColor = Colors.Green;
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
            magendarm.StuhlGangTaeglich = StuhlGangTaeglich;
            magendarm.StuhlGangAllePaarTage = StuhlGangAllePaarTage;
            magendarm.StuhlGangWoechentlich = StuhlGangWoechentlich;
            magendarm.StuhlKonsistenzNormal = StuhlKonsistenzNormal;
            magendarm.StuhlKonsistenzSchleimig = StuhlKonsistenzSchleimig;
            magendarm.StuhlKonsistenzBlutig = StuhlKonsistenzBlutig;
            magendarm.StuhlKonsistenzFluessig = StuhlKonsistenzFluessig;
            magendarm.StuhlKonsistenzSehrFest = StuhlKonsistenzSehrFest;
            magendarm.ImAusland = ImAusland;
            magendarm.ChronischeFamilienDarmErkrankungen = ChronischeFamilienDarmErkrankungen;
            magendarm.AugenErkrankung = AugenErkrankung;
            magendarm.HautVeraenderungen = HautVeraenderungen;
            magendarm.GelenkSchmerzen = GelenkSchmerzen;
            magendarm.GetreideBeschwerdeZeit = GetreideBeschwerdeZeit;
            magendarm.MilchBeschwerdeZeit = MilchBeschwerdeZeit;
            magendarm.FruchtZuckerBeschwerdeZeit = FruchtZuckerBeschwerdeZeit;
            magendarm.HistamineBeschwerdeZeit = HistamineBeschwerdeZeit;
            magendarm.Allergien = Allergien;
            magendarm.GlutenFrei = GlutenFrei; 
            magendarm.SpezielleKost = SpezielleKost;
            magendarm.VorBefundeLaborErgebnisse = VorBefundeLaborErgebnisse;
            magendarm.BlutArmut = BlutArmut;
            magendarm.ErhoehteLeberWerte = ErhoehteLeberWerte;
            magendarm.Osteoporose = Osteoporose;
            magendarm.VitaminDMangel = VitaminDMangel;
            magendarm.VitaminB12Mangel = VitaminB12Mangel;
            magendarm.SchildDruesenErkrankung = SchildDruesenErkrankung;
            magendarm.Typ1Diabetes = Typ1Diabetes;
            magendarm.AndereImmunErkrankung = AndereImmunErkrankung;
            // MagenDarm als Anamnese setzen
            _dataService.Patient.Anamnese = magendarm;
            // Navigiere zur ErkältungsAnamnesePage
            await Shell.Current.GoToAsync(nameof(FinalPage));
        }
    }
}
