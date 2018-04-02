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
    public partial class Conver_Berat : Form
    {
        public Conver_Berat()
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

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tentangKamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sebuah calculator sederhana yang memiliki fitur rumus bangun ruang maupun datar dan fitur convers mata uang, berat, jarak");
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
                int berat;
                double hasilberat;
                string beratdari, beratke;
                berat = Int32.Parse(textBox1.Text);
                beratdari = comboBox1.Text;
                beratke = comboBox2.Text;
                if(beratdari == "Kg" & beratke == "Gram")
                {
                    hasilberat = berat * 1000;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else  if (beratdari == "Kg" & beratke == "Kg")
                {
                    hasilberat = berat * 1;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Kg" & beratke == "Kwintal")
                {
                    hasilberat =(double)berat / 100;
                    label4.Text = Convert.ToString(hasilberat);
                }

                else if (beratdari == "Kg" & beratke == "Ons")
                {
                    hasilberat = berat * 10;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Kg" & beratke == "Ton")
                {
                    hasilberat = berat * 0.001;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Gram" & beratke == "Gram")
                {
                    hasilberat = berat * 1;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Gram" & beratke == "Kg")
                {
                    hasilberat = berat * 0.001;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Gram" & beratke == "Ons")
                {
                    hasilberat = berat * 0.01;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Gram" & beratke == "Ton")
                {
                    hasilberat = berat * 0.000001;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Gram" & beratke == "Kwintal")
                {
                    hasilberat = berat * 0.00001;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Ons" & beratke == "Ons")
                {
                    hasilberat = berat * 1;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Ons" & beratke == "Kg")
                {
                    hasilberat = berat * 0.1;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Ons" & beratke == "Gram")
                {
                    hasilberat = berat * 100;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Ons" & beratke == "Ton")
                {
                    hasilberat = berat * 0.0001;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Ons" & beratke == "Kwintal")
                {
                    hasilberat = berat * 10;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Ton" & beratke == "Ton")
                {
                    hasilberat = berat * 1;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Ton" & beratke == "Kg")
                {
                    hasilberat = berat * 1000;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Ton" & beratke == "Gram")
                {
                    hasilberat = berat * 1000000;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Ton" & beratke == "Ons")
                {
                    hasilberat = berat * 10000;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Ton" & beratke == "Kwintal")
                {
                    hasilberat = berat * 10;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Kwintal" & beratke == "Kwintal")
                {
                    hasilberat = berat * 1;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Kwintal" & beratke == "Kg")
                {
                    hasilberat = berat * 100;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Kwintal" & beratke == "Gram")
                {
                    hasilberat = berat * 100000;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Kwintal" & beratke == "Ons")
                {
                    hasilberat = berat * 1000;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (beratdari == "Kwintal" & beratke == "Ton")
                {
                    hasilberat = berat / 0.1;
                    label4.Text = Convert.ToString(hasilberat);
                }
                else if (comboBox1.Text == comboBox2.Text)
                {
                    MessageBox.Show("Tentukanlah Satuannya dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
