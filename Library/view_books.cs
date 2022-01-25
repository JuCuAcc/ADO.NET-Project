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
    public partial class view_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\adoProject_Jashim\Library\library_management_system.mdf;Integrated Security=True");

        public view_books()
        {
            InitializeComponent();
        }

        private void view_books_Load(object sender, EventArgs e)
        {
            displayBooks();
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE books_name like('%" + txtEnterBookName.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                dgvViewBooks.DataSource = dt;
                con.Close();

                if (i == 0)
                {
                    MessageBox.Show("No Books Found.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtEnterBookName_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE books_name like('%" + txtEnterBookName.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                dgvViewBooks.DataSource = dt;
                con.Close();

                if (i == 0)
                {
                    MessageBox.Show("No Books Found.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        //private void btnSearchBooksByAuthor_KeyUp(object sender, KeyEventArgs e)
        //{
        //    int i = 0;
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = con.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "SELECT * FROM books_info WHERE books_author_name like('%" + txtEnterBookAuthorName.Text + "%')";
        //        cmd.ExecuteNonQuery();
        //        DataTable dt = new DataTable();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //        i = Convert.ToInt32(dt.Rows.Count.ToString());
        //        dgvViewBooks.DataSource = dt;
        //        con.Close();

        //        if (i == 0)
        //        {
        //            MessageBox.Show("No Records Found.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btnSearchBooksByAuthor_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE books_author_name like('%" + txtEnterBookAuthorName.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                dgvViewBooks.DataSource = dt;
                con.Close();

                if (i== 0)
                {
                    MessageBox.Show("No Records Found.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlViewBooksUpdate.Visible = true;
            int i;
            i = Convert.ToInt32(dgvViewBooks.SelectedCells[0].Value.ToString());
            MessageBox.Show("Book ID: " + i.ToString()+ " is selected.");

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE id="+i+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtViewBooksBooksName.Text = dr["books_name"].ToString();
                    txtViewBooksAuthorName.Text = dr["books_author_name"].ToString();
                    txtViewBooksPublicationName.Text = dr["books_publication_name"].ToString();
                    dtpViewBooksPurchaseDate.Value = Convert.ToDateTime(dr["books_purchase_date"].ToString());
                    txtViewBooksPrice.Text = dr["books_price"].ToString();
                    txtViewBooksQuantity.Text = dr["books_quantity"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dgvViewBooks.SelectedCells[0].Value.ToString());

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE books_info SET books_name='" + txtViewBooksBooksName.Text + "'," +" books_author_name='" + txtViewBooksAuthorName.Text + "'," +" books_publication_name='" + txtViewBooksPublicationName.Text + "'," +" books_purchase_date='" + dtpViewBooksPurchaseDate.Value + "'," +" books_price=" + txtViewBooksPrice.Text + "," +" books_quantity=" + txtViewBooksQuantity.Text + "WHERE id=" + i + "";
                cmd.ExecuteNonQuery();
                con.Close();
                displayBooks();
                MessageBox.Show("Record Updated Successfully.");
                pnlViewBooksUpdate.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void displayBooks()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvViewBooks.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtEnterBookAuthorName_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE books_author_name like('%" + txtEnterBookAuthorName.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                dgvViewBooks.DataSource = dt;
                con.Close();

                if (i == 0)
                {
                    MessageBox.Show("No Records Found.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
