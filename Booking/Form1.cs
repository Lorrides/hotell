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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameInputBox.Text == "")
            {
                System.Console.WriteLine("Intet navn angitt");
            }
            
            else {
                    gjesteListe.Items.Clear();
                    XmlHåndterer xh = new XmlHåndterer();
                    xh.leggTilNyGjest(nameInputBox.Text);

                    XDocument ListBoxOptions = XDocument.Load("../../XML/nyGjest.XML");
                    foreach (XElement element in ListBoxOptions.Root.Elements())
                    {
                        if (element.Name.LocalName.Contains("gjest"))
                        {
                            foreach (XElement subelement in element.Elements())
                            {
                                if (subelement.Name.LocalName.Contains("gjestenavn"))
                                {
                                    gjesteListe.Items.Add(element.Value.ToString());
                                }
                            }
                        }
                    }
            }
        }      
    }
}
