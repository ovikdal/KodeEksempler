using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contains
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string tekst = "Hei, jeg heter Rune";
            string deltekst = "Runer";
            bool funnetDeltekst = false;
            Console.WriteLine("funnetDeltekst = ");

            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == deltekst[0])
                {
                    for (int j = 0; j < deltekst.Length; j++)
                    {
                        if((j + i) < tekst.Length)
                        {
                            if (deltekst[j] == tekst[j + i])
                            {
                                funnetDeltekst = true;
                            }
                            else
                            {
                                funnetDeltekst = false;
                                break;
                            }
                        }
                        else
                        {
                            funnetDeltekst = false;
                            break;
                        }
                    }
                }
                if (funnetDeltekst)
                    break;
            }
            Console.WriteLine(funnetDeltekst);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
