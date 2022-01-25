
namespace Library
{
    partial class issue_books
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsbIssueBooksBookName = new System.Windows.Forms.ListBox();
            this.btnIssueBooksIssueBooks = new System.Windows.Forms.Button();
            this.txtIssueBooksBookName = new System.Windows.Forms.TextBox();
            this.lblIssueBooksBookName = new System.Windows.Forms.Label();
            this.dtpIssueBooksBookIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblEnterEnrollmentNumber = new System.Windows.Forms.Label();
            this.lblIssueBooksBookIssueDate = new System.Windows.Forms.Label();
            this.lblIssueBooksStudentEmail = new System.Windows.Forms.Label();
            this.lblIssueBooksStudentContact = new System.Windows.Forms.Label();
            this.lblIssueBooksStudentSemester = new System.Windows.Forms.Label();
            this.lblIssueBooksStudentDepartment = new System.Windows.Forms.Label();
            this.lblIssueBooksStudentName = new System.Windows.Forms.Label();
            this.txtIssueBooksStudentEmail = new System.Windows.Forms.TextBox();
            this.txtIssueBooksStudentContact = new System.Windows.Forms.TextBox();
            this.txtIssueBooksStudentSemester = new System.Windows.Forms.TextBox();
            this.txtIssueBooksStudentDepartment = new System.Windows.Forms.TextBox();
            this.txtIssueBooksStudentName = new System.Windows.Forms.TextBox();
            this.btnIssueBooksSearchStudent = new System.Windows.Forms.Button();
            this.txtIssueBooksEnrollmentNumber = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsbIssueBooksBookName);
            this.panel1.Controls.Add(this.btnIssueBooksIssueBooks);
            this.panel1.Controls.Add(this.txtIssueBooksBookName);
            this.panel1.Controls.Add(this.lblIssueBooksBookName);
            this.panel1.Controls.Add(this.dtpIssueBooksBookIssueDate);
            this.panel1.Controls.Add(this.lblEnterEnrollmentNumber);
            this.panel1.Controls.Add(this.lblIssueBooksBookIssueDate);
            this.panel1.Controls.Add(this.lblIssueBooksStudentEmail);
            this.panel1.Controls.Add(this.lblIssueBooksStudentContact);
            this.panel1.Controls.Add(this.lblIssueBooksStudentSemester);
            this.panel1.Controls.Add(this.lblIssueBooksStudentDepartment);
            this.panel1.Controls.Add(this.lblIssueBooksStudentName);
            this.panel1.Controls.Add(this.txtIssueBooksStudentEmail);
            this.panel1.Controls.Add(this.txtIssueBooksStudentContact);
            this.panel1.Controls.Add(this.txtIssueBooksStudentSemester);
            this.panel1.Controls.Add(this.txtIssueBooksStudentDepartment);
            this.panel1.Controls.Add(this.txtIssueBooksStudentName);
            this.panel1.Controls.Add(this.btnIssueBooksSearchStudent);
            this.panel1.Controls.Add(this.txtIssueBooksEnrollmentNumber);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(65, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 489);
            this.panel1.TabIndex = 0;
            // 
            // lsbIssueBooksBookName
            // 
            this.lsbIssueBooksBookName.FormattingEnabled = true;
            this.lsbIssueBooksBookName.ItemHeight = 16;
            this.lsbIssueBooksBookName.Location = new System.Drawing.Point(534, 392);
            this.lsbIssueBooksBookName.Name = "lsbIssueBooksBookName";
            this.lsbIssueBooksBookName.Size = new System.Drawing.Size(200, 84);
            this.lsbIssueBooksBookName.TabIndex = 19;
            this.lsbIssueBooksBookName.Visible = false;
            this.lsbIssueBooksBookName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsbIssueBooksBookName_MouseClick);
            this.lsbIssueBooksBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbIssueBooksBookName_KeyDown);
            // 
            // btnIssueBooksIssueBooks
            // 
            this.btnIssueBooksIssueBooks.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBooksIssueBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIssueBooksIssueBooks.Location = new System.Drawing.Point(195, 424);
            this.btnIssueBooksIssueBooks.Name = "btnIssueBooksIssueBooks";
            this.btnIssueBooksIssueBooks.Size = new System.Drawing.Size(162, 37);
            this.btnIssueBooksIssueBooks.TabIndex = 18;
            this.btnIssueBooksIssueBooks.Text = "Issue Books";
            this.btnIssueBooksIssueBooks.UseVisualStyleBackColor = true;
            this.btnIssueBooksIssueBooks.Click += new System.EventHandler(this.btnIssueBooksIssueBooks_Click);
            // 
            // txtIssueBooksBookName
            // 
            this.txtIssueBooksBookName.Location = new System.Drawing.Point(534, 364);
            this.txtIssueBooksBookName.Name = "txtIssueBooksBookName";
            this.txtIssueBooksBookName.Size = new System.Drawing.Size(200, 22);
            this.txtIssueBooksBookName.TabIndex = 17;
            this.txtIssueBooksBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIssueBooksBookName_KeyDown);
            this.txtIssueBooksBookName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIssueBooksBookName_KeyUp);
            // 
            // lblIssueBooksBookName
            // 
            this.lblIssueBooksBookName.AutoSize = true;
            this.lblIssueBooksBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueBooksBookName.ForeColor = System.Drawing.Color.Maroon;
            this.lblIssueBooksBookName.Location = new System.Drawing.Point(365, 364);
            this.lblIssueBooksBookName.Name = "lblIssueBooksBookName";
            this.lblIssueBooksBookName.Size = new System.Drawing.Size(101, 20);
            this.lblIssueBooksBookName.TabIndex = 16;
            this.lblIssueBooksBookName.Text = "Book Name";
            // 
            // dtpIssueBooksBookIssueDate
            // 
            this.dtpIssueBooksBookIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueBooksBookIssueDate.Location = new System.Drawing.Point(534, 309);
            this.dtpIssueBooksBookIssueDate.Name = "dtpIssueBooksBookIssueDate";
            this.dtpIssueBooksBookIssueDate.Size = new System.Drawing.Size(200, 22);
            this.dtpIssueBooksBookIssueDate.TabIndex = 15;
            // 
            // lblEnterEnrollmentNumber
            // 
            this.lblEnterEnrollmentNumber.AutoSize = true;
            this.lblEnterEnrollmentNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterEnrollmentNumber.Location = new System.Drawing.Point(30, 43);
            this.lblEnterEnrollmentNumber.Name = "lblEnterEnrollmentNumber";
            this.lblEnterEnrollmentNumber.Size = new System.Drawing.Size(241, 24);
            this.lblEnterEnrollmentNumber.TabIndex = 14;
            this.lblEnterEnrollmentNumber.Text = "Enter Enrollment Number";
            // 
            // lblIssueBooksBookIssueDate
            // 
            this.lblIssueBooksBookIssueDate.AutoSize = true;
            this.lblIssueBooksBookIssueDate.Location = new System.Drawing.Point(363, 309);
            this.lblIssueBooksBookIssueDate.Name = "lblIssueBooksBookIssueDate";
            this.lblIssueBooksBookIssueDate.Size = new System.Drawing.Size(114, 16);
            this.lblIssueBooksBookIssueDate.TabIndex = 13;
            this.lblIssueBooksBookIssueDate.Text = "Books Issue Date";
            this.lblIssueBooksBookIssueDate.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblIssueBooksStudentEmail
            // 
            this.lblIssueBooksStudentEmail.AutoSize = true;
            this.lblIssueBooksStudentEmail.Location = new System.Drawing.Point(366, 255);
            this.lblIssueBooksStudentEmail.Name = "lblIssueBooksStudentEmail";
            this.lblIssueBooksStudentEmail.Size = new System.Drawing.Size(90, 16);
            this.lblIssueBooksStudentEmail.TabIndex = 12;
            this.lblIssueBooksStudentEmail.Text = "Student Email";
            // 
            // lblIssueBooksStudentContact
            // 
            this.lblIssueBooksStudentContact.AutoSize = true;
            this.lblIssueBooksStudentContact.Location = new System.Drawing.Point(363, 201);
            this.lblIssueBooksStudentContact.Name = "lblIssueBooksStudentContact";
            this.lblIssueBooksStudentContact.Size = new System.Drawing.Size(101, 16);
            this.lblIssueBooksStudentContact.TabIndex = 11;
            this.lblIssueBooksStudentContact.Text = "Student Contact";
            // 
            // lblIssueBooksStudentSemester
            // 
            this.lblIssueBooksStudentSemester.AutoSize = true;
            this.lblIssueBooksStudentSemester.Location = new System.Drawing.Point(363, 147);
            this.lblIssueBooksStudentSemester.Name = "lblIssueBooksStudentSemester";
            this.lblIssueBooksStudentSemester.Size = new System.Drawing.Size(114, 16);
            this.lblIssueBooksStudentSemester.TabIndex = 10;
            this.lblIssueBooksStudentSemester.Text = "Student Semester";
            // 
            // lblIssueBooksStudentDepartment
            // 
            this.lblIssueBooksStudentDepartment.AutoSize = true;
            this.lblIssueBooksStudentDepartment.Location = new System.Drawing.Point(363, 90);
            this.lblIssueBooksStudentDepartment.Name = "lblIssueBooksStudentDepartment";
            this.lblIssueBooksStudentDepartment.Size = new System.Drawing.Size(126, 16);
            this.lblIssueBooksStudentDepartment.TabIndex = 9;
            this.lblIssueBooksStudentDepartment.Text = "Student Department";
            // 
            // lblIssueBooksStudentName
            // 
            this.lblIssueBooksStudentName.AutoSize = true;
            this.lblIssueBooksStudentName.Location = new System.Drawing.Point(363, 34);
            this.lblIssueBooksStudentName.Name = "lblIssueBooksStudentName";
            this.lblIssueBooksStudentName.Size = new System.Drawing.Size(93, 16);
            this.lblIssueBooksStudentName.TabIndex = 8;
            this.lblIssueBooksStudentName.Text = "Student Name";
            // 
            // txtIssueBooksStudentEmail
            // 
            this.txtIssueBooksStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueBooksStudentEmail.Location = new System.Drawing.Point(534, 255);
            this.txtIssueBooksStudentEmail.Name = "txtIssueBooksStudentEmail";
            this.txtIssueBooksStudentEmail.Size = new System.Drawing.Size(182, 22);
            this.txtIssueBooksStudentEmail.TabIndex = 6;
            // 
            // txtIssueBooksStudentContact
            // 
            this.txtIssueBooksStudentContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueBooksStudentContact.Location = new System.Drawing.Point(534, 201);
            this.txtIssueBooksStudentContact.Name = "txtIssueBooksStudentContact";
            this.txtIssueBooksStudentContact.Size = new System.Drawing.Size(182, 22);
            this.txtIssueBooksStudentContact.TabIndex = 5;
            // 
            // txtIssueBooksStudentSemester
            // 
            this.txtIssueBooksStudentSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueBooksStudentSemester.Location = new System.Drawing.Point(534, 147);
            this.txtIssueBooksStudentSemester.Name = "txtIssueBooksStudentSemester";
            this.txtIssueBooksStudentSemester.Size = new System.Drawing.Size(182, 22);
            this.txtIssueBooksStudentSemester.TabIndex = 4;
            // 
            // txtIssueBooksStudentDepartment
            // 
            this.txtIssueBooksStudentDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueBooksStudentDepartment.Location = new System.Drawing.Point(534, 87);
            this.txtIssueBooksStudentDepartment.Name = "txtIssueBooksStudentDepartment";
            this.txtIssueBooksStudentDepartment.Size = new System.Drawing.Size(182, 22);
            this.txtIssueBooksStudentDepartment.TabIndex = 3;
            // 
            // txtIssueBooksStudentName
            // 
            this.txtIssueBooksStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueBooksStudentName.Location = new System.Drawing.Point(534, 28);
            this.txtIssueBooksStudentName.Name = "txtIssueBooksStudentName";
            this.txtIssueBooksStudentName.Size = new System.Drawing.Size(182, 22);
            this.txtIssueBooksStudentName.TabIndex = 2;
            // 
            // btnIssueBooksSearchStudent
            // 
            this.btnIssueBooksSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBooksSearchStudent.ForeColor = System.Drawing.Color.Maroon;
            this.btnIssueBooksSearchStudent.Location = new System.Drawing.Point(48, 133);
            this.btnIssueBooksSearchStudent.Name = "btnIssueBooksSearchStudent";
            this.btnIssueBooksSearchStudent.Size = new System.Drawing.Size(193, 39);
            this.btnIssueBooksSearchStudent.TabIndex = 1;
            this.btnIssueBooksSearchStudent.Text = "Search Student";
            this.btnIssueBooksSearchStudent.UseVisualStyleBackColor = true;
            this.btnIssueBooksSearchStudent.Click += new System.EventHandler(this.btnIssueBooksSearchStudent_Click);
            // 
            // txtIssueBooksEnrollmentNumber
            // 
            this.txtIssueBooksEnrollmentNumber.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueBooksEnrollmentNumber.Location = new System.Drawing.Point(48, 87);
            this.txtIssueBooksEnrollmentNumber.Name = "txtIssueBooksEnrollmentNumber";
            this.txtIssueBooksEnrollmentNumber.Size = new System.Drawing.Size(193, 22);
            this.txtIssueBooksEnrollmentNumber.TabIndex = 0;
            this.txtIssueBooksEnrollmentNumber.TextChanged += new System.EventHandler(this.txtIssueBooksEnrollmentNumber_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // issue_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 549);
            this.Controls.Add(this.panel1);
            this.Name = "issue_books";
            this.Text = "issue_books";
            this.Load += new System.EventHandler(this.issue_books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIssueBooksSearchStudent;
        private System.Windows.Forms.TextBox txtIssueBooksEnrollmentNumber;
        private System.Windows.Forms.TextBox txtIssueBooksStudentEmail;
        private System.Windows.Forms.TextBox txtIssueBooksStudentContact;
        private System.Windows.Forms.TextBox txtIssueBooksStudentSemester;
        private System.Windows.Forms.TextBox txtIssueBooksStudentDepartment;
        private System.Windows.Forms.TextBox txtIssueBooksStudentName;
        private System.Windows.Forms.Label lblEnterEnrollmentNumber;
        private System.Windows.Forms.Label lblIssueBooksBookIssueDate;
        private System.Windows.Forms.Label lblIssueBooksStudentEmail;
        private System.Windows.Forms.Label lblIssueBooksStudentContact;
        private System.Windows.Forms.Label lblIssueBooksStudentSemester;
        private System.Windows.Forms.Label lblIssueBooksStudentDepartment;
        private System.Windows.Forms.Label lblIssueBooksStudentName;
        private System.Windows.Forms.DateTimePicker dtpIssueBooksBookIssueDate;
        private System.Windows.Forms.TextBox txtIssueBooksBookName;
        private System.Windows.Forms.Label lblIssueBooksBookName;
        private System.Windows.Forms.Button btnIssueBooksIssueBooks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lsbIssueBooksBookName;
    }
}