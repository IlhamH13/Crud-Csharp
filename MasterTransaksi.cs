using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace WindowsFormsApp1
{
    public partial class MasterTransaksi : Form
    {
        //Inisialisasi Variable Instance
        public static int total_harga;
        static int irec = 0;
        static string kode_trsStatic = "";
        static string selectItem = "";
        static string kode_barang = "";

        
        public MasterTransaksi()
        {
            InitializeComponent();
        }

        private void MasterTransaksi_Load(object sender, EventArgs e)
        {
            loadSemua();
        }

        private void loadSemua()
        {
            loadDataBarang();
            clear();
        }

        private void grd_Barang_DoubleClick(object sender, EventArgs e)
        {
            if (grd_brg.CurrentRow.Index != -1)
            {
                string kode_brg = grd_brg.CurrentRow.Cells[0].Value.ToString();
                string nama_brg = grd_brg.CurrentRow.Cells[1].Value.ToString();
                string harga_brg = grd_brg.CurrentRow.Cells[4].Value.ToString();

                txt_hargaBrg.Text = harga_brg;
                txt_cariBrg.Text = kode_brg;
                txt_namaBrg.Text = nama_brg;
            }
        }

        public void loadDataBarang()
        {
            clsSQLServer db = new clsSQLServer("");
            string sql = "SELECT KODE_BRG,NAMA_BRG,PERSEDIAAN_BRG,SATUAN_BRG,HARGA_BRG FROM tblBarang";
            db.GetSummaryData(sql);
            DataTable dt = db.GetSummaryData(sql);
            grd_brg.DataSource = dt;
        }

        private void loadData()
        {
            //load data
            clsSQLServer db = new clsSQLServer("");
            string sql = "select a.nama_brg,a.harga_brg,b.kode_trs,b.kuantitasBrg_trs,b.tgl_trs,b.totHarga_trs " +
                "from tblBarang a right join tblTransaksi b on a.id_brg = b.id_brg where kode_trs ='" +kode_trsStatic+ "' order by id_trs desc";
            db.GetSummaryData(sql);
            DataTable dt = db.GetSummaryData(sql);
            db = null;

            grdTransaksi.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bayarKembali bk = new bayarKembali();

            string sqlBarang = "";

            Random rnd = new Random();
            int kode_trs = rnd.Next(1, 10000);
            string strKode_trs = "TRS-" + kode_trs.ToString();

            clsSQLServer db = new clsSQLServer("");

            for (int j=0;j<listBox1.Items.Count;j++)
            {
                string sql = "SELECT NAMA_BRG, KODE_BRG, ID_BRG, HARGA_BRG,PERSEDIAAN_BRG FROM TBLBARANG WHERE NAMA_BRG='" + listBox1.Items[j] + "'";
                db.GetSummaryData(sql);
                DataTable dt = db.GetSummaryData(sql);

                string kode_brg = dt.Rows[0]["kode_brg"].ToString(); 
                string nama_brg = listBox1.Items[j].ToString(); 
                int jumlahBrg_trs = Convert.ToInt32(listBox2.Items[j]); 
                int harga_brg = Convert.ToInt32(dt.Rows[0]["harga_brg"]); 
                int totHarga_trs = jumlahBrg_trs * harga_brg;
                int id_brg = Convert.ToInt32(dt.Rows[0]["ID_BRG"]);
                int persediaan_brg = Convert.ToInt32(dt.Rows[0]["PERSEDIAAN_BRG"]);
                int sisa_brg = persediaan_brg - jumlahBrg_trs;

                if (sisa_brg < 0)
                {
                    MessageBox.Show("Barang Sudah Habis");
                }
                else
                {
                    DateTime dateTime = DateTime.UtcNow.Date;
                    string tanggal_trs = dateTime.ToString();

                    sql = "SELECT kode_trs FROM TBLTRANSAKSI WHERE kode_trs='" + strKode_trs + "'";
                    db.GetSummaryData(sql);
                    DataTable dt2 = db.GetSummaryData(sql);

                    sql = "INSERT INTO TBLTRANSAKSI(KODE_TRS,TGL_TRS,TOTHARGA_TRS,KUANTITASBRG_TRS,ID_BRG) VALUES('" + strKode_trs + "','" + tanggal_trs + "','" + totHarga_trs + "','" + jumlahBrg_trs + "','" + id_brg + "')";
                    sqlBarang = "UPDATE TBLBARANG SET PERSEDIAAN_BRG='" + sisa_brg + "' WHERE ID_BRG ='" + id_brg + "'";

                }

                db.SQLCommand(sqlBarang);
                int iRec = db.SQLCommand(sql);
                if (iRec > 0)
                {
                    irec++;
                }
            }

            if (irec > 0)
            {

                bk.Show();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                
                lbl_total.Text = "";
            }

            kode_trsStatic = strKode_trs;
            loadSemua();
            loadData();
            db.CloseDatabaseConnection(); db = null;

        }
        
        private void clear()
        {
            txt_cariBrg.Text = "";
            txt_jumlah.Text = "";
            //cbo_barang.Text = "";
        }

        private void MasterTransaksi_DoubleClick(object sender, EventArgs e)
        {
            loadSemua();
        }

        private void daftarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createAccount ca = new createAccount();
            ca.Show();

        }

        private void masterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txt_kodeTrs_Enter(object sender, EventArgs e)
        {

        }

        private void loadData_enter(object sender, EventArgs e)
        {
            string kode_brg = txt_cariBrg.Text;
            clsSQLServer db = new clsSQLServer("");
            string sql = "SELECT * FROM TBLBARANG WHERE kode_brg ='" + kode_brg + "'";
            db.GetSummaryData(sql);
            DataTable dt = db.GetSummaryData(sql);

            if (dt.Rows.Count == 1)
            {
                string nama_brg = dt.Rows[0]["nama_brg"].ToString();
                int harga_brg = Convert.ToInt32(dt.Rows[0]["harga_brg"].ToString());

                txt_namaBrg.Text = nama_brg;
                txt_hargaBrg.Text = harga_brg.ToString();
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
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void btn_beli_Click(object sender, EventArgs e)
        {
            try
            {
                string nama_brg = txt_namaBrg.Text;
                string harga_brg = txt_hargaBrg.Text;
                string jumlah_brg = txt_jumlah.Text;
                string kode_brg = txt_cariBrg.Text;

                int harga_brgTot = Convert.ToInt32(harga_brg) * Convert.ToInt32(jumlah_brg);

                clsSQLServer db = new clsSQLServer("");
                string sql = "SELECT persediaan_brg FROM TBLBARANG WHERE kode_brg ='" + txt_cariBrg.Text + "'";
                db.GetSummaryData(sql);
                DataTable dt = db.GetSummaryData(sql);

                int persediaan_brg = Convert.ToInt32(dt.Rows[0]["persediaan_brg"]);
                int sisa_brg = persediaan_brg - Convert.ToInt32(jumlah_brg);

                if (sisa_brg < 0)
                {
                    MessageBox.Show("Barang sudah habis");
                }
                else
                {
                    total_harga += harga_brgTot;

                    if (txt_hargaBrg.Text != "" && txt_namaBrg.Text != "")
                    {
                        listBox1.Items.Add(nama_brg);
                        listBox2.Items.Add(jumlah_brg);
                        listBox3.Items.Add(kode_brg);
                    }
                    else
                    {
                        btn_masukan.Enabled = false;
                    }

                    txt_cariBrg.Text = "";
                    txt_jumlah.Text = "";
                    txt_namaBrg.Text = "";
                    txt_hargaBrg.Text = "";
                    lbl_total.Text = total_harga.ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Item tidak dapat dimasukan kedalam keranjang "+ a);
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBox1_delItem(this, new EventArgs());
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                if (listBox2.Items.Count > listBox1.SelectedIndex) //checking if listBox2 has enough items to select
                {
                    listBox2.SelectedIndex = listBox1.SelectedIndex;
                    listBox3.SelectedIndex = listBox1.SelectedIndex;
                }
            }
            selectItem = listBox2.SelectedItem.ToString();
            kode_barang = listBox3.SelectedItem.ToString();


        }

        private void listBox1_delItem(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            listBox3.Items.RemoveAt(listBox3.SelectedIndex);

            clsSQLServer db = new clsSQLServer("");
            string sql = "SELECT harga_brg FROM TBLBARANG WHERE kode_brg='" + kode_barang + "'";
            db.GetSummaryData(sql);
            DataTable dt = db.GetSummaryData(sql);
            db.CloseDatabaseConnection(); db = null;

            int harga_brg = Convert.ToInt32(dt.Rows[0]["harga_brg"]);

            total_harga -= Convert.ToInt32(selectItem) * harga_brg;
            lbl_total.Text = total_harga.ToString();

        }

        public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            var font = new Font("Arial", 12);
            int row = 90;

            e.Graphics.DrawString("Transaksi Pembelian \n", font, Brushes.Black, 50, 10);
            e.Graphics.DrawString("\n" + "No Transaksi" + "\t" + ": " + kode_trsStatic, font, Brushes.Black, 25, 30);
            e.Graphics.DrawString("\n" + "Barang Yang dibeli" + "\t" + "\t" + ":", font, Brushes.Black, 25, 50);
            for (int i = 0; i < grdTransaksi.RowCount; i++)
            {
                e.Graphics.DrawString("\t"+grdTransaksi.Rows[i].Cells["clmNamaBarang"].Value.ToString() + "\t" +grdTransaksi.Rows[i].Cells["clmTotHargaTrs"].Value.ToString(), font, Brushes.Black, 25, row);
                row += 20;
            }
            e.Graphics.DrawString("\n" + "Harga Total" + "\t" + ": " + total_harga + "\n", font, Brushes.Black, 25, row);
            e.Graphics.DrawString("\n" + "Bayar" + "\t" + ": " + bayarKembali.bayar + "\n", font, Brushes.Black, 25, row+20);
            e.Graphics.DrawString("\n" + "Kembali" + "\t" + ": " + bayarKembali.kembali + "\n", font, Brushes.Black, 25, row+40);
            
            
            
        }

        public void btnPrintClick()
        {
            PrinterSettings ps = new PrinterSettings();
            recordDoc.PrinterSettings = ps;
            recordDoc.DefaultPageSettings.PaperSize = new PaperSize("55 x 297 mm", 340, 800);

            PrintPreviewDialog ppvw = new PrintPreviewDialog();
            ppvw.Document = recordDoc;
            ppvw.PrintPreviewControl.Zoom = 1;
            ppvw.ShowDialog();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            btnPrintClick();       
        }

        private void transaksiBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transaksiBaru();
        }

        private void tambahBarangBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            fm.tambahBarang();
            this.Hide();
        }

        public void laporan()
        {
            RepViewer rv = new RepViewer();
            rv.Show();
        }

        private void laporanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            laporan();
        }

        public void transaksiBaru()
        {
            txt_cariBrg.Text = "";
            txt_jumlah.Text = "";
            txt_namaBrg.Text = "";
            txt_hargaBrg.Text = "";
            total_harga = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            lbl_total.Text = "0";
            grdTransaksi.Refresh();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
        }

        private void menuAwalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuAwal ma = new menuAwal();
            ma.Show();
            this.Hide();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}


