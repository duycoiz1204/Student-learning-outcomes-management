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
    }
}