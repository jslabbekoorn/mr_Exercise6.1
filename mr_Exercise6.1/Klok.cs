using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr_Exercise6._1
{
    public class Klok
    {
        private string strKleur;
        private string strVorm;
        private int intHoogte;
        private int intBreedte;
        private int intUren12;
        private int intUren24;
        private int intMinuten;
        private int intSeconden;
        private string strAMPM;

        public Klok(string strKleur, string strVorm, int intHoogte, int intBreedte)
        {
            this.strKleur = strKleur;
            this.strVorm = strVorm;
            this.intHoogte = intHoogte;
            this.intBreedte = intBreedte;
            this.strAMPM = "AM";
            this.Uren12 = intUren12;
            this.Uren24 = intUren24;
            this.Minuten = intMinuten;
            this.Seconden = intSeconden;
        }

        public int Uren12
        {
            set { intUren12 = value; }
        }

        public int Uren24
        {
            set
            {
                if (value > 23 || value < 0)
                {
                    intUren24 = 0;
                }
                else
                {
                    intUren24 = value;
                }
            }
            get { return intUren24; }
        }


        public int Minuten
        {
            set { intMinuten = value; }
        }

        public int Seconden
        {
            set { intSeconden = value; }
        }

        public string KlokSlag()
        {
            string strBoodschap = "";

            if (intMinuten == 0 && intSeconden == 0)
            {
                strBoodschap = "BIM! BAM!";
            }

            return strBoodschap;
        }


        public void Instellen12Uur(int uren12)
        {
            intUren12 += uren12;

            if (uren12 <= 12)
            {
                if (intUren12 > 12)
                {
                    intUren12 = intUren12 - 12;
                    strAMPM = "PM";
                }
            }
            else
            {
                intUren12 = 0;
            }
        }


        public void Instellen24Uur(int uren24)
        {
            Uren24 += uren24;

            if (uren24 <= 24)
            {
                if (Uren24 > 24)
                {
                    Uren24 = Uren24 - 24;
                }
            }
            else
            {
                Uren24 = 0;
            }
        }


        public void InstellenMinuut(int minuten)
        {
            intMinuten = intMinuten + minuten;

            if (minuten < 60)
            {
                if (intMinuten > 59)
                {
                    intMinuten = intMinuten - 60;
                }

            }
            else
            {
                intMinuten = 0;
            }
        }

        public void InstellenSeconde(int seconde)
        {
            intSeconden = intSeconden + seconde;

            if (seconde < 60)
            {
                if (intSeconden > 59)
                {
                    intSeconden = intSeconden - 60;
                }

            }
            else
            {
                intSeconden = 0;
            }
        }

        public int ToonUren12()
        {
            return intUren12;
        }

        public int ToonUren24()
        {
            return Uren24;
        }

        public int ToonMinuten()
        {
            return intMinuten;
        }

        public int ToonSeconden()
        {
            return intSeconden;
        }

        public string ToonAMPM()
        {
            return strAMPM;
        }
    }
}
