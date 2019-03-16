using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class BasicCalculator : Form
    {

        int wynik = 0;
        int wartosc = 0;
        string dzialanie = "";

        public BasicCalculator()
        {
            InitializeComponent();
            txtWynik.Text = wynik.ToString();
        }

        private void btnPrzycisk7_Click(object sender, EventArgs e)
        {
            txtWynik.Text = "7";
            wartosc = 7;
        }

        private void btnPrzycisk0_Click(object sender, EventArgs e)
        {
            txtWynik.Text = "0";
            wartosc = 0;
        }

        private void btnPrzycisk1_Click(object sender, EventArgs e)
        {
            txtWynik.Text = "1";
            wartosc = 1;
            
        }

        private void btnPrzycisk2_Click(object sender, EventArgs e)
        {
            txtWynik.Text = "2";
            wartosc = 2;
        }

        private void btnPrzycisk3_Click(object sender, EventArgs e)
        {
            txtWynik.Text = "3";
            wartosc = 3;
        }

        private void btnPrzycisk4_Click(object sender, EventArgs e)
        {
            txtWynik.Text = "4";
            wartosc = 4;
        }

        private void btnPrzycisk5_Click(object sender, EventArgs e)
        {
            txtWynik.Text = "5";
            wartosc = 5;
        }

        private void btnPrzycisk6_Click(object sender, EventArgs e)
        {
            txtWynik.Text = "6";
            wartosc = 6;
        }

        private void btnPrzycisk8_Click(object sender, EventArgs e)
        {
            txtWynik.Text = "8";
            wartosc = 8;
        }

        private void btnPrzycisk9_Click(object sender, EventArgs e)
        {
            txtWynik.Text = "9";
            wartosc = 9;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dzialanie = "dodawanie";
            PokazWynik();
        }

        private void btnOdejmij_Click(object sender, EventArgs e)
        {
            dzialanie = "odejmowanie";
            PokazWynik();
        }

        private void btnPomnoz_Click(object sender, EventArgs e)
        {
            dzialanie = "mnozenie";
            wartosc = 1;
            PokazWynik();
        }

        private void btnPodziel_Click(object sender, EventArgs e)
        {
            dzialanie = "dzielenie";
            wartosc = 1;
            PokazWynik();
        }

        private void btnWynik_Click(object sender, EventArgs e)
        {
            PokazWynik();
        }

        private void PokazWynik()
        {
            
            switch (dzialanie)
            {
                case "dodawanie":
                    wynik  += wartosc;
                    break;
                case "odejmowanie":
                    wynik -= wartosc;
                    break;
                case "mnozenie":
                    wynik = Convert.ToInt16(txtWynik.Text);
                    wynik *= wartosc;
                    break;
                case "dzielenie":
                    wynik = Convert.ToInt16(txtWynik.Text);
                    wynik += wartosc;
                    break;
                default:
                    break;
            }
            wartosc = 0;
            txtWynik.Text = wynik.ToString();
        }

      
    }
}
