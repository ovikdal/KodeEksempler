using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funksjoner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        int tallA = 2, tallB = 6, sum;
        int tallAA = 5, tallBB = 7;
        int[] tabell = { 3, 5, 7, 9, 12, 13 };

        // Alle deler av oppgave 1 testes i Form1_Load
        // Alle deler av oppgave 3 testes i Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Test: oppgave 1a) - 1g)
            // 
            Summer1a();
            textBox1.Text = "" + sum;

            Summer1b(tallAA, tallBB);
            textBox2.Text = "" + sum;

            sum = Summer1c();
            textBox3.Text = "" + sum;
            
            // 1d)
            textBox4.Text = "" + Summer1d(tallA,tallBB);

            // 1e)
            Summer1e();
            textBox5.Text = "" + sum;

            Summer1e(tallAA, tallBB);
            textBox6.Text = "" + sum;
            // 1f)
            sum = Summer1f();
            textBox7.Text = "" + sum;
            
            textBox8.Text = "" + Summer1f(tallA, tallBB);

            // 1g) - Rekursivt kall
            textBox9.Text = "" + Summer1f(tallA, Summer1f(tallB, tallBB));
            #endregion

            #region Test: oppgave 3a) - 3c)
            textBox16.Text = Convert.ToString(sumAvArray(tabell));
            textBox17.Text = Convert.ToString(snittAvArray(tabell));
            textBox18.Text = Convert.ToString(størsteTall(tabell));

            #endregion
        }

        #region Funksjonene i oppgave 1
        // 1a)
        private void Summer1a()
        {
            sum = tallA + tallB;
        }

        // 1b)
        private void Summer1b(int a, int b)
        {
            sum = a + b;
        }

        // 1c)
        private int Summer1c()
        {
            int s = (tallA + tallB)*10;
            return s;
        }

        // 1d)
        private int Summer1d(int a, int b)
        {
            int s = (a + b)*25;
            return s;
        }

        // 1e)
        /*
        // 1a)
         private void Summer1a()
        {
            sum = tallA + tallB;
            textBox1.Text += "" + sum;
        }

        // 1b)
        private void Summer1b(int a, int b)
        {
            sum = a + b;
            textBox1.Text += ", " + sum;
        }
        */
        private void Summer1e()
        {
            sum = tallA + tallB;
            textBox1.Text += "" + sum;
        }

        private void Summer1e(int a, int b)
        {
            sum = a + b;
            textBox1.Text += ", " + sum;
        }

        // 1f
        private int Summer1f()
        {
            int s = (tallA + tallB) * 10;
            return s;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private int Summer1f(int a, int b)
        {
            int s = (a + b) * 25;
            return s;
        }

        // 1g) - se Form1_Load
        #endregion o1

        // Alle deler av oppgave 2 testes når knapperutinen kjøres
        #region Funksjonene i oppgave 2
        private void button1_Click(object sender, EventArgs e)
        {
            // 2a)
            double antTommer = Convert.ToDouble(textBox10.Text);
            double cm = FraTommerTilCm(antTommer);
            textBox11.Text = Convert.ToString(cm);

            // 2b)
            textBox12.Text = Convert.ToString(InnenforIntervall(5, tallA, tallB));

            // 2c)
            textBox13.Text = Convert.ToString(TilfeldigTallFraNullTilHundre());

            // 2d)
            textBox14.Text = Convert.ToString(Gjennomsnitt(tallA, tallB));

            // 2e)
            textBox15.Text = Convert.ToString(ErPartall(tallB));

        }

        // 2a)
        private double FraTommerTilCm(double tommer)
        {
            double antCm = 2.54 * tommer;
            return antCm;
        }

        // 2b)
        private bool InnenforIntervall(int tall, int fra, int til)
        {
            if (tall > fra && tall < til)
                return true;
            else
                return false;
        }

        // 2c)
        private int TilfeldigTallFraNullTilHundre()
        {
            Random r = new Random();
            int t = r.Next(0, 101);
            return t;
        }

        // 2d)
        private int Gjennomsnitt(int tall1, int tall2)
        {
            int g = (tall1 + tall2) / 2;
            return g;
        }

        // 2e)
        private bool ErPartall(int tall)
        {
            int t = tall % 2;
            if (t > 0)
                return true;
            else
                return false;
        }
        #endregion

        #region Funksjonene i oppgave 3
        // a)
        private int sumAvArray(int[] t)
        {
            int s = 0;
            foreach (int i in t)
                s += i;
            return s;
        }

        // b)
        private double snittAvArray(int[] t)
        {
            double s = 0;
            foreach (int i in t)
                s += i;
            s = s / t.Length;
            return s;
        }

        // c)
        private int størsteTall(int[] t)
        {
            int s = t[0];
            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] > t[i-1])
                {
                    s = t[i];
                }
            }
            return s;
        }

        #endregion

        #region Funksjonen i oppgave 4
        private void button2_Click(object sender, EventArgs e)
        {
            TomTekstboks(textBox19);
        }

        private void TomTekstboks(TextBox tb)
        {
            // Ett alternativ til
            // tb.Text = "";
            tb.Clear();
        }
        #endregion
    }
}
