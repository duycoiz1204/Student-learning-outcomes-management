using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;

namespace student_learning_outcomes_management
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItemKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoa frm = new frmKhoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGiaoVien frm = new frmGiaoVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemKhoaHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoaHoc frm = new frmKhoaHoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSinhVien frm = new frmSinhVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemKetQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKetQua frm = new frmKetQua();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemDSSinhVienKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSelectR_DSSV frm = new frmSelectR_DSSV();
            frm.Show();
        }

        private void barButtonItemCongTacGiangDay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSelectRCongTacgiangDay frm = new frmSelectRCongTacgiangDay();
            frm.Show();
        }

        private void barButtonItemBangDiemKhoaHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSelectRBangDiemKhoaHoc frm = new frmSelectRBangDiemKhoaHoc();
            frm.Show();
        }

        private void barButtonItemBangDiemSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSelectRDiemCuaSinhVien frm = new frmSelectRDiemCuaSinhVien();
            frm.Show();
        }
    }
}