using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zajecia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dodaj_Click(object sender, EventArgs e)
        {
            wynik.Text = (Double.Parse(wart1.Text) + Double.Parse(wart2.Text)).ToString();
        }


        private void odejmij_Click(object sender, EventArgs e)
        {
            wynik.Text = (Double.Parse(wart1.Text) - Double.Parse(wart2.Text)).ToString();
        }

        private void pomnoz_Click(object sender, EventArgs e)
        {
            wynik.Text = (Double.Parse(wart1.Text) * Double.Parse(wart2.Text)).ToString();
        }

        private void podziel_Click(object sender, EventArgs e)
        {
            if (Double.Parse(wart1.Text) != 0) wynik.Text = (Double.Parse(wart1.Text) / Double.Parse(wart2.Text)).ToString();
            else wynik.Text = "Nie dziel przez 0!";
        }
    }
}