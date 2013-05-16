using System;
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
                lblHour.Text = Convert.ToString(klok.Uren24);
            }
            else
            {
                klok.Instellen12Uur(1);
                lblHour.Text = Convert.ToString(klok.Uren12);
                lblAmPm.Text = klok.ToonAMPM();
            }
        }

        private void btnMinHour_Click(object sender, EventArgs e)
        {
            if (cboAmPm.Checked)
            {
                klok.Instellen24Uur(-1);
                lblHour.Text = Convert.ToString(klok.Uren24);

                if (klok.Uren24 <= 0)
                {
                    klok.Uren24 = 24;
                }
            }
            
            else
            {
                klok.Instellen12Uur(-1);
                lblHour.Text = Convert.ToString(klok.Uren12);
                lblAmPm.Text = klok.ToonAMPM();

                if (klok.Uren12 <= 1)
                {
                    klok.Uren12 = 13;
                }
            }
        }

        private void btnPlusMin_Click(object sender, EventArgs e)
        {
            klok.InstellenMinuut(1);
            lblMin.Text = Convert.ToString(klok.Minuten);

            if (klok.KlokSlag() != "")
            {
                MessageBox.Show(klok.KlokSlag());
            }
            
        }

        private void btnMinMin_Click(object sender, EventArgs e)
        {
            klok.InstellenMinuut(-1);
            lblMin.Text = Convert.ToString(klok.Minuten);

            if (klok.Minuten < 1)
            {
                klok.Minuten = 60;
            }

            if (klok.KlokSlag() != "")
            {
                MessageBox.Show(klok.KlokSlag());
            }
        }

        private void btnPlusSec_Click(object sender, EventArgs e)
        {
            klok.InstellenSeconde(1);
            lblSec.Text = Convert.ToString(klok.Seconden);

            if (klok.KlokSlag() != "")
            {
                MessageBox.Show(klok.KlokSlag());
            }
        }

        private void btnMinSec_Click(object sender, EventArgs e)
        {
            klok.InstellenSeconde(-1);
            lblSec.Text = Convert.ToString(klok.Seconden);

            if (klok.Seconden < 1)
            {
                klok.Seconden = 60;
            }

            if (klok.KlokSlag() != "")
            {
                MessageBox.Show(klok.KlokSlag());
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
