using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnkelAdressebok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Endrer størrelse på vinduet til applikasjonen.
            this.Size = new Size(460, 300);
            // Sentrerer applikasjonen på skjermen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Globale deklarasjoner og initialiseringer
        const string passord = "sikkert";
        const int maksOppføringer = 4;
        string[] demo = { "Fornavn", "Etternavn", "23456712" };
        string[,] oppføring = new string[3, maksOppføringer];
        int indeks = 0; //
        int sisteOppføring = -1; // -1 indikerer ingen oppføringer
        
        // Klargjør brukergrensesnittet
        private void Form1_Load(object sender, EventArgs e)
        {
            //Ønsker ikke at det skal være mulig å skrive i visningsrutene
            tbFnavn.Enabled = false;
            tbEnavn.Enabled = false;
            tbMnum.Enabled = false;

            //Styrer slik at panel pLoggOn slik at det dekker hele programvinduet
            pLoggOn.Dock = DockStyle.Fill;
            //Det krever også at menyen skjules
            menuStrip1.Visible = false;

            // Flytter og skjuler panelet for registrering av nye oppføringer
            pNyOppf.Location = new Point(37, 47);
            pNyOppf.Visible = false;
            
            //Presenterer demo verdier, siden det ikke er noen oppføringer når programmet starter
            presenter(demo);
        }

        /**** Pålogging med passord
        * Applikasjonen sperres med et påloggins panel.
        * Panel pLoggOn skal bare skjules hvis tekst i tbPassord feltet er identisk med passord.
        * Eventuelt melding til bruker om feil passord.
        ****/
        private void btLoggInn_Click(object sender, EventArgs e)
        {
            
        }

        /**** Overlastede funksjoner av presenter
         * Et bestemt string array
         * Oppføringer for en bestemt indeks
         ****/
        private void presenter(string[] p)
        {
        }

        private void presenter(int i)
        {
        }

        /**** Fellesrutine for knappene btNeste og btForrige.
        * Med knappene skal det være mulig å bla frem og tilbake
        * mellom oppføringene.
        * For hvert knappetrykk skal visningsfeltet oppdateres. 
        ****/
        private void bla_Click(object sender, EventArgs e)
        {

        }

        // Gjøre panel pNyOppf synlig slik at en ny oppføring kan lagres
        private void nyOppføringToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /**** Lagre oppføring
         * Sjekke at det er plass til en ny oppføring.
         * Hvis plass: Lagre felter. Tømme felter. Ordne indeksering og presentere.
         * Hvis ikke plass: Melding til bruker.
         * Panelt pNyOppf skal skjules.
         ****/
        private void btLagre_Click(object sender, EventArgs e)
        {

        }

        /**** Menyvalget Slett oppføring
        * Menyvalget skal føre til at den oppføringen som vises
        * i visningsfeltet slettes fra adresselisten.
        * Adresselisten må ordnes slik at den ikke inneholder tomme felter.
        * Visningsfeltet skal vise den ny oppføringen med samme indeks referanse,
        * og sisteOppføring dekrementeres.
        * Hvis det er siste element i listen som slettes skal demo-listen presenteres
        * og sisteOppføring skal settes til -1, og demo presenteres.
        * ****/
        private void slettOppføringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}