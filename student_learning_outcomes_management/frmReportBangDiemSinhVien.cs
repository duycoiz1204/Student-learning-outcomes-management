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
    public partial class frmReportBangDiemSinhVien : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();
        rpLstDiemOfSinhVien rpt;
        public frmReportBangDiemSinhVien(String MaSinhVien)
        {
            InitializeComponent();
            rpt = new rpLstDiemOfSinhVien();
            List<tKetQua> lst = data.tKetQuas.Where(x => x.MaSinhVien == MaSinhVien).ToList();
            var column = from t in lst
                         group t by (t.tKhoaHoc.MaMonHoc, t.tKhoaHoc.tMonHoc.TenMonHoc) into g
                         select new
                         {
                             MaMonHoc = g.Key.MaMonHoc,
                             TenMonHoc = g.Key.TenMonHoc,
                             Diem = g.Max(t => t.Diem)
                         };
            rpt.DataSource = column;

            tSinhVien sv = data.tSinhViens.FirstOrDefault(x => x.MaSinhVien == MaSinhVien);
            rpt.HoTenSinhVien.Text = sv.HoSinhVien + " " + sv.TenSinhVien;
            rpt.MaSinhVien.Text = MaSinhVien;
            rpt.Khoa.Text = sv.tKhoa.TenKhoa;
            rpt.NgaySinh.Text = sv.NgaySinh.Value.ToString("dd/MM/yyyy");
            rpt.Phai.Text = sv.Phai.Value ? "Nam" : "Nữ";
            rpt.DienThoai.Text = sv.DienThoai;
            rpt.DiaChi.Text = sv.DiaChi;
            rpt.Ngay.Text = String.Format("Hồ Chí Minh, ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            documentViewer1.DocumentSource = rpt;
        }

        private void frmReportBangDiemSinhVien_Load(object sender, EventArgs e)
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