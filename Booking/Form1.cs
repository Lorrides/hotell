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
<<<<<<< HEAD
            innsjekkDatoVelger.MinDate = DateTime.Now;
            utsjekkDatoVelger.MinDate = DateTime.Now;
=======

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
>>>>>>> 77f531466fe3fe328a74281f66d0e65762ae2d1e
        }

        XmlHåndterer xh = new XmlHåndterer();
        private DateTime _innsjekkDato;
        private DateTime _utsjekkDato;

<<<<<<< HEAD
=======
        
>>>>>>> 77f531466fe3fe328a74281f66d0e65762ae2d1e

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameInputBox.Text == "")
            {
                System.Console.WriteLine("Intet navn angitt");
            }

            else
            {
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
               
        private void gjesteListe_MouseDown(object sender, MouseEventArgs e)
        {
            if (gjesteListe.Items.Count == 0)
                return;

            int index = gjesteListe.IndexFromPoint(e.X, e.Y);
            string gjesteListeNavn = gjesteListe.Items[index].ToString();
            DragDropEffects dragDropEvent = DoDragDrop(gjesteListeNavn, DragDropEffects.All);

            if (dragDropEvent == DragDropEffects.All)
            {
                gjesteListe.Items.RemoveAt(gjesteListe.IndexFromPoint(e.X, e.Y));
            }
           
        }

        private void gjesteListe_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                DragDropEffects dropEffect = gjesteListe.DoDragDrop(gjesteListe.Text, DragDropEffects.Move);
            }

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);
                listBox1.Items.Add(str);
            }

        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragOver listbox 1");
            e.Effect = DragDropEffects.All;
        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                label1.Text =(str);
            }
        }

        private void label1_DragOver(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragOver listbox 1");
            e.Effect = DragDropEffects.All;
        }
            
    }
}
