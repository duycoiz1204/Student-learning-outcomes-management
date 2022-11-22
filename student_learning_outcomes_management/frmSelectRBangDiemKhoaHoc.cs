using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace student_learning_outcomes_management
{
    public partial class frmSelectRBangDiemKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();
        Boolean isLoop1 = true;
        Boolean isLoop2 = true;
        public frmSelectRBangDiemKhoaHoc()
        {
            InitializeComponent();
        }

        private void frmSelectRBangDiemKhoaHoc_Load(object sender, EventArgs e)
        {
            load_cbx_khoa();
            load_cbx_gv("",1);
            load_cbx_mh("",1);
            load_cbx_kh("", 1);

            btn_ctn.Enabled = false;
        }
        private void load_cbx_khoa()
        {
            tKhoa k = new tKhoa
            {
                MaKhoa = "",
                TenKhoa = "Khoa",
            };
            List<tKhoa> list = new List<tKhoa>();
            list.Add(k);
            list.AddRange(data.tKhoas.ToList<tKhoa>());
            
            
            cbx_khoa.DisplayMember = "TenKhoa";
            cbx_khoa.ValueMember = "MaKhoa";
            cbx_khoa.DataSource = list;
        }
        private void load_cbx_gv(string k,int type)
        {
            List<tGiaoVien> list = new List<tGiaoVien>();
            
                tGiaoVien gv = new tGiaoVien
                {
                    MaGiaoVien = "",
                    TenGiaoVien = "Giáo viên",
                };
                list.Add(gv);
            
            if (k == "")
            {
                list.AddRange(data.tGiaoViens.ToList<tGiaoVien>());
            }
            else
            {
                if(type ==1)
                    list.AddRange(data.tGiaoViens.Where(q => q.MaKhoa==k).ToList<tGiaoVien>());
                if(type ==2)
                    list.AddRange(data.tGiaoViens.Where(q => q.tKhoaHocs.Any(z=>z.MaMonHoc==k)).ToList<tGiaoVien>());

            }

            cbx_gv.DisplayMember = "TenGiaoVien";
            cbx_gv.ValueMember = "MaGiaoVien";
            cbx_gv.DataSource = list;
        }

        private void load_cbx_mh(string k, int type)
        {
            List<tMonHoc> list = new List<tMonHoc>();
            
                tMonHoc mh = new tMonHoc
                {
                    MaMonHoc = "",
                    TenMonHoc = "Môn học",
                };
                list.Add(mh);
            
            if (k == "")
            {
                list.AddRange(data.tMonHocs.ToList<tMonHoc>());
            }
            else
            {
                if(type==1)
                    list.AddRange(data.tMonHocs.Where(q => q.tKhoaHocs.Any(z => z.tGiaoVien.MaKhoa == k)).ToList<tMonHoc>());
                if(type==2)
                    list.AddRange(data.tMonHocs.Where(q => q.tKhoaHocs.Any(z => z.MaGiaoVien == k)).ToList<tMonHoc>());
            }

            cbx_mh.DisplayMember = "TenMonHoc";
            cbx_mh.ValueMember = "MaMonHoc";
            cbx_mh.DataSource = list;
        }
        private void load_cbx_kh(string k,int type)
        {
            List<tKhoaHoc> list = new List<tKhoaHoc>();
            
                tKhoaHoc kh = new tKhoaHoc
                {
                    MaKhoaHoc = "Khóa học",
                };
                list.Add(kh);
            
            if (k == "")
            {
                list.AddRange(data.tKhoaHocs.ToList<tKhoaHoc>());
            }
            else
            {
                if (type == 1)
                    list.AddRange(data.tKhoaHocs.Where(q => q.tGiaoVien.MaKhoa==k).ToList<tKhoaHoc>());
                if (type == 2)
                    list.AddRange(data.tKhoaHocs.Where(q => q.MaGiaoVien==k).ToList<tKhoaHoc>());
                if (type == 3)
                    list.AddRange(data.tKhoaHocs.Where(q => q.MaMonHoc == k).ToList<tKhoaHoc>());
            }

            cbx_kh.DisplayMember = "MaKhoaHoc";
            cbx_kh.ValueMember = "MaKhoaHoc";
            cbx_kh.DataSource = list;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ctn_Click(object sender, EventArgs e)
        {
            if (cbx_kh.SelectedValue != null)
            {
                string kh = cbx_kh.SelectedValue.ToString().Trim();
                if (kh != "" && kh.Length == 4)
                {
                    frmReportBangDiemKhoaHoc frm = new frmReportBangDiemKhoaHoc(kh);
                    frm.Show();
                    return;
                }
            }
            MessageBox.Show("Khóa học không hợp lệ!");

        }

        private void cbx_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string k = cbx_khoa.SelectedValue == null ? "" : cbx_khoa.SelectedValue.ToString().Trim();
            load_cbx_gv(k, 1);
            load_cbx_mh(k, 1);
            load_cbx_kh(k, 1);
        }

        private void cbx_mh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoop1)
            {
                string k = cbx_mh.SelectedValue == null ? "" : cbx_mh.SelectedValue.ToString().Trim();
                load_cbx_gv(k, 2);
                load_cbx_kh(k, 3);
                isLoop1 = false;
            }
            else
            {
                isLoop1 = true;
            }
        }

        private void cbx_gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoop2)
            {
                string k = cbx_gv.SelectedValue == null ? "" : cbx_gv.SelectedValue.ToString().Trim();
                load_cbx_mh(k, 2);
                load_cbx_kh(k, 2);
                isLoop2 = false;
            }
            else
            {
                isLoop2 = true;
            }
        }

        private void cbx_khoa_Click(object sender, EventArgs e)
        {
        }

        private void cbx_kh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_kh.SelectedValue != null )
            {
                string kh = cbx_kh.SelectedValue.ToString().Trim();
                if (kh != "" && kh.Length==4)
                {
                    btn_ctn.Enabled = true;
                    return;
                }
            }
            btn_ctn.Enabled = false;
        }
    }
}