using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace student_learning_outcomes_management
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();

        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();

            barButtonItemUpdate.Enabled = false;
            barButtonItemDelete.Enabled = false;

            dxErrorProvider.SetIconAlignment(textEditMaMonHoc, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditTenMonHoc, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditSoTietLyThuyet, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditSoTietThucHanh, ErrorIconAlignment.MiddleRight);
        }

        private void LoadData()
        {
            List<tMonHoc> LstMonHoc = data.tMonHocs.ToList();
            var column = from t in LstMonHoc
                         select new
                         {
                             MaMonHoc = t.MaMonHoc,
                             TenMonHoc = t.TenMonHoc,
                             SoTietLyThuyet = t.SoTietLyThuyet,
                             SoTietThucHanh = t.SoTietThucHanh
                         };
            gridControl.DataSource = column.ToList();
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            textEditMaMonHoc.Text = gridView.GetRowCellValue(e.RowHandle, "MaMonHoc").ToString();
            textEditTenMonHoc.Text = gridView.GetRowCellValue(e.RowHandle, "TenMonHoc").ToString();
            textEditSoTietLyThuyet.Text = gridView.GetRowCellValue(e.RowHandle, "SoTietLyThuyet").ToString();
            textEditSoTietThucHanh.Text = gridView.GetRowCellValue(e.RowHandle, "SoTietThucHanh").ToString();

            textEditMaMonHoc.ReadOnly = true;

            barButtonItemAdd.Enabled = false;
            barButtonItemUpdate.Enabled = true;
            barButtonItemDelete.Enabled = true;
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            createMonHoc();
        }

        public bool validateForm()
        {
            bool isValid = true;
            string MaMonHoc = textEditMaMonHoc.Text.Trim();
            string TenMonHoc = textEditTenMonHoc.Text.Trim();
            string SoTietLyThuyet = textEditSoTietLyThuyet.Text.Trim();
            string SoTietThucHanh = textEditSoTietThucHanh.Text.Trim();
            dxErrorProvider.ClearErrors();

            if (MaMonHoc.Length == 0)
            {
                dxErrorProvider.SetError(textEditMaMonHoc, "Vui lòng nhập mã môn học");
                isValid = false;
            }
            else if (MaMonHoc.Length != 4)
            {
                dxErrorProvider.SetError(textEditMaMonHoc, "Mã môn học bắt buộc phải có 4 kí tự");
                isValid = false;
            }
            if (TenMonHoc.Length == 0)
            {
                dxErrorProvider.SetError(textEditTenMonHoc, "Vui lòng nhập tên môn học");
                isValid = false;
            }
            Int16 parseSoTietLyThuyet;
            if (!Int16.TryParse(SoTietLyThuyet, out parseSoTietLyThuyet))
            {
                dxErrorProvider.SetError(textEditSoTietLyThuyet, "Vui lòng nhập số tiết lý thuyết hợp lệ");
                isValid = false;
            }
            Int16 parseSoTietThucHanh;
            if (!Int16.TryParse(SoTietThucHanh, out parseSoTietThucHanh))
            {
                dxErrorProvider.SetError(textEditSoTietThucHanh, "Vui lòng nhập số tiết thực hành hợp lệ");
                isValid = false;
            }

            return isValid;
        }

        public bool createMonHoc()
        {
            if (!validateForm())
                return false;

            bool isExistedRecord = data.tMonHocs.Any(x => x.MaMonHoc == textEditMaMonHoc.Text.Trim());

            if (isExistedRecord)
            {
                MessageBox.Show("Thêm thất bại. Đã tồn tại mã môn học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tMonHoc mh = new tMonHoc
                {
                    MaMonHoc = textEditMaMonHoc.Text.Trim(),
                    TenMonHoc = textEditTenMonHoc.Text.Trim(),
                    SoTietLyThuyet = Int16.Parse(textEditSoTietLyThuyet.Text.Trim()),
                    SoTietThucHanh = Int16.Parse(textEditSoTietThucHanh.Text.Trim())
                };
                data.tMonHocs.Add(mh);
                data.SaveChanges();
                LoadData();

                handleCancel();
            }
            return !isExistedRecord;
        }

        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            updateMonHoc();
        }
        public bool updateMonHoc()
        {
            if (!validateForm())
                return false;
            tMonHoc mh = data.tMonHocs.FirstOrDefault(x => x.MaMonHoc.Contains(textEditMaMonHoc.Text.Trim()));

            mh.TenMonHoc = textEditTenMonHoc.Text.Trim();
            mh.SoTietLyThuyet = Int16.Parse(textEditSoTietLyThuyet.Text.Trim());
            mh.SoTietThucHanh = Int16.Parse(textEditSoTietThucHanh.Text.Trim());

            data.SaveChanges();
            LoadData();

            handleCancel();
            return true;
        }
        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Xác nhận hành động", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool isExistedConstraintRecord = data.tKhoaHocs.Any(x => x.MaMonHoc == textEditMaMonHoc.Text.Trim());

                if (isExistedConstraintRecord)
                {
                    MessageBox.Show("Xóa thất bại. Dữ liệu đã ràng buộc với bảng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tMonHoc mh = data.tMonHocs.FirstOrDefault(x => x.MaMonHoc.Contains(textEditMaMonHoc.Text.Trim()));

                    data.tMonHocs.Remove(mh);
                    data.SaveChanges();
                    LoadData();

                    handleCancel();
                    data = new dbStudentLearningOutcomesManagementEntities();
                }
            }
        }

        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            handleCancel();
        }

        private void handleCancel()
        {
            textEditMaMonHoc.Text = "";
            textEditTenMonHoc.Text = "";
            textEditSoTietLyThuyet.Text = "";
            textEditSoTietThucHanh.Text = "";

            textEditMaMonHoc.ReadOnly = false;

            barButtonItemAdd.Enabled = true;
            barButtonItemUpdate.Enabled = false;
            barButtonItemDelete.Enabled = false;

            dxErrorProvider.ClearErrors();
        }
    }
}