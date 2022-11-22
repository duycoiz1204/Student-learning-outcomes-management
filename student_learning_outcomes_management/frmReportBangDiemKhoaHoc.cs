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
    public partial class frmReportBangDiemKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();
        BangDiemKhoaHoc rpt;
        public frmReportBangDiemKhoaHoc(string mkh)
        {
            InitializeComponent();
            rpt = new BangDiemKhoaHoc();
            List<tKetQua> l = data.tKetQuas.ToList<tKetQua>();
            
                             rpt.DataSource = l;
            tKhoaHoc kh = data.tKhoaHocs.FirstOrDefault(q => q.MaKhoaHoc == mkh);
            rpt.MaKhoaHoc.Text = mkh;
            rpt.MonHoc.Text = kh.tMonHoc.TenMonHoc.ToString().Trim();
            rpt.MaMonHoc.Text = kh.MaMonHoc.ToString().Trim();
            rpt.GiaoVien.Text = kh.tGiaoVien.TenGiaoVien.ToString().Trim();
            rpt.MaGiaoVien.Text = kh.MaGiaoVien.ToString().Trim();
            rpt.Khoa.Text = kh.tGiaoVien.tKhoa.TenKhoa.ToString().Trim();
            rpt.NgayBatDau.Text = kh.NgayBatDau.ToString().Trim();
            rpt.NgayKetThuc.Text = kh.NgayKetThuc.ToString().Trim();
            rpt.Ngay.Text = String.Format("Hồ Chí Minh, ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            documentViewer1.DocumentSource = rpt;
        }

        private void frmReportBangDiemKhoaHoc_Load(object sender, EventArgs e)
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