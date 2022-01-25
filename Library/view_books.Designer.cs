
namespace Library
{
    partial class view_books
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
            this.dgvViewBooks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.txtEnterBookName = new System.Windows.Forms.TextBox();
            this.lblEnterBookName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchBooksByAuthor = new System.Windows.Forms.Button();
            this.txtEnterBookAuthorName = new System.Windows.Forms.TextBox();
            this.lblEnterAuthorName = new System.Windows.Forms.Label();
            this.pnlViewBooksUpdate = new System.Windows.Forms.Panel();
            this.dtpViewBooksPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtViewBooksQuantity = new System.Windows.Forms.TextBox();
            this.txtViewBooksPrice = new System.Windows.Forms.TextBox();
            this.txtViewBooksPublicationName = new System.Windows.Forms.TextBox();
            this.txtViewBooksAuthorName = new System.Windows.Forms.TextBox();
            this.txtViewBooksBooksName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblPublicationName = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblBooksName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlViewBooksUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewBooks
            // 
            this.dgvViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBooks.Location = new System.Drawing.Point(399, -3);
            this.dgvViewBooks.Name = "dgvViewBooks";
            this.dgvViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewBooks.Size = new System.Drawing.Size(773, 364);
            this.dgvViewBooks.TabIndex = 0;
            this.dgvViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewBooks_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchBooks);
            this.panel1.Controls.Add(this.txtEnterBookName);
            this.panel1.Controls.Add(this.lblEnterBookName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 168);
            this.panel1.TabIndex = 1;
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBooks.Location = new System.Drawing.Point(58, 101);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(160, 45);
            this.btnSearchBooks.TabIndex = 2;
            this.btnSearchBooks.Text = "Search Books";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // txtEnterBookName
            // 
            this.txtEnterBookName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterBookName.Location = new System.Drawing.Point(130, 38);
            this.txtEnterBookName.Name = "txtEnterBookName";
            this.txtEnterBookName.Size = new System.Drawing.Size(155, 21);
            this.txtEnterBookName.TabIndex = 1;
            this.txtEnterBookName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEnterBookName_KeyUp);
            // 
            // lblEnterBookName
            // 
            this.lblEnterBookName.AutoSize = true;
            this.lblEnterBookName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterBookName.Location = new System.Drawing.Point(16, 41);
            this.lblEnterBookName.Name = "lblEnterBookName";
            this.lblEnterBookName.Size = new System.Drawing.Size(103, 15);
            this.lblEnterBookName.TabIndex = 0;
            this.lblEnterBookName.Text = "Enter Book Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchBooksByAuthor);
            this.panel2.Controls.Add(this.txtEnterBookAuthorName);
            this.panel2.Controls.Add(this.lblEnterAuthorName);
            this.panel2.Location = new System.Drawing.Point(12, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 168);
            this.panel2.TabIndex = 3;
            // 
            // btnSearchBooksByAuthor
            // 
            this.btnSearchBooksByAuthor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBooksByAuthor.Location = new System.Drawing.Point(58, 101);
            this.btnSearchBooksByAuthor.Name = "btnSearchBooksByAuthor";
            this.btnSearchBooksByAuthor.Size = new System.Drawing.Size(160, 45);
            this.btnSearchBooksByAuthor.TabIndex = 2;
            this.btnSearchBooksByAuthor.Text = "Search Books";
            this.btnSearchBooksByAuthor.UseVisualStyleBackColor = true;
            this.btnSearchBooksByAuthor.Click += new System.EventHandler(this.btnSearchBooksByAuthor_Click);
            this.btnSearchBooksByAuthor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSearchBooksByAuthor_Click);
            // 
            // txtEnterBookAuthorName
            // 
            this.txtEnterBookAuthorName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterBookAuthorName.Location = new System.Drawing.Point(130, 38);
            this.txtEnterBookAuthorName.Name = "txtEnterBookAuthorName";
            this.txtEnterBookAuthorName.Size = new System.Drawing.Size(155, 21);
            this.txtEnterBookAuthorName.TabIndex = 1;
            this.txtEnterBookAuthorName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEnterBookAuthorName_KeyUp);
            // 
            // lblEnterAuthorName
            // 
            this.lblEnterAuthorName.AutoSize = true;
            this.lblEnterAuthorName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAuthorName.Location = new System.Drawing.Point(16, 41);
            this.lblEnterAuthorName.Name = "lblEnterAuthorName";
            this.lblEnterAuthorName.Size = new System.Drawing.Size(112, 15);
            this.lblEnterAuthorName.TabIndex = 0;
            this.lblEnterAuthorName.Text = "Enter Author Name";
            // 
            // pnlViewBooksUpdate
            // 
            this.pnlViewBooksUpdate.Controls.Add(this.dtpViewBooksPurchaseDate);
            this.pnlViewBooksUpdate.Controls.Add(this.button1);
            this.pnlViewBooksUpdate.Controls.Add(this.txtViewBooksQuantity);
            this.pnlViewBooksUpdate.Controls.Add(this.txtViewBooksPrice);
            this.pnlViewBooksUpdate.Controls.Add(this.txtViewBooksPublicationName);
            this.pnlViewBooksUpdate.Controls.Add(this.txtViewBooksAuthorName);
            this.pnlViewBooksUpdate.Controls.Add(this.txtViewBooksBooksName);
            this.pnlViewBooksUpdate.Controls.Add(this.lblQuantity);
            this.pnlViewBooksUpdate.Controls.Add(this.lblPrice);
            this.pnlViewBooksUpdate.Controls.Add(this.lblPurchaseDate);
            this.pnlViewBooksUpdate.Controls.Add(this.lblPublicationName);
            this.pnlViewBooksUpdate.Controls.Add(this.lblAuthorName);
            this.pnlViewBooksUpdate.Controls.Add(this.lblBooksName);
            this.pnlViewBooksUpdate.Location = new System.Drawing.Point(180, 390);
            this.pnlViewBooksUpdate.Name = "pnlViewBooksUpdate";
            this.pnlViewBooksUpdate.Size = new System.Drawing.Size(859, 152);
            this.pnlViewBooksUpdate.TabIndex = 4;
            this.pnlViewBooksUpdate.Visible = false;
            // 
            // dtpViewBooksPurchaseDate
            // 
            this.dtpViewBooksPurchaseDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpViewBooksPurchaseDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpViewBooksPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpViewBooksPurchaseDate.Location = new System.Drawing.Point(705, 14);
            this.dtpViewBooksPurchaseDate.Name = "dtpViewBooksPurchaseDate";
            this.dtpViewBooksPurchaseDate.Size = new System.Drawing.Size(100, 20);
            this.dtpViewBooksPurchaseDate.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(436, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtViewBooksQuantity
            // 
            this.txtViewBooksQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewBooksQuantity.Location = new System.Drawing.Point(705, 87);
            this.txtViewBooksQuantity.Name = "txtViewBooksQuantity";
            this.txtViewBooksQuantity.Size = new System.Drawing.Size(100, 26);
            this.txtViewBooksQuantity.TabIndex = 11;
            // 
            // txtViewBooksPrice
            // 
            this.txtViewBooksPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewBooksPrice.Location = new System.Drawing.Point(705, 53);
            this.txtViewBooksPrice.Name = "txtViewBooksPrice";
            this.txtViewBooksPrice.Size = new System.Drawing.Size(100, 26);
            this.txtViewBooksPrice.TabIndex = 10;
            // 
            // txtViewBooksPublicationName
            // 
            this.txtViewBooksPublicationName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewBooksPublicationName.Location = new System.Drawing.Point(219, 94);
            this.txtViewBooksPublicationName.Name = "txtViewBooksPublicationName";
            this.txtViewBooksPublicationName.Size = new System.Drawing.Size(189, 26);
            this.txtViewBooksPublicationName.TabIndex = 8;
            // 
            // txtViewBooksAuthorName
            // 
            this.txtViewBooksAuthorName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewBooksAuthorName.Location = new System.Drawing.Point(219, 56);
            this.txtViewBooksAuthorName.Name = "txtViewBooksAuthorName";
            this.txtViewBooksAuthorName.Size = new System.Drawing.Size(189, 26);
            this.txtViewBooksAuthorName.TabIndex = 7;
            // 
            // txtViewBooksBooksName
            // 
            this.txtViewBooksBooksName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewBooksBooksName.Location = new System.Drawing.Point(219, 14);
            this.txtViewBooksBooksName.Name = "txtViewBooksBooksName";
            this.txtViewBooksBooksName.Size = new System.Drawing.Size(189, 26);
            this.txtViewBooksBooksName.TabIndex = 6;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(557, 94);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(54, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(557, 53);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(557, 14);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(91, 13);
            this.lblPurchaseDate.TabIndex = 3;
            this.lblPurchaseDate.Text = "Purchase Date";
            // 
            // lblPublicationName
            // 
            this.lblPublicationName.AutoSize = true;
            this.lblPublicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicationName.Location = new System.Drawing.Point(84, 97);
            this.lblPublicationName.Name = "lblPublicationName";
            this.lblPublicationName.Size = new System.Drawing.Size(106, 13);
            this.lblPublicationName.TabIndex = 2;
            this.lblPublicationName.Text = "Publication Name";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(84, 53);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(80, 13);
            this.lblAuthorName.TabIndex = 1;
            this.lblAuthorName.Text = "Author Name";
            // 
            // lblBooksName
            // 
            this.lblBooksName.AutoSize = true;
            this.lblBooksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksName.Location = new System.Drawing.Point(84, 14);
            this.lblBooksName.Name = "lblBooksName";
            this.lblBooksName.Size = new System.Drawing.Size(78, 13);
            this.lblBooksName.TabIndex = 0;
            this.lblBooksName.Text = "Books Name";
            // 
            // view_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 550);
            this.Controls.Add(this.pnlViewBooksUpdate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvViewBooks);
            this.Name = "view_books";
            this.Text = "view_books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.view_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlViewBooksUpdate.ResumeLayout(false);
            this.pnlViewBooksUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.TextBox txtEnterBookName;
        private System.Windows.Forms.Label lblEnterBookName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchBooksByAuthor;
        private System.Windows.Forms.TextBox txtEnterBookAuthorName;
        private System.Windows.Forms.Label lblEnterAuthorName;
        private System.Windows.Forms.Panel pnlViewBooksUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtViewBooksQuantity;
        private System.Windows.Forms.TextBox txtViewBooksPrice;
        private System.Windows.Forms.TextBox txtViewBooksPublicationName;
        private System.Windows.Forms.TextBox txtViewBooksAuthorName;
        private System.Windows.Forms.TextBox txtViewBooksBooksName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblPublicationName;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblBooksName;
        private System.Windows.Forms.DateTimePicker dtpViewBooksPurchaseDate;
    }
}