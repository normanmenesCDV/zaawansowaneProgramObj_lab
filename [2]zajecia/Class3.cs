using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zajecia
{
    internal class Class3
    {
        private const uint maxLiczbaElementow = 5;
        private uint aktualnyIndeks = 0;
        public uint AktualnyIndeks
        {
            get { return aktualnyIndeks; }
        }

        private int[] tab = new int[maxLiczbaElementow];
        public Class3(int[] _tab)
        {
            foreach (int element in _tab)
            {
                add(element);
            }
        }

        public void add(int nowaWartosc)
        {
            try
            {
                tab[aktualnyIndeks] = nowaWartosc;
                Console.WriteLine($"Dodano wartość! tab[{aktualnyIndeks}] = {nowaWartosc}");
                aktualnyIndeks++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
