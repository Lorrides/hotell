using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public class Rom : Label
    {
        public Etasje Etasje { get; private set; }
        public bool Opptatt { get; set; }
        public int RomNummer { get; set; }
        public string GjesteNavn { get; set; }
        public DateTime InnsjekkDato { get; set; }
        public DateTime UtsjekkDato { get; set; }

        // private bool _opptatt = false;
        // public bool Opptatt { get { return _opptatt; } set { _opptatt = value; if(value) { Label.BackgroundColor = Color.Red; } else { Label.BackgroundColor = Color.Silver; } }

        public Label Label { get; set; }

        public Rom(Etasje etasje, int romNummer, Label label)
        {
            Etasje = etasje;
            Label = label;

            // nå har du en referanse til labelen som er blitt opprettet og du kan endre egenskaper på den om man endrer status på rommet uten at det direkte henger sammen med UI
        }


        public override string ToString()
        {
            return string.Concat(Etasje.Nummer, RomNummer.ToString().PadLeft(3, '0'));
        }

    }
}
