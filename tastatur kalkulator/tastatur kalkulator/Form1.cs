using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tastatur_kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Denne versjonen av den hendelses styrte kalkulatoren er, i tillegg til interaktive trykk på skjermen,
         * utvidet til å registrere trykk på tataturet.
         * Hver objekt i det grafiske grensesnittet er også tilordnet navn som er logiske med tanke
         * på hvilken oppgave/funksjon de har/utgjør. F.eks. så har visningsruten (tekstboksen) fått navnet display.
         * Knappen som representerer tallet 0 har fått navnet bt0, mens knappen som sletter displayet heter btSlett. 
         */

        // Deklarasjon og initialisering av globale vaiabler
        decimal tall1 = 0;
        string regneoperasjon = "";

        // En felles funksjon for alle kalkulator hendelser.
        // Kjøres når en interaktiv knapp på skjermen eller en tast på tastatures
        // blir trykkes
        private void bt_Click(object sender, EventArgs e)
        {
            // Lager ett lokal instans av objektet Button med referanse b (en "variabel").
            // b blir tilordnet verdiene til det knappe objektet som er trykket,
            // og dermed er årsaken til at bt_Click metoden kjøres.
            Button b = sender as Button;

            // Kontrollerer funksjonen til kalkulatoren ved å sjekke Text property til knappe objektet.
            switch (b.Text)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    if (display.Text == "0")
                    {
                        display.Text = b.Text;
                    }
                    else
                    {
                        display.Text = display.Text + b.Text;
                    }
                    break;
                case "+":
                case "-":
                case "*":
                case "/":
                    regneoperasjon = b.Text;
                    tall1 = Convert.ToDecimal(display.Text);
                    display.Text = "0";
                    break;
                case ",":
                    if (!display.Text.Contains(','))
                    {
                        display.Text = display.Text + b.Text;
                    }
                    break;
                case "=":
                    decimal resultat = 0;
                    // PS!!! Linjen under kan som alternativ benyttes, og erstatter dermed de 2 påfølgende linjer
                    //decimal tall2 = Convert.ToDecimal(display.Text);
                    decimal tall2;
                    tall2 = Convert.ToDecimal(display.Text);
                    if (regneoperasjon == "+")
                    {
                        resultat = tall1 + tall2;
                    }
                    else if (regneoperasjon == "-")
                    {
                        resultat = tall1 - tall2;
                    }
                    else if (regneoperasjon == "*")
                    {
                        resultat = tall1 * tall2;
                    }
                    else if (regneoperasjon == "/" && tall2 != 0)
                    {
                        resultat = tall1 / tall2;
                    }
                    // Spesialtilfelle hvis det deles på 0
                    if (tall2 == 0 && regneoperasjon == "/")
                    {
                        display.Text = "∞";
                    }
                    else
                    {
                        display.Text = Convert.ToString(resultat);
                    }
                    break;
                case "C":
                    display.Text = "0";
                    break;
                #region Vis på fredag 2: Slett tilbake-tasten
                case "←":
                    if (display.Text.Length > 1)
                        display.Text = display.Text.Remove(display.Text.Length - 1, 1);
                    else
                        display.Text = "0";
                    break;
                    #endregion
            }
            // Setter fokus på = - knappen, slik at enter kan brukes til å beregne svar
            btErlik.Focus();
        }


        // En felles funksjon for alle trykk på tastaturet.
        // Hvert lovlige tastetrykk blir videresendt til bt_Click funksjonen for videre behandling.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Ikke nødvendigvis en komplett liste over tastetrykk og tastetrykk kombinasjoner,
            // men viser prinsippet for å kunne bruke tastaturet til å betjene kalkulatoren.
            // !!! tall-taster, numpad-taster og kombinasjonstrykk (f.eks. shift og 7 = dele) !!!
            switch (e.KeyCode)
            {
                case Keys.D0:
                    if (e.Modifiers == Keys.Shift)
                        btErlik.PerformClick();
                    else
                        bt0.PerformClick();
                    break;
                //PS! Skal forklare linjen under senere hvordan denne fungerer.
                //case Keys.Shift | Keys.D0: btErlik.PerformClick(); break;
                case Keys.NumPad0: bt0.PerformClick(); break;
                case Keys.D1:
                case Keys.NumPad1: bt1.PerformClick(); break;
                case Keys.D2:
                case Keys.NumPad2: bt2.PerformClick(); break;
                case Keys.D3:
                case Keys.NumPad3: bt3.PerformClick(); break;
                case Keys.D4:
                case Keys.NumPad4: bt4.PerformClick(); break;
                case Keys.D5:
                case Keys.NumPad5: bt5.PerformClick(); break;
                case Keys.D6:
                case Keys.NumPad6: bt6.PerformClick(); break;
                case Keys.D7:
                    if (e.Modifiers == Keys.Shift) //Shift + 7 for / (dele)
                        btDele.PerformClick();
                    else
                        bt7.PerformClick(); //Tallet 7
                    break;
                case Keys.NumPad7: bt7.PerformClick(); break;
                case Keys.D8:
                case Keys.NumPad8: bt8.PerformClick(); break;
                case Keys.D9:
                case Keys.NumPad9: bt9.PerformClick(); break;
                case Keys.Oemplus:
                case Keys.Add: btPluss.PerformClick(); break;
                case Keys.OemMinus: btMinus.PerformClick(); break;
                case Keys.Multiply: btGange.PerformClick(); break;
                case Keys.OemQuestion:
                    if (e.Modifiers == Keys.Shift)
                        btGange.PerformClick();
                    break;
                case Keys.Divide: btDele.PerformClick(); break;
                case Keys.Oemcomma: btKomma.PerformClick(); break;
                // Kan slette innhold ved å benytte c-tast eller delete-tast
                case Keys.C:
                case Keys.Delete: btSlett.PerformClick(); break;
                case Keys.Back: btSlettTB.PerformClick(); break;
            }
            
            // Setter fokus på = - knappen, slik at enter kan brukes til å beregne svar
            btErlik.Focus();
        }
    }
}