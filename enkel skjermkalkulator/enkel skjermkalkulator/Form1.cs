using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enkel_skjermkalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region talltastene
        private void bt1_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = bt1.Text;
            }
            else
            {
                display.Text = display.Text + bt1.Text;
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = bt2.Text;
            }
            else
            {
                display.Text = display.Text + bt2.Text;
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = bt7.Text;
            }
            else
            {
                display.Text = display.Text + bt7.Text;
            }

        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = bt8.Text;
            }
            else
            {
                display.Text = display.Text + bt8.Text;
            }

        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = bt9.Text;
            }
            else
            {
                display.Text = display.Text + bt9.Text;
            }

        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = bt4.Text;
            }
            else
            {
                display.Text = display.Text + bt4.Text;
            }

        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = bt5.Text;
            }
            else
            {
                display.Text = display.Text + bt5.Text;
            }

        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = bt6.Text;
            }
            else
            {
                display.Text = display.Text + bt6.Text;
            }

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = bt3.Text;
            }
            else
            {
                display.Text = display.Text + bt3.Text;
            }

        }

        //Enlinjes kommentar

        /* 
         * Mange linjer med kommentar
         */

        private void bt0_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = bt0.Text;
            }
            else
            {
                display.Text = display.Text + bt0.Text;
            }
        }
        #endregion

        //int tall1 = 0;
        decimal tall1 = 0;
        string regneoperasjon = "";

        #region regnetastene
        private void btPluss_Click(object sender, EventArgs e)
        {
            //tall1 = Convert.ToInt16(display.Text);
            tall1 = Convert.ToDecimal(display.Text);
            regneoperasjon = "pluss";
            display.Text = "0";
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            //tall1 = Convert.ToInt16(display.Text);
            tall1 = Convert.ToDecimal(display.Text);
            regneoperasjon = "minus";
            display.Text = "0";
        }

        private void btGange_Click(object sender, EventArgs e)
        {
            //tall1 = Convert.ToInt16(display.Text);
            tall1 = Convert.ToDecimal(display.Text);
            regneoperasjon = "gange";
            display.Text = "0";
        }

        private void btDele_Click(object sender, EventArgs e)
        {
            //tall1 = Convert.ToInt16(display.Text);
            tall1 = Convert.ToDecimal(display.Text);
            regneoperasjon = "dele";
            display.Text = "0";
        }

        private void btErlik_Click(object sender, EventArgs e)
        {
            //int resultat = 0;
            //int tall2 = Convert.ToInt16(display.Text);

            decimal resultat = 0;
            decimal tall2 = Convert.ToDecimal(display.Text);
            if (regneoperasjon == "pluss")
            {
                resultat = tall1 + tall2;
            }
            else if (regneoperasjon == "minus")
            {
                resultat = tall1 - tall2;
            }
            else if (regneoperasjon == "gange")
            {
                resultat = tall1 * tall2;
            }
            else if (regneoperasjon == "dele" && tall2 != 0)
            {
                resultat = tall1 / tall2;
            }

            if (regneoperasjon == "dele" && tall2 == 0)
            {
                display.Text = "∞";
            }
            else
            {
                display.Text = Convert.ToString(resultat);

            }
            
        }
        #endregion
        private void btSlett_Click(object sender, EventArgs e)
        {

        }

        private void btKomma_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains(','))
            {
                display.Text = display.Text + btKomma.Text;
            }
        }
    }
}
