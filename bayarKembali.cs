using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class bayarKembali : Form
    {
        public static int kembali = 0;
        public static int bayar = 0;
        public bayarKembali()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hitungKembali_enter(this, new EventArgs());
            }
        }

        private void hitungKembali_enter(object sender, EventArgs e)
        {
            bayar = Convert.ToInt32(txt_bayar.Text);
            kembali = bayar - MasterTransaksi.total_harga;
            lbl_kembali.Text = kembali.ToString();
            txt_bayar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MasterTransaksi.total_harga = 0;
            MasterTransaksi mt = new MasterTransaksi();
            //mt.btnPrintClick();
            mt.Show();
            
        }

        private void bayarKembali_Load(object sender, EventArgs e)
        {
            lbl_harga.Text =  MasterTransaksi.total_harga.ToString();

        }
    }
}
