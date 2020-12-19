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
    public partial class Form1 : Form
    {
        MasterTransaksi mt = new MasterTransaksi();
        public static String persediaan;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_hargaBrg.Enabled = false;
            txt_kodeBrg.Enabled = false;
            txt_namaBrg.Enabled = false;
            txt_persediaanBrg.Enabled = false;
            comboBox1.Enabled = false;

            loadData();
        }


        public void loadData()
        {
            clsSQLServer db = new clsSQLServer("");
            string sql = "SELECT ID_BRG,KODE_BRG,NAMA_BRG,PERSEDIAAN_BRG,SATUAN_BRG,HARGA_BRG FROM tblBarang";
            db.GetSummaryData(sql);
            DataTable dt = db.GetSummaryData(sql);
            grd_Barang.DataSource = dt;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                string kode_brg = txt_kodeBrg.Text;
                clsSQLServer db = new clsSQLServer("");
                string sql = "SELECT KODE_BRG FROM TBLBARANG WHERE KODE_BRG='" + kode_brg + "'";
                string pesan = "";
                db.GetSummaryData(sql);
                DataTable dt = db.GetSummaryData(sql);
                
                string nama_brg = txt_namaBrg.Text;
                int persediaan_brg = Convert.ToInt32(persediaan);
                int tambah_brg = Convert.ToInt32(txt_persediaanBrg.Text);
                int jumlah_brg = persediaan_brg + tambah_brg;
                int harga_brg = Convert.ToInt32(txt_hargaBrg.Text);

                

                if (dt.Rows.Count == 0)
                {
                    sql = "INSERT INTO TBLBARANG(KODE_BRG,NAMA_BRG,PERSEDIAAN_BRG,SATUAN_BRG,HARGA_BRG) " +
                    "VALUES('" + kode_brg + "','" + nama_brg + "','" + jumlah_brg + "','"+comboBox1.Text+"','" + harga_brg + "')";
                    pesan = "Berhasil di simpan";
                }
                else
                {
                    sql = "UPDATE TBLBARANG SET KODE_BRG='" + kode_brg + "',NAMA_BRG='" + nama_brg + "',PERSEDIAAN_BRG='" + jumlah_brg + "',SATUAN_BRG='" + comboBox1.Text + "',HARGA_BRG='" + harga_brg + "' WHERE KODE_BRG='" + kode_brg + "'";
                    pesan = "Berhasil DI Update!";
                }
                int iRec = db.SQLCommand(sql);
                if (iRec > 0)
                {
                    MessageBox.Show(pesan);
                    loadData();
                }

                tambahBarang();
            }catch(Exception a)
            {
                MessageBox.Show("Item tidak ditambahkan \n" + a);
            }
            

        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            const string message = "Anda yakin ingin menghapus item ini?";
            const string caption = "Hapus Item?";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string kode_brg = grd_Barang.CurrentRow.Cells[1].Value.ToString();
                clsSQLServer db = new clsSQLServer("");
                string sql = "DELETE FROM TBLBARANG WHERE KODE_BRG='" + kode_brg + "'";
                int iRec = db.SQLCommand(sql);
                if (iRec > 0)
                {
                    MessageBox.Show("Berhasil Dihapus!");
                    loadData();
                }
            }
        }

        private void grd_Barang_DoubleClick(object sender, EventArgs e)
        {
            if(grd_Barang.CurrentRow.Index != -1)
            {
                txt_hargaBrg.Enabled = true;
                txt_kodeBrg.Enabled = true;
                txt_namaBrg.Enabled = true;
                txt_persediaanBrg.Enabled = true;
                comboBox1.Enabled = true;

                string kode_brg = grd_Barang.CurrentRow.Cells[1].Value.ToString();
                string nama_brg = grd_Barang.CurrentRow.Cells[2].Value.ToString();
                persediaan = grd_Barang.CurrentRow.Cells[3].Value.ToString();
                string satuan_brg = grd_Barang.CurrentRow.Cells[4].Value.ToString();
                string harga_brg = grd_Barang.CurrentRow.Cells[5].Value.ToString();

                txt_hargaBrg.Text = harga_brg;
                txt_kodeBrg.Text = kode_brg;
                txt_namaBrg.Text = nama_brg;
                txt_persediaanBrg.Text = Convert.ToString(0);
                comboBox1.Text = satuan_brg;

                txt_kodeBrg.Enabled = false;
            }
        }

        private void loadData_enter(object sender, EventArgs e)
        {
            string kode_brg = txt_kodeBrg.Text;
            clsSQLServer db = new clsSQLServer("");
            string sql = "SELECT * FROM TBLBARANG WHERE kode_brg ='" + kode_brg + "'";
            db.GetSummaryData(sql);
            DataTable dt = db.GetSummaryData(sql);

            if (dt.Rows.Count == 1)
            {
                string nama_brg = dt.Rows[0]["nama_brg"].ToString();
                int harga_brg = Convert.ToInt32(dt.Rows[0]["harga_brg"].ToString());
                int persediaan_brg = Convert.ToInt32(dt.Rows[0]["persediaan_brg"].ToString());

                txt_namaBrg.Text = nama_brg;
                txt_hargaBrg.Text = harga_brg.ToString();
                txt_persediaanBrg.Text = persediaan_brg.ToString();
            }
            else
            {
                MessageBox.Show("Barang tidak terdaftar");
            }


        }
        private void Klik_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadData_enter(this, new EventArgs());
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            txt_kodeBrg.Enabled = true;
            txt_hargaBrg.Text = "";
            txt_kodeBrg.Text = "";
            txt_namaBrg.Text = "";
            txt_persediaanBrg.Text = "";
        }

        private void masterTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void daftarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createAccount ca = new createAccount();
            ca.Show();
        }

        private void tambahBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tambahBarang();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        public void tambahBarang()
        {
            txt_kodeBrg.Enabled = true;
            txt_hargaBrg.Text = "";
            txt_kodeBrg.Text = "";
            txt_namaBrg.Text = "";
            txt_persediaanBrg.Text = "";

            txt_hargaBrg.Enabled = true;
            Random rnd = new Random();
            int kode_trs = rnd.Next(1, 10000);
            string str_kode_trs = "BRG-" + kode_trs.ToString();

            txt_kodeBrg.Text = str_kode_trs;
            txt_kodeBrg.Enabled = true;
            txt_namaBrg.Enabled = true;
            txt_persediaanBrg.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void transaksiBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            mt.Show();
            this.Hide();
            mt.transaksiBaru();
        }

        private void laporanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mt.laporan();
        }

        private void daftarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            createAccount ca = new createAccount();
            ca.Show();
        }

        private void masterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuAwalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuAwal ma = new menuAwal();
            ma.Show();
            this.Hide();
        }
    }
}
