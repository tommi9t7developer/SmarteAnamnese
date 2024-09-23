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


    }
}
