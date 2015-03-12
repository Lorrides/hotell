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

        private void button1_Click(object sender, EventArgs e)
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
}
