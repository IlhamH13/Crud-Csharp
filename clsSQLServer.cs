using System;

public class clsSQLServer
{
    private System.Data.SqlClient.SqlConnection conn;

    string IP = null;
    string Database = null;
    string UserName = null;
    string Password = null;

    public clsSQLServer(string FILE)
    {
        CreateDatabaseConection(FILE);
    }

    public string DatabaseConnection
    {
        get
        {
            return conn.State.ToString().ToUpper();
        }
    }

    private void CreateDatabaseConection(string FILE)
    {
        //Database property
        IP = "DESKTOP-INCKF0L\\SA";
        Database = "Projek2";

        UserName = "sa";
        Password = "123";

        string p_conn_db = "Data Source=" + IP + ";Persist Security Info=false;Initial Catalog=" +
            Database + ";User ID=" + UserName + ";PWD=" + Password + ";";

        conn = new System.Data.SqlClient.SqlConnection(p_conn_db);
        conn.Open();
    }

    public void CloseDatabaseConnection()
    {
        conn.Close();
        conn.Dispose();
    }

    public System.Data.DataTable GetSummaryData(string SQLStatement)
    {
        System.Data.DataTable dt = new System.Data.DataTable();

        if (conn.State.ToString().Equals("Open"))
        {
            System.Data.SqlClient.SqlCommand cmd = new
                System.Data.SqlClient.SqlCommand(SQLStatement, conn);

            using (System.Data.SqlClient.SqlDataAdapter rsAdapter = new
                System.Data.SqlClient.SqlDataAdapter())
            {
                rsAdapter.SelectCommand = cmd;
                rsAdapter.Fill(dt);
            }
        }

        return dt;
    }

    public int SQLCommand(string SQLStatement)
    {
        int irec = 0;

        if (conn.State.ToString().Equals("Open"))
        {
            System.Data.SqlClient.SqlCommand cmd = new
                System.Data.SqlClient.SqlCommand(SQLStatement, conn);
            irec = cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        return irec;
    }
}