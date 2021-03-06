﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Booking;

namespace WebBooking
{
    public partial class Default : System.Web.UI.Page
    {
        public DateTime innsjekkDato;
        public DateTime utsjekkDato;
        public string   gjesteNavn;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void Calendar1_SelectionChanged(object sender, EventArgs e)
        {        
        }

        public void Calendar2_SelectionChanged(object sender, EventArgs e)
        {      
        }

        protected void GodkjennKnapp_Click(object sender, EventArgs e)
        {
            gjesteNavn = NavnInputTextBox.Text;
            innsjekkDato = Calendar1.SelectedDate;
            utsjekkDato = Calendar2.SelectedDate;
            XmlHåndterer xh = new XmlHåndterer();

            xh.leggTilNyGjest(gjesteNavn, innsjekkDato, utsjekkDato);

            Response.Redirect(Request.RawUrl);

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < DateTime.Today)
            {
                e.Day.IsSelectable = false;
                e.Cell.Enabled = false;
            }
        }

        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < DateTime.Now)
            {
                e.Day.IsSelectable = false;
                e.Cell.Enabled = false;
            }
        }
    }
}