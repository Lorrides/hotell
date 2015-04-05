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

            innsjekkDatoVelger.MinDate = DateTime.Today;
            utsjekkDatoVelger.MinDate = DateTime.Today.AddDays (1);

            int antallEtasjer = 3;
            int antallRomPerEtasje = 14;
            
            Hotell hotell = new Hotell(etasjeOversiktTabControl);

            for (int i = 0; i < antallEtasjer; i++)
            {
                hotell.AddEtasje();
                etasjeOversiktTabControl.TabPages[i].Controls.Add(new Button() { Text = "Jøss" });
                etasjeOversiktTabControl.TabPages[i].Controls.Add(new FlowLayoutPanel());              
            }

            int etasjeTeller = 0;

            foreach (Etasje etasje in hotell._etasjer)
            {                              
                for (int i = 1; i <= 3; i++)
                {                    
                    for (int j = 1; j <= 4; j++)
                    {
                        Panel a = new Panel();
                        a.Location = new Point(i * 200, j * 50);
                        a.Width = 180;
                        a.Height = 40;
                        a.Name = "Rom " + (((i * 4) - 3) + (j - 1));
                        a.BackColor = Color.Yellow;
                        a.AllowDrop = true;
                        // Setter opp hendelseshåndterere for DragOver og DragDrop
                         //a.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
                         //a.DragOver += new System.Windows.Forms.DragEventHandler(this.panel1_DragOver);
                        a.Visible = true;
                        // Legger til en label inne i panelet
                        Label l = new Label();
                        l.Location = new Point(10, 10);
                        l.Width = 180;
                        l.Text = a.Name;
                        a.Controls.Add(l);
                        // Legger panelet til form
                        etasjeOversiktTabControl.TabPages[etasjeTeller].Controls.Add(a);

                    }
                    
                }
                etasjeTeller++;
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
