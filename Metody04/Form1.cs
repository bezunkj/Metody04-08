using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            MessageBox.Show("Mocnina:" + CelaCisla.Mocnina(x, y));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Faktorial:" + CelaCisla.Faktorial(x));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);

            MessageBox.Show("Soucet lichych cifer: " + CelaCisla.CifLichSoucet(x));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            if (CelaCisla.JePrvocislo(x))
            {
                MessageBox.Show("Cislo " + x + " JE prvocislo");

            } else
            {
                MessageBox.Show("Cislo " + x + " NENI prvocislo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Pocet sudych delitelu: " + CelaCisla.PocetDeliteluSudych(x));
        }
    }
}
