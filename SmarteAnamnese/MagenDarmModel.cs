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
    }
}
