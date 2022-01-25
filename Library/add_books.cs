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
    public partial class add_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\adoProject_Jashim\Library\library_management_system.mdf;Integrated Security=True");
        public add_books()
        {
            InitializeComponent();
        }

        private void add_books_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO books_info VALUES('" + txtBooksName.Text + "','" + txtBooksAuthorName.Text + "','" + txtBooksPublication.Text + "','" + dtpBooksPurchaseDate.Text + "'," + txtBooksPrice.Text + "," + txtBooksQuantity.Text + "," + txtBooksQuantity.Text + ")";
            cmd.ExecuteNonQuery();
            con.Close();

            txtBooksName.Text = "";
            txtBooksAuthorName.Text = "";
            txtBooksPublication.Text = "";
            dtpBooksPurchaseDate.Text = "";
            txtBooksPrice.Text = "";
            txtBooksQuantity.Text = "";

            MessageBox.Show("Record inserted Successfully.");
        }
    }
}
