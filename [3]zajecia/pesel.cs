using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zajecia
{
    internal class pesel
    {
        private string sPesel;
        private char sex;
        private DateTime dateOfBirth;

        public pesel(string _sPesel)
        {
            sPesel = _sPesel;
            setSex();
            setDateOfBirth();
        }

        private void setSex()
        {
            int intVal = (int)Char.GetNumericValue(sPesel[9]);

            if (intVal % 2 == 0) sex = 'K';
            else sex = 'M';
        }

        private void setDateOfBirth()
        {
            int year = digitChar(sPesel[0]) * 10 + digitChar(sPesel[1]) + ((digitChar(sPesel[2]) / 2 + 1) % 5) * 100 + 1800;
            int month = (digitChar(sPesel[2]) % 2) * 10 + digitChar(sPesel[3]);
            int day = digitChar(sPesel[4]) * 10 + digitChar(sPesel[5]);
            dateOfBirth = new DateTime(year, month, day);
        }

        private int digitChar(char c) {
            return c - '0';
        }

        public void display()
        {
            Console.WriteLine($"data urodzenia: {dateOfBirth.ToString("dd.MM.yyyy")}");
            DateTime now = DateTime.Today;
            int age = now.Year - dateOfBirth.Year;
            if (dateOfBirth.AddYears(age) > now)
                age--;
            Console.WriteLine($"wiek: { age }");
            Console.WriteLine($"płeć: {sex}");
        }
    }
}
