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
    public partial class issue_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\adoProject_Jashim\Library\library_management_system.mdf;Integrated Security=True");
        public issue_books()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnIssueBooksIssueBooks_Click(object sender, EventArgs e)
        {
            int books_quantity = 0;
            SqlCommand cmd5 = con.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "SELECT * FROM books_info WHERE books_name = '"+txtIssueBooksBookName.Text+"'";
            cmd5.ExecuteNonQuery();
            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            da5.Fill(dt5);
            foreach (DataRow dr5 in dt5.Rows)
            {
                books_quantity = Convert.ToInt32(dr5["available_quantity"].ToString());
            }
            if (books_quantity > 0)
            {

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "UPDATE books_info SET available_quantity = (available_quantity - 1) WHERE books_name= '" + txtIssueBooksBookName.Text + "'";
                cmd1.ExecuteNonQuery();


                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "INSERT INTO issue_books VALUES('" + txtIssueBooksEnrollmentNumber.Text + "','" + txtIssueBooksStudentName.Text + "','" + txtIssueBooksStudentDepartment.Text + "','" + txtIssueBooksStudentSemester.Text + "','" + txtIssueBooksStudentContact.Text + "','" + txtIssueBooksStudentEmail.Text + "','" + dtpIssueBooksBookIssueDate.Value.ToShortDateString() + "','' )"; // One Empthy Field
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Book issued successfully.");
            }
            else
            {
                MessageBox.Show("Book is not available right now.");
            }


        }

        private void issue_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void btnIssueBooksSearchStudent_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM student_info WHERE student_enrollment_no = '"+ txtIssueBooksEnrollmentNumber.Text+"' "; 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i==0)
            {
                MessageBox.Show("The Enrollment Number is not Found.");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    txtIssueBooksStudentName.Text = dr["student_name"].ToString();
                    txtIssueBooksStudentDepartment.Text = dr["student_department"].ToString();
                    txtIssueBooksStudentContact.Text = dr["student_contact"].ToString();
                    //txtIssueBooksEnrollmentNumber.Text = dr["student_enrollment_no"].ToString();
                    txtIssueBooksStudentSemester.Text = dr["student_semester"].ToString();
                    txtIssueBooksStudentEmail.Text = dr["student_email"].ToString();
                }
            }

        }

        private void txtIssueBooksBookName_KeyUp(object sender, KeyEventArgs e)
        {

            int count = 0;

            if (e.KeyCode != Keys.Enter)
            {
                lsbIssueBooksBookName.Items.Clear();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE books_name like ('%" + txtIssueBooksBookName.Text + "%' )";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());


                if (count > 0)
                {
                    lsbIssueBooksBookName.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        lsbIssueBooksBookName.Items.Add(dr["books_name"].ToString());
                    }
                }
            }
        }

        private void txtIssueBooksBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lsbIssueBooksBookName.Focus();
                lsbIssueBooksBookName.SelectedIndex = 0;
            }
        }

        private void lsbIssueBooksBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtIssueBooksBookName.Text = lsbIssueBooksBookName.SelectedItem.ToString();
                lsbIssueBooksBookName.Visible = false;
            }
        }

        private void lsbIssueBooksBookName_MouseClick(object sender, MouseEventArgs e)
        {

                txtIssueBooksBookName.Text = lsbIssueBooksBookName.SelectedItem.ToString();
                lsbIssueBooksBookName.Visible = false;         
        }

        private void txtIssueBooksEnrollmentNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
