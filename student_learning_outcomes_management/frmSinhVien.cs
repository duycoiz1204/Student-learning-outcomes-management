using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace student_learning_outcomes_management
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            RenderLookUpEditKhoa();
            LoadData();

            dxErrorProvider.SetIconAlignment(textEditMaSinhVien, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditHoSinhVien, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditTenSinhVien, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditNgaySinh, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(radioGroupPhai, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditDienThoai, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditDiaChi, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(lookUpEditKhoa, ErrorIconAlignment.MiddleRight);
        }

        private void RenderLookUpEditKhoa()
        {
            List<tKhoa> LstKhoa = data.tKhoas.ToList();
            var column = from t in LstKhoa
                         select new
                         {
                             MaKhoa = t.MaKhoa,
                             TenKhoa = t.TenKhoa
                         };
            lookUpEditKhoa.Properties.DataSource = column;
            lookUpEditKhoa.EditValue = lookUpEditKhoa.Properties.GetDataSourceValue(lookUpEditKhoa.Properties.Columns[0], 2);
        }

        private void LoadData()
        {
            List<tSinhVien> LstSinhVien = data.tSinhViens.ToList();
            var columns = from t in LstSinhVien
                          select new
                          {
                              MaSinhVien = t.MaSinhVien,
                              HoSinhVien = t.HoSinhVien,
                              TenSinhVien = t.TenSinhVien,
                              NgaySinh = t.NgaySinh.Value.ToString("dd/MM/yyyy"),
                              Phai = t.Phai.Value ? "Nam" : "Nữ",
                              DienThoai = t.DienThoai,
                              DiaChi = t.DiaChi,
                              MaKhoa = t.MaKhoa,
                              tKhoa = t.tKhoa.TenKhoa
                          };
            gridControl.DataSource = columns.ToList();
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            textEditMaSinhVien.Text = gridView.GetRowCellValue(e.RowHandle, "MaSinhVien").ToString();
            textEditHoSinhVien.Text = gridView.GetRowCellValue(e.RowHandle, "HoSinhVien").ToString();
            textEditTenSinhVien.Text = gridView.GetRowCellValue(e.RowHandle, "TenSinhVien").ToString();
            textEditNgaySinh.Text = gridView.GetRowCellValue(e.RowHandle, "NgaySinh").ToString();
            radioGroupPhai.SelectedIndex = gridView.GetRowCellValue(e.RowHandle, "Phai").ToString() == "Nam" ? 1 : 0;
            textEditDienThoai.Text = gridView.GetRowCellValue(e.RowHandle, "DienThoai").ToString();
            textEditDiaChi.Text = gridView.GetRowCellValue(e.RowHandle, "DiaChi").ToString();
            lookUpEditKhoa.EditValue = gridView.GetRowCellValue(e.RowHandle, "MaKhoa").ToString();

            textEditMaSinhVien.ReadOnly = true;

            barButtonItemAdd.Enabled = false;
            barButtonItemUpdate.Enabled = true;
            barButtonItemDelete.Enabled = true;
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (validateForm())
                createSinhVien();
        }

        private bool validateForm()
        {
            bool isValid = true;
            string MaSinhVien = textEditMaSinhVien.Text.Trim();
            string HoSinhVien = textEditHoSinhVien.Text.Trim();
            string TenSinhVien = textEditTenSinhVien.Text.Trim();
            string NgaySinh = textEditNgaySinh.Text.Trim();
            bool Phai = radioGroupPhai.SelectedIndex == 0 ? true : false;
            string DienThoai = textEditDienThoai.Text.Trim();
            string DiaChi = textEditDiaChi.Text.Trim();
            string MaKhoa = lookUpEditKhoa.EditValue.ToString();
            dxErrorProvider.ClearErrors();

            if (MaSinhVien.Length == 0)
            {
                dxErrorProvider.SetError(textEditMaSinhVien, "Vui lòng nhập mã sinh viên");
                isValid = false;
            }
            else if (MaSinhVien.Length != 8)
            {
                dxErrorProvider.SetError(textEditMaSinhVien, "Mã sinh viên bắt buộc phải có 8 kí tự");
                isValid = false;
            }
            if (HoSinhVien.Length == 0)
            {
                dxErrorProvider.SetError(textEditHoSinhVien, "Vui lòng nhập họ sinh viên");
                isValid = false;
            }
            if (TenSinhVien.Length == 0)
            {
                dxErrorProvider.SetError(textEditTenSinhVien, "Vui lòng nhập tên sinh viên");
                isValid = false;
            }
            DateTime parseNgaySinh;
            if (!DateTime.TryParse(NgaySinh, out parseNgaySinh) || DateTime.Compare(parseNgaySinh, DateTime.Now) > 0)
            {
                dxErrorProvider.SetError(textEditNgaySinh, "Vui lòng nhập ngày sinh hợp lệ");
                isValid = false;
            }
            if (radioGroupPhai.SelectedIndex == -1)
            {
                dxErrorProvider.SetError(radioGroupPhai, "Vui lòng chọn phái");
                isValid = false;
            }
            Regex regexPhone = new Regex(@"^0\d{9,10}$");
            if (!regexPhone.IsMatch(DienThoai))
            {
                dxErrorProvider.SetError(textEditDienThoai, "Vui lòng nhập điện thoại");
                isValid = false;
            }
            if (DiaChi.Length == 0)
            {
                dxErrorProvider.SetError(textEditDiaChi, "Vui lòng nhập địa chỉ");
                isValid = false;
            }

            if (!isValid) return false;
            return true;
        }

        private void createSinhVien()
        {
            bool isExistedRecord = data.tSinhViens.Any(x => x.MaSinhVien == textEditMaSinhVien.Text.Trim());

            if (isExistedRecord)
            {
                MessageBox.Show("Thêm thất bại. Đã tồn tại mã sinh viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tSinhVien sv = new tSinhVien
                {
                    MaSinhVien = textEditMaSinhVien.Text.Trim(),
                    HoSinhVien = textEditHoSinhVien.Text.Trim(),
                    TenSinhVien = textEditTenSinhVien.Text.Trim(),
                    NgaySinh = DateTime.Parse(textEditNgaySinh.Text),
                    Phai = radioGroupPhai.SelectedIndex == 0 ? true : false,
                    DienThoai = textEditDienThoai.Text.Trim(),
                    DiaChi = textEditDiaChi.Text.Trim(),
                    MaKhoa = lookUpEditKhoa.EditValue.ToString(),
                };
                data.tSinhViens.Add(sv);
                data.SaveChanges();
                LoadData();
            }
        }
    }
}