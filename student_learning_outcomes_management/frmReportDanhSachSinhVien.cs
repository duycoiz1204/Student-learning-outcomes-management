using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_learning_outcomes_management
{
    public partial class frmReportDanhSachSinhVien : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();
        rpLstSinhVienInKhoa rpt;
        public frmReportDanhSachSinhVien(string MaKhoa)
        {
            InitializeComponent();
            rpt = new rpLstSinhVienInKhoa();
            List<tSinhVien> lst = data.tSinhViens.Where(x => x.MaKhoa == MaKhoa).ToList();
            var column = from t in lst
                         select new
                         {
                             MaSinhVien = t.MaSinhVien,
                             HoSinhVien = t.HoSinhVien,
                             TenSinhVien = t.TenSinhVien,
                             NgaySinh = t.NgaySinh.Value.ToString("dd/MM/yyyy"),
                             PhaiText = t.Phai == true ? "Nam" : "Nữ",
                             DienThoai = t.DienThoai,
                             DiaChi = t.DiaChi
                         };
            rpt.DataSource = column;

            tKhoa k = data.tKhoas.FirstOrDefault(x => x.MaKhoa == MaKhoa);
            rpt.MaKhoa.Text = MaKhoa;
            rpt.TenKhoa.Text = k.TenKhoa;
            rpt.DienThoai.Text = k.DienThoai;
            rpt.DiaChi.Text = k.DiaChi;
            rpt.Ngay.Text = String.Format("Hồ Chí Minh, ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            documentViewer1.DocumentSource = rpt;
        }

        private void frmReportDanhSachSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void editPrint_Click(object sender, EventArgs e)
        {
            ReportPrintTool tool = new ReportPrintTool(rpt);
            tool.ShowRibbonPreview();
        }

        private void print_Click(object sender, EventArgs e)
        {
            ReportPrintTool tool = new ReportPrintTool(rpt);
            tool.PrintDialog(); 
        }
    }
}