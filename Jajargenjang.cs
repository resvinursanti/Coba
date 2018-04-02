using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simple_kalkulator
{
    public partial class Jajargenjang : Form
    {
        public Jajargenjang()
        {
            InitializeComponent();
        }
        private void tentangKamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sebuah calculator sederhana yang memiliki fitur rumus bangun ruang maupun datar dan fitur convers mata uang, berat, jarak");
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm GB = new MainForm();
            GB.Show();
            this.Hide();
        }
        private void rumusBangunDatarRuangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_Bangun GB = new Menu_Bangun();
            GB.Show();
            this.Hide();
        }

        private void conversMataUangIndonesiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conversi_Mata_uang MU = new Conversi_Mata_uang();
            MU.Show();
            this.Hide();
        }

        private void conversJarakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conver_Jarak GB = new Conver_Jarak();
            GB.Show();
            this.Hide();
        }

        private void conversBeratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conver_Berat GB = new Conver_Berat();
            GB.Show();
            this.Hide();
        }

        private void persegiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persegii GB = new Persegii();
            GB.Show();
            this.Hide();
        }

        private void persegiPanjangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persegi_Panjang GB = new Persegi_Panjang();
            GB.Show();
            this.Hide();
        }

        private void segitigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Segitiga GB = new Segitiga();
            GB.Show();
            this.Hide();
        }

        private void lingkaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lingkaran GB = new Lingkaran();
            GB.Show();
            this.Hide();
        }

        private void trapesiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trapesium GB = new Trapesium();
            GB.Show();
            this.Hide();
        }

        private void jajargenjangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jajargenjang GB = new Jajargenjang();
            GB.Show();
            this.Hide();
        }

        private void layangLayangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Layang_Layang GB = new Layang_Layang();
            GB.Show();
            this.Hide();
        }

        private void kubusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kubus GB = new Kubus();
            GB.Show();
            this.Hide();
        }

        private void balokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balok GB = new Balok();
            GB.Show();
            this.Hide();
        }

        private void limasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limas GB = new Limas();
            GB.Show();
            this.Hide();
        }

        private void kerucutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kerucut GB = new Kerucut();
            GB.Show();
            this.Hide();
        }

        private void tabungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabung GB = new Tabung();
            GB.Show();
            this.Hide();
        }

        private void bolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bola GB = new Bola();
            GB.Show();
            this.Hide();
        }
        public double a, t, sa, sb, L, K;
        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            t = Convert.ToDouble(textBox3.Text);
            L = a * t;
            textBox2.Text = L.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sa = Convert.ToDouble(textBox4.Text);
            sb = Convert.ToDouble(textBox5.Text);
            K = 2 * (sa + sb);
            textBox6.Text = K.ToString();
        }
    }
}
