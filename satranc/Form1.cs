using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satranc
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private char harfBul(int x)
        {
            /*
             Gelen sayi degerinin harf karsiligini bulmak icin yazdim
             */
            return "ABCDEFGH"[x - 1];
        }

        public void button1_Click(object sender, EventArgs e)
        {
            IDictionary<char, int> harfSayi = new Dictionary<char, int>() { {'A', 1},
                { 'B', 2}, { 'C', 3}, { 'D', 4}, { 'E', 5}, { 'F', 6}, { 'G', 7}, { 'H', 8} }; // Harfler ve harflerin sayi karsiliklarini bir sozluk yapisinda tutuyorum


            string konum = textBox1.Text.ToUpper();
            if (konum.Length == 2 && "12345678".Contains(konum[1])) // Gelen konum bilgisinin uygun standartlara olup olmadigini test ediyorum
            {
                try
                {

                    int h = harfSayi[konum[0]];
                    int s = int.Parse(konum[1].ToString());
                    label1.Text = "Gidebileceği Yerler:";
                    if (s + 2 < 9)
                    {
                        if (h + 1 < 9) // At iki ileri 1 sag
                            label1.Text += " " + harfBul(h + 1).ToString() + (s + 2).ToString(); // Gidebilecegi konumu bulup, label1 e ekliyorum.

                        if (h - 1 > 0) // At iki ileri 1 sol
                            label1.Text += " " + harfBul(h - 1).ToString() + (s + 2).ToString();
                    }

                    if (s - 2 > 0)
                    {
                        if (h + 1 < 9) // At iki geri 1 sag
                            label1.Text += " " + harfBul(h + 1).ToString() + (s - 2).ToString();

                        if (h - 1 > 0) // At iki geri 1 sol
                            label1.Text += " " + harfBul(h - 1).ToString() + (s - 2).ToString();
                    }

                    if (h + 2 < 9)
                    {

                        if (s + 1 < 9) // At iki sag 1 ileri
                            label1.Text += " " + harfBul(h + 2).ToString() + (s + 1).ToString();

                        if (s - 1 > 0) // At iki sag 1 geri
                            label1.Text += " " + harfBul(h + 2).ToString() + (s - 1).ToString();

                    }
                    if (h - 2 > 0)
                    {

                        if (s + 1 < 9) // At iki sol 1 ileri
                            label1.Text += " " + harfBul(h - 2).ToString() + (s + 1).ToString();

                        if (s - 1 > 0) // At iki sol 1 geri
                            label1.Text += " " + harfBul(h - 2).ToString() + (s - 1).ToString();
                    }
                }
                catch (Exception ex) // Hata farketmeksizin yakalayip programi kapatmadan kullaniciyi uyariyorum
                {
                    MessageBox.Show("Harfler: ABCDEFGH olabilir!");
                }

            }
            else
            {
                MessageBox.Show("Konum A1 gibi 2 haneli ve harf sayi olmalidir");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
