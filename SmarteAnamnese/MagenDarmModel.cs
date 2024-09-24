using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarteAnamnese
{
    public class MagenDarmModel : AnamneseModel
    {
        public string BeschwerdeZeitraum { get; set; } = string.Empty; // Standardwert

        public bool BeschwerdeNachInfekt {  get; set; }

        public bool VorerkrankungenBeschwerde {  get; set; }

        public bool OperationMagenDarm { get; set; }

        public string Tumor { get; set; } = string.Empty; // Standardwert

        public string VorerkrankungenGenerell { get; set; } = string.Empty; // Standardwert

        public bool Blaehungen { get; set; }

        public bool Verstopfung { get; set; }

        public bool Bauchkraempfe { get; set; }

        public bool Nachtschweiss { get; set; }

        public bool Durchfall { get; set; }

        public bool Fieber { get; set; }

        public string FieberHoehe { get; set; } = string.Empty; // Standardwert

        public string WeitereVeraenderungen { get; set; } = string.Empty; // Standardwert 

        public bool Kopfschmerzen { get; set; }

        public bool Muedigkeit { get; set; }

        public bool Abgeschlagenheit { get; set; }

        public bool Gewichtsverlust { get; set; }

        public string GewichtVerloren { get; set; } = string.Empty; // Standardwert 

        public string Gewicht { get; set; } = string.Empty; // Standardwert

        public string Groesse { get; set; } = string.Empty; // Standardwert

        public bool StuhlGangTaeglich { get; set; }
        public bool StuhlGangAllePaarTage { get; set; }
        public bool StuhlGangWoechentlich { get; set; }


        public bool StuhlKonsistenzNormal { get; set; }
        public bool StuhlKonsistenzSchleimig { get; set; }
        public bool StuhlKonsistenzBlutig { get; set; }
        public bool StuhlKonsistenzFluessig { get; set; }

        public bool StuhlKonsistenzSehrFest { get; set; }

        public string ImAusland { get; set; } = string.Empty; // Standardwert

        public string ChronischeFamilienDarmErkrankungen { get; set; } = string.Empty; // Standardwert

        public bool AugenErkrankung { get; set; }

        public bool HautVeraenderungen { get; set; }

        public bool GelenkSchmerzen { get; set; }

        public string GetreideBeschwerdeZeit { get; set; } = string.Empty; // Standardwert

        public string MilchBeschwerdeZeit { get; set; } = string.Empty; // Standardwert

        public string FruchtZuckerBeschwerdeZeit { get; set; } = string.Empty; // Standardwert

        public string HistamineBeschwerdeZeit { get; set; } = string.Empty; // Standardwert

        public string Allergien { get; set; } = string.Empty; // Standardwert

        public bool GlutenFrei { get; set; }

        public bool SpezielleKost { get; set; }

        public bool VorBefundeLaborErgebnisse { get; set; }

        public bool BlutArmut { get; set; }
        public bool ErhoehteLeberWerte { get; set; }
        public bool Osteoporose { get; set; }
        public bool VitaminDMangel { get; set; }
        public bool VitaminB12Mangel { get; set; }
        public bool SchildDruesenErkrankung { get; set; }
        public bool Typ1Diabetes { get; set; }
    
        public string AndereImmunErkrankung { get; set; } = string.Empty; // Standardwert

        public string Medikamente { get; set; } = string.Empty; // Standardwert

        public string AlkoholhaltigeGetraenke { get; set; } = string.Empty; // Standardwert

        public bool AlkoholProblem { get; set; }

        public bool GefaessErkrankungen { get; set; }

        public bool CoronareHerzKrankheit { get; set; }

        public bool DurchBlutungsStoerungenBeine { get; set; }

    }
}
