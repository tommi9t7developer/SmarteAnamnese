using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarteAnamnese
{
    public  class ErkaeltungModel : AnamneseModel
    {
        public string BeschwerdeZeitraum {  get; set; }
        public ErkaeltungModel(string beschwerdenzeitraum) {
            BeschwerdeZeitraum = beschwerdenzeitraum;
        }    
    }
}
