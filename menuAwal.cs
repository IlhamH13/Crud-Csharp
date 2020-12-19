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
    public partial class menuAwal : Form
    {
        public menuAwal()
        {
            InitializeComponent();
        }

        private void menuAwal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void masterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tambahBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transaksiBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterTransaksi mt = new MasterTransaksi();
            mt.Show();
            this.Hide();
        }

        private void laporanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RepViewer rt = new RepViewer();
            rt.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
