using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_learning_outcomes_management
{
    public partial class frmSelectRDiemCuaSinhVien : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();

        public frmSelectRDiemCuaSinhVien()
        {
            InitializeComponent();
        }

        private void frmSelectRDiemCuaSinhVien_Load(object sender, EventArgs e)
        {
            btn_ctn.Enabled = false;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            tSinhVien sv = data.tSinhViens.FirstOrDefault(q => q.MaSinhVien == txt_MSSV.Text.Trim());
            if (sv != null)
            {
                txtHoTen.Text = sv.HoSinhVien.Trim() + " " + sv.TenSinhVien.Trim();
                txt_ngaysinh.Text = sv.NgaySinh.ToString();
                txt_phai.Text = sv.Phai == true? "nam" : "nữ";
                txtKhoa.Text = sv.tKhoa.TenKhoa.Trim();
                txtHoTen.ForeColor = Color.Black;
                btn_ctn.Enabled = true;
            }
            else
            {
                txtHoTen.Text = "MSSV không đúng!";
                txt_ngaysinh.Text = "";
                txt_phai.Text = "";
                txtKhoa.Text ="";
                txtHoTen.ForeColor = Color.Red;
                btn_ctn.Enabled = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ctn_Click(object sender, EventArgs e)
        {
            frmReportBangDiemSinhVien frm = new frmReportBangDiemSinhVien(txt_MSSV.Text.Trim());
            frm.Show();
        }
    }
}