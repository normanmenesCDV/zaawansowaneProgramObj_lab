using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk
{
    public partial class Form1 : Form
    {
        public enum EnumGracz
        {
            graczA,
            graczB
        };

        private EnumGracz czyjaKolej = EnumGracz.graczA;

        private char graczA = 'X';
        private char graczB = 'O';
        private char[] plansza;
        private Ustawienia ustawienia;
        private Wyniki wyniki;

        public Form1()
        {
            InitializeComponent();
            ustawienia = new Ustawienia();
            wyniki = new Wyniki();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            resetujGre();

        }

        #region PROGRAM
        #region program-menu
        private void buttonHomeGraj_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
            resetujGre();
        }

        private void buttonHomeUstawienia_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }

        private void buttonHomeTabelaWynikow_Click(object sender, EventArgs e)
        {
            label7.Text = wyniki.LiczbaPunktowGraczaA.ToString();
            label8.Text = wyniki.LiczbaPunktowGraczaB.ToString();
            tabControl1.SelectTab(tabPage4);
        }
        #endregion

        #region program-ustawienia
        private void radioButtonZKomputerem_CheckedChanged(object sender, EventArgs e)
        {
            ustawienia.TypGry = Ustawienia.EnumTypGry.ZKomputerem;
            radioButtonLatwy.Checked = true;
            ustawienia.PoziomTrudnosci = Ustawienia.EnumPoziomTrudnosci.Latwy;
            groupBoxPoziomTrudnosci.Visible = radioButtonZKomputerem.Checked;
        }

        private void radioButtonMultiplayer_CheckedChanged(object sender, EventArgs e)
        {
            ustawienia.TypGry = Ustawienia.EnumTypGry.Multiplayer;
            ustawienia.PoziomTrudnosci = Ustawienia.EnumPoziomTrudnosci.NieDotyczy;
            groupBoxPoziomTrudnosci.Visible = radioButtonZKomputerem.Checked;
        }
        private void radioButtonLatwy_CheckedChanged(object sender, EventArgs e)
        {
            ustawienia.PoziomTrudnosci = Ustawienia.EnumPoziomTrudnosci.Latwy;
        }

        private void radioButtonSredni_CheckedChanged(object sender, EventArgs e)
        {
            ustawienia.PoziomTrudnosci = Ustawienia.EnumPoziomTrudnosci.Sredni;
        }

        private void radioButtonTrudny_CheckedChanged(object sender, EventArgs e)
        {
            ustawienia.PoziomTrudnosci = Ustawienia.EnumPoziomTrudnosci.Trudny;
        }

        #endregion

        #region program-wyniki
        private void button10_Click(object sender, EventArgs e)
        {
            wyniki.ResetujWyniki();
            label7.Text = wyniki.LiczbaPunktowGraczaA.ToString();
            label8.Text = wyniki.LiczbaPunktowGraczaB.ToString();
        }
        #endregion

        #region program-sterowaniePoProgramie
        private void pictureBox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }
        #endregion
        #endregion

        #region GRA
        #region gra-sterowanie
        private void resetujGre()
        {
            plansza = new char[9];
            for (int i = 0; i < 9; i++)
            {
                plansza[i] = ' ';
            }

            aktualizujPrzyciski();

            czyjaKolej = EnumGracz.graczA;
            switch (ustawienia.TypGry)
            {
                case Ustawienia.EnumTypGry.ZKomputerem:
                    label1.Text = "Ruch gracza";
                    break;
                case Ustawienia.EnumTypGry.Multiplayer:
                    label1.Text = "Ruch gracza A";
                    break;
            }

            progressBar1.Visible = false;
        }

        private void aktualizujPrzyciski()
        {
            button1.Text = plansza[0].ToString();
            button2.Text = plansza[1].ToString();
            button3.Text = plansza[2].ToString();
            button4.Text = plansza[3].ToString();
            button5.Text = plansza[4].ToString();
            button6.Text = plansza[5].ToString();
            button7.Text = plansza[6].ToString();
            button8.Text = plansza[7].ToString();
            button9.Text = plansza[8].ToString();
        }

        private void zmienKolejGracza()
        {
            switch (czyjaKolej)
            {
                case EnumGracz.graczA:
                    czyjaKolej = EnumGracz.graczB;
                    switch (ustawienia.TypGry)
                    {
                        case Ustawienia.EnumTypGry.ZKomputerem:
                            label1.Text = "Ruch komputera";
                            break;
                        case Ustawienia.EnumTypGry.Multiplayer:
                            label1.Text = "Ruch gracza B";
                            break;
                    }
                    break;
                case EnumGracz.graczB:
                    czyjaKolej = EnumGracz.graczA;
                    switch (ustawienia.TypGry)
                    {
                        case Ustawienia.EnumTypGry.ZKomputerem:
                            label1.Text = "Ruch gracza";
                            break;
                        case Ustawienia.EnumTypGry.Multiplayer:
                            label1.Text = "Ruch gracza A";
                            break;
                    }
                    break;
            }
        }
        #endregion

        #region gra-ruch
        private void wykonajRuchGraczaA(int pole)
        {
            if (plansza[pole] == ' ')
            {
                plansza[pole] = graczA;
                aktualizujPrzyciski();

                bool koniecGry = sprawdzCzyKoniecGry();
                if (koniecGry) return;

                zmienKolejGracza();
                if (ustawienia.TypGry == Ustawienia.EnumTypGry.ZKomputerem) wykonajRuchGraczaB(-1);
            }
        }

        private void wykonajRuchGraczaB(int pole)
        {
            switch (ustawienia.TypGry)
            {
                case Ustawienia.EnumTypGry.ZKomputerem:
                    {
                        progressBar1.Value = 0;
                        progressBar1.Visible = true;
                        pokazPseudoMyslenieKomputera();

                        int ruch;

                        switch (ustawienia.PoziomTrudnosci)
                        {
                            case Ustawienia.EnumPoziomTrudnosci.Latwy:
                                ruch = losowyRuch();
                                break;
                            case Ustawienia.EnumPoziomTrudnosci.Sredni:
                                ruch = znajdzRuchSredni();
                                break;
                            case Ustawienia.EnumPoziomTrudnosci.Trudny:
                                ruch = ZnajdzRuchTrudny();
                                break;
                            default:
                                return;
                        }

                        plansza[ruch] = graczB;
                        aktualizujPrzyciski();

                        bool koniecGry = sprawdzCzyKoniecGry();
                        if (koniecGry) return;

                        progressBar1.Visible = false;
                        break;
                    }
                case Ustawienia.EnumTypGry.Multiplayer:
                    if (plansza[pole] == ' ')
                    {
                        plansza[pole] = graczB;
                        aktualizujPrzyciski();

                        bool koniecGry = sprawdzCzyKoniecGry();
                        if (koniecGry) return;
                    }
                    break;
            }
            zmienKolejGracza();
        }

        private void button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button przycisk = (System.Windows.Forms.Button)sender;
            int pole = Convert.ToInt32(przycisk.Tag);

            switch (czyjaKolej)
            {
                case EnumGracz.graczA:
                    wykonajRuchGraczaA(pole);
                    break;
                case EnumGracz.graczB:
                    wykonajRuchGraczaB(pole);
                    break;
            }
        }
        #endregion

        #region gra-wyborKomputera
        private void pokazPseudoMyslenieKomputera()
        {
            int totalTime = 3000;
            int updateInterval = 50;

            int progress = 0;
            int increment = (int)Math.Ceiling(100.0 / (totalTime / updateInterval));

            while (progress < 100)
            {
                progress += increment;
                if (progress > 100)
                    progress = 100;

                progressBar1.Value = progress;
                Task.Delay(updateInterval).Wait();
            }
        }

        private int losowyRuch()
        {
            Random losowa = new Random();
            int ruch;

            do
            {
                ruch = losowa.Next(0, 9);
            }
            while (plansza[ruch] != ' ');

            return ruch;
        }

        private int znajdzRuchSredni()
        {
            // SprawdŸ, czy mo¿emy wygraæ
            for (int i = 0; i < 9; i++)
            {
                if (plansza[i] == ' ')
                {
                    plansza[i] = graczB;
                    if (sprawdzCzyWygrana(graczB))
                    {
                        plansza[i] = ' ';
                        return i;
                    }
                    plansza[i] = ' ';
                }
            }

            // SprawdŸ, czy przeciwnik mo¿e wygraæ
            for (int i = 0; i < 9; i++)
            {
                if (plansza[i] == ' ')
                {
                    plansza[i] = graczA;
                    if (sprawdzCzyWygrana(graczA))
                    {
                        plansza[i] = ' ';
                        return i;
                    }
                    plansza[i] = ' ';
                }
            }

            // Wykonaj ruch œrodkowy
            if (plansza[4] == ' ')
            {
                return 4;
            }

            // Wykonaj ruch w pobli¿u istniej¹cego symbolu
            int[] preferredMoves = { 0, 2, 6, 8 };

            foreach (int move in preferredMoves)
            {
                if (plansza[move] == ' ')
                {
                    return move;
                }
            }

            // Wykonaj dowolny dostêpny ruch
            for (int i = 0; i < 9; i++)
            {
                if (plansza[i] == ' ')
                {
                    return i;
                }
            }

            return -1; // Ten kod nie zostanie osi¹gniêty, ale kompilator wymaga zwrotu wartoœci
        }

        private int ZnajdzRuchTrudny()
        {
            int najlepszyRuch = -1;
            int najlepszyWynik = int.MinValue;

            for (int i = 0; i < 9; i++)
            {
                if (plansza[i] == ' ')
                {
                    plansza[i] = graczB;
                    int wynik = Minimax(0, false);
                    plansza[i] = ' ';

                    if (wynik > najlepszyWynik)
                    {
                        najlepszyWynik = wynik;
                        najlepszyRuch = i;
                    }
                }
            }
            return najlepszyRuch;
        }

        private int Minimax(int depth, bool isMaximizingPlayer)
        {
            if (sprawdzCzyWygrana(graczA))
            {
                return -10 + depth;
            }
            else if (sprawdzCzyWygrana(graczB))
            {
                return 10 - depth;
            }
            else if (sprawdzCzyPlanszaPelna())
            {
                return 0;
            }

            if (isMaximizingPlayer)
            {
                int bestScore = int.MinValue;

                for (int i = 0; i < 9; i++)
                {
                    if (plansza[i] == ' ')
                    {
                        plansza[i] = graczB;
                        int score = Minimax(depth + 1, false);
                        plansza[i] = ' ';
                        bestScore = Math.Max(score, bestScore);
                    }
                }

                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;

                for (int i = 0; i < 9; i++)
                {
                    if (plansza[i] == ' ')
                    {
                        plansza[i] = graczA;
                        int score = Minimax(depth + 1, true);
                        plansza[i] = ' ';
                        bestScore = Math.Min(score, bestScore);
                    }
                }

                return bestScore;
            }
        }
        #endregion

        #region gra-sprawdzaniePlanszy
        private bool sprawdzCzyPlanszaPelna()
        {
            foreach (char pole in plansza)
            {
                if (pole == ' ')
                {
                    return false;
                }
            }

            return true;
        }

        private bool sprawdzCzyKoniecGry()
        {
            if (czyjaKolej == EnumGracz.graczA && sprawdzCzyWygrana(graczA))
            {
                switch (ustawienia.TypGry)
                {
                    case Ustawienia.EnumTypGry.ZKomputerem:
                        MessageBox.Show("Wygra³eœ!");
                        break;
                    case Ustawienia.EnumTypGry.Multiplayer:
                        MessageBox.Show("Wygra³ gracz A!");
                        break;
                }
                wyniki.DodajPunkt(EnumGracz.graczA);
                resetujGre();
                return true;
            }

            else if (czyjaKolej == EnumGracz.graczB && sprawdzCzyWygrana(graczB))
            {
                switch (ustawienia.TypGry)
                {
                    case Ustawienia.EnumTypGry.ZKomputerem:
                        MessageBox.Show("Wygra³ komputer!");
                        break;
                    case Ustawienia.EnumTypGry.Multiplayer:
                        MessageBox.Show("Wygra³ gracz B!");
                        break;
                }
                wyniki.DodajPunkt(EnumGracz.graczB);
                resetujGre();
                return true;
            }

            else if (sprawdzCzyPlanszaPelna())
            {
                MessageBox.Show("Remis!");
                resetujGre();
                return true;
            }
            return false;
        }

        private bool sprawdzCzyWygrana(char symbol)
        {
            return (
                (plansza[0] == symbol && plansza[1] == symbol && plansza[2] == symbol) ||
                (plansza[3] == symbol && plansza[4] == symbol && plansza[5] == symbol) ||
                (plansza[6] == symbol && plansza[7] == symbol && plansza[8] == symbol) ||
                (plansza[0] == symbol && plansza[3] == symbol && plansza[6] == symbol) ||
                (plansza[1] == symbol && plansza[4] == symbol && plansza[7] == symbol) ||
                (plansza[2] == symbol && plansza[5] == symbol && plansza[8] == symbol) ||
                (plansza[0] == symbol && plansza[4] == symbol && plansza[8] == symbol) ||
                (plansza[2] == symbol && plansza[4] == symbol && plansza[6] == symbol)
                );
        }

        #endregion
        #endregion

    }
}
