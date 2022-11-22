namespace student_learning_outcomes_management
{
    partial class frmSelectRCongTacgiangDay
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ctn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(190, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(201, 28);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Vui lòng chọn khoa:";
            // 
            // cbx_khoa
            // 
            this.cbx_khoa.FormattingEnabled = true;
            this.cbx_khoa.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbx_khoa.Location = new System.Drawing.Point(219, 109);
            this.cbx_khoa.Name = "cbx_khoa";
            this.cbx_khoa.Size = new System.Drawing.Size(217, 24);
            this.cbx_khoa.TabIndex = 2;
            this.cbx_khoa.SelectedIndexChanged += new System.EventHandler(this.cbx_khoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Khoa:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(390, 226);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ctn
            // 
            this.btn_ctn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ctn.Location = new System.Drawing.Point(490, 226);
            this.btn_ctn.Name = "btn_ctn";
            this.btn_ctn.Size = new System.Drawing.Size(94, 29);
            this.btn_ctn.TabIndex = 7;
            this.btn_ctn.Text = "Tiếp tục";
            this.btn_ctn.Click += new System.EventHandler(this.btn_ctn_Click);
            // 
            // frmSelectRCongTacgiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 267);
            this.Controls.Add(this.btn_ctn);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_khoa);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectRCongTacgiangDay";
            this.Text = "Công tác giảng dạy";
            this.Load += new System.EventHandler(this.frmSelectRCongTacgiangDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbx_khoa;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.SimpleButton btn_ctn;
    }
}