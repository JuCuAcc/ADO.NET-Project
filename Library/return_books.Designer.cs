
namespace Library
{
    partial class return_books
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEnterEnrollmentNumber = new System.Windows.Forms.Label();
            this.txtReturnBooksEnrollmentNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReturnBooksUpper = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBooksName = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblSelectReturnDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooksUpper)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtReturnBooksEnrollmentNumber);
            this.panel1.Controls.Add(this.lblEnterEnrollmentNumber);
            this.panel1.Location = new System.Drawing.Point(38, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 145);
            this.panel1.TabIndex = 0;
            // 
            // lblEnterEnrollmentNumber
            // 
            this.lblEnterEnrollmentNumber.AutoSize = true;
            this.lblEnterEnrollmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterEnrollmentNumber.Location = new System.Drawing.Point(39, 19);
            this.lblEnterEnrollmentNumber.Name = "lblEnterEnrollmentNumber";
            this.lblEnterEnrollmentNumber.Size = new System.Drawing.Size(179, 16);
            this.lblEnterEnrollmentNumber.TabIndex = 0;
            this.lblEnterEnrollmentNumber.Text = "Enter Enrollment Number";
            // 
            // txtReturnBooksEnrollmentNumber
            // 
            this.txtReturnBooksEnrollmentNumber.Location = new System.Drawing.Point(42, 64);
            this.txtReturnBooksEnrollmentNumber.Name = "txtReturnBooksEnrollmentNumber";
            this.txtReturnBooksEnrollmentNumber.Size = new System.Drawing.Size(176, 20);
            this.txtReturnBooksEnrollmentNumber.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search Books";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvReturnBooksUpper);
            this.panel2.Location = new System.Drawing.Point(400, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 300);
            this.panel2.TabIndex = 1;
            // 
            // dgvReturnBooksUpper
            // 
            this.dgvReturnBooksUpper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBooksUpper.Location = new System.Drawing.Point(-62, -11);
            this.dgvReturnBooksUpper.Name = "dgvReturnBooksUpper";
            this.dgvReturnBooksUpper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnBooksUpper.Size = new System.Drawing.Size(695, 362);
            this.dgvReturnBooksUpper.TabIndex = 0;
            this.dgvReturnBooksUpper.Visible = false;
            this.dgvReturnBooksUpper.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnBooksUpper_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.lblSelectReturnDate);
            this.panel3.Controls.Add(this.lblIssueDate);
            this.panel3.Controls.Add(this.lblBooksName);
            this.panel3.Location = new System.Drawing.Point(151, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 178);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // lblBooksName
            // 
            this.lblBooksName.AutoSize = true;
            this.lblBooksName.BackColor = System.Drawing.Color.PeachPuff;
            this.lblBooksName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksName.Location = new System.Drawing.Point(30, 23);
            this.lblBooksName.Name = "lblBooksName";
            this.lblBooksName.Size = new System.Drawing.Size(76, 15);
            this.lblBooksName.TabIndex = 0;
            this.lblBooksName.Text = "Books Name";
            this.lblBooksName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.BackColor = System.Drawing.Color.PeachPuff;
            this.lblIssueDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(342, 23);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(64, 15);
            this.lblIssueDate.TabIndex = 2;
            this.lblIssueDate.Text = "Issue Date";
            this.lblIssueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectReturnDate
            // 
            this.lblSelectReturnDate.AutoSize = true;
            this.lblSelectReturnDate.BackColor = System.Drawing.Color.PeachPuff;
            this.lblSelectReturnDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectReturnDate.Location = new System.Drawing.Point(33, 79);
            this.lblSelectReturnDate.Name = "lblSelectReturnDate";
            this.lblSelectReturnDate.Size = new System.Drawing.Size(111, 15);
            this.lblSelectReturnDate.TabIndex = 4;
            this.lblSelectReturnDate.Text = "Select Return Date";
            this.lblSelectReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.PeachPuff;
            this.btnReturn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(154, 123);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 39);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return Books";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // return_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 559);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "return_books";
            this.Text = "return_books";
            this.Load += new System.EventHandler(this.return_books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooksUpper)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReturnBooksEnrollmentNumber;
        private System.Windows.Forms.Label lblEnterEnrollmentNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReturnBooksUpper;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSelectReturnDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblBooksName;
    }
}