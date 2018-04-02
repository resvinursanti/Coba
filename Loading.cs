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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMulai GB = new FormMulai();
            GB.Show();
            this.Hide();
        }
    }
}
