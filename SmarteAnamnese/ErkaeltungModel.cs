using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarteAnamnese
{
    public  class ErkaeltungModel : AnamneseModel
    {

        public string BeschwerdeZeitraum { get; set; }
        public bool PloetzlicherBeginn { get; set; }
        public bool Fieber { get; set; }
        public string FieberHoehe { get; set; }
        public bool Nachtschweiß { get; set; }
        public bool HalsSchmerzen { get; set; }
        public bool SchluckBeschwerden { get; set; }
        public bool VerlegteNasenAtmung { get; set; }
        public bool Druck { get; set; }
        public bool Ohrenschmerzen { get; set; }
        public bool Hoeren { get; set; }
        public bool Husten { get; set; }
        public bool Atemnot { get; set; }
        public bool FehlendeBelastbarkeit { get; set; }
        public bool AtemGeraeusche { get; set; }
        public bool Schmerzen { get; set; }
        public bool Hautsymptome { get; set; }
        public bool CoronaSchnelltest { get; set; }
        public string PositivNegativ { get; set; }
        public bool GrippeImpfung { get; set; }
        public bool GrippeCoronaErkrankung { get; set; }
        public bool Antibiotika { get; set; }
        public bool Lungenvorerkrankung { get; set; }
        public bool Raucher { get; set; }
        public string SonstigeBeschwerden { get; set; }

        // Verschachtelte Modelle für Husten und Magen-Darm
        public HustenModel HustenDetails { get; set; } = new HustenModel();
        public MagenDarmModel MagenDarmDetails { get; set; } = new MagenDarmModel();

        public class HustenModel
        {
            public bool Trocken { get; set; }
            public bool Fest { get; set; }
            public bool Loesend { get; set; }
            public bool Auswurf { get; set; }
            public string AuswurfFarbe { get; set; }
        }

        public class MagenDarmModel
        {
            public bool MagenDarm { get; set; }
            public bool Durchfall { get; set; }
            public bool Uebelkeit { get; set; }
            public bool Erbrechen { get; set; }
        }

    }
}
