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
    public partial class Conversi_Mata_uang : Form
    {
        public Conversi_Mata_uang()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Masukan Bilangan Bulat !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else if (comboBox1.Text == "-Pilih-")
            {
                MessageBox.Show("Pilih Satuan Awal !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else if (comboBox2.Text == "-Pilih-")
            {
                MessageBox.Show("Pilih Satuan Tujuan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else
            {
                int Uang;
                double hasiluang;
                string uangdari, uangke;
                Uang = Int32.Parse(textBox1.Text);
                uangdari = comboBox1.Text;
                uangke = comboBox2.Text;
                if (uangdari == "Rupiah" & uangke == "Dolar")
                {
                    hasiluang = Uang * 1000;
                    label4.Text = Convert.ToString(hasiluang);
                }
                else if (comboBox1.Text == comboBox2.Text)
                {
                    MessageBox.Show("Tentukanlah Satuannya dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
