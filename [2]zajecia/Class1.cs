using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zajecia
{
    internal class Class1
    {
        private const uint maxLiczbaElementow = 5;
        private uint aktualnyIndeks = 0;
        public uint AktualnyIndeks
        {
            get { return aktualnyIndeks; }
        }

        private int[] tab = new int[maxLiczbaElementow];
        public Class1(int[] _tab)
        {
            foreach (int element in _tab)
            {
                add(element);
            }
        }

        public void add(int nowaWartosc)
        {
            if (aktualnyIndeks >= maxLiczbaElementow)
            {
                Console.WriteLine("Błąd. Przekroczono pojemność tablicy.");
                return;
            }
            tab[aktualnyIndeks] = nowaWartosc;
            Console.WriteLine($"Dodano wartość! tab[{aktualnyIndeks}] = {nowaWartosc}");
            aktualnyIndeks++;
        }
    }
}
