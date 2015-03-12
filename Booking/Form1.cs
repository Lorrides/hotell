using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Må overføres til XmlHåndterer 
        private void button1_Click(object sender, EventArgs e)
        {
            if (nameInputBox.Text != null)
            {
                try
                {
                    XDocument doc = XDocument.Load("../../XML/nyGjest.XML");
                    doc.Root.Add(
                        new XElement("gjest",
                        new XElement("gjestenavn", nameInputBox.Text)));
                    doc.Save("../../XML/nyGjest.XML");
                }
                catch (Exception f)
                {
                    MessageBox.Show("Noe gikk galt:" + f.Message);
                }
            }
        }

        // Må overføres til XmlHåndterer og opptadering på tick ikke button click
        private void button2_Click(object sender, EventArgs e)
        {
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
