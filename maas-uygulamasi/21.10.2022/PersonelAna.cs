using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._10._2022
{
    public partial class PersonelAna : Form
    {
        Personel p1 = new Personel();
        public PersonelAna(string ad, string soyad, string sehir, int personelNo, bool cinsiyet, int maas)
        {
            InitializeComponent();
            p1.ad = ad;
            p1.soyad = soyad;



            p1.personelNo = personelNo;
            p1.sehir = sehir;
            p1.cinsiyet = cinsiyet;
            p1.maas = 15000;
            p1.izinHakkı = 30;
        }

        private void PersonelAna_Load(object sender,EventArgs e)
        {
            label1.Text = "Bu ay ki maaşınız:" + p1.maas.ToString();
            label3.Text = "Bu yılki izin hakkınız" + p1.izinHakkı.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            p1.izinAl(Convert.ToInt32(textBox2.Text));
            label3.Text = "Bu yıl ki İzin hakkınız:" + p1.izinHakkı.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int avans = Convert.ToInt32(textBox1.Text);
            p1.avansAl(avans);
            label1.Text = "Bu ayki maaş miktarınız:" + p1.maas.ToString();

        }
    }
}
