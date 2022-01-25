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

namespace Library
{
    public partial class return_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\adoProject_Jashim\Library\library_management_system.mdf;Integrated Security=True");

        public return_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM issue_books WHERE student_enrollment_no = '" + txtReturnBooksEnrollmentNumber.Text + "' "; //Works to be done
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvReturnBooksUpper.DataSource = dt;
            //fillGrid(txtReturnBooksEnrollmentNumber.Text);
        }

        private void return_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        public void fillGrid(string txtReturnBooksEnrollmentNumber)
        {

            try
            {
                //Check carefully

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM issue_books WHERE student_enrollment_no = '" + txtReturnBooksEnrollmentNumber.ToString() + "' and books_return_date= '' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvReturnBooksUpper.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void dgvReturnBooksUpper_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            panel3.Visible = true;
            int i;
            i = Convert.ToInt32(dgvReturnBooksUpper.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM issue_books WHERE id= "+i+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblBooksName.Text = dr["books_name"].ToString();
                lblIssueDate.Text = dr["books_issue_date"].ToString();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dgvReturnBooksUpper.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE issue_books SET books_return_date = '"+dateTimePicker1.Value.ToString()+"' WHERE id= " + i + "";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "UPDATE books_info SET books_quantity = books_quantity + 1 WHERE books_name = " + lblBooksName.Text + "";
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Books Returned Succesfully.");
           
            panel3.Visible = true;
            fillGrid(txtReturnBooksEnrollmentNumber.Text);
        }
    }
}
