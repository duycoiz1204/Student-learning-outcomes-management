using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace student_learning_outcomes_management
{
    public partial class frmGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            renderLookup();
            cbx_khoa.EditValue = "";
            LoadData();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btn_update.Enabled = false;
            gridView1.Columns["No"].View.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
            gridView1.RowClick += gridView1_RowClick;
        }
        private void renderLookup()
        {
            List<tKhoa> khoa = data.tKhoas.ToList();
            var column = from t in khoa
                         select new
                         {
                             MaKhoa = t.MaKhoa.Trim(),
                             TenKhoa = t.TenKhoa.Trim(),
                         };
            cbx_khoa.Properties.DataSource = column;
            cbx_khoa.Properties.DisplayMember = "TenKhoa";
            cbx_khoa.Properties.ValueMember = "MaKhoa";
        }
        private void LoadData()
        {
            int i = 0;
            List<tGiaoVien> LstGiaoVien = data.tGiaoViens.ToList();
            var column = from t in LstGiaoVien
                         select new
                         {
                             No = ++i,
                             MaGiaoVien = t.MaGiaoVien,
                             TenGiaoVien = t.TenGiaoVien,
                             HocVi = t.HocVi,
                             SoDienThoai = t.SoDienThoai,
                             MaKhoa = t.MaKhoa,
                         };
            lView_GV.DataSource = column.ToList();
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            errorProvider.ClearErrors();
            

                txtMaGV.Text = (sender as GridView).GetFocusedRowCellValue("MaGiaoVien").ToString().Trim();
                txtTenGV.Text = (sender as GridView).GetFocusedRowCellValue("TenGiaoVien").ToString().Trim();
                cbx_HocVi.Text = (sender as GridView).GetFocusedRowCellValue("HocVi").ToString().Trim();
                txtSDT.Text = (sender as GridView).GetFocusedRowCellValue("SoDienThoai").ToString().Trim();
                cbx_khoa.EditValue = (sender as GridView).GetFocusedRowCellValue("MaKhoa").ToString().Trim();

            //cbx_khoa.Text = (sender as GridView).GetFocusedRowCellValue("MaKhoa").ToString().Trim();

            btnDelete.Enabled = true;
            btn_update.Enabled = true;
            btnAdd.Enabled = false;

                txtMaGV.ReadOnly = true;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            errorProvider.ClearErrors();
            if (handleError())
            {
                bool flag = data.tGiaoViens.Any(x => x.MaGiaoVien == txtMaGV.Text.Trim());
                if (flag)
                {
                    MessageBox.Show("Đã tồn tại giáo viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tGiaoVien gv = new tGiaoVien
                    {
                        MaGiaoVien = txtMaGV.Text.Trim(),
                        TenGiaoVien = txtTenGV.Text.Trim(),
                        HocVi = cbx_HocVi.Text.Trim(),
                        SoDienThoai = txtSDT.Text.Trim(),
                        MaKhoa = cbx_khoa.EditValue.ToString().Trim()
                };
                    data.tGiaoViens.Add(gv);
                    data.SaveChanges();
                    LoadData();
                    handleCancel();
                }
            }


        }
        private Boolean handleError()
        {
            string MaGV = txtMaGV.Text.Trim();
            string TenGV = txtTenGV.Text.Trim();
            string Khoa = cbx_khoa.Text.Trim();
            string HV = cbx_HocVi.Text.Trim();
            string SDT = txtSDT.Text.Trim();
            bool isValid = true;
            if (MaGV.Length == 0)
            {
                errorProvider.SetError(txtMaGV, "Vui lòng nhập mã giáo viên");
                isValid = false;
            }
            else if (MaGV.Length != 4)
            {
                errorProvider.SetError(txtMaGV, "Mã giáo viên bắt buộc phải có 4 kí tự");
                isValid = false;
            }
            if (TenGV.Length == 0)
            {
                errorProvider.SetError(txtTenGV, "Vui lòng nhập tên giáo viên");
                isValid = false;
            }
            if (SDT.Length == 0)
            {
                errorProvider.SetError(txtSDT, "Vui lòng nhập số điện thoại");
                isValid = false;
            }
            if (HV.Length == 0)
            {
                errorProvider.SetError(cbx_HocVi, "Vui lòng xác nhận học vị cho giáo viên");
                isValid = false;
            }
            if (Khoa.Length == 0)
            {
                errorProvider.SetError(cbx_khoa, "Vui lòng xác nhận khoa cho giáo viên");
                isValid = false;
            }
            if (!isValid) return false;
            return true;    
        }

        private void cbx_khoa_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            errorProvider.ClearErrors();
            if (handleError())
            {
                var gv = data.tGiaoViens.FirstOrDefault(x => x.MaGiaoVien == txtMaGV.Text.Trim());
                gv.TenGiaoVien = txtTenGV.Text.Trim();
                gv.HocVi = cbx_HocVi.Text.Trim();
                gv.SoDienThoai = txtSDT.Text.Trim();
                gv.MaKhoa = cbx_khoa.EditValue.ToString().Trim();
                data.SaveChanges();
                LoadData();
                handleCancel();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            errorProvider.ClearErrors();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Boolean t2 = data.tKhoaHocs.Any(q => q.MaGiaoVien == txtMaGV.Text.Trim());
                if (t2)
                {
                    MessageBox.Show("Không thể xóa, giáo viên còn dạy khóa học khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    tGiaoVien k = new tGiaoVien { MaGiaoVien = txtMaGV.Text.Trim() };
                    data.tGiaoViens.Attach(k);
                    data.tGiaoViens.Remove(k);

                    btnAdd.Enabled = true;
                    btn_update.Enabled =false;
                    btnDelete.Enabled = false;
                    txtMaGV.ReadOnly = false;

                    data.SaveChanges();
                    LoadData();
                    handleCancel();

                }
            }
        }

        private void btn_cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            handleCancel();
        }
        public void handleCancel()
        {
            cbx_khoa.EditValue = "";
            errorProvider.ClearErrors();
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            cbx_HocVi.Text = "";
            txtSDT.Text = "";
            cbx_khoa.Text = "";

            txtMaGV.ReadOnly = false;
            btnDelete.Enabled = false;
            btn_update.Enabled = false;
            btnAdd.Enabled = true;
        }
    }
}