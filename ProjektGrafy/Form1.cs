using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektGrafy
{
    public partial class Form1 : Form
    {

        LoadGraf macierz; //deklaracja macierzy

        public Form1()
        {
            InitializeComponent(); 
            loadGrafButton.Enabled = true;
            checkGrafButton.Enabled = false;
        }

        private void loadGrafButton_Click(object sender, EventArgs e)
        {
            macierz = new LoadGraf();
            ClearLabel();

            loadGrafButton.Enabled = false;
            checkGrafButton.Enabled = true;

            checkGrafButton.Enabled = false;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                macierz.CreateTab(sr); //tworzy tablicę do zapisau macierzy
                sr.Close();
                System.IO.StreamReader Sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                if (macierz.LoadDatebase(Sr))
                {
                    debugLogLabel.Text += "Załadowano dane macierzy do tabeli \n"; //log
                    checkGrafButton.Enabled = true;
                    grafLabel.Enabled = true;
                    rightPartLabel.Enabled = true;
                    leftPartLabel.Enabled = true;
                    label4.Enabled = true;
                }
                else
                {
                    debugLogLabel.Text += "Macierz niepoprawna \n"; //log
                    debugLogLabel.Text += "Wybierz poprawny plik z macierzą \n"; //log
                    checkGrafButton.Enabled = false;
                    loadGrafButton.Enabled = true;
                    grafLabel.Enabled = false;
                    rightPartLabel.Enabled = false;
                    leftPartLabel.Enabled = false;
                    label4.Enabled = false;
                }
            }
            else
            {
                debugLogLabel.Text += "Nie wybrano pliku \n"; //log
                debugLogLabel.Text += "Musisz wybrać plik \n"; //log
                loadGrafButton.Enabled = true;
            }

            grafLabel.Text = ""; //panel wyświetlający graf
            for (int i = 0; i < macierz.HorizontalTabLength; i++) //pentla do wyświetlania grafu
            {
                grafLabel.Text += macierz.WriteOnLine(i) + "\n"; //funkcja wyświetla jedną macierz grafu
            }

            if (!macierz.CheckGraf()) //sprawdza, czy załadowane dane, to macierz
            {
                checkGrafButton.Enabled = false;  
                debugLogLabel.Text += "Macierz jest niepoprawna \n"; //log
            }

            for (int i = 1; i <= macierz.VerticalTabLength; i++)
            {
                if (macierz.SortGraf(i - 1))
                    leftPartLabel.Text += i.ToString() + "\n"; //wypisuje lewe wierzchołki macierzy
                else
                    rightPartLabel.Text += i.ToString() + "\n"; //wypisuje prawe wierzchołki macierzy
            }
        }

        private void checkGrafButton_Click(object sender, EventArgs e)
        {
            loadGrafButton.Enabled = true;
            checkGrafButton.Enabled = false;

            if (macierz.CheckThatGrafIsDwudzielnyPelny())
            {
                grafIsDwudzielnyCheckBox.Checked = true;
                groupBox1.BackColor = Color.Green;
                debugLogLabel.Text += "Graf dwudzielny jest pełny \n"; //log
            }
            else
            {
                debugLogLabel.Text += "Graf dwudzielny nie jest pełny \n"; //log
                groupBox1.BackColor = Color.Red;
            }
        }

        public void ClearLabel()
        {
            leftPartLabel.Text = ""; //czyści etykietę
            rightPartLabel.Text = ""; //czyści etykietę
            debugLogLabel.Text = ""; //czyści log
            grafIsDwudzielnyCheckBox.Checked = false;
            groupBox1.BackColor = Color.Gray;
        }
    }
}
