namespace _3_zajecia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // należy przenieść katalog "attach" do lokalizacji: "Zaawansowane programowanie obiektowe\[3]zajecia\bin\Debug\net6.0\"
            Console.Title = "[3] zajęcia - Norman Menes, 27058";
           
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

            static void zadanie1()
            {
                const string text = "Dziś jest bardzo ładna pogoda. Musi to być udany dzień.";
                const string pathFileExport = @"attach\tekst1.txt";

                file f = new file();
                f.addTextToFile(text);
                f.saveFile(pathFileExport);
                f.readFile(pathFileExport);
            }

            static void zadanie2()
            {
                const string pathFileImport = @"attach\tekst2.txt";

                file f = new file();
                f.readFile(pathFileImport);
                f.writeToConsole();
            }

            static void zadanie3()
            {
                const string pathFileImport = @"attach\pesel.txt";

                file f = new file();
                f.readFile(pathFileImport);
                pesel p = new pesel(f.FileContent);
                p.display();
            }
        }
    }
}