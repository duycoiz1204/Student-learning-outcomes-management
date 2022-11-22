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
    public partial class frmReportCongTacGiangDay : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();
        CongTacGiangDay rpt;
        public frmReportCongTacGiangDay(string khoa)
        {
            InitializeComponent();
            rpt = new CongTacGiangDay();
            List<tKhoaHoc> l = data.tKhoaHocs.Where(q => q.tGiaoVien.tKhoa.MaKhoa == khoa).ToList<tKhoaHoc>();
            var column = from t in l
                         select new
                         {
                             MaKhoaHoc = t.MaKhoaHoc,
                             MaGiaoVien = t.MaGiaoVien,
                             tGiaoVien = t.tGiaoVien,
                             MaMonHoc = t.MaMonHoc,
                             tMonHoc = t.tMonHoc,
                             NgayBatDau = t.NgayBatDau.Value.ToString("dd/MM/yyyy"),
                             NgayKetThuc = t.NgayKetThuc.Value.ToString("dd/MM/yyyy")
                         };
            rpt.DataSource = column;
            tKhoa k = data.tKhoas.FirstOrDefault(q => q.MaKhoa == khoa);
            rpt.MaKhoa.Text = khoa;
            rpt.Khoa.Text = k.TenKhoa;
            rpt.Ngay.Text = String.Format("Hồ Chí Minh, ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            documentViewer1.DocumentSource = rpt;
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