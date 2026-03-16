using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryATudasFaja;

namespace aTudasFaja

{
    public partial class aTudasFajaForm : Form
    {
        public static List<ATudasFaja> KerdesLista=new List<ATudasFaja>();
        public static int AktualisKerdes { get; set; } = 0;
        public static int AktualisMagyarazat { get; set; } = 0;

        public static int Elet = 3;

        public aTudasFajaForm()
        {
            InitializeComponent();           
        }

        private void aTudasFajaForm_Load(object sender, EventArgs e)
        {
            KerdesLista = ATudasFaja.FileBeolvasas("atudasfaja.txt");
            EletFrissites();
            buttonValaszA.Click += Valasz_Click;
            buttonValaszB.Click += Valasz_Click;
            buttonValaszC.Click += Valasz_Click;
            buttonValaszD.Click += Valasz_Click;
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            valaszolva = false;
            KerdesKiiras();
            labelKerdes.Visible = true;
            labelValaszA.Visible = true;
            labelValaszB.Visible = true;
            labelValaszC.Visible = true;
            labelValaszD.Visible = true;
            labelMagyarazat.Visible = false;
            button1.Visible = false;          
        }

        private void labelKerdes_Click(object sender, EventArgs e)
        {

        }
        private void KerdesKiiras()
        {
            if (AktualisKerdes >= KerdesLista.Count)
            {
                MessageBox.Show("Vége a kérdéseknek!");
                Application.Exit();
            }
            labelKerdes.Text = KerdesLista[AktualisKerdes].Kerdes;
            labelValaszA.Text = KerdesLista[AktualisKerdes].Valasz1;
            labelValaszB.Text = KerdesLista[AktualisKerdes].Valasz2;
            labelValaszC.Text = KerdesLista[AktualisKerdes].Valasz3;
            labelValaszD.Text = KerdesLista[AktualisKerdes].Valasz4;
            AktualisKerdes++;
            buttonValaszA.BackColor = DefaultBackColor;
            buttonValaszB.BackColor = DefaultBackColor;
            buttonValaszC.BackColor = DefaultBackColor;
            buttonValaszD.BackColor = DefaultBackColor;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            buttonValaszA.Visible = true;
            buttonValaszB.Visible = true;
            buttonValaszC.Visible = true;
            buttonValaszD.Visible = true;
            buttonNextQuestion.Visible = true;
            buttonStart.Visible = false;
            labelElet.Visible = true;
            KerdesKiiras(); // EZ HIÁNYZOTT
            labelKerdes.Visible = true;
            labelValaszA.Visible = true;
            labelValaszB.Visible = true;
            labelValaszC.Visible = true;
            labelValaszD.Visible = true;
            
            
        }

        private void button1_Click(object sender, EventArgs e) //magyarázat
        {
            labelMagyarazat.Visible = true;
            MagyarazatKiiras();
        }
        private void MagyarazatKiiras()
        {
            labelMagyarazat.Text = KerdesLista[AktualisKerdes - 1].Magyarazat;
        }
        private void EletFrissites()
        {
            labelElet.Text = "Életek: " + new string('❤', Elet);
        }
        bool valaszolva = false;
        private void Valasz_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            if (valaszolva) return;
            valaszolva = true;

            Button kattintott = sender as Button;
            

            string valasz = kattintott.Text;
            string helyes = KerdesLista[AktualisKerdes - 1].Helyes;

            if (valasz == helyes)
            {
                kattintott.BackColor = Color.Green;
            }
            
            else
            {
                kattintott.BackColor = Color.Red;
                Elet--;
                EletFrissites();
            }
            //zöldre színezés ha rossz a válasz
            foreach (Control c in this.Controls)
            {
                if (c is Button gomb && gomb.Text == helyes)
                {
                    gomb.BackColor = Color.Green;
                }
            }
            if (Elet == 0)
            {
                MessageBox.Show("Elfogytak az életek!");
                Application.Exit();
            }
        }
    }
}
