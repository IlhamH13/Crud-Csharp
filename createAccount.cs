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
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
        }

        private void createAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txt_username.Text;

            string pass = txt_password.Text;
            clsEncrypt cls = new clsEncrypt();
            string pass_md5 = cls.Ekrip(pass);
            cls = null;

            String sql = "";
            clsSQLServer db = new clsSQLServer("");
            sql = "SELECT ID_AKUN FROM TBLLOGIN WHERE USERNAME='" + username + "'";
            db.GetSummaryData(sql);
            DataTable dt = db.GetSummaryData(sql);

            if (dt.Rows.Count == 0)
            {
                sql = "INSERT INTO TBLLOGIN(USERNAME,PASSWORD) VALUES('" + username + "','" + pass_md5 + "')";
            }
            else
            {
                MessageBox.Show("Data Sudah ada");
            }
            int iRec = db.SQLCommand(sql);
            if (iRec > 0)
            {
                MessageBox.Show("Berhasil disimpan!");

            }
            db.CloseDatabaseConnection(); db = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MasterTransaksi mt = new MasterTransaksi();
            mt.Show();
            this.Hide();
        }
    }
}
