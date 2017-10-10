using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace terning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] terningkast = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Random nyttKast = new Random();
            for (int i = 0; i < terningkast.Length; i++)
            {
                int verdi = nyttKast.Next(1, 7);
                terningkast[i] = verdi;
                //Console.WriteLine(terningkast[i]);
            }
            for ( int i = 0; i < terningkast.Length; i++)
            {
                richTextBox1.Text = richTextBox1.Text + terningkast[i] + ", ";
            }
            richTextBox1.Text += "\n----------\n";
            foreach (int t in terningkast)
            {
                richTextBox1.Text = richTextBox1.Text + terningkast[t] + ", ";
            }

            //  1  2  3  4  5  6
            int[] antNummer = { 0, 0, 0, 0, 0, 0 };
            //for(int i = 0; i < )
            //int antEnere = 0;
            //int antToere = 0;
            for (int i = 0; i < terningkast.Length; i++)
            {
                if (terningkast[i] == 1)
                {
                    antNummer[0] = antNummer[0] + 1;
                }
                else if (terningkast[i] == 2)
                {
                    antNummer[1] = antNummer[1] + 1;
                }
            }
            Console.WriteLine(antNummer[0] + ", " + antNummer[1]);
        }
    }
}
