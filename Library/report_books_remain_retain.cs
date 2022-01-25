using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Library.Report;

namespace Library
{
    public partial class report_books_remain_retain : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\adoProject_Jashim\Library\library_management_system.mdf;Integrated Security=True");
        public report_books_remain_retain()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM issue_books WHERE books_return_date = ''";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            StudentReportForBookReturn bookReturn = new StudentReportForBookReturn();
            bookReturn.SetDataSource(ds);
            crystalReportViewer1.ReportSource = bookReturn;


        }

        private void report_books_remain_retain_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}
