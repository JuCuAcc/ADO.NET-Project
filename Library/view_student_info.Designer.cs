
namespace Library
{
    partial class view_student_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvViewStudentInfo = new System.Windows.Forms.DataGridView();
            this.txtViewStuInfoSearchStudent = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblViewStuInfoStudentEmail = new System.Windows.Forms.Label();
            this.lblViewStuInfoStudentContact = new System.Windows.Forms.Label();
            this.lblViewStuInfoStudentSemester = new System.Windows.Forms.Label();
            this.lblViewStuInfoStudentDepartment = new System.Windows.Forms.Label();
            this.lblViewStuInfoStudentEnrollmentNo = new System.Windows.Forms.Label();
            this.lblViewStuInfoStudentName = new System.Windows.Forms.Label();
            this.btnViewStuInfoUpdateRecord = new System.Windows.Forms.Button();
            this.btnViewStuInfoSelectFile = new System.Windows.Forms.Button();
            this.txtViewStuInfoStudentEmail = new System.Windows.Forms.TextBox();
            this.txtViewStuInfoStudentContact = new System.Windows.Forms.TextBox();
            this.txtViewStuInfoStudentSemester = new System.Windows.Forms.TextBox();
            this.txtViewStuInfoStudentDepartment = new System.Windows.Forms.TextBox();
            this.txtViewStuInfoEnrollmentNo = new System.Windows.Forms.TextBox();
            this.txtViewStuInfoStudentName = new System.Windows.Forms.TextBox();
            this.fdViewStudentInfo = new System.Windows.Forms.OpenFileDialog();
            this.lblSearchStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudentInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewStudentInfo
            // 
            this.dgvViewStudentInfo.AllowUserToAddRows = false;
            this.dgvViewStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudentInfo.Location = new System.Drawing.Point(264, 12);
            this.dgvViewStudentInfo.Name = "dgvViewStudentInfo";
            this.dgvViewStudentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewStudentInfo.Size = new System.Drawing.Size(952, 300);
            this.dgvViewStudentInfo.TabIndex = 0;
            this.dgvViewStudentInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewStudentInfo_CellClick);
            // 
            // txtViewStuInfoSearchStudent
            // 
            this.txtViewStuInfoSearchStudent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewStuInfoSearchStudent.ForeColor = System.Drawing.Color.Maroon;
            this.txtViewStuInfoSearchStudent.Location = new System.Drawing.Point(41, 47);
            this.txtViewStuInfoSearchStudent.Name = "txtViewStuInfoSearchStudent";
            this.txtViewStuInfoSearchStudent.Size = new System.Drawing.Size(196, 32);
            this.txtViewStuInfoSearchStudent.TabIndex = 1;
            this.txtViewStuInfoSearchStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtViewStuInfoSearchStudent.TextChanged += new System.EventHandler(this.txtViewStuInfoSearchStudent_TextChanged);
            this.txtViewStuInfoSearchStudent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtViewStuInfoSearchStudent_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.lblViewStuInfoStudentEmail);
            this.panel1.Controls.Add(this.lblViewStuInfoStudentContact);
            this.panel1.Controls.Add(this.lblViewStuInfoStudentSemester);
            this.panel1.Controls.Add(this.lblViewStuInfoStudentDepartment);
            this.panel1.Controls.Add(this.lblViewStuInfoStudentEnrollmentNo);
            this.panel1.Controls.Add(this.lblViewStuInfoStudentName);
            this.panel1.Controls.Add(this.btnViewStuInfoUpdateRecord);
            this.panel1.Controls.Add(this.btnViewStuInfoSelectFile);
            this.panel1.Controls.Add(this.txtViewStuInfoStudentEmail);
            this.panel1.Controls.Add(this.txtViewStuInfoStudentContact);
            this.panel1.Controls.Add(this.txtViewStuInfoStudentSemester);
            this.panel1.Controls.Add(this.txtViewStuInfoStudentDepartment);
            this.panel1.Controls.Add(this.txtViewStuInfoEnrollmentNo);
            this.panel1.Controls.Add(this.txtViewStuInfoStudentName);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Fuchsia;
            this.panel1.Location = new System.Drawing.Point(264, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 192);
            this.panel1.TabIndex = 2;
            // 
            // lblViewStuInfoStudentEmail
            // 
            this.lblViewStuInfoStudentEmail.AutoSize = true;
            this.lblViewStuInfoStudentEmail.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewStuInfoStudentEmail.Location = new System.Drawing.Point(618, 97);
            this.lblViewStuInfoStudentEmail.Name = "lblViewStuInfoStudentEmail";
            this.lblViewStuInfoStudentEmail.Size = new System.Drawing.Size(81, 13);
            this.lblViewStuInfoStudentEmail.TabIndex = 13;
            this.lblViewStuInfoStudentEmail.Text = "Student Email";
            this.lblViewStuInfoStudentEmail.Click += new System.EventHandler(this.lblViewStuInfoStudentEmail_Click);
            // 
            // lblViewStuInfoStudentContact
            // 
            this.lblViewStuInfoStudentContact.AutoSize = true;
            this.lblViewStuInfoStudentContact.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewStuInfoStudentContact.Location = new System.Drawing.Point(618, 33);
            this.lblViewStuInfoStudentContact.Name = "lblViewStuInfoStudentContact";
            this.lblViewStuInfoStudentContact.Size = new System.Drawing.Size(92, 13);
            this.lblViewStuInfoStudentContact.TabIndex = 12;
            this.lblViewStuInfoStudentContact.Text = "Student Contact";
            // 
            // lblViewStuInfoStudentSemester
            // 
            this.lblViewStuInfoStudentSemester.AutoSize = true;
            this.lblViewStuInfoStudentSemester.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewStuInfoStudentSemester.Location = new System.Drawing.Point(339, 97);
            this.lblViewStuInfoStudentSemester.Name = "lblViewStuInfoStudentSemester";
            this.lblViewStuInfoStudentSemester.Size = new System.Drawing.Size(100, 13);
            this.lblViewStuInfoStudentSemester.TabIndex = 11;
            this.lblViewStuInfoStudentSemester.Text = "Student Semester";
            // 
            // lblViewStuInfoStudentDepartment
            // 
            this.lblViewStuInfoStudentDepartment.AutoSize = true;
            this.lblViewStuInfoStudentDepartment.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewStuInfoStudentDepartment.Location = new System.Drawing.Point(339, 36);
            this.lblViewStuInfoStudentDepartment.Name = "lblViewStuInfoStudentDepartment";
            this.lblViewStuInfoStudentDepartment.Size = new System.Drawing.Size(113, 13);
            this.lblViewStuInfoStudentDepartment.TabIndex = 10;
            this.lblViewStuInfoStudentDepartment.Text = "Student Department";
            // 
            // lblViewStuInfoStudentEnrollmentNo
            // 
            this.lblViewStuInfoStudentEnrollmentNo.AutoSize = true;
            this.lblViewStuInfoStudentEnrollmentNo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewStuInfoStudentEnrollmentNo.Location = new System.Drawing.Point(16, 97);
            this.lblViewStuInfoStudentEnrollmentNo.Name = "lblViewStuInfoStudentEnrollmentNo";
            this.lblViewStuInfoStudentEnrollmentNo.Size = new System.Drawing.Size(83, 13);
            this.lblViewStuInfoStudentEnrollmentNo.TabIndex = 9;
            this.lblViewStuInfoStudentEnrollmentNo.Text = "Enrollment No";
            // 
            // lblViewStuInfoStudentName
            // 
            this.lblViewStuInfoStudentName.AutoSize = true;
            this.lblViewStuInfoStudentName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewStuInfoStudentName.Location = new System.Drawing.Point(13, 36);
            this.lblViewStuInfoStudentName.Name = "lblViewStuInfoStudentName";
            this.lblViewStuInfoStudentName.Size = new System.Drawing.Size(81, 13);
            this.lblViewStuInfoStudentName.TabIndex = 8;
            this.lblViewStuInfoStudentName.Text = "Student Name";
            // 
            // btnViewStuInfoUpdateRecord
            // 
            this.btnViewStuInfoUpdateRecord.BackColor = System.Drawing.Color.MistyRose;
            this.btnViewStuInfoUpdateRecord.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStuInfoUpdateRecord.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnViewStuInfoUpdateRecord.Location = new System.Drawing.Point(472, 142);
            this.btnViewStuInfoUpdateRecord.Name = "btnViewStuInfoUpdateRecord";
            this.btnViewStuInfoUpdateRecord.Size = new System.Drawing.Size(100, 23);
            this.btnViewStuInfoUpdateRecord.TabIndex = 7;
            this.btnViewStuInfoUpdateRecord.Text = "Update Record";
            this.btnViewStuInfoUpdateRecord.UseVisualStyleBackColor = false;
            this.btnViewStuInfoUpdateRecord.Click += new System.EventHandler(this.btnViewStuInfoUpdateRecord_Click);
            // 
            // btnViewStuInfoSelectFile
            // 
            this.btnViewStuInfoSelectFile.BackColor = System.Drawing.Color.MistyRose;
            this.btnViewStuInfoSelectFile.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStuInfoSelectFile.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnViewStuInfoSelectFile.Location = new System.Drawing.Point(157, 142);
            this.btnViewStuInfoSelectFile.Name = "btnViewStuInfoSelectFile";
            this.btnViewStuInfoSelectFile.Size = new System.Drawing.Size(100, 23);
            this.btnViewStuInfoSelectFile.TabIndex = 6;
            this.btnViewStuInfoSelectFile.Text = "Select Image";
            this.btnViewStuInfoSelectFile.UseVisualStyleBackColor = false;
            this.btnViewStuInfoSelectFile.Click += new System.EventHandler(this.btnViewStuInfoSelectFile_Click);
            // 
            // txtViewStuInfoStudentEmail
            // 
            this.txtViewStuInfoStudentEmail.Location = new System.Drawing.Point(742, 91);
            this.txtViewStuInfoStudentEmail.Name = "txtViewStuInfoStudentEmail";
            this.txtViewStuInfoStudentEmail.Size = new System.Drawing.Size(100, 21);
            this.txtViewStuInfoStudentEmail.TabIndex = 5;
            // 
            // txtViewStuInfoStudentContact
            // 
            this.txtViewStuInfoStudentContact.Location = new System.Drawing.Point(742, 29);
            this.txtViewStuInfoStudentContact.Name = "txtViewStuInfoStudentContact";
            this.txtViewStuInfoStudentContact.Size = new System.Drawing.Size(100, 21);
            this.txtViewStuInfoStudentContact.TabIndex = 4;
            // 
            // txtViewStuInfoStudentSemester
            // 
            this.txtViewStuInfoStudentSemester.Location = new System.Drawing.Point(472, 91);
            this.txtViewStuInfoStudentSemester.Name = "txtViewStuInfoStudentSemester";
            this.txtViewStuInfoStudentSemester.Size = new System.Drawing.Size(100, 21);
            this.txtViewStuInfoStudentSemester.TabIndex = 3;
            // 
            // txtViewStuInfoStudentDepartment
            // 
            this.txtViewStuInfoStudentDepartment.Location = new System.Drawing.Point(472, 34);
            this.txtViewStuInfoStudentDepartment.Name = "txtViewStuInfoStudentDepartment";
            this.txtViewStuInfoStudentDepartment.Size = new System.Drawing.Size(100, 21);
            this.txtViewStuInfoStudentDepartment.TabIndex = 2;
            // 
            // txtViewStuInfoEnrollmentNo
            // 
            this.txtViewStuInfoEnrollmentNo.Location = new System.Drawing.Point(157, 91);
            this.txtViewStuInfoEnrollmentNo.Name = "txtViewStuInfoEnrollmentNo";
            this.txtViewStuInfoEnrollmentNo.Size = new System.Drawing.Size(134, 21);
            this.txtViewStuInfoEnrollmentNo.TabIndex = 1;
            // 
            // txtViewStuInfoStudentName
            // 
            this.txtViewStuInfoStudentName.Location = new System.Drawing.Point(157, 30);
            this.txtViewStuInfoStudentName.Name = "txtViewStuInfoStudentName";
            this.txtViewStuInfoStudentName.Size = new System.Drawing.Size(134, 21);
            this.txtViewStuInfoStudentName.TabIndex = 0;
            // 
            // fdViewStudentInfo
            // 
            this.fdViewStudentInfo.FileName = "fdViewStudentInfo";
            // 
            // lblSearchStudent
            // 
            this.lblSearchStudent.AutoSize = true;
            this.lblSearchStudent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearchStudent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStudent.ForeColor = System.Drawing.Color.Maroon;
            this.lblSearchStudent.Location = new System.Drawing.Point(98, 28);
            this.lblSearchStudent.Name = "lblSearchStudent";
            this.lblSearchStudent.Size = new System.Drawing.Size(91, 15);
            this.lblSearchStudent.TabIndex = 3;
            this.lblSearchStudent.Text = "Search Student";
            // 
            // view_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 535);
            this.Controls.Add(this.lblSearchStudent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtViewStuInfoSearchStudent);
            this.Controls.Add(this.dgvViewStudentInfo);
            this.Name = "view_student_info";
            this.Text = "view_student_info";
            this.Load += new System.EventHandler(this.view_student_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudentInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewStudentInfo;
        private System.Windows.Forms.TextBox txtViewStuInfoSearchStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblViewStuInfoStudentEmail;
        private System.Windows.Forms.Label lblViewStuInfoStudentContact;
        private System.Windows.Forms.Label lblViewStuInfoStudentSemester;
        private System.Windows.Forms.Label lblViewStuInfoStudentDepartment;
        private System.Windows.Forms.Label lblViewStuInfoStudentEnrollmentNo;
        private System.Windows.Forms.Label lblViewStuInfoStudentName;
        private System.Windows.Forms.Button btnViewStuInfoUpdateRecord;
        private System.Windows.Forms.Button btnViewStuInfoSelectFile;
        private System.Windows.Forms.TextBox txtViewStuInfoStudentEmail;
        private System.Windows.Forms.TextBox txtViewStuInfoStudentContact;
        private System.Windows.Forms.TextBox txtViewStuInfoStudentSemester;
        private System.Windows.Forms.TextBox txtViewStuInfoStudentDepartment;
        private System.Windows.Forms.TextBox txtViewStuInfoEnrollmentNo;
        private System.Windows.Forms.TextBox txtViewStuInfoStudentName;
        private System.Windows.Forms.OpenFileDialog fdViewStudentInfo;
        private System.Windows.Forms.Label lblSearchStudent;
    }
}