using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Svg.CommonSvgImages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace student_learning_outcomes_management
{
    public partial class frmKetQua : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();
        Boolean existStudent = false;
        Boolean existCourse = false;
        Boolean isSearch = true;

        public frmKetQua()
        {
            InitializeComponent();
            
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            errorProvider.ClearErrors();
            isSearch = false;

            txtMaSV.Text = (sender as GridView).GetFocusedRowCellValue("MaSinhVien").ToString().Trim(); 
            txtMaKH.Text = (sender as GridView).GetFocusedRowCellValue("MaKhoaHoc").ToString().Trim(); 
            txtDiem.Text = (sender as GridView).GetFocusedRowCellValue("Diem").ToString().Trim(); 
            txtLanThi.Text = (sender as GridView).GetFocusedRowCellValue("LanThi").ToString().Trim(); 

            //txtMaSV.Text = gridView1.GetRowCellValue(e.RowHandle, "MaSinhVien").ToString().Trim();
            //txtMaKH.Text = gridView1.GetRowCellValue(e.RowHandle, "MaKhoaHoc").ToString().Trim();
            //txtDiem.Text = gridView1.GetRowCellValue(e.RowHandle, "Diem").ToString().Trim();
            //txtLanThi.Text = gridView1.GetRowCellValue(e.RowHandle, "LanThi").ToString().Trim();

            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btn_update.Enabled = true;
            btnCancel.Enabled = true;

            txtMaSV.ReadOnly = true;
            txtMaKH.ReadOnly = true;
            txtLanThi.ReadOnly = true;

           

        }
        private void frmKetQua_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btn_update.Enabled = false;
            loadData();
            gridView1.Columns["MaSinhVien"].View.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
            gridView1.RowClick += gridView_RowClick;
            enable_Input();
        }
        private void enable_Input()
        {

            txtMaSV.Text = "";
            txtMaKH.Text = "";
            txtLanThi.Text = "";
            txtDiem.Text = "";

            course.ForeColor = Color.Red;
            course.Text = "Vui Lòng nhập khóa học!";
            existCourse = false;
            student_name.Text = "Vui Lòng nhập mã sinh viên!";
            course.ForeColor = Color.Red;
            student_address.Text = "";
            student_birthday.Text = "";
            student_falcuty.Text = "";

            btnAdd.Enabled = true;
        }
        private void loadData()
        {
            int i = 0;
            List<tKetQua> LstKetQua = data.tKetQuas.ToList();
            var column = from t in LstKetQua
                         select new
                         {
                             No = ++i,
                             MaSinhVien = t.MaSinhVien.Trim(),
                             MaKhoaHoc = t.MaKhoaHoc.Trim(),
                             Diem = t.Diem,
                             LanThi = t.LanThi
                         };
            gridControl1.DataSource = column.ToList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (handleValidate())
            {
                createScore();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                handleCancel();
            }
            
        }

        private void btn_update_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            handleValidate();
            updateScore();
            loadData();
            handleCancel();
        }
        private bool handleValidate()
        {
            errorProvider.ClearErrors();
            bool isValid = true;
            string MaSV = txtMaSV.Text.Trim();
            string MaKH = txtMaKH.Text.Trim();

            if (MaSV.Length == 0)
            {
                errorProvider.SetError(txtMaSV, "Vui lòng nhập mã sinh viên");
                isValid = false;
            }
            else if (MaSV.Length != 8)
            {
                errorProvider.SetError(txtMaSV, "Mã sinh viên bắt buộc phải có 8 kí tự");
                isValid = false;
            }
            if (MaKH.Length == 0)
            {
                errorProvider.SetError(txtMaKH, "Vui lòng nhập mã khóa học");
                isValid = false;
            }
            else if (MaKH.Length != 4)
            {
                errorProvider.SetError(txtMaKH, "Mã khóa học bắt buộc phải có 4 kí tự");
                isValid = false;
            }
            if (txtLanThi.Text.Trim().Length == 0)
            {
                errorProvider.SetError(txtLanThi, "Vui lòng nhập lần thi");
                isValid = false;
            }
            else if (Int32.Parse(txtLanThi.Text.Trim()) < 1)
            {
                errorProvider.SetError(txtLanThi, "Lần thi phải lớn hơn 1");
                isValid = false;
            }
            if (txtDiem.Text.Trim().Length == 0)
            {
                errorProvider.SetError(txtDiem, "Vui lòng nhập điểm");
                isValid = false;
            }
            else if (Double.Parse(txtDiem.Text.Trim()) < 0)
            {
                errorProvider.SetError(txtDiem, "Điểm số không âm");
                isValid = false;
            }
            else if (Double.Parse(txtDiem.Text.Trim()) > 10)
            {
                errorProvider.SetError(txtDiem, "Điểm số không vượt quá 10");
                isValid = false;
            }
            if (!isValid) return false;
            return true;
        }
        private void createScore()
        {
            int t = Int32.Parse(txtLanThi.Text.Trim());
            bool flag = data.tKetQuas.Any(x => (x.MaSinhVien == txtMaSV.Text.Trim() && x.MaKhoaHoc == txtMaKH.Text.Trim() && x.LanThi == t));
            if (flag)
            {
                MessageBox.Show("Đã tồn tại kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (existCourse && existStudent)
                {
                    tKetQua KQ = new tKetQua
                    {
                        MaSinhVien = txtMaSV.Text.Trim(),
                        MaKhoaHoc = txtMaKH.Text.Trim(),
                        LanThi = Int16.Parse(txtLanThi.Text.Trim()),
                        Diem = Double.Parse(txtDiem.Text.Trim())
                    };
                    data.tKetQuas.Add(KQ);
                    data.SaveChanges();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
            }
        }

        private void updateScore()
        {
            int t = Int16.Parse(txtLanThi.Text.Trim());
            var kh = data.tKetQuas.FirstOrDefault(x => x.MaSinhVien == txtMaSV.Text.Trim() && x.MaKhoaHoc == txtMaKH.Text.Trim() && x.LanThi == t);

            kh.Diem = Double.Parse(txtDiem.Text.Trim());

            data.SaveChanges();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            errorProvider.ClearErrors();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tKetQua k = new tKetQua { MaSinhVien = txtMaSV.Text.Trim(), MaKhoaHoc = txtMaKH.Text.Trim(), LanThi = Int16.Parse(txtLanThi.Text.Trim()) };
                data.tKetQuas.Attach(k);
                data.tKetQuas.Remove(k);

                btnDelete.Enabled = false;
                btn_update.Enabled = false;
                btnAdd.Enabled = true;

                txtMaSV.ReadOnly = false;
                txtMaKH.ReadOnly = false;
                txtLanThi.ReadOnly = false;

                data.SaveChanges();
                loadData();
                handleCancel();
            }
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            handleCancel();
        }
        private void handleCancel()
        {

            isSearch = true;

            txtMaSV.Focus();
            txtMaSV.ReadOnly = false;
            txtMaKH.ReadOnly = false;

            txtDiem.ReadOnly = false;
            txtLanThi.ReadOnly = false;

            enable_Input();
            errorProvider.ClearErrors();

            btnDelete.Enabled = false;
            btn_update.Enabled = false;
            btnAdd.Enabled = true ;

            student_address.Text = "";
            student_birthday.Text = "";
            student_falcuty.Text = "";
            student_name.Text = "Bạn chưa điền mã số sinh viên";
            course.Text = "Bạn chưa nhập mã khóa học";
            student_name.ForeColor = Color.Red;
            course.ForeColor = Color.Red;
        }

        private void txtMaSV_EditValueChanged_1(object sender, EventArgs e)
        {
            if (isSearch)
            {
                List<tKetQua> search = data.tKetQuas.Where(q => q.MaSinhVien.Contains(txtMaSV.Text) == true).ToList();
                int i = 0;
                var column = from t in search
                             select new
                             {
                                 No = ++i,
                                 MaSinhVien = t.MaSinhVien.Trim(),
                                 MaKhoaHoc = t.MaKhoaHoc.Trim(),
                                 Diem = t.Diem,
                                 LanThi = t.LanThi
                             };
                gridControl1.DataSource = column;
            }
            

            tSinhVien sv = data.tSinhViens.FirstOrDefault(q=>q.MaSinhVien == txtMaSV.Text);
            existStudent = sv != null;
            
            if (existStudent)
            {
                student_name.Text = sv.HoSinhVien + " " + sv.TenSinhVien;
                student_name.ForeColor = Color.Black;
                student_address.Text = sv.DiaChi;
                student_birthday.Text = sv.NgaySinh.ToString();
                student_falcuty.Text = sv.tKhoa.TenKhoa;
                
            }
            else
            {
                student_name.Text = "Mã sinh viên chưa đúng!";
                student_name.ForeColor = Color.Red;
            }
        }

        private void txtMaKH_EditValueChanged_1(object sender, EventArgs e)
        {

            if (isSearch)
            {
                List<tKetQua> search = data.tKetQuas.Where(q => q.MaKhoaHoc.Contains(txtMaKH.Text) == true).ToList();
                int i = 0;
                var column = from t in search
                             select new
                             {
                                 No = ++i,
                                 MaSinhVien = t.MaSinhVien.Trim(),
                                 MaKhoaHoc = t.MaKhoaHoc.Trim(),
                                 Diem = t.Diem,
                                 LanThi = t.LanThi
                             };
                gridControl1.DataSource = column;
            }

            tKhoaHoc kh = data.tKhoaHocs.FirstOrDefault(q => q.MaKhoaHoc == txtMaKH.Text.Trim());
            if(kh != null)
            {
                course.Text = txtMaKH.Text;
                course.ForeColor = Color.Black;
                existCourse = true;
            }
            else
            {
                course.ForeColor = Color.Red;
                course.Text = "Không có khóa học này!";
                existCourse = false;
            }
            
        }
    }
}