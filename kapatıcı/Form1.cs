using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kapatıcı
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "C:\\Windows\\system32\\shutdown.exe";
            psi.Arguments = "-f -s -t 0";
            Process.Start(psi);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-f -s");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            timer1.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            string saat, dakika, saniye;
            saat = textBox1.Text;
            dakika = textBox2.Text;
            saniye = textBox3.Text;


            if ((Convert.ToString(DateTime.Now.Hour)) == saat && (Convert.ToString(DateTime.Now.Minute) == dakika) && (Convert.ToString(DateTime.Now.Second)) == saniye)
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "C:\\Windows\\system32\\shutdown.exe";
                psi.Arguments = "-f -s -t 0";
                Process.Start(psi);
            }
        }
    }
}
