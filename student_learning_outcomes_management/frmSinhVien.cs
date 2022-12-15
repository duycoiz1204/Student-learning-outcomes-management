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
using DevExpress.XtraBars.Docking2010.Views.Widget;
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
        public frmSinhVien(String MSV, String ho, String ten, String BD, int phai, String sdt, String address, String khoa)
        {
            InitializeComponent();
            this.textEditMaSinhVien.Text = MSV;
            this.textEditHoSinhVien.Text = ho;
            this.textEditTenSinhVien.Text = ten;
            this.textEditNgaySinh.Text = BD;
            this.radioGroupPhai.SelectedIndex = phai;
            this.textEditDienThoai.Text = sdt;
            this.textEditDiaChi.Text = address;
            this.lookUpEditKhoa.EditValue = khoa;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            RenderLookUpEditKhoa();
            LoadData();

            barButtonItemUpdate.Enabled = false;
            barButtonItemDelete.Enabled = false;

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
            lookUpEditKhoa.EditValue = lookUpEditKhoa.Properties.GetDataSourceValue(lookUpEditKhoa.Properties.Columns[0], 1);
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
            radioGroupPhai.SelectedIndex = gridView.GetRowCellValue(e.RowHandle, "Phai").ToString() == "Nam" ? 0 : 1;
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

        public bool validateForm()
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
                String year = DateTime.Now.ToString("yy");
                String makhoa = lookUpEditKhoa.EditValue.ToString();
                char k = makhoa.ToCharArray()[3];

                countStudent c = data.countStudents.FirstOrDefault(q => (q.MaKhoa == makhoa && q.Year.Trim() == year));
                int stt = c.Count.Value;
                c.Count = stt + 1;
                String MSSV;
                if (stt < 10)
                {
                    MSSV = k + year + "0000" + stt;
                }else if (stt < 100)
                {
                    MSSV = k + year + "000" + stt;
                }
                else if (stt < 1000)
                {
                    MSSV = k + year + "00" + stt;
                }
                else
                {
                    MSSV = k + year + "0" + stt;
                }

                tSinhVien sv = new tSinhVien
                {
                    MaSinhVien = MSSV,
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

                handleCancel();
            }
        }

        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (validateForm())
                updateSinhVien();
        }

        private void updateSinhVien()
        {
            var sv = data.tSinhViens.FirstOrDefault(x => x.MaSinhVien.Contains(textEditMaSinhVien.Text.Trim()));

            sv.HoSinhVien = textEditHoSinhVien.Text.Trim();
            sv.TenSinhVien = textEditTenSinhVien.Text.Trim();
            sv.NgaySinh = DateTime.Parse(textEditNgaySinh.Text);
            sv.Phai = radioGroupPhai.SelectedIndex == 0 ? true : false;
            sv.DienThoai = textEditDienThoai.Text.Trim();
            sv.DiaChi = textEditDiaChi.Text.Trim();
            sv.MaKhoa = lookUpEditKhoa.EditValue.ToString();

            data.SaveChanges();
            LoadData();
            handleCancel();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Xác nhận hành động", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool isExistedConstraintRecord = data.tKetQuas.Any(x => x.MaSinhVien == textEditMaSinhVien.Text.Trim());

                if (isExistedConstraintRecord)
                {
                    MessageBox.Show("Xóa thất bại. Dữ liệu đã ràng buộc với bảng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tSinhVien sv = data.tSinhViens.FirstOrDefault(x => x.MaSinhVien.Contains(textEditMaSinhVien.Text.Trim()));

                    data.tSinhViens.Remove(sv);
                    data.SaveChanges();
                    LoadData();

                    handleCancel();
                    data = new dbStudentLearningOutcomesManagementEntities(); // fix tạm [tạo mới id, xóa rồi tạo lại id đó bị lỗi]
                }
            }
        }

        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            handleCancel();
        }

        private void handleCancel()
        {
            textEditMaSinhVien.Text = "";
            textEditHoSinhVien.Text = "";
            textEditTenSinhVien.Text = "";
            textEditNgaySinh.Text = "";
            radioGroupPhai.SelectedIndex = -1;
            textEditDienThoai.Text = "";
            textEditDiaChi.Text = "";
            lookUpEditKhoa.EditValue = lookUpEditKhoa.Properties.GetDataSourceValue(lookUpEditKhoa.Properties.Columns[0], 1);


            barButtonItemAdd.Enabled = true;
            barButtonItemUpdate.Enabled = false;
            barButtonItemDelete.Enabled = false;
        }
    }
}