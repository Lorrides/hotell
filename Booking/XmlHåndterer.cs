using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Booking
{
    class XmlHåndterer
    {
        public void leggTilNyGjest(string gjesteNavn, DateTime innsjekkDato, DateTime utsjekkDato)
        {
            try
            {
                XDocument doc = XDocument.Load("../../XML/nyGjest.XML");
                doc.Root.Add(
                    new XElement("gjest",
                    new XElement("gjestenavn", gjesteNavn)));
                    new XElement("innsjekkdato", innsjekkDato);
                    new XElement("utsjekkdato", utsjekkDato);
                doc.Save("../../XML/nyGjest.XML");               
            }
            catch (Exception f)
            {
                System.Windows.Forms.MessageBox.Show("Noe gikk galt:" + f.Message);
            }
        }

    }
}
