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
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();

        public frmKhoa()
        {
            InitializeComponent();

            barButtonItemUpdate.Enabled = false;
            dxErrorProvider.SetIconAlignment(textEditMaKhoa, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditTenKhoa, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditDiaChi, ErrorIconAlignment.MiddleRight);
            dxErrorProvider.SetIconAlignment(textEditDienThoai, ErrorIconAlignment.MiddleRight);
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            LoadData();
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
            if (validateForm())
                createKhoa();
        }

        private bool validateForm()
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

        private void createKhoa()
        {
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
            }
        }
    }
}