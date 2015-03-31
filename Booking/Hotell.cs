using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public class Hotell : IEnumerable<Etasje>   // IEnumerable gjør at foreach og LINQ funker på objektet. Den vil nå kunne returnere en liste av etasjer
    {
        private readonly TabControl _tabControl;
        private readonly List<Etasje> _etasjer;
        private int _etasjeTeller = 0;

        public TabControl Tab { get { return _tabControl; } }

        public Hotell(TabControl tabControl)
        {
            _tabControl = tabControl;
            _etasjer = new List<Etasje>();
            _tabControl = tabControl;
        }

        public Etasje AddEtasje()
        {
            TabPage tab = new TabPage(); // opprett tab her
            _tabControl.TabPages.Add(string.Format("Etasje {0}", _etasjeTeller));
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
