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
    public partial class frmKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();

        public frmKhoaHoc()
        {
            InitializeComponent();
        }
        public frmKhoaHoc(String makh,String magv, String mamh, String start, String end)
        {
            InitializeComponent();
            this.txtMaKH.Text = makh;
            this.cbx_GV.EditValue = magv;
            this.cbx_MH.EditValue = mamh;
            this.dtm_start.Text = start;
            this.dtm_end.Text =end;
        }

        private void frmKhoaHoc_Load(object sender, EventArgs e)
        {
            renderGiaoVienCBX();
            renderMonHocCBX();
            cbx_MH.EditValue = "";
            cbx_GV.EditValue = "";

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            LoadData();

            gridView1.Columns["No"].View.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
            gridView1.RowClick += gridView1_RowClick;
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            errorProvider.ClearErrors();

            txtMaKH.Text = (sender as GridView).GetFocusedRowCellValue("MaKhoaHoc").ToString().Trim();
                cbx_GV.EditValue = (sender as GridView).GetFocusedRowCellValue("MaGiaoVien").ToString().Trim();
                cbx_MH.EditValue = (sender as GridView).GetFocusedRowCellValue("MaMonHoc").ToString().Trim();
                dtm_start.EditValue = (sender as GridView).GetFocusedRowCellValue("NgayBatDau").ToString().Trim();
                dtm_end.EditValue = (sender as GridView).GetFocusedRowCellValue("NgayKetThuc").ToString().Trim();

                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;

                txtMaKH.ReadOnly = true;
            
        }
        private void LoadData()
        {
            int i = 0;
            List<tKhoaHoc> LstKhoaHoc = data.tKhoaHocs.ToList();
            var column = from t in LstKhoaHoc
                         select new
                         {
                             No = ++i,
                             MaKhoaHoc = t.MaKhoaHoc.Trim(),
                             MaGiaoVien = t.MaGiaoVien.Trim(),
                             TenGiaoVien = t.tGiaoVien.TenGiaoVien.Trim(),
                             MaMonHoc = t.MaMonHoc.Trim(),
                             TenMonHoc = t.tMonHoc.TenMonHoc.Trim(),
                             NgayBatDau = t.NgayBatDau,
                             NgayKetThuc = t.NgayKetThuc,
                         };
            lView_Course.DataSource = column.ToList();
        }
        private void renderGiaoVienCBX()
        {
            List<tGiaoVien> l = data.tGiaoViens.ToList();
            var column = from t in l
                         select new
                         {
                             MaGiaoVien = t.MaGiaoVien.Trim(),
                             TenGiaoVien = t.TenGiaoVien.Trim()
                         };
            cbx_GV.Properties.DataSource = column;
            cbx_GV.Properties.DisplayMember = "TenGiaoVien";
            cbx_GV.Properties.ValueMember = "MaGiaoVien";

        }
        private void renderMonHocCBX()
        {
            List<tMonHoc> l = data.tMonHocs.ToList();
            var column = from t in l
                         select new
                         {
                             MaMonHoc = t.MaMonHoc.Trim(),
                             TenMonHoc = t.TenMonHoc.Trim()
                         };
            cbx_MH.Properties.DataSource = column;
            cbx_MH.Properties.DisplayMember = "TenMonHoc";
            cbx_MH.Properties.ValueMember = "MaMonHoc";
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (handleError())
            {
                bool flag = data.tKhoaHocs.Any(x => x.MaKhoaHoc == txtMaKH.Text.Trim());
                if (flag)
                {
                    MessageBox.Show("Đã tồn tại khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tKhoaHoc kh = new tKhoaHoc
                    {
                        MaKhoaHoc = txtMaKH.Text.Trim(),
                        MaGiaoVien = cbx_GV.EditValue.ToString().Trim(),
                        MaMonHoc = cbx_MH.EditValue.ToString().Trim(),
                        NgayBatDau = DateTime.Parse(dtm_start.EditValue.ToString().Trim()),
                        NgayKetThuc = DateTime.Parse(dtm_end.EditValue.ToString().Trim())
                    };
                    data.tKhoaHocs.Add(kh);

                    data.SaveChanges();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    handleCancel();
                }
            }
            
        }
        public Boolean handleError()
        {
            errorProvider.ClearErrors();
            bool isValid = true;
            string KH = txtMaKH.Text.Trim();


            if (KH.Length == 0)
            {
                errorProvider.SetError(txtMaKH, "Vui lòng nhập mã khóa học");
                isValid = false;
            }
            else if (KH.Length != 4)
            {
                errorProvider.SetError(txtMaKH, "Mã khóa học phải có 4 ký tự");
                isValid = false;
            }
            if (cbx_GV.EditValue == "")
            {
                errorProvider.SetError(cbx_GV, "Vui lòng chọn giáo viên cho khóa học");
                isValid = false;
            }
            if (cbx_MH.EditValue == "")
            {
                errorProvider.SetError(cbx_MH, "Vui lòng chọn môn học cho khóa học");
                isValid = false;
            }
            if (!isValid) return false;
            return true;
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (handleError())
            {
                var kh = data.tKhoaHocs.FirstOrDefault(x => x.MaKhoaHoc.Contains(txtMaKH.Text.Trim()));

                kh.MaGiaoVien = cbx_GV.EditValue.ToString().Trim();
                kh.MaMonHoc = cbx_MH.EditValue.ToString().Trim();
                kh.NgayBatDau = DateTime.Parse(dtm_start.EditValue.ToString().Trim());
                kh.NgayKetThuc = DateTime.Parse(dtm_end.EditValue.ToString().Trim());

                data.SaveChanges();
                LoadData();
                handleCancel();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            errorProvider.ClearErrors();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Boolean t2 = data.tKetQuas.Any(q => q.MaKhoaHoc == txtMaKH.Text.Trim());
                if (t2)
                {
                    MessageBox.Show("Không thể xóa, còn tồn tại nhiều kết quả liên quan đên khóa học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    tKhoaHoc k = new tKhoaHoc { MaKhoaHoc = txtMaKH.Text.Trim() };
                    data.tKhoaHocs.Attach(k);
                    data.tKhoaHocs.Remove(k);

                    data.SaveChanges();
                    LoadData();

                    btnDelete.Enabled = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;
                    txtMaKH.ReadOnly = false;
                    handleCancel();

                }
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            handleCancel();
        }
        private void handleCancel()
        {
            errorProvider.ClearErrors();
            txtMaKH.Text = "";
            cbx_GV.EditValue = "";
            cbx_MH.EditValue = "";
            dtm_start.EditValue = DateTime.Today;
            dtm_end.EditValue = DateTime.Today;

            txtMaKH.ReadOnly = false;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;


        }

        private void lView_Course_Click(object sender, EventArgs e)
        {

        }
    }
}