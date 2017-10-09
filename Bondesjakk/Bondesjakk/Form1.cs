using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bondesjakk
{
    public partial class Form1 : Form
    {
        int spiller;
        const int maksAntallTrekk = 9;
        int antallTrekk = maksAntallTrekk;

        public Form1()
        {
            InitializeComponent();
        }

        // Når programmet lastes - Presenteres ett valg der det bestemmes hvilken av spuillerene so skal starte.
        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult svar = MessageBox.Show("Ønsker du at X skal begynne?", "Bekreft!", MessageBoxButtons.YesNo);
            if (svar == DialogResult.Yes)
                spiller = 1;
            else
                spiller = 2;
        }

        // Ved hvert trykk i spillflaten kjøres rutinen play_Click
        private void play_Click(object sender, EventArgs e)
        {
            // Styrer plassering og skifter tur for spiller
            // (annenhver X og O
            Button b = sender as Button;

            if (b.Text == "")
            {
                antallTrekk--;
                if (spiller == 1)
                {
                    b.Text = "X";
                    spiller = 2;
                }
                else
                {
                    b.Text = "O";
                    spiller = 1;
                }
                b.Enabled = false;
            }

            // Lager logiske uttrykk for å detektere om det er 3 på rad i en av
            // av de 8 mulighetene for hver spiller  
            bool x1 = (b11.Text == "X") & (b12.Text == "X") & (b13.Text == "X");
            bool x2 = (b21.Text == "X") & (b22.Text == "X") & (b23.Text == "X");
            bool x3 = (b31.Text == "X") & (b32.Text == "X") & (b33.Text == "X");
            bool x4 = (b11.Text == "X") & (b21.Text == "X") & (b31.Text == "X");
            bool x5 = (b12.Text == "X") & (b22.Text == "X") & (b32.Text == "X");
            bool x6 = (b13.Text == "X") & (b23.Text == "X") & (b33.Text == "X");
            bool x7 = (b11.Text == "X") & (b22.Text == "X") & (b33.Text == "X");
            bool x8 = (b13.Text == "X") & (b22.Text == "X") & (b31.Text == "X");
            // x er sann hvis det er 3 x'er på rad, ellers usann
            bool x = x1 | x2 | x3 | x4 | x5 | x6 | x7 | x8;

            bool o1 = (b11.Text == "O") & (b12.Text == "O") & (b13.Text == "O");
            bool o2 = (b21.Text == "O") & (b22.Text == "O") & (b23.Text == "O");
            bool o3 = (b31.Text == "O") & (b32.Text == "O") & (b33.Text == "O");
            bool o4 = (b11.Text == "O") & (b21.Text == "O") & (b31.Text == "O");
            bool o5 = (b12.Text == "O") & (b22.Text == "O") & (b32.Text == "O");
            bool o6 = (b13.Text == "O") & (b23.Text == "O") & (b33.Text == "O");
            bool o7 = (b11.Text == "O") & (b22.Text == "O") & (b33.Text == "O");
            bool o8 = (b13.Text == "O") & (b22.Text == "O") & (b31.Text == "O");
            // 0 er sann hvis det er 3 o'er på rad, ellers usann
            bool o = o1 | o2 | o3 | o4 | o5 | o6 | o7 | o8;

            // Sjekker status i spillet og kontrollerer spillflaten
            if (x)
            {
                label1.Text = "X er vinner!";
                label1.ForeColor = Color.Green;
            }
            else if (o)
            {
                label1.Text = "O er vinner!";
                label1.ForeColor = Color.Green;
            }
            else if (antallTrekk == 0)
            {
                label1.Text = "Uavgjort!";
                label1.ForeColor = Color.Red;
            }
            else
                label1.Text = "Neste trekk!!!";
            if (x | o)
            {
                b11.Enabled = false;
                b12.Enabled = false;
                b13.Enabled = false;
                b21.Enabled = false;
                b22.Enabled = false;
                b23.Enabled = false;
                b31.Enabled = false;
                b32.Enabled = false;
                b33.Enabled = false;
            }
        }

        // Istedet for å bruke en knapp til å lage "Nytt spill" funksjonalitet er det i dette
        // prosjektet satt inn ett menuStrip objekt.
        // Når valget i menuStrip objektet er "Nytt spill" kjøres denne rutinen, og det klargjøres
        // for en nyomgang.
        private void nyttSpillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fjerner alle X'er og O'er i spillfalten
            b11.Text = "";
            b12.Text = "";
            b13.Text = "";
            b21.Text = "";
            b22.Text = "";
            b23.Text = "";
            b31.Text = "";
            b32.Text = "";
            b33.Text = "";
            // Nullstiller info teksten til spillerene
            label1.Text = "Gjør ett trekk!!!";
            label1.ForeColor = DefaultForeColor;
            // Gjør alle knappene trykkbare igjen
            b11.Enabled = true;
            b12.Enabled = true;
            b13.Enabled = true;
            b21.Enabled = true;
            b22.Enabled = true;
            b23.Enabled = true;
            b31.Enabled = true;
            b32.Enabled = true;
            b33.Enabled = true;
            // Setter nødvendige verdier til sin opprinnelige verdi.
            antallTrekk = maksAntallTrekk;
            // Kaller metoden for å kunne velge på nytt hvem som skal begynne.
            // PS!! Hvis linjen under kommenteres ut, er det taperen som starter.
            Form1_Load(null, null);
        }
    }
}
