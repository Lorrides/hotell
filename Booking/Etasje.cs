using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Tab.Controls.Add(label);          

            var rom = new Rom(this, ++_romTeller, label) { Opptatt = false };

            _rom.Add(rom);
            Console.WriteLine("Addet rom: " +Nummer.ToString() +" "+_romTeller.ToString());

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
}
