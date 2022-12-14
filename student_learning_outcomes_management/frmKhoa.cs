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
using DevExpress.XtraGrid.Views.Base;

namespace student_learning_outcomes_management
{
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();

        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            LoadData();

            barButtonItemUpdate.Enabled = false;
            barButtonItemDelete.Enabled = false;

            dxErrorProvider.SetIconAlignment(textEditMaKhoa, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditTenKhoa, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditDiaChi, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditDienThoai, ErrorIconAlignment.MiddleRight);
        }

        private void LoadData()
        {
            int i = 0;
            List<tKhoa> LstKhoa = data.tKhoas.ToList();
            var columns = from t in LstKhoa
                          select new
                          {
                              No = ++i,
                              MaKhoa = t.MaKhoa,
                              TenKhoa = t.TenKhoa,
                              DiaChi = t.DiaChi,
                              DienThoai = t.DienThoai
                          };
            gridControl.DataSource = columns.ToList();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            createKhoa();
        }

        public bool validateForm()
        {
            bool isValid = true;
            string MaKhoa = textEditMaKhoa.Text.Trim();
            string TenKhoa = textEditTenKhoa.Text.Trim();
            string DiaChi = textEditDiaChi.Text.Trim();
            string DienThoai = textEditDienThoai.Text.Trim();
            dxErrorProvider.ClearErrors();

            if (MaKhoa.Length == 0)
            {
                dxErrorProvider.SetError(textEditMaKhoa, "Vui lòng nhập mã khoa");
                isValid = false;
            }
            else if (MaKhoa.Length != 4)
            {
                dxErrorProvider.SetError(textEditMaKhoa, "Mã khoa bắt buộc phải có 4 kí tự");
                isValid = false;
            }
            if (TenKhoa.Length == 0)
            {
                dxErrorProvider.SetError(textEditTenKhoa, "Vui lòng nhập tên khoa");
                isValid = false;
            }
            if (DiaChi.Length == 0)
            {
                dxErrorProvider.SetError(textEditDiaChi, "Vui lòng nhập địa chỉ");
                isValid = false;
            }
            if (DienThoai.Length == 0)
            {
                dxErrorProvider.SetError(textEditDienThoai, "Vui lòng nhập điện thoại");
                isValid = false;
            }

            if (!isValid) return false;
            return true;
        } 

        public bool createKhoa()
        {
            if(!validateForm())
                return false;

            bool isExistedRecord = data.tKhoas.Any(x => x.MaKhoa == textEditMaKhoa.Text.Trim());

            if (isExistedRecord)
            {
                MessageBox.Show("Thêm thất bại. Đã tồn tại mã khoa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tKhoa k = new tKhoa
                {
                    MaKhoa = textEditMaKhoa.Text.Trim(),
                    TenKhoa = textEditTenKhoa.Text.Trim(),
                    DiaChi = textEditDiaChi.Text.Trim(),
                    DienThoai = textEditDienThoai.Text.Trim(),
                };
                data.tKhoas.Add(k);
                data.SaveChanges();
                LoadData();

                handleCancel();
            }
            return !isExistedRecord;
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            textEditMaKhoa.Text = gridView.GetRowCellValue(e.RowHandle, "MaKhoa").ToString();
            textEditTenKhoa.Text = gridView.GetRowCellValue(e.RowHandle, "TenKhoa").ToString();
            textEditDiaChi.Text = gridView.GetRowCellValue(e.RowHandle, "DiaChi").ToString();
            textEditDienThoai.Text = gridView.GetRowCellValue(e.RowHandle, "DienThoai").ToString();

            textEditMaKhoa.ReadOnly = true;

            barButtonItemAdd.Enabled = false;
            barButtonItemUpdate.Enabled = true;
            barButtonItemDelete.Enabled = true;
        }

        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            updateKhoa();
        }

        public bool updateKhoa()
        {
            if (!validateForm())
                return false;

            tKhoa k = data.tKhoas.FirstOrDefault(x => x.MaKhoa.Contains(textEditMaKhoa.Text.Trim()));

            k.TenKhoa = textEditTenKhoa.Text.Trim();
            k.DiaChi = textEditDiaChi.Text.Trim();
            k.DienThoai = textEditDienThoai.Text.Trim();

            data.SaveChanges();
            LoadData();

            handleCancel();

            return true;
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Xác nhận hành động", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool isExistedConstraintRecord = data.tSinhViens.Any(x => x.MaKhoa == textEditMaKhoa.Text.Trim());

                if (isExistedConstraintRecord)
                {
                    MessageBox.Show("Xóa thất bại. Dữ liệu đã ràng buộc với bảng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tKhoa k = data.tKhoas.FirstOrDefault(x => x.MaKhoa.Contains(textEditMaKhoa.Text.Trim()));

                    data.tKhoas.Remove(k);
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
            textEditMaKhoa.Text = "";
            textEditTenKhoa.Text = "";
            textEditDiaChi.Text = "";
            textEditDienThoai.Text = "";

            textEditMaKhoa.ReadOnly = false;

            barButtonItemAdd.Enabled = true;
            barButtonItemUpdate.Enabled = false;
            barButtonItemDelete.Enabled = false;

            dxErrorProvider.ClearErrors();
        }
    }
}