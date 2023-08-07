using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poker
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        ArrayList kartlar = new ArrayList();
        string[] kartTur = new string[] { "Maça", "Karo", "Sinek", "Kupa" };
        string[] kartNo = new string[] { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Kız", "Papaz" };
        Random rasgele = new Random();
        ArrayList oyuncu1deger = new ArrayList();
        ArrayList oyuncu2deger = new ArrayList();
        ArrayList oyuncu3deger = new ArrayList();
        ArrayList oyuncu4deger = new ArrayList();
        int sayac = 0;
        string yazi;
        void yazdirma()
        {
            // Sayaç durumuna göre oyuncuların ellerindeki kartların durumu yazdırılıyor..
            if (sayac == 0)
            {
                yazi = "Elinizde bir Şey yok";
            }
            if (sayac == 1)
            {
                yazi = "Elinizde ikili var";
            }
            if (sayac == 2)
            {
                yazi = "Elinizde üçlü var";
            }
            if (sayac == 3)
            {
                yazi = "Elinizde dörtlü var";
            }
            if (sayac == 4)
            {
                yazi = "Elinizde beşli var";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Oyuncunun ellerindeki kartlar kontrol ediliyor..
            {
                foreach (string item in listBox1.Items)  // oyuncu 1 için;
                {
                    string[] dizi = item.Split('-');     // kartları - işaretine göre ayırıyorum, ikinci kısmı index 1 oluyor, ayrı bir diziye alıyorum.
                    if (oyuncu1deger.Contains(dizi[1]))  // dizideki elemanı önceden tanımladığım dizi içinde arıyorum, burada ilk elemanı hemen diziye atmıyorum, çünkü kendisinden sonraki ile kıyaslanması gerekiyor.
                    {
                        sayac++;                         // eğer içeriyor ise sayaç++
                    }
                    oyuncu1deger.Add(dizi[1]);           // dizinin elemanının, kıyaslayacağım diziye eklenmesi..
                }
                yazdirma();                              //methodumu çağırıyorum..
                label5.Text = yazi;                      // methodumdaki yapıya göre yazı değişkenine ne geldi ise, ilgili alana yazdırıyorum.

                sayac = 0;                               // yeni dağıtım için sıfırlama işlemim, hem dizi hem sayaç.. Aynı şekilde diğer oyuncular içinde aşağıdaki işlemler bu şekilde yapılıyor.
                oyuncu1deger.Clear();
            }
            {
                foreach (string item in listBox2.Items)
                {
                    string[] dizi = item.Split('-');
                    if (oyuncu2deger.Contains(dizi[1]))
                    {
                        sayac++;
                    }
                    oyuncu2deger.Add(dizi[1]);
                }
                yazdirma();
                label6.Text = yazi;
                sayac = 0;
                oyuncu2deger.Clear();
            }
            {
                foreach (string item in listBox3.Items)
                {
                    string[] dizi = item.Split('-');
                    if (oyuncu3deger.Contains(dizi[1]))
                    {
                        sayac++;
                    }
                    oyuncu3deger.Add(dizi[1]);
                }
                yazdirma();
                label7.Text = yazi;
                sayac = 0;
                oyuncu3deger.Clear();
            }
            {
                foreach (string item in listBox4.Items)
                {
                    string[] dizi = item.Split('-');
                    if (oyuncu4deger.Contains(dizi[1]))
                    {
                        sayac++;
                    }
                    oyuncu4deger.Add(dizi[1]);
                }
                yazdirma();
                label8.Text = yazi;
                sayac = 0;
                oyuncu4deger.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // listboxlar temizleniyor..
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            kartlar.Clear();
            //kartlar oluşturuluyor..
            for (int i = 0; i < kartTur.Length; i++)
            {
                for (int x = 0; x < kartNo.Length; x++)
                {
                    string gelenkart = kartTur[i] + "-" + kartNo[x];
                    kartlar.Add(gelenkart);
                }
            }
            // oyuncu 1 için kartlar oluşturuluyor, remove AT ile gelen kart bir daha gelmesin diye kaldırılıyor..
            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rasgele.Next(0, kartlar.Count);
                listBox1.Items.Add(kartlar[gidenkart]);
                kartlar.RemoveAt(gidenkart);
            }
            // oyuncu 2 için kartlar oluşturuluyor, remove AT ile gelen kart bir daha gelmesin diye kaldırılıyor..
            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rasgele.Next(0, kartlar.Count);
                listBox2.Items.Add(kartlar[gidenkart]);
                kartlar.RemoveAt(gidenkart);
            }
            // oyuncu 3 için kartlar oluşturuluyor, remove AT ile gelen kart bir daha gelmesin diye kaldırılıyor..

            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rasgele.Next(0, kartlar.Count);
                listBox3.Items.Add(kartlar[gidenkart]);
                kartlar.RemoveAt(gidenkart);
            }
            // oyuncu 4 için kartlar oluşturuluyor, remove AT ile gelen kart bir daha gelmesin diye kaldırılıyor..

            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rasgele.Next(0, kartlar.Count);
                listBox4.Items.Add(kartlar[gidenkart]);
                kartlar.RemoveAt(gidenkart);
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
