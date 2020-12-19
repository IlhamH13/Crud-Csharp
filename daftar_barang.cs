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
    public partial class daftar_barang : Form
    {
        public daftar_barang()
        {
            InitializeComponent();
            loadBarang();
        }

        public void loadBarang()
        {
            clsSQLServer db = new clsSQLServer("");
            string sql = "SELECT KODE_BRG,NAMA_BRG,PERSEDIAAN_BRG,SATUAN_BRG,HARGA_BRG FROM TBLBARANG ORDER BY NAMA_BRG ASC";
            db.GetSummaryData(sql);
            DataTable dt = db.GetSummaryData(sql);
            grd_Barang.DataSource = dt; db.CloseDatabaseConnection();
            db = null;

        }
    }
}
