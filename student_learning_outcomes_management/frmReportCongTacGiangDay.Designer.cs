namespace student_learning_outcomes_management
{
    partial class frmReportCongTacGiangDay
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
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.editPrint = new DevExpress.XtraEditors.SimpleButton();
            this.print = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.DocumentSource = typeof(student_learning_outcomes_management.CongTacGiangDay);
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(1030, 557);
            this.documentViewer1.TabIndex = 0;
            // 
            // editPrint
            // 
            this.editPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editPrint.Location = new System.Drawing.Point(797, 501);
            this.editPrint.Name = "editPrint";
            this.editPrint.Size = new System.Drawing.Size(105, 29);
            this.editPrint.TabIndex = 4;
            this.editPrint.Text = "Chỉnh sửa bản in";
            this.editPrint.Click += new System.EventHandler(this.editPrint_Click);
            // 
            // print
            // 
            this.print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.print.Location = new System.Drawing.Point(908, 501);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(94, 29);
            this.print.TabIndex = 3;
            this.print.Text = "In";
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // frmReportCongTacGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 557);
            this.Controls.Add(this.editPrint);
            this.Controls.Add(this.print);
            this.Controls.Add(this.documentViewer1);
            this.Name = "frmReportCongTacGiangDay";
            this.Text = "Công tác giảng dạy";
            this.Load += new System.EventHandler(this.frmReportCongTacGiangDay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraEditors.SimpleButton editPrint;
        private DevExpress.XtraEditors.SimpleButton print;
    }
}