using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika_1
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();

            
            timer = new Timer();
            timer.Interval = 500; // fél másodperc
            timer.Tick += Timer_Tick;
            timer.Start();
        }

       
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer.Stop(); 
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            labelUserName.Text = textBoxInput.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ColorChanger_Click(object sender, EventArgs e)
        {
            ColorChanger.ForeColor = Color.Red;
            ColorChanger.Font = new Font(
                ColorChanger.Font,
                FontStyle.Bold | FontStyle.Italic
            );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void sum_Click(object sender, EventArgs e)
        {
            int a = int.Parse(szam1.Text.Trim());
            int b = int.Parse(szam2.Text.Trim());

            int osszeg = a + b;

            eredmenyLabel.Text = "eredmény: " + osszeg;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(szam1.Text.Trim());
            int b = int.Parse(szam2.Text.Trim());
            int szorzat = a * b;

            eredmenyLabel.Text = "eredmény: " + szorzat;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

