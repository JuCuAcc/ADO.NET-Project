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

namespace Library
{
    public partial class view_student_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\adoProject_Jashim\Library\library_management_system.mdf;Integrated Security=True");
        //int i = 0;
        string wanted_path;
        string pwd = Class1.GetRandomPassword(20);
        DialogResult result;
        public view_student_info()
        {
            InitializeComponent();
        }

        private void view_student_info_Load(object sender, EventArgs e)
        {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                fillGrid();        
        }

        public void fillGrid() {
            try
            {
                dgvViewStudentInfo.Columns.Clear();
                dgvViewStudentInfo.Refresh();
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM student_info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvViewStudentInfo.DataSource = dt;

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();

                imageCol.HeaderText = "Student Image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dgvViewStudentInfo.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString()); //Check this line
                    dgvViewStudentInfo.Rows[i].Cells[8].Value = img;
                    dgvViewStudentInfo.Rows[i].Height = 100;
                    i = i + 1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void txtViewStuInfoSearchStudent_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                dgvViewStudentInfo.Columns.Clear();
                dgvViewStudentInfo.Refresh();

                //int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM student_info WHERE student_name like('%"+txtViewStuInfoSearchStudent.Text+"%')"; //student_id
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvViewStudentInfo.DataSource = dt;

                //Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn
                {
                    HeaderText = "Student Image",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 100
                };
                //dgvViewStudentInfo.ColumnCount = 8; 
                dgvViewStudentInfo.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    txtViewStuInfoStudentName.Text = dr["student_name"].ToString();
                    txtViewStuInfoStudentDepartment.Text = dr["student_department"].ToString();
                    txtViewStuInfoStudentContact.Text = dr["student_contact"].ToString();
                    txtViewStuInfoEnrollmentNo.Text = dr["student_enrollment_no"].ToString();
                    txtViewStuInfoStudentSemester.Text = dr["student_semester"].ToString();
                    txtViewStuInfoStudentEmail.Text = dr["student_email"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void lblViewStuInfoStudentEmail_Click(object sender, EventArgs e)
        {

        }

        private void dgvViewStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int i;
            i = Convert.ToInt32(dgvViewStudentInfo.SelectedCells[0].Value);
            //i = Convert.ToInt32(dgvViewStudentInfo.SelectedCells[0].Value.ToString());
            //MessageBox.Show("Student with ID "+ i.ToString() + " is selected for update. ");
           
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM student_info WHERE id=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtViewStuInfoStudentName.Text = dr["student_name"].ToString();
                    txtViewStuInfoStudentDepartment.Text = dr["student_department"].ToString();
                    txtViewStuInfoStudentContact.Text = dr["student_contact"].ToString();
                    txtViewStuInfoEnrollmentNo.Text = dr["student_enrollment_no"].ToString();
                    txtViewStuInfoStudentSemester.Text = dr["student_semester"].ToString();
                    txtViewStuInfoStudentEmail.Text = dr["student_email"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnViewStuInfoSelectFile_Click(object sender, EventArgs e)
        {
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            result = fdViewStudentInfo.ShowDialog();
            fdViewStudentInfo.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";         
        }

        private void txtViewStuInfoSearchStudent_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnViewStuInfoUpdateRecord_Click(object sender, EventArgs e)
        {
            try
            {

                if (result == DialogResult.OK)
                {
                    //dgvViewStudentInfo.Columns.Clear();
                    //dgvViewStudentInfo.Refresh();
                    // dgvViewStudentInfo.ColumnCount = 8;
                    int i;
                    i = Convert.ToInt32(dgvViewStudentInfo.SelectedCells[0].Value.ToString()); //Check this line
                    string img_path;
                    File.Copy(fdViewStudentInfo.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");
                    img_path = "student_images\\" + pwd + ".jpg";

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "UPDATE student_info SET student_name = '" + txtViewStuInfoStudentName.Text + "', student_image = '" + img_path.ToString() + "', student_enrollment_no = '" + txtViewStuInfoEnrollmentNo.Text + "', student_department = '" + txtViewStuInfoStudentDepartment.Text + "', student_semester= '" + txtViewStuInfoStudentSemester.Text + "', student_contact = '" + txtViewStuInfoStudentContact.Text + "', student_email = '" + txtViewStuInfoStudentEmail.Text + "' WHERE id=" + i + "";
                    cmd.ExecuteNonQuery();
                    fillGrid();
                    MessageBox.Show("Record Updated Successfully.");
                   

                }
                else if (result == DialogResult.Cancel)
                {

                    int i;
                    i = Convert.ToInt32(dgvViewStudentInfo.SelectedCells[0].Value.ToString());
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE student_info SET student_name = '" + txtViewStuInfoStudentName.Text + "', student_enrollment_no = '" + txtViewStuInfoEnrollmentNo.Text + "', student_department = '" + txtViewStuInfoStudentDepartment.Text + "', student_semester= '" + txtViewStuInfoStudentSemester.Text + "', student_contact = '" + txtViewStuInfoStudentContact.Text + "', student_email = '" + txtViewStuInfoStudentEmail.Text + "' WHERE id=" + i + "";
                    cmd.ExecuteNonQuery();
                    fillGrid();
                    MessageBox.Show("Record Updated Successfully.");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
