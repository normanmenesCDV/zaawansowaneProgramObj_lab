using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zajecia
{
    internal class file
    {
        private string fileContent;
        public string FileContent { get { return fileContent; }}

        public file()
        {
        }

        public void readFile(string @pathFileImport)
        {
            String line;
            try
            {
                fileContent = null;
                StreamReader sr = new StreamReader(@pathFileImport);
                line = sr.ReadLine();
                while (line != null)
                {
                    fileContent += line;
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void saveFile(string @pathFileExport)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@pathFileExport);
                sw.WriteLine(fileContent);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void addTextToFile(string text)
        {
            fileContent += text;
        }

        public void writeToConsole()
        {
            Console.WriteLine(fileContent);
        }
    }
}
