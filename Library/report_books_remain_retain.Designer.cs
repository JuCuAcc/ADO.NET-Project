
namespace Library
{
    partial class report_books_remain_retain
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
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SubCrystalReport11 = new Library.SubCrystalReport1();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.Maroon;
            this.btnGenerateReport.Location = new System.Drawing.Point(323, 51);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(204, 52);
            this.btnGenerateReport.TabIndex = 0;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(41, 137);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.SubCrystalReport11;
            this.crystalReportViewer1.Size = new System.Drawing.Size(852, 353);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // report_books_remain_retain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 525);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnGenerateReport);
            this.Name = "report_books_remain_retain";
            this.Text = "report_books_remain_retain";
            this.Load += new System.EventHandler(this.report_books_remain_retain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private SubCrystalReport1 SubCrystalReport11;
    }
}