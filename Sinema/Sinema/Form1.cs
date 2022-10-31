using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Sinema s = new Sinema();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s.bakiye = 100;
            s.bosKoltukSayisi = 30;
            label6.Text = s.bakiye.ToString();
            label7.Text = s.bosKoltukSayisi.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool indirimliMi = true;
            if (checkBox1.Checked)
                indirimliMi = true;
            else
                indirimliMi = false;

            s.BiletSat(indirimliMi);
            label6.Text = s.BakiyeOgren().ToString();
            label7.Text = s.BosKoltukOgren().ToString();          
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
