using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public static bool session = false;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            klik_login(this, new EventArgs());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void klik_login(object sender,EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            clsEncrypt enk = new clsEncrypt();
            string passmd5 = enk.Ekrip(password);
            enk = null;

            clsSQLServer db = new clsSQLServer("");
            string sql = "SELECT * FROM TBLLOGIN WHERE USERNAME='" + username + "' AND PASSWORD='" + passmd5 + "'";
            db.GetSummaryData(sql);
            DataTable dt = db.GetSummaryData(sql);
            db.CloseDatabaseConnection(); db = null;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("User tidak terdaftar!");
                return;
            }
            else
            {
                menuAwal main = new menuAwal();
                main.Show();
                this.Hide();
            }
            DateTime dateTime = DateTime.UtcNow.Date;
            Console.WriteLine("Login : " + DateTime.Now.ToString());
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                klik_login(this, new EventArgs());
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
