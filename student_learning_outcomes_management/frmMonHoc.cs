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
        }
    }
}