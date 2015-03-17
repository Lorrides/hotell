﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Booking
{
    class XmlHåndterer
    {
        public void leggTilNyGjest(string gjesteNavn)
        {
            try
            {
                XDocument doc = XDocument.Load("../../XML/nyGjest.XML");
                doc.Root.Add(
                    new XElement("gjest",
                    new XElement("gjestenavn", gjesteNavn)));
                doc.Save("../../XML/nyGjest.XML");               
            }
            catch (Exception f)
            {
                System.Windows.Forms.MessageBox.Show("Noe gikk galt:" + f.Message);
            }
        }

    }
}
