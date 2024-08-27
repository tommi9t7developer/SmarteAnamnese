using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarteAnamnese
{
    public class Patient
    {
        public string Sprache { get; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtsdatum { get; set; }

        public AnamneseModel Anamnese { get; set; }

        public Patient(string sprache)
        {
            Sprache = sprache;
           
        }
    }
}
