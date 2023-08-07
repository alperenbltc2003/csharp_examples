namespace hesap
{
    public partial class Form3 : Form
    {
        double x, y;
        string islem; public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //işlemşi birden küçükl yapıpyoruz
            if (textBox1.Text.IndexOf(",") < 1)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //= işaretinin sonuclarını yazdırıyoruz
            y = Convert.ToDouble(textBox1.Text);
            if (islem == "+")
            {
                label1.Text += textBox1.Text;
                textBox1.Text = Convert.ToString(x + y);
                label1.Text += "=" + textBox1.Text;
            }
            if (islem == "-")
            {
                label1.Text += textBox1.Text;
                textBox1.Text = Convert.ToString(x - y);
                label1.Text += "=" + textBox1.Text;
            }
            if (islem == "*")
            {
                label1.Text += textBox1.Text;
                textBox1.Text = Convert.ToString(x * y);
                label1.Text += "=" + textBox1.Text;
            }
            if (islem == "/")
            {
                label1.Text += textBox1.Text;
                textBox1.Text = Convert.ToString(x / y);
                label1.Text += "=" + textBox1.Text;
            }
            if (islem == "%")
            {
                label1.Text += textBox1.Text;
                textBox1.Text = Convert.ToString((x * y) / 100);
                label1.Text += "=" + textBox1.Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //işlemi doublayıp yanina yapacağımız işlemin isaretini koyuyoruz işlemi tanımlayıp textboxı 0 yapıyoruz
            x = Convert.ToDouble(textBox1.Text);
            islem = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //işlemi doublayıp yanina yapacağımız işlemin isaretini koyuyoruz işlemi tanımlayıp textboxı 0 yapıyoruz
            x = Convert.ToDouble(textBox1.Text);
            islem = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //işlemi doublayıp yanina yapacağımız işlemin isaretini koyuyoruz işlemi tanımlayıp textboxı 0 yapıyoruz
            x = Convert.ToDouble(textBox1.Text);
            islem = "*";
            label1.Text = textBox1.Text + "*";
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //işlemi doublayıp yanina yapacağımız işlemin isaretini koyuyoruz işlemi tanımlayıp textboxı 0 yapıyoruz
            x = Convert.ToDouble(textBox1.Text);
            islem = "/";
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //işlemi doublayıp yanina yapacağımız işlemin isaretini koyuyoruz işlemi tanımlayıp textboxı 0 yapıyoruz
            x = Convert.ToDouble(textBox1.Text);
            islem = "%";
            label1.Text = textBox1.Text + "%";
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //işlemi doublayıp yanina - degeri koyup listboxa yazdırıyoruz
            listBox1.Items.Add(-1 * Convert.ToDouble(textBox1.Text));
            listBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // yapılan işlemi math kutuphanesinden karekok işlemini aliyoruz 
            double karekok = Convert.ToDouble(textBox1.Text);
            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //işlemi doublayıp yanina + degeri koyup listboxa yazdırıyoruz
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //kapatma kodu
            Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //işlemi doublayıp listboxun icinde yazan sayiları text boxun içinde toplayip listboxu temizliyoruz
            double toplam = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox1.Items[i]);
            }
            textBox1.Text = Convert.ToString(toplam);
            listBox1.Items.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //textbox ve labeli temizliyoruz//
            textBox1.Text = "0";
            label1.Text = " ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

      

      

       
    }
}