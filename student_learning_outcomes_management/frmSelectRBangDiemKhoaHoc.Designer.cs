namespace student_learning_outcomes_management
{
    partial class frmSelectRBangDiemKhoaHoc
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbx_khoa = new System.Windows.Forms.ComboBox();
            this.btn_ctn = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_mh = new System.Windows.Forms.ComboBox();
            this.cbx_gv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_kh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(207, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(236, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Vui lòng chọn khóa học";
            // 
            // cbx_khoa
            // 
            this.cbx_khoa.FormattingEnabled = true;
            this.cbx_khoa.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbx_khoa.Location = new System.Drawing.Point(270, 108);
            this.cbx_khoa.Name = "cbx_khoa";
            this.cbx_khoa.Size = new System.Drawing.Size(217, 24);
            this.cbx_khoa.TabIndex = 1;
            this.cbx_khoa.SelectedValueChanged += new System.EventHandler(this.cbx_khoa_SelectedIndexChanged);
            this.cbx_khoa.Click += new System.EventHandler(this.cbx_khoa_Click);
            // 
            // btn_ctn
            // 
            this.btn_ctn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ctn.Location = new System.Drawing.Point(540, 327);
            this.btn_ctn.Name = "btn_ctn";
            this.btn_ctn.Size = new System.Drawing.Size(94, 29);
            this.btn_ctn.TabIndex = 2;
            this.btn_ctn.Text = "Tiếp tục";
            this.btn_ctn.Click += new System.EventHandler(this.btn_ctn_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(436, 327);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Môn học:";
            // 
            // cbx_mh
            // 
            this.cbx_mh.FormattingEnabled = true;
            this.cbx_mh.Location = new System.Drawing.Point(270, 154);
            this.cbx_mh.Name = "cbx_mh";
            this.cbx_mh.Size = new System.Drawing.Size(217, 24);
            this.cbx_mh.TabIndex = 6;
            this.cbx_mh.SelectedValueChanged += new System.EventHandler(this.cbx_mh_SelectedIndexChanged);
            // 
            // cbx_gv
            // 
            this.cbx_gv.FormattingEnabled = true;
            this.cbx_gv.Location = new System.Drawing.Point(270, 204);
            this.cbx_gv.Name = "cbx_gv";
            this.cbx_gv.Size = new System.Drawing.Size(217, 24);
            this.cbx_gv.TabIndex = 7;
            this.cbx_gv.SelectedValueChanged += new System.EventHandler(this.cbx_gv_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giáo viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã khóa học:";
            // 
            // cbx_kh
            // 
            this.cbx_kh.FormattingEnabled = true;
            this.cbx_kh.Location = new System.Drawing.Point(270, 254);
            this.cbx_kh.Name = "cbx_kh";
            this.cbx_kh.Size = new System.Drawing.Size(217, 24);
            this.cbx_kh.TabIndex = 10;
            this.cbx_kh.SelectedIndexChanged += new System.EventHandler(this.cbx_kh_SelectedIndexChanged);
            // 
            // frmSelectRBangDiemKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 368);
            this.Controls.Add(this.cbx_kh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_gv);
            this.Controls.Add(this.cbx_mh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ctn);
            this.Controls.Add(this.cbx_khoa);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectRBangDiemKhoaHoc";
            this.Text = "Bảng điểm khóa học";
            this.Load += new System.EventHandler(this.frmSelectRBangDiemKhoaHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbx_khoa;
        private DevExpress.XtraEditors.SimpleButton btn_ctn;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_mh;
        private System.Windows.Forms.ComboBox cbx_gv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_kh;
    }
}