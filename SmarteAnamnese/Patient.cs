using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarteAnamnese
{
    public class Patient
    {
        public string Vorname { get; }
        public string Nachname { get; }
        public DateTime Geburtsdatum { get; }

        public AnamneseModel Anamnese { get; set; }

        public Patient(string vorname, string nachname, DateTime geburtsdatum)
        {
            Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = geburtsdatum;
        }

        public void SetzeAnamnese(AnamneseModel anamnese)
        {
            Anamnese = anamnese;
        }
    }
}
