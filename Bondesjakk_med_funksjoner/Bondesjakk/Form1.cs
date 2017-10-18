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

        // InitializeComponent
        public Form1()
        {
            InitializeComponent();
        }

        // Når programmet lastes
        //Presenterer en meldingsboks der det velges hvem av spillerene som skal beynne (X eller O).
        private void Form1_Load(object sender, EventArgs e)
        {
            VelgStartSpiller();
        }

        // Ved hvert trykk i spillflaten kjøres rutinen play_Click
        private void play_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            MarkerValg(b);
            if (SjekkVinner() == "uavgjort" || SjekkVinner() == "seier")
            {
                StyrSpillflate("lås");
            }
        }

        // Menyvalget "Nytt spill" klargjør spillflaten for en ny omgang
        // Valget "Nytt spill" gjøres i menuStrip objektet.
        private void nyttSpillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nullstiller info teksten til spillerene
            label1.Text = "Gjør ett trekk!!!";
            label1.ForeColor = DefaultForeColor;
            // Gjør alle knappene trykkbare igjen
            StyrSpillflate("åpne");
            // Setter nødvendige verdier til sin opprinnelige verdi.
            antallTrekk = maksAntallTrekk;
            // Kaller metoden for å kunne velge på nytt hvem som skal begynne.
            // PS!! Hvis linjen under kommenteres ut, er det taperen som starter.
            VelgStartSpiller();
        }

        /// <summary>
        /// En meldingsboks presentere et valg om hvem som skal starte spillet
        /// </summary>
        private void VelgStartSpiller()
        {
            DialogResult svar = MessageBox.Show("Ønsker du at X skal begynne?", "Bekreft!", MessageBoxButtons.YesNo);
            if (svar == DialogResult.Yes)
                spiller = 1;
            else
                spiller = 2;
        }

        /// <summary>
        /// Det settes en "X" eller en "O" i knappens Text variabel annenhvergang knappen trykkes.
        /// </summary>
        /// <param name="_b"></param>
        private void MarkerValg(Button _b)
        {
            // Styrer plassering og skifter tur for spiller
            // (annenhver X og O

            if (_b.Text == "")
            {
                antallTrekk--;
                if (spiller == 1)
                {
                    _b.Text = "X";
                    spiller = 2;
                }
                else
                {
                    _b.Text = "O";
                    spiller = 1;
                }
                _b.Enabled = false;
            }
        }

        /// <summary>
        /// Sjekker om det er 3 på rad.
        /// Returnerer "", "seier" eller "uavgjort".
        /// </summary>
        private string SjekkVinner()
        {
            string melding = "";
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
                melding = "seier";
                label1.Text = "X er vinner!";
                label1.ForeColor = Color.Green;
            }
            else if (o)
            {
                melding = "seier";
                label1.Text = "O er vinner!";
                label1.ForeColor = Color.Green;
            }
            else if (antallTrekk == 0)
            {
                melding = "uavgjordt";
                label1.Text = "Uavgjort!";
                label1.ForeColor = Color.Red;
            }
            else
                label1.Text = "Neste trekk!!!";
            return melding;
        }

        /// <summary>
        /// Spillflaten sperres eller klargjøres med parameter s (lås/åpne).
        /// </summary>
        private void StyrSpillflate(string s)
        {
            bool k = false;
            if (s.ToLower() == "lås")
                k = false;
            else if (s.ToLower() == "åpne")
                k = true;
            foreach (Control bt in Controls)
            {
                if (bt is Button)
                {
                    if (k)
                        bt.Text = "";
                    bt.Enabled = k;
                }
            }        
        }

    }
}
