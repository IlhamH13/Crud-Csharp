using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApp1
{
    public partial class RepViewer : Form
    {
        public RepViewer()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Enabled = false;
            //dateTimePicker2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string tglDari = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string tglSampai = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            string sql = "SELECT dbo.tblBarang.kode_brg, dbo.tblBarang.nama_brg, dbo.tblBarang.harga_brg, dbo.tblTransaksi.kode_trs, dbo.tblTransaksi.tgl_trs, dbo.tblTransaksi.totHarga_trs, dbo.tblTransaksi.kuantitasBrg_trs FROM dbo.tblBarang INNER JOIN dbo.tblTransaksi ON dbo.tblBarang.id_brg = dbo.tblTransaksi.id_brg WHERE dbo.tblTransaksi.tgl_trs >= '" + tglDari + "' AND dbo.tblTransaksi.tgl_trs <= '" + tglSampai + "' ORDER BY dbo.tblTransaksi.id_trs DESC";


            clsSQLServer db = new clsSQLServer("");
            db.GetSummaryData(sql);
            DataTable dt = db.GetSummaryData(sql);

            ReportDocument myReportDocument;
            myReportDocument = new ReportDocument();
            myReportDocument.Load(@"C:\Users\ilham\source\repos\WindowsFormsApp1\WindowsFormsApp1\repTransaksi.rpt");
            myReportDocument.SetDataSource(dt);
            myReportDocument.SetDatabaseLogon("sa", "123");
            crystalReportViewer1.ReportSource = myReportDocument;
            crystalReportViewer1.DisplayToolbar = true;

            db.CloseDatabaseConnection(); db = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string tglDari = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string tglSampai = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            loadData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBox1.Checked == true)
            {
                loadData();
            }
            else
            {
                crystalReportViewer1.ReportSource = null;
            }*/

        }

        private void cbo_detail_CheckedChanged(object sender, EventArgs e)
        {
            /*if (cbo_detail.Checked == false)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
