using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    //For File Processing
using System.Data.SqlClient;

namespace Library
{
    public partial class add_student_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\adoProject_Jashim\Library\library_management_system.mdf;Integrated Security=True");
        string wanted_path;
        string pwd = Class1.GetRandomPassword(20);
        public add_student_info()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            DialogResult result = fdImage.ShowDialog();
            fdImage.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (result== DialogResult.OK) // Test result
            {
                pictureBox1.ImageLocation = fdImage.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            //pictureBox1.ImageLocation = @"..\student_images\" + pwd + ".jpg";
        }

        private void btnAddStudentSaveInformation_Click(object sender, EventArgs e)
        {

            try
            {
                string img_path;
                File.Copy(fdImage.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");
                img_path = "student_images\\" + pwd + ".jpg";
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO student_info VALUES('"+txtAddStuStudentname.Text+ "','"+img_path.ToString()+"','" + txtAddStuEnrollmentNo.Text+"','"+txtAddStuStudentDepartment.Text+"','"+txtAddStuStudentSemester.Text+"','"+txtAddStuStudentContactNo.Text+"','"+txtAddStuStudentEmail.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Inserted Successfully.");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
