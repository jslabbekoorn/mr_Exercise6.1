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
            set {
                    if (value > 12 || value < 0)
                    {
                        if (value > 12)
                        {
                            intUren12 = 1;
                        }

                        if (value < 0)
                        {
                            intUren12 = 11;
                        }
                    }
                    else
                    {
                        intUren12 = value;
                    }
                }

            get { return intUren12; }
        }

        public int Uren24
        {
            set
            {
                if (value > 23 || value < 0)
                {
                    if (value > 23)
                    {
                        intUren24 = 0;
                    }

                    if (value < 0)
                    {
                        intUren24 = 23;
                    }
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
            set 
            {
                if (value > 59 || value < 0)
                {
                    if (value > 59)
                    {
                        intMinuten = 0;
                    }

                    if (value < 0)
                    {
                        intMinuten = 59;
                    }
                }
                else
                {
                    intMinuten = value;
                }
            }
            
            get { return intMinuten; }
        }

        public int Seconden
        {
            set
            {
                if (value > 59 || value < 0)
                {
                    if (value > 59)
                    {
                        intSeconden = 0;
                    }

                    if (value < 0)
                    {
                        intSeconden = 59;
                    }
                }
                else
                {
                    intSeconden = value;
                }
            }

            get { return intSeconden; }
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
            Uren12 += uren12;

            if (uren12 <= 12)
            {
                if (Uren12 > 12)
                {
                    Uren12 = Uren12 - 12;
                    strAMPM = "PM";
                }
            }
            else
            {
                Uren12 = 0;
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
            Minuten = Minuten + minuten;

            if (minuten < 60)
            {
                if (Minuten > 59)
                {
                    Minuten = Minuten - 60;
                }

            }
            else
            {
                Minuten = 0;
            }
        }

        public void InstellenSeconde(int seconde)
        {
            Seconden = Seconden + seconde;

            if (seconde < 60)
            {
                if (Seconden > 59)
                {
                    Seconden = Seconden - 60;
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
