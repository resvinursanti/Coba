/*
 * Created by SharpDevelop.
 * User: Suma Wijaya
 * Date: 01/11/2010
 * Time: 17:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace simple_kalkulator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.keterangan = new System.Windows.Forms.TextBox();
			this.panelMtr = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.berkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tentangKamiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tmblBackSpace = new System.Windows.Forms.Button();
			this.tmblHapus = new System.Windows.Forms.Button();
			this.tmblAwal = new System.Windows.Forms.Button();
			this.tmblPersen = new System.Windows.Forms.Button();
			this.tmbl7 = new System.Windows.Forms.Button();
			this.tmbl8 = new System.Windows.Forms.Button();
			this.tmbl9 = new System.Windows.Forms.Button();
			this.tmbl4 = new System.Windows.Forms.Button();
			this.tmbl5 = new System.Windows.Forms.Button();
			this.tmbl6 = new System.Windows.Forms.Button();
			this.tmbl1 = new System.Windows.Forms.Button();
			this.tmbl2 = new System.Windows.Forms.Button();
			this.tmbl3 = new System.Windows.Forms.Button();
			this.tmblKurang = new System.Windows.Forms.Button();
			this.tmblTambah = new System.Windows.Forms.Button();
			this.tmblBagi = new System.Windows.Forms.Button();
			this.tmblKali = new System.Windows.Forms.Button();
			this.tmblNegatif = new System.Windows.Forms.Button();
			this.tmblHasil = new System.Windows.Forms.Button();
			this.tmbl0 = new System.Windows.Forms.Button();
			this.tmblAkar = new System.Windows.Forms.Button();
			this.tmblTitik = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.keterangan);
			this.groupBox1.Controls.Add(this.panelMtr);
			this.groupBox1.Location = new System.Drawing.Point(12, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(218, 72);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Panel Layar";
			// 
			// keterangan
			// 
			this.keterangan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.keterangan.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.keterangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.keterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.keterangan.Location = new System.Drawing.Point(6, 20);
			this.keterangan.MaxLength = 16;
			this.keterangan.Name = "keterangan";
			this.keterangan.ReadOnly = true;
			this.keterangan.Size = new System.Drawing.Size(206, 19);
			this.keterangan.TabIndex = 3;
			this.keterangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// panelMtr
			// 
			this.panelMtr.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panelMtr.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.panelMtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelMtr.Location = new System.Drawing.Point(6, 39);
			this.panelMtr.MaxLength = 16;
			this.panelMtr.Name = "panelMtr";
			this.panelMtr.ReadOnly = true;
			this.panelMtr.Size = new System.Drawing.Size(206, 24);
			this.panelMtr.TabIndex = 2;
			this.panelMtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.berkasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(241, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// berkasToolStripMenuItem
			// 
			this.berkasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tentangKamiToolStripMenuItem,
									this.keluarToolStripMenuItem});
			this.berkasToolStripMenuItem.Name = "berkasToolStripMenuItem";
			this.berkasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.berkasToolStripMenuItem.Text = "Berkas";
			// 
			// tentangKamiToolStripMenuItem
			// 
			this.tentangKamiToolStripMenuItem.Name = "tentangKamiToolStripMenuItem";
			this.tentangKamiToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.tentangKamiToolStripMenuItem.Text = "Tentang Saya :D";
			this.tentangKamiToolStripMenuItem.Click += new System.EventHandler(this.TentangKamiToolStripMenuItemClick);
			// 
			// keluarToolStripMenuItem
			// 
			this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
			this.keluarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.keluarToolStripMenuItem.Text = "Keluar ->";
			this.keluarToolStripMenuItem.Click += new System.EventHandler(this.KeluarToolStripMenuItemClick);
			// 
			// tmblBackSpace
			// 
			this.tmblBackSpace.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblBackSpace.Location = new System.Drawing.Point(16, 127);
			this.tmblBackSpace.Name = "tmblBackSpace";
			this.tmblBackSpace.Size = new System.Drawing.Size(80, 27);
			this.tmblBackSpace.TabIndex = 2;
			this.tmblBackSpace.Text = "backspace";
			this.tmblBackSpace.UseVisualStyleBackColor = true;
			this.tmblBackSpace.Click += new System.EventHandler(this.TmblBackSpaceClick);
			// 
			// tmblHapus
			// 
			this.tmblHapus.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblHapus.Location = new System.Drawing.Point(102, 127);
			this.tmblHapus.Name = "tmblHapus";
			this.tmblHapus.Size = new System.Drawing.Size(37, 27);
			this.tmblHapus.TabIndex = 3;
			this.tmblHapus.Text = "CE";
			this.tmblHapus.UseVisualStyleBackColor = true;
			this.tmblHapus.Click += new System.EventHandler(this.TmblHapusClick);
			// 
			// tmblAwal
			// 
			this.tmblAwal.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblAwal.Location = new System.Drawing.Point(145, 127);
			this.tmblAwal.Name = "tmblAwal";
			this.tmblAwal.Size = new System.Drawing.Size(37, 27);
			this.tmblAwal.TabIndex = 4;
			this.tmblAwal.Text = "C";
			this.tmblAwal.UseVisualStyleBackColor = true;
			this.tmblAwal.Click += new System.EventHandler(this.TmblAwalClick);
			// 
			// tmblPersen
			// 
			this.tmblPersen.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblPersen.Location = new System.Drawing.Point(188, 127);
			this.tmblPersen.Name = "tmblPersen";
			this.tmblPersen.Size = new System.Drawing.Size(37, 27);
			this.tmblPersen.TabIndex = 5;
			this.tmblPersen.Text = "%";
			this.tmblPersen.UseVisualStyleBackColor = true;
			// 
			// tmbl7
			// 
			this.tmbl7.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmbl7.Location = new System.Drawing.Point(16, 160);
			this.tmbl7.Name = "tmbl7";
			this.tmbl7.Size = new System.Drawing.Size(37, 27);
			this.tmbl7.TabIndex = 6;
			this.tmbl7.Text = "7";
			this.tmbl7.UseVisualStyleBackColor = true;
			this.tmbl7.Click += new System.EventHandler(this.Tmbl7Click);
			// 
			// tmbl8
			// 
			this.tmbl8.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmbl8.Location = new System.Drawing.Point(59, 160);
			this.tmbl8.Name = "tmbl8";
			this.tmbl8.Size = new System.Drawing.Size(37, 27);
			this.tmbl8.TabIndex = 7;
			this.tmbl8.Text = "8";
			this.tmbl8.UseVisualStyleBackColor = true;
			this.tmbl8.Click += new System.EventHandler(this.Tmbl8Click);
			// 
			// tmbl9
			// 
			this.tmbl9.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmbl9.Location = new System.Drawing.Point(102, 160);
			this.tmbl9.Name = "tmbl9";
			this.tmbl9.Size = new System.Drawing.Size(37, 27);
			this.tmbl9.TabIndex = 8;
			this.tmbl9.Text = "9";
			this.tmbl9.UseVisualStyleBackColor = true;
			this.tmbl9.Click += new System.EventHandler(this.Tmbl9Click);
			// 
			// tmbl4
			// 
			this.tmbl4.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmbl4.Location = new System.Drawing.Point(16, 193);
			this.tmbl4.Name = "tmbl4";
			this.tmbl4.Size = new System.Drawing.Size(37, 27);
			this.tmbl4.TabIndex = 9;
			this.tmbl4.Text = "4";
			this.tmbl4.UseVisualStyleBackColor = true;
			this.tmbl4.Click += new System.EventHandler(this.Tmbl4Click);
			// 
			// tmbl5
			// 
			this.tmbl5.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmbl5.Location = new System.Drawing.Point(59, 193);
			this.tmbl5.Name = "tmbl5";
			this.tmbl5.Size = new System.Drawing.Size(37, 27);
			this.tmbl5.TabIndex = 10;
			this.tmbl5.Text = "5";
			this.tmbl5.UseVisualStyleBackColor = true;
			this.tmbl5.Click += new System.EventHandler(this.Tmbl5Click);
			// 
			// tmbl6
			// 
			this.tmbl6.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmbl6.Location = new System.Drawing.Point(102, 193);
			this.tmbl6.Name = "tmbl6";
			this.tmbl6.Size = new System.Drawing.Size(37, 27);
			this.tmbl6.TabIndex = 11;
			this.tmbl6.Text = "6";
			this.tmbl6.UseVisualStyleBackColor = true;
			this.tmbl6.Click += new System.EventHandler(this.Tmbl6Click);
			// 
			// tmbl1
			// 
			this.tmbl1.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmbl1.Location = new System.Drawing.Point(16, 226);
			this.tmbl1.Name = "tmbl1";
			this.tmbl1.Size = new System.Drawing.Size(37, 27);
			this.tmbl1.TabIndex = 12;
			this.tmbl1.Text = "1";
			this.tmbl1.UseVisualStyleBackColor = true;
			this.tmbl1.Click += new System.EventHandler(this.Tmbl1Click);
			// 
			// tmbl2
			// 
			this.tmbl2.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmbl2.Location = new System.Drawing.Point(59, 226);
			this.tmbl2.Name = "tmbl2";
			this.tmbl2.Size = new System.Drawing.Size(37, 27);
			this.tmbl2.TabIndex = 13;
			this.tmbl2.Text = "2";
			this.tmbl2.UseVisualStyleBackColor = true;
			this.tmbl2.Click += new System.EventHandler(this.Tmbl2Click);
			// 
			// tmbl3
			// 
			this.tmbl3.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmbl3.Location = new System.Drawing.Point(102, 226);
			this.tmbl3.Name = "tmbl3";
			this.tmbl3.Size = new System.Drawing.Size(37, 27);
			this.tmbl3.TabIndex = 14;
			this.tmbl3.Text = "3";
			this.tmbl3.UseVisualStyleBackColor = true;
			this.tmbl3.Click += new System.EventHandler(this.Tmbl3Click);
			// 
			// tmblKurang
			// 
			this.tmblKurang.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblKurang.Location = new System.Drawing.Point(145, 160);
			this.tmblKurang.Name = "tmblKurang";
			this.tmblKurang.Size = new System.Drawing.Size(37, 27);
			this.tmblKurang.TabIndex = 15;
			this.tmblKurang.Text = "-";
			this.tmblKurang.UseVisualStyleBackColor = true;
			this.tmblKurang.Click += new System.EventHandler(this.TmblKurangClick);
			// 
			// tmblTambah
			// 
			this.tmblTambah.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblTambah.Location = new System.Drawing.Point(145, 193);
			this.tmblTambah.Name = "tmblTambah";
			this.tmblTambah.Size = new System.Drawing.Size(37, 27);
			this.tmblTambah.TabIndex = 16;
			this.tmblTambah.Text = "+";
			this.tmblTambah.UseVisualStyleBackColor = true;
			this.tmblTambah.Click += new System.EventHandler(this.TmblTambahClick);
			// 
			// tmblBagi
			// 
			this.tmblBagi.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblBagi.Location = new System.Drawing.Point(145, 226);
			this.tmblBagi.Name = "tmblBagi";
			this.tmblBagi.Size = new System.Drawing.Size(37, 27);
			this.tmblBagi.TabIndex = 17;
			this.tmblBagi.Text = "/";
			this.tmblBagi.UseVisualStyleBackColor = true;
			this.tmblBagi.Click += new System.EventHandler(this.TmblBagiClick);
			// 
			// tmblKali
			// 
			this.tmblKali.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblKali.Location = new System.Drawing.Point(175, 52);
			this.tmblKali.Name = "tmblKali";
			this.tmblKali.Size = new System.Drawing.Size(37, 27);
			this.tmblKali.TabIndex = 18;
			this.tmblKali.Text = "x";
			this.tmblKali.UseVisualStyleBackColor = true;
			this.tmblKali.Click += new System.EventHandler(this.TmblKaliClick);
			// 
			// tmblNegatif
			// 
			this.tmblNegatif.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblNegatif.Location = new System.Drawing.Point(188, 193);
			this.tmblNegatif.Name = "tmblNegatif";
			this.tmblNegatif.Size = new System.Drawing.Size(37, 27);
			this.tmblNegatif.TabIndex = 19;
			this.tmblNegatif.Text = "+/-";
			this.tmblNegatif.UseVisualStyleBackColor = true;
			this.tmblNegatif.Click += new System.EventHandler(this.TmblNegatifClick);
			// 
			// tmblHasil
			// 
			this.tmblHasil.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblHasil.Location = new System.Drawing.Point(102, 259);
			this.tmblHasil.Name = "tmblHasil";
			this.tmblHasil.Size = new System.Drawing.Size(80, 27);
			this.tmblHasil.TabIndex = 20;
			this.tmblHasil.Text = "=";
			this.tmblHasil.UseVisualStyleBackColor = true;
			this.tmblHasil.Click += new System.EventHandler(this.TmblHasilClick);
			// 
			// tmbl0
			// 
			this.tmbl0.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmbl0.Location = new System.Drawing.Point(4, 151);
			this.tmbl0.Name = "tmbl0";
			this.tmbl0.Size = new System.Drawing.Size(80, 27);
			this.tmbl0.TabIndex = 21;
			this.tmbl0.Text = "0";
			this.tmbl0.UseVisualStyleBackColor = true;
			this.tmbl0.Click += new System.EventHandler(this.Tmbl0Click);
			// 
			// tmblAkar
			// 
			this.tmblAkar.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblAkar.Location = new System.Drawing.Point(188, 226);
			this.tmblAkar.Name = "tmblAkar";
			this.tmblAkar.Size = new System.Drawing.Size(37, 27);
			this.tmblAkar.TabIndex = 22;
			this.tmblAkar.Text = "√";
			this.tmblAkar.UseVisualStyleBackColor = true;
			this.tmblAkar.Click += new System.EventHandler(this.TmblAkarClick);
			// 
			// tmblTitik
			// 
			this.tmblTitik.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmblTitik.Location = new System.Drawing.Point(188, 259);
			this.tmblTitik.Name = "tmblTitik";
			this.tmblTitik.Size = new System.Drawing.Size(37, 27);
			this.tmblTitik.TabIndex = 23;
			this.tmblTitik.Text = ",";
			this.tmblTitik.UseVisualStyleBackColor = true;
			this.tmblTitik.Click += new System.EventHandler(this.TmblTitikClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tmblKali);
			this.groupBox2.Controls.Add(this.tmbl0);
			this.groupBox2.Location = new System.Drawing.Point(12, 108);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(218, 188);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Panel Tombol";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 306);
			this.Controls.Add(this.tmblTitik);
			this.Controls.Add(this.tmblAkar);
			this.Controls.Add(this.tmblHasil);
			this.Controls.Add(this.tmblNegatif);
			this.Controls.Add(this.tmblBagi);
			this.Controls.Add(this.tmblTambah);
			this.Controls.Add(this.tmblKurang);
			this.Controls.Add(this.tmbl3);
			this.Controls.Add(this.tmbl2);
			this.Controls.Add(this.tmbl1);
			this.Controls.Add(this.tmbl6);
			this.Controls.Add(this.tmbl5);
			this.Controls.Add(this.tmbl4);
			this.Controls.Add(this.tmbl9);
			this.Controls.Add(this.tmbl8);
			this.Controls.Add(this.tmbl7);
			this.Controls.Add(this.tmblPersen);
			this.Controls.Add(this.tmblAwal);
			this.Controls.Add(this.tmblHapus);
			this.Controls.Add(this.tmblBackSpace);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Kalkulator Sederhana";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox keterangan;
		private System.Windows.Forms.Button tmblBackSpace;
		private System.Windows.Forms.Button tmblHapus;
		private System.Windows.Forms.Button tmblAwal;
		private System.Windows.Forms.Button tmblPersen;
		private System.Windows.Forms.Button tmbl7;
		private System.Windows.Forms.Button tmbl8;
		private System.Windows.Forms.Button tmbl9;
		private System.Windows.Forms.Button tmbl4;
		private System.Windows.Forms.Button tmbl5;
		private System.Windows.Forms.Button tmbl6;
		private System.Windows.Forms.Button tmbl3;
		private System.Windows.Forms.Button tmblKurang;
		private System.Windows.Forms.Button tmblTambah;
		private System.Windows.Forms.Button tmblBagi;
		private System.Windows.Forms.Button tmblKali;
		private System.Windows.Forms.Button tmblNegatif;
		private System.Windows.Forms.Button tmblHasil;
		private System.Windows.Forms.Button tmbl0;
		private System.Windows.Forms.Button tmblAkar;
		private System.Windows.Forms.Button tmblTitik;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button tmbl2;
		private System.Windows.Forms.Button tmbl1;
		private System.Windows.Forms.TextBox panelMtr;
		private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tentangKamiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem berkasToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
