using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zajecia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "[2] zajęcia - Norman Menes, 27058";

            Console.Write("Podaj numer zadania: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    zadanie1();
                    break;
                case 2:
                    zadanie2();
                    break;
                case 3:
                    zadanie3();
                    break;
                default:
                    Console.WriteLine("Podano zły numer zadania!");
                    break;
            }
        }

        static void zadanie1()
        {
            Class1 c1 = new Class1(new[] { 1, 10, 100, 1000, 5000, 205, 7456, 4856 });
        }

        static void zadanie2()
        {
            Class2 c2 = new Class2(new[] { 1, 10, 100, 1000, 5000, 205, 7456, 4856 });
        }

        static void zadanie3()
        {
            Class3 c3 = new Class3(new[] { 1, 10, 100, 1000, 5000, 205, 7456, 4856 });
        }
    }
}