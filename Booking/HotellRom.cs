using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    class HotellRom : Label
    {
        public int      romNummer;
        public string   GjesteNavn;
        public bool     opptatt;
        public string   innsjekkDato;
        public string   utsjekkdato;

        public HotellRom(int romNummer)
        {
            opptatt = "False";
            romNummer = this.romNummer;
        }       
    }
}
