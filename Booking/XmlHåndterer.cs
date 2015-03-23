﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    new XElement("gjestenavn", gjesteNavn),
                    new XElement("innSjekkDato", innsjekkDato.ToString("d", System.Globalization.CultureInfo.InvariantCulture)),
                    new XElement("utSjekkDato", utsjekkDato.ToString("d", System.Globalization.CultureInfo.InvariantCulture))));
                doc.Save("../../XML/nyGjest.XML");               
            }
            catch (Exception f)
            {
                System.Windows.Forms.MessageBox.Show("Noe gikk galt:" + f.Message);
            }
        }

        public void oppdaterGjesteListeFraXML(ListBox gjesteListe)
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
