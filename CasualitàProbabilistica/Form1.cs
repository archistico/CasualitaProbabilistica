using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasualitàProbabilistica
{
    public partial class frmMain : Form
    {
        string[] lettere;
        Dictionary<Tuple<char, char>, double> tabella = new Dictionary<Tuple<char, char>, double>();

        public frmMain()
        {
            InitializeComponent();
            CaricaDati();
        }

        private void CaricaDati()
        {
            string listaLettere = "a;à;b;c;d;e;è;é;f;g;h;i;ì;j;k;l;m;n;o;ò;p;q;r;s;t;u;ù;v;w;x;y;z;#";
            lettere = listaLettere.Split(';');

            using (StreamReader sr = File.OpenText("ListaProbabilita.txt"))
            {
                string linea;
                int contLettera = 0;

                while ((linea = sr.ReadLine()) != null)
                {
                    string[] probabilitaLettera;
                    probabilitaLettera = linea.Split(';');
                    int contProbabilita = 0;

                    foreach (string lettera in lettere)
                    {
                        tabella.Add(new Tuple<char, char>(lettere[contLettera][0], lettera[0]), Convert.ToDouble (probabilitaLettera[contProbabilita]));
                        contProbabilita++;
                    }

                    contLettera++;
                }
            }
        }

        private char CercaLettera(char c, double perc)
        {
            foreach (string lettera in lettere)
            {
                if (tabella[new Tuple<char, char>(c, lettera[0])] > perc)
                    return Convert.ToChar(lettera);
            }

            return '*';
        }

        private void btCrea_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double percPrimaLettera = rnd.Next(10000)/100;

            // La prima lettera corrisponde alle probabilità <#,lettera>
            string[] parola = new string[Convert.ToByte (upLunghezza.Value)];
            parola[0] = CercaLettera('#', percPrimaLettera).ToString();

            for (int c = 1; c < Convert.ToByte(upLunghezza.Value); c++)
            {
                int perc = rnd.Next(100);
                string nuovaLettera = "";
                nuovaLettera = CercaLettera(Convert.ToChar(parola[c - 1]), perc).ToString();

                if (nuovaLettera == "#")
                    break;

                parola[c] = nuovaLettera;
            }

            tbRis.Text += string.Join("", parola) + System.Environment.NewLine; 
        }
    }
}
