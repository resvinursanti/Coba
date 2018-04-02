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
    public partial class Conver_Jarak : Form
    {
        public Conver_Jarak()
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
                int jarak;
                double hasiljarak;
                string jarakdari, jarakke;
                jarak = Int32.Parse(textBox1.Text);
                jarakdari = comboBox1.Text;
                jarakke = comboBox2.Text;
                if (jarakdari == "Km" & jarakke == "Km")
                {
                    hasiljarak = jarak * 1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Km" & jarakke == "Mil")
                {
                    hasiljarak = jarak * 0.621371192237334;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Km" & jarakke == "Hm")
                {
                    hasiljarak = jarak * 10;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Km" & jarakke == "Dam")
                {
                    hasiljarak = jarak * 100;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Km" & jarakke == "M")
                {
                    hasiljarak = jarak * 1000;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Km" & jarakke == "Dm")
                {
                    hasiljarak = jarak * 10000;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Km" & jarakke == "Cm")
                {
                    hasiljarak = jarak * 100000;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Km" & jarakke == "Mm")
                {
                    hasiljarak = jarak * 1000000;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mil" & jarakke == "Mil")
                {
                    hasiljarak = jarak * 1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mil" & jarakke == "Km")
                {
                    hasiljarak = jarak * 1.609344;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mil" & jarakke == "Hm")
                {
                    hasiljarak = jarak * 16.09344;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mil" & jarakke == "Dam")
                {
                    hasiljarak = jarak * 160.9344;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mil" & jarakke == "M")
                {
                    hasiljarak = jarak * 1609.344;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mil" & jarakke == "Dm")
                {
                    hasiljarak = jarak * 16093.44;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mil" & jarakke == "Cm")
                {
                    hasiljarak = jarak * 160934.4;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mil" & jarakke == "MM")
                {
                    hasiljarak = jarak * 1609344;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Hm" & jarakke == "Hm")
                {
                    hasiljarak = jarak * 1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Hm" & jarakke == "Mil")
                {
                    hasiljarak = jarak * 0.0621371192237334;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Hm" & jarakke == "Km")
                {
                    hasiljarak = jarak * 0.1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Hm" & jarakke == "Dam")
                {
                    hasiljarak = jarak * 10;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Hm" & jarakke == "M")
                {
                    hasiljarak = jarak * 100;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Hm" & jarakke == "Dm")
                {
                    hasiljarak = jarak * 1000;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Hm" & jarakke == "Cm")
                {
                    hasiljarak = jarak * 10000;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Hm" & jarakke == "Mm")
                {
                    hasiljarak = jarak * 100000;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dam" & jarakke == "Mil")
                {
                    hasiljarak = jarak * 0.00621371192237334;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dam" & jarakke == "Km")
                {
                    hasiljarak = jarak * 0.01;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dam" & jarakke == "Hm")
                {
                    hasiljarak = jarak * 0.1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dam" & jarakke == "Dam")
                {
                    hasiljarak = jarak * 1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dam" & jarakke == "M")
                {
                    hasiljarak = jarak * 10;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dam" & jarakke == "Dm")
                {
                    hasiljarak = jarak * 100;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dam" & jarakke == "Cm")
                {
                    hasiljarak = jarak * 1000;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dam" & jarakke == "Mm")
                {
                    hasiljarak = jarak * 100000;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "M" & jarakke == "Mil")
                {
                    hasiljarak = jarak * 0.000621371192237334;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "M" & jarakke == "Km")
                {
                    hasiljarak = jarak * 0.001;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "M" & jarakke == "Hm")
                {
                    hasiljarak = jarak * 0.01;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "M" & jarakke == "Dam")
                {
                    hasiljarak = jarak * 0.1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "M" & jarakke == "M")
                {
                    hasiljarak = jarak * 1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "M" & jarakke == "Dm")
                {
                    hasiljarak = jarak * 10;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "M" & jarakke == "Cm")
                {
                    hasiljarak = jarak * 100;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "M" & jarakke == "MM")
                {
                    hasiljarak = jarak * 1000;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dm" & jarakke == "Mil")
                {
                    hasiljarak = jarak * 0.0000621371192237334;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dm" & jarakke == "Km")
                {
                    hasiljarak = jarak * 0.0001;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dm" & jarakke == "Hm")
                {
                    hasiljarak = jarak * 0.001;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dm" & jarakke == "Dam")
                {
                    hasiljarak = jarak * 0.01;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dm" & jarakke == "M")
                {
                    hasiljarak = jarak * 0.1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dm" & jarakke == "Dm")
                {
                    hasiljarak = jarak * 1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dm" & jarakke == "Cm")
                {
                    hasiljarak = jarak * 10;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Dm" & jarakke == "Mm")
                {
                    hasiljarak = jarak * 100;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Cm" & jarakke == "Mil")
                {
                    hasiljarak = jarak * 0.00000621371192237334;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Cm" & jarakke == "Km")
                {
                    hasiljarak = jarak * 0.00001;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Cm" & jarakke == "Hm")
                {
                    hasiljarak = jarak * 0.0001;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Cm" & jarakke == "Dam")
                {
                    hasiljarak = jarak * 0.001;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Cm" & jarakke == "M")
                {
                    hasiljarak = jarak * 0.01;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Cm" & jarakke == "Dm")
                {
                    hasiljarak = jarak * 0.1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Cm" & jarakke == "Cm")
                {
                    hasiljarak = jarak * 1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Cm" & jarakke == "Mm")
                {
                    hasiljarak = jarak * 10;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mm" & jarakke == "Mil")
                {
                    hasiljarak = jarak * 0.000000621371192237334;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mm" & jarakke == "Km")
                {
                    hasiljarak = jarak * 0.000001;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mm" & jarakke == "Hm")
                {
                    hasiljarak = jarak * 0.00001;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mm" & jarakke == "Dam")
                {
                    hasiljarak = jarak * 0.0001;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mm" & jarakke == "M")
                {
                    hasiljarak = jarak * 0.001;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mm" & jarakke == "Dm")
                {
                    hasiljarak = jarak * 0.01;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mm" & jarakke == "Cm")
                {
                    hasiljarak = jarak * 0.1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (jarakdari == "Mm" & jarakke == "Mm")
                {
                    hasiljarak = jarak * 1;
                    label4.Text = Convert.ToString(hasiljarak);
                }
                else if (comboBox1.Text == comboBox2.Text)
                {
                    MessageBox.Show("Tentukanlah Satuannya dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
