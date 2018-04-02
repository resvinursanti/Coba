using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace simple_kalkulator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		double bilangan1;
		double bilangan2;
		bool statusText = true; //mengisyaratkan untuk menambahkan angka baru
		string tanda = "";
		
		void Tmbl1Click(object sender, EventArgs e)
		{
			if(statusText)
			{
				//akan menggabungkan angka sebelumnya dengan inputan yang baru dimasukkan, karena variabel
				//statusText bernilai false
				panelMtr.Text += tmbl1.Text;
				keterangan.Text += tmbl1.Text;
			}
			else
			{
				//menambahkan angka baru karena variabel statusText bernilai true
				panelMtr.Text = tmbl1.Text;
				keterangan.Text += tmbl1.Text;
				statusText=true;
			}
		}
		
		void Tmbl2Click(object sender, EventArgs e)
		{
			if(statusText)
			{
				//akan menggabungkan angka sebelumnya dengan inputan yang baru dimasukkan, karena variabel
				//statusText bernilai false
				panelMtr.Text += tmbl2.Text;
				keterangan.Text += tmbl2.Text;
			}
			else
			{
				//menambahkan angka baru karena variabel statusText bernilai true
				panelMtr.Text = tmbl2.Text;
				keterangan.Text += tmbl2.Text;
				statusText=true;
			}
		}
		
		void Tmbl3Click(object sender, EventArgs e)
		{
			if(statusText)
			{
				//akan menggabungkan angka sebelumnya dengan inputan yang baru dimasukkan, karena variabel
				//statusText bernilai false
				panelMtr.Text += tmbl3.Text;
				keterangan.Text += tmbl3.Text;
			}
			else
			{
				//menambahkan angka baru karena variabel statusText bernilai true
				panelMtr.Text = tmbl3.Text;
				keterangan.Text += tmbl3.Text;
				statusText=true;
			}
		}
		
		void Tmbl4Click(object sender, EventArgs e)
		{
			if(statusText)
			{
				//akan menggabungkan angka sebelumnya dengan inputan yang baru dimasukkan, karena variabel
				//statusText bernilai false
				panelMtr.Text += tmbl4.Text;
				keterangan.Text += tmbl4.Text;
			}
			else
			{
				//menambahkan angka baru karena variabel statusText bernilai true
				panelMtr.Text = tmbl4.Text;
				keterangan.Text += tmbl4.Text;
				statusText=true;
			}
		}
		
		void Tmbl5Click(object sender, EventArgs e)
		{
			if(statusText)
			{
				//akan menggabungkan angka sebelumnya dengan inputan yang baru dimasukkan, karena variabel
				//statusText bernilai false
				panelMtr.Text += tmbl5.Text;
				keterangan.Text += tmbl5.Text;
			}
			else
			{
				//menambahkan angka baru karena variabel statusText bernilai true
				panelMtr.Text = tmbl5.Text;
				keterangan.Text += tmbl5.Text;
				statusText=true;
			}
		}
		
		void Tmbl6Click(object sender, EventArgs e)
		{
			if(statusText)
			{
				//akan menggabungkan angka sebelumnya dengan inputan yang baru dimasukkan, karena variabel
				//statusText bernilai false
				panelMtr.Text += tmbl6.Text;
				keterangan.Text += tmbl6.Text;
			}
			else
			{
				//menambahkan angka baru karena variabel statusText bernilai true
				panelMtr.Text = tmbl6.Text;
				keterangan.Text += tmbl6.Text;
				statusText=true;
			}
		}
		
		void Tmbl7Click(object sender, EventArgs e)
		{
			if(statusText)
			{
				//akan menggabungkan angka sebelumnya dengan inputan yang baru dimasukkan, karena variabel
				//statusText bernilai false
				panelMtr.Text += tmbl7.Text;
				keterangan.Text += tmbl7.Text;
			}
			else
			{
				//menambahkan angka baru karena variabel statusText bernilai true
				panelMtr.Text = tmbl7.Text;
				keterangan.Text += tmbl7.Text;
				statusText=true;
			}
		}
		
		void Tmbl9Click(object sender, EventArgs e)
		{
			if(statusText)
			{
				//akan menggabungkan angka sebelumnya dengan inputan yang baru dimasukkan, karena variabel
				//statusText bernilai false
				panelMtr.Text += tmbl9.Text;
				keterangan.Text += tmbl9.Text;
			}
			else
			{
				//menambahkan angka baru karena variabel statusText bernilai true
				panelMtr.Text = tmbl9.Text;
				keterangan.Text += tmbl9.Text;
				statusText=true;
			}
		}
		
		void Tmbl8Click(object sender, EventArgs e)
		{
			if(statusText)
			{
				//akan menggabungkan angka sebelumnya dengan inputan yang baru dimasukkan, karena variabel
				//statusText bernilai false
				panelMtr.Text += tmbl8.Text;
				keterangan.Text += tmbl8.Text;
			}
			else
			{
				//menambahkan angka baru karena variabel statusText bernilai true
				panelMtr.Text = tmbl8.Text;
				keterangan.Text += tmbl8.Text;
				statusText=true;
			}
		}
		
		void Tmbl0Click(object sender, EventArgs e)
		{
			if(statusText)
			{
				//akan menggabungkan angka sebelumnya dengan inputan yang baru dimasukkan, karena variabel
				//statusText bernilai false
				panelMtr.Text += tmbl0.Text;
				keterangan.Text += tmbl0.Text;
			}
			else
			{
				//menambahkan angka baru karena variabel statusText bernilai true
				panelMtr.Text = tmbl0.Text;
				keterangan.Text += tmbl0.Text;
				statusText=true;
			}
		}
		
		void TmblAwalClick(object sender, EventArgs e)
		{
			panelMtr.Text = string.Empty;
			statusText=false;
			tanda="";
			keterangan.Text="";
		}
		
		void TmblTambahClick(object sender, EventArgs e)
		{
			if(panelMtr.Text.Length != 0)
			{
				if(tanda == "")
				{
					bilangan1 = Convert.ToDouble(panelMtr.Text);
					panelMtr.Text = "";
					keterangan.Text += tmblTambah.Text;
				}
				else
				{
					bilangan2 = Convert.ToDouble(panelMtr.Text);
					bilangan1 = bilangan1 + bilangan2;
					panelMtr.Text = bilangan1.ToString();
					keterangan.Text += tmblTambah.Text;
				}
					tanda = "Tambah";
					statusText=false;
			}
		}
		
		void TmblHapusClick(object sender, EventArgs e)
		{
			panelMtr.Text="";
		}
		
		void TmblKurangClick(object sender, EventArgs e)
		{
			if(panelMtr.Text.Length != 0)
			{
				if(tanda == "")
				{
					bilangan1 = Convert.ToDouble(panelMtr.Text);
					panelMtr.Text = "";
					keterangan.Text += tmblKurang.Text;
				}
				else
				{
					bilangan2 = Convert.ToDouble(panelMtr.Text);
					bilangan1 = bilangan1 - bilangan2;
					panelMtr.Text = bilangan1.ToString();
					keterangan.Text += tmblKurang.Text;
				}
					tanda = "Kurang";
					statusText=false;
			}
		}
		
		void TmblBagiClick(object sender, EventArgs e)
		{
			if(panelMtr.Text.Length != 0)
			{
				if(tanda == "")
				{
					bilangan1 = Convert.ToDouble(panelMtr.Text);
					panelMtr.Text = "";
					keterangan.Text += tmblBagi.Text;
				}
				else
				{
					bilangan2 = Convert.ToDouble(panelMtr.Text);
					bilangan1 = bilangan1 - bilangan2;
					panelMtr.Text = bilangan1.ToString();
					keterangan.Text += tmblBagi.Text;
				}
					tanda = "Bagi";
					statusText=false;
			}
		}
		
		void TmblKaliClick(object sender, EventArgs e)
		{
			if(panelMtr.Text.Length != 0)
			{
				if(tanda == "")
				{
					bilangan1 = Convert.ToDouble(panelMtr.Text);
					panelMtr.Text = "";
					keterangan.Text += tmblKali.Text;
				}
				else
				{
					bilangan2 = Convert.ToDouble(panelMtr.Text);
					bilangan1 = bilangan1 * bilangan2;
					panelMtr.Text = bilangan1.ToString();
					keterangan.Text += tmblKali.Text;
				}
					tanda = "Kali";
					statusText=false;
			}
		}
		
		void TmblHasilClick(object sender, EventArgs e)
		{
			if(panelMtr.Text.Length !=0)
			{
				bilangan2 = Convert.ToDouble(panelMtr.Text);
				switch(tanda)
				{
					case "Tambah":
						bilangan1=bilangan1+bilangan2;
						panelMtr.Text=bilangan1.ToString();
					break;
					
					case "Kurang":
						bilangan1=bilangan1-bilangan2;
						panelMtr.Text=bilangan1.ToString();
					break;
					
					case "Bagi":
						bilangan1=bilangan1/bilangan2;
						panelMtr.Text=bilangan1.ToString();
					break;
					
					case "Kali":
						bilangan1=bilangan1*bilangan2;
						panelMtr.Text=bilangan1.ToString();
					break;
					
				}
				statusText=false;
				tanda="";
			}
		}
		
		void TmblNegatifClick(object sender, EventArgs e)
		{
			if(panelMtr.Text.Length > 0)
			{
				bilangan1 = -1*Convert.ToDouble(panelMtr.Text);
				panelMtr.Text=bilangan1.ToString();
				keterangan.Text=bilangan1.ToString();
			}
		}
		
		void TmblAkarClick(object sender, EventArgs e)
		{
			if(panelMtr.Text=="")
			{
				panelMtr.Text="";
			}
			else{
				bilangan1 = Convert.ToDouble(panelMtr.Text);
				double hasil = System.Math.Sqrt(bilangan1);
				panelMtr.Text = hasil.ToString();
				keterangan.Text = hasil.ToString();
			}
			tanda = "Kuadrat";
		}
		
		void TmblBackSpaceClick(object sender, EventArgs e)
		{
            string teks;
            int panjang;
            if (panelMtr.Text.Length > 0)
            {
                teks = panelMtr.Text.Substring(panelMtr.Text.Length - 1);
                if (teks == ".")
                {
                    tanda = "Backspace";
                }
                panjang = panelMtr.Text.Length;
               panelMtr.Text = panelMtr.Text.Remove(panjang - 1, 1);
              keterangan.Text = keterangan.Text.Remove(panjang - 1, 1);
            }
		}
		
		void KeluarToolStripMenuItemClick(object sender, EventArgs e)
		{
            Application.Exit();
		}
		
		void TentangKamiToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Sebuah calculator sederhana yang memiliki fitur rumus bangun ruang maupun datar dan fitur convers mata uang, berat, jarak");
		}
		
		void TmblTitikClick(object sender, EventArgs e)
		{
			if (panelMtr.Text.Length != 0)
                    {
                    }
                    else
                    {
                       panelMtr.Text = "0.";
                    }
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
	}
}
