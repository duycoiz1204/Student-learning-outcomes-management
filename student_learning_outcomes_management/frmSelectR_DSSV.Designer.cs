namespace student_learning_outcomes_management
{
    partial class frmSelectR_DSSV
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
            this.btn_ctn = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_khoa = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btn_ctn
            // 
            this.btn_ctn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ctn.Location = new System.Drawing.Point(490, 226);
            this.btn_ctn.Name = "btn_ctn";
            this.btn_ctn.Size = new System.Drawing.Size(94, 29);
            this.btn_ctn.TabIndex = 12;
            this.btn_ctn.Text = "Tiếp tục";
            this.btn_ctn.Click += new System.EventHandler(this.btn_ctn_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(390, 226);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Khoa:";
            // 
            // cbx_khoa
            // 
            this.cbx_khoa.FormattingEnabled = true;
            this.cbx_khoa.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbx_khoa.Location = new System.Drawing.Point(219, 121);
            this.cbx_khoa.Name = "cbx_khoa";
            this.cbx_khoa.Size = new System.Drawing.Size(217, 24);
            this.cbx_khoa.TabIndex = 9;
            this.cbx_khoa.SelectedIndexChanged += new System.EventHandler(this.cbx_khoa_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(190, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(201, 28);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Vui lòng chọn khoa:";
            // 
            // frmSelectR_DSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 267);
            this.Controls.Add(this.btn_ctn);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_khoa);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectR_DSSV";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.frmSelectR_DSSV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_ctn;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_khoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}