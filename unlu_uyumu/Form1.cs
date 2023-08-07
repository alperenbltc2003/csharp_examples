using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unlu_uyumu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string kalinharfler = "AIOUaıou";
        string inceharfler = "EİÖÜeiöü";
        string rakamlar = "0123456789";
        string metin;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            {
                if (sonuc == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hatalı kelime girme durumlarını yakalama..

            if (textBox1.Text.Contains(" "))
            {
                MessageBox.Show("Lütfen Tek Kelime Giriniz");
                textBox1.Focus();
                textBox1.Clear();
                label1.Text = "";
            }
            else if (textBox1.Text == null)
            {
                MessageBox.Show("Lütfen Bir Kelime Giriniz");
                textBox1.Focus();
                textBox1.Clear();
                label1.Text = "";
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kelime Giriniz");
                textBox1.Focus();
                textBox1.Clear();
                label1.Text = "";
            }
            else
            {
                kelimekontrol();
            }
        }
        // kelime kontrol methodum..
        void kelimekontrol()
        {
            metin = textBox1.Text;
            // öncelikle false değeri atadım..
            bool varyok1 = false;
            bool varyok2 = false;
            bool varyok3 = false;
            foreach (char item in metin)
            {
                // kalın harfleri arıyorum, eğer kalın harf var ise TRUE
                if (kalinharfler.IndexOf(item) != -1)
                {
                    varyok1 = true;
                }
                // ince harfleri arıyorum, eğer ince harf var ise TRUE

                if (inceharfler.IndexOf(item) != -1)
                {
                    varyok2 = true;
                }
                // Rakamları arıyorum eğer rakam var ise TRUE

                if (rakamlar.IndexOf(item) != -1)
                {
                    varyok3 = true;
                }
            }
            // eğer ikisi de true ise demekki kelime de hem ince hem kalın harf vardır, o halde Büyük Ünlü Uyumuna Uymaz..

            if (varyok1 == true && varyok2 == true)
            {
                label1.Text = "Büyük Ünlü Uyumuna Uymuyor";
            }
            // Eğer iki durum birbirinden farklı ise demek ki, kelime büyük ünlü uyumuna uyuyor.
            else if (varyok1 != varyok2)
            {
                label1.Text = "Büyük Ünlü Uyumuna Uyuyor";
            }
            // eğer varyok3 true ise demekki metin rakam içeriyor.
            else if (varyok3 == true)
            {
                label1.Text = "Kelime lütfen rakam içermesin";
            }
            else if (varyok3 == true && (varyok1 == true || varyok1 == false || varyok2 == true || varyok2 == false))
            {
                label1.Text = "Kelime Lütfen Rakam İçermesin";
            }
            // eğer bu durumların haricinde ise kelime sesli harf içermez..
            else
            {
                label1.Text = "Kelime Sesli Harf İçermiyor";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
