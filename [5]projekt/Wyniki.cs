using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk
{
    internal class Wyniki
    {
        private int liczbaPunktowGraczaA;
        public int LiczbaPunktowGraczaA { get { return liczbaPunktowGraczaA; } }

        private int liczbaPunktowGraczaB;
        public int LiczbaPunktowGraczaB { get { return liczbaPunktowGraczaB; } }

        public Wyniki()
        {
            liczbaPunktowGraczaA = 0;
            liczbaPunktowGraczaB = 0;
        }

        public void DodajPunkt(Form1.EnumGracz gracz)
        {
            switch (gracz)
            {
                case Form1.EnumGracz.graczA:
                    liczbaPunktowGraczaA++;
                    break;
                case Form1.EnumGracz.graczB:
                    liczbaPunktowGraczaB++;
                    break;
            }
        }

        public void ResetujWyniki()
        {
            liczbaPunktowGraczaA = 0;
            liczbaPunktowGraczaB = 0;
        }
    }
}
