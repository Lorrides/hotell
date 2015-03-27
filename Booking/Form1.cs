using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            xh.oppdaterGjesteListeFraXML(gjesteListe);

            int antallEtasjer = 3;
            int antallRomPerEtasje = 14;
            
            for(int i = 0; i < antallEtasjer; i++)
            {
               
                etasjeOversiktTabControl.TabPages.Add((i+1).ToString());
                foreach (TabPage tab in etasjeOversiktTabControl.TabPages)
                {
                    Etasje etasje = new Etasje(i, tab);
                }
            }            
        }

        XmlHåndterer xh = new XmlHåndterer();
        private DateTime _innsjekkDato;
        private DateTime _utsjekkDato;

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameInputBox.Text == "")
            {
                System.Console.WriteLine("Intet navn angitt");
            }
            
            else {
                    gjesteListe.Items.Clear();
                   
                    xh.leggTilNyGjest(nameInputBox.Text, _innsjekkDato, _utsjekkDato);

                    xh.oppdaterGjesteListeFraXML(gjesteListe);
            }
        }

        

        private void innSjekkDato_ValueChanged(object sender, EventArgs e)
        {
            _innsjekkDato = innsjekkDatoVelger.Value;
        }

        private void utsjekkDatoVelger_ValueChanged(object sender, EventArgs e)
        {
            _utsjekkDato = utsjekkDatoVelger.Value;
        }      
    }
}
