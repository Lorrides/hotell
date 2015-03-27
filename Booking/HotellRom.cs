using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class Etasje : IEnumerable<Rom>  // IEnumerable gjør slik at foreach og LINQ funker. Den vil returnere en liste med rom
    {
        public TabPage Tab { get; private set; }

        public int Nummer { get; private set; }

        private readonly List<Rom> _rom;

        public Etasje(int etasjeNummer, TabPage tabPage)
        {
            _rom = new List<Rom>();

            Nummer = etasjeNummer;

            Tab = tabPage;
        }

        private int _romTeller = 0;

        public Rom AddRom()
        {
            var label = new Label();           
            Tab.Container.Add(label);

            var rom = new Rom(this, ++_romTeller, label) { Opptatt = false };

            _rom.Add(rom);

            return rom;
        }

        public bool RemoveRom(Rom rom)
        {
            return _rom.Remove(rom);
        }


        public IEnumerator<Rom> GetEnumerator()
        {
            return _rom.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _rom.GetEnumerator();
        }

        public int GetAntallLedigeRom()
        {
            return GetLedigeRom().Count();
        }

        public IEnumerable<Rom> GetLedigeRom()
        {
            return _rom.Where(a => !a.Opptatt);
        }
    }

    public class Rom
    {
        public Etasje Etasje { get; private set; }
        public bool Opptatt { get; set; }
        public int Nummer { get; set; }

        // private bool _opptatt = false;
        // public bool Opptatt { get { return _opptatt; } set { _opttatt = value; if(value) { Label.BackgroundColor = Color.Red; } else { Label.BackgroundColor = Color.Silver; } }

        public Label Label { get; set; }

        public Rom(Etasje etasje, int romNummer, Label label)
        {
            Etasje = etasje;
            Label = label;

            // nå har du en referanse til labelen som er blitt opprettet og du kan endre egenskaper på den om man endrer status på rommet uten at det direkte henger sammen med UI
        }


        public override string ToString()
        {
            return string.Concat(Etasje.Nummer, Nummer.ToString().PadLeft(3, '0'));
        }

    }

    public class Form1 : IEnumerable<Etasje>   // IEnumerable gjør at foreach og LINQ funker på objektet. Den vil nå kunne returnere en liste av etasjer
    {
        private readonly TabControl _tab;
        private readonly List<Etasje> _etasjer;
        private int _etasjeTeller = 0;

        public TabControl Tab { get { return _tab; } }

        public Form1(TabControl tab)
        {
            _tab = tab;
            _etasjer = new List<Etasje>();
            _tab = tab;
        }

        public Etasje AddEtasje()
        {
            TabPage tab = null; // opprett tab her
            var etasje = new Etasje(++_etasjeTeller, tab);

            _etasjer.Add(etasje);

            return etasje;
        }

        // Dette er for at foreach og LINQ skal funke
        public IEnumerator<Etasje> GetEnumerator()
        {
            return _etasjer.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _etasjer.GetEnumerator();
        }
    }
}
         



/*FORRIGE BEGYNNELSE PÅ IMPLEMENTASJON
 * namespace Booking
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
            opptatt = false;
            romNummer = this.romNummer;
        }       
    }
}
 */
