using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjektGrafy
{
    class LoadGraf
    {
        List<int> LeweWierzcholki = new List<int>();
        List<int> PraweWierzcholki = new List<int>();
        private int sumaGrafu = 0; //suma w pierwszym wierszu

        int verticalTabLength; //ilość kolumn tablicy
        public int VerticalTabLength { //pozioma długość (liczba kolumn)
            get { return verticalTabLength; }
            set {
                verticalTabLength = value;
            }
        }

        int horizontalTabLength; //pionowa długość (liczba wierszy)
        public int HorizontalTabLength {
            get { return horizontalTabLength; }
            set { horizontalTabLength = value;} 
        }

        public int[,] macierz; //macierz grafu

        public bool CheckGraf() //sprawdzanie, czy wszystkie wiersze macierzy sa tej samej długości
        {
            if (VerticalTabLength != HorizontalTabLength)
            {
                System.Windows.Forms.MessageBox.Show("To nie jest macierz grafu!");
                return false;
            }
            else
                return true;
        }

        public void CreateTab(StreamReader Sr) //Tworzenie tablicy do której następnie załadujemy naszą macierz grafu
        {
            string line;

            int temp = 0;

            while ((line = Sr.ReadLine()) != null)
            {
                var wiersz = line.Split(new char[] { '\t' });
                this.VerticalTabLength = wiersz.Length;
                temp++;
            }

            HorizontalTabLength = temp;
            macierz = new int[temp, this.VerticalTabLength];
        }

        public bool LoadDatebase(StreamReader Sr) //ładujemy bazę danych do listy
        {
            string line;

            int temp = 0; //liczba wierszy macierzy
            bool macierzZer = false;
            
            try
            {
                while ((line = Sr.ReadLine()) != null)
                {
                    var wiersz = line.Split(new char[] { '\t' });
                    this.VerticalTabLength = wiersz.Length;

                    for (int j = 0; j < this.VerticalTabLength; j++)
                    {
                        if (Convert.ToInt32(wiersz[j]) == 1)
                        {
                            macierzZer = true;
                        }
                        if (Convert.ToInt32(wiersz[j]) < 0)
                        {
                            return false;
                        }

                        if (temp == 0) //rozdziela wierzchołki na lewą i prawą część grafu
                        {
                            if (Convert.ToInt32(wiersz[j]) == 1)
                            {
                                LeweWierzcholki.Add(j);
                                sumaGrafu++;
                            }
                            else if (Convert.ToInt32(wiersz[j]) == 0)
                                PraweWierzcholki.Add(j);

                        }

                        macierz[temp, j] = Convert.ToInt32(wiersz[j]);
                    }
                    temp++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Niepoprawne dane wejściowe. Wybierz poprawny plik");
            }
            return macierzZer;
        }

        public string WriteOnLine(int lineIndex) //wyświetlanie jednego wiersza naszej macierzy (lineIndex - index wiersza)
        {
            string line = "";
            for (int i = 0; i < this.VerticalTabLength; i++)
            {
                line += macierz[lineIndex, i].ToString() + " ";
            }
            return line;
        }

        public bool SortGraf(int i)
        {
            if (macierz[0, i] == 1)
                return true;
            else
                return false;
        }

        public bool CheckThatGrafIsDwudzielnyPelny()
        {
            int temp;
            for (int i = 0; i < HorizontalTabLength; i++)
            {
                temp = 0;
                foreach (var item in LeweWierzcholki)
                {
                    if (item == i)
                    {
                        for (int j = 0; j < VerticalTabLength; j++)
                        {
                            temp += macierz[i, j];
                        }
                    }
                }

                if (macierz[i,0] == 1)
                {
                    if ((VerticalTabLength - sumaGrafu) != temp)
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < HorizontalTabLength; i++)
            {
                temp = 0;
                foreach (var item in PraweWierzcholki)
                {
                    if (item == i)
                    {
                        for (int j = 0; j < VerticalTabLength; j++)
                        {
                            temp += macierz[i, j];
                        }
                    }
                }

                if (macierz[i, 0] == 0)
                {
                    if (sumaGrafu != temp)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
