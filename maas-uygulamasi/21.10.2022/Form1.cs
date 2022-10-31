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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Rize");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            bool cinsiyet = true;
            if (checkBox1.Checked)
                cinsiyet = true;
            else if (checkBox2.Checked)
                cinsiyet = false;
            else
                MessageBox.Show("Cinsiyet seçimini yapmadınız");

            string sehir = comboBox1.SelectedItem.ToString();
            bool kullaniciTipi; //true-> Personel ; false-> Müşteri//

            Random rnd = new Random();
            Personel p1 = new Personel();
            Musteri m1 = new Musteri();


            if (chc_müsteri.Checked)
            { 

                //kullaniciTipi = false;//
                m1.musteriNo = rnd.Next(100, 999);
                m1.ad = ad;
                m1.soyad = soyad;
                m1.sehir = sehir;
                m1.cinsiyet = cinsiyet;
                MessageBox.Show("Müşteri olarak sisteme kayıt oldunuz. Müşteri numaranız:" + m1.musteriNo.ToString());




            }
            else if (chc_personel.Checked)
            {

                kullaniciTipi = true;
                p1.ad = textBox1.Text;
                p1.soyad = textBox2.Text;
                p1.sehir = comboBox1.SelectedItem.ToString();
                p1.personelNo = rnd.Next(1000, 9999);
                p1.cinsiyet = cinsiyet;
                MessageBox.Show("Personel olarak sisteme kayıt oldunuz. Personel numaranız:" + p1.personelNo.ToString());
                PersonelAna p = new PersonelAna(p1.ad, p1.soyad, p1.sehir, p1.personelNo, p1.cinsiyet, p1.maas);

                p.Show();
            }
            else
            { 

                MessageBox.Show("Kullanıcı Tipini Giriniz");

            }

            



        }
    }
}
