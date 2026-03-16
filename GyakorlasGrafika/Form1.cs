using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GyakorlasGrafika
{
    public partial class Form1 : Form
    {
        private int FizetendoOsszesen { get; set; }
        public Form1()
        {
            InitializeComponent();
            Caulculator();
        }

        private void buttonGomb_Click(object sender, EventArgs e)
        {
            if (buttonFizetes.Text == "Fizetés")
            {
                buttonBankkartya.Visible = true;
                buttonKeszpenz.Visible = true;
                buttonFizetes.Text = "Mégse";
            }
            else
            {
                buttonBankkartya.Visible = false;
                buttonKeszpenz.Visible = false;
                buttonFizetes.Text = "Fizetés";
            }
        }

        private void radioButtonCukorSok_CheckedChanged(object sender, EventArgs e)
        {
            Caulculator();
        }

        private void checkBoxKávéKrém_CheckedChanged(object sender, EventArgs e)
        {
            Caulculator();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonTea_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCitrom.Enabled = true;
            checkBoxCitrom.Checked = false;
            checkBoxKaveKrem.Enabled= false;
            checkBoxTejpor.Enabled = false;
            checkBoxTejszin.Enabled= false;
            
            checkBoxKaveKrem.Checked= false;
            checkBoxTejpor.Checked= false;
            checkBoxTejszin.Checked= false;
            Caulculator();

        }     
        private void IngredientsSettings()
        {
            checkBoxCitrom.Enabled = false;
            checkBoxCitrom.Enabled= false;
            checkBoxKaveKrem.Enabled = true;
            checkBoxTejpor.Enabled = true;
            checkBoxTejszin.Enabled = true;

            checkBoxKaveKrem.Checked = false;
            checkBoxTejpor.Checked = false;
            checkBoxTejszin.Checked = false;
        }

        private void Caulculator()
        {
            int ital=0, hozzavalo=0, cukor=0;
            if (radioButtonEspresso.Checked) 
            {
                ital += 140;
            }
            if (radioButtonDuplaKave.Checked)
            {
                ital += 200;
            }
            if (radioButtonHosszuKave.Checked)
            {
                ital += 170;
            }
            if (radioButtonTea.Checked)
            {
                ital += 120;
            }
            textBoxItalAr.Text=ital.ToString();
            if (checkBoxCitrom.Checked)
            {
                hozzavalo += 20;
            }
            if (checkBoxKaveKrem.Checked)
            {
                hozzavalo += 40;
            }
            if (checkBoxTejpor.Checked)
            {
                hozzavalo += 25;
            }
            if (checkBoxTejszin.Checked)
            {
                hozzavalo += 30;
            }
            textBoxHozzavaloAr.Text=hozzavalo.ToString();
            if (radioButtonCukorKeves.Checked)
            {
                cukor += 60;
            }
            if (radioButtonCukorSok.Checked)
            {
                cukor += 10;
            }
            textBoxCukorAr.Text=cukor.ToString();
            FizetendoOsszesen=ital+hozzavalo+cukor;
            textBoxOsszesenAr.Text=FizetendoOsszesen.ToString();
        }

        private void radioButtonEspresso_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
            Caulculator();
        }

        private void radioButtonDuplaKave_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
            Caulculator();
        }
        private void radioButtonHosszuKave_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
            Caulculator();
        }

        private void checkBoxCitrom_CheckedChanged(object sender, EventArgs e)
        {
            Caulculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxTejszin_CheckedChanged(object sender, EventArgs e)
        {
            Caulculator();
        }

        private void checkBoxTejpor_CheckedChanged(object sender, EventArgs e)
        {
            Caulculator();
        }

        private void radioButtonCukorKeves_CheckedChanged(object sender, EventArgs e)
        {
            Caulculator();
        }

        private void radioButtonCukorNelkul_CheckedChanged(object sender, EventArgs e)
        {
            Caulculator();
        }

        private void buttonBankkartya_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A kártyaolvasó nem működik, sajnálom!","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void buttonKeszpenz_Click(object sender, EventArgs e)
        {
            groupBoxKeszpenz.Visible = true;
        }

        private void textBoxItalAr_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEredmeny_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void buttonPenzBedobas_Click(object sender, EventArgs e)
        {
            if (textBoxGep.Text == "")
            {
                textBoxGep.Text = "0";
            }
            int kp = int.Parse(textBoxGep.Text);
            
            if(kp == FizetendoOsszesen)
            {
                labelEredmeny.Text = "Pont annyi!";
            }
            
            else if(kp > FizetendoOsszesen)
            {
                labelEredmeny.Text = $"Visszajáró: {kp-FizetendoOsszesen} Ft";
            }
            else
            {
                labelEredmeny.Text = "Ez kevés lesz...";               
            }
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            groupBoxKeszpenz.Visible=false;
            buttonBankkartya.Visible=false;
            buttonKeszpenz.Visible = false;
            IngredientsSettings();
            radioButtonCukorNelkul.Checked=true;
            radioButtonEspresso.Checked=true;
        }
    }
}
