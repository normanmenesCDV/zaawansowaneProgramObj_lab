using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk
{
    internal class Ustawienia
    {
        public enum EnumPoziomTrudnosci
        {
            Latwy,
            Sredni,
            Trudny,
            NieDotyczy
        }

        public enum EnumTypGry
        {
            ZKomputerem,
            Multiplayer
        }

        private EnumPoziomTrudnosci poziomTrudnosci;

        public EnumPoziomTrudnosci PoziomTrudnosci
        {
            get { return poziomTrudnosci; }
            set { poziomTrudnosci = value; }
        }

        private EnumTypGry typGry;

        public EnumTypGry TypGry
        {
            get { return typGry; }
            set { typGry = value; }
        }

        public Ustawienia(EnumTypGry typGry = EnumTypGry.ZKomputerem, EnumPoziomTrudnosci poziomTrudnosci = EnumPoziomTrudnosci.Latwy)
        {
            this.TypGry = typGry;
            this.PoziomTrudnosci = poziomTrudnosci;
        }
    }
}
