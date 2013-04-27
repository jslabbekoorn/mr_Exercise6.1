﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mr_Exercise6._1
{
    public partial class frmKlok : Form
    {

        Klok klok;

        public frmKlok()
        {
            InitializeComponent();
        }

        private void frmKlok_Load(object sender, EventArgs e)
        {
            klok = new Klok("Zwart", "Vierkant", 4, 4);    
        }

        private void btnPlusHour_Click(object sender, EventArgs e)
        {
            if (cboAmPm.Checked)
            {
                klok.Instellen24Uur(1);
                lblHour.Text = Convert.ToString(klok.ToonUren24());
            }
            else
            {
                klok.Instellen12Uur(1);
                lblHour.Text = Convert.ToString(klok.ToonUren12());
                lblAmPm.Text = klok.ToonAMPM();
            }
        }

        private void btnMinHour_Click(object sender, EventArgs e)
        {
            if (cboAmPm.Checked)
            {
                klok.Instellen24Uur(-1);
                lblHour.Text = Convert.ToString(klok.ToonUren24());
            }
            
            else
            {
                klok.Instellen12Uur(-1);
                lblHour.Text = Convert.ToString(klok.ToonUren12());
                lblAmPm.Text = klok.ToonAMPM();
            }

            if (cboAmPm.Checked)
            {
                if (klok.ToonUren24() <= 0)
                {
                    klok.Uren24 = 24;
                }
            }
            else
            {
                if (klok.ToonUren12() <= 1)
                {
                    klok.Uren12 = 13;
                }
            }
        }

        private void btnPlusMin_Click(object sender, EventArgs e)
        {
            klok.InstellenMinuut(1);
            lblMin.Text = Convert.ToString(klok.ToonMinuten());
        }

        private void btnMinMin_Click(object sender, EventArgs e)
        {
            klok.InstellenMinuut(-1);
            lblMin.Text = Convert.ToString(klok.ToonMinuten());

            if (klok.ToonMinuten() < 1)
            {
                klok.Minuten = 60;
            }
        }

        private void btnPlusSec_Click(object sender, EventArgs e)
        {
            klok.InstellenSeconde(1);
            lblSec.Text = Convert.ToString(klok.ToonSeconden());
        }

        private void btnMinSec_Click(object sender, EventArgs e)
        {
            klok.InstellenSeconde(-1);
            lblSec.Text = Convert.ToString(klok.ToonSeconden());

            if (klok.ToonSeconden() < 1)
            {
                klok.Seconden = 60;
            }

        }

        private void cboAmPm_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAmPm.Checked)
            {
                lblAmPm.Text = "";
            }
            else
            {
                lblAmPm.Text = klok.ToonAMPM();
            }
        }
    }
}
