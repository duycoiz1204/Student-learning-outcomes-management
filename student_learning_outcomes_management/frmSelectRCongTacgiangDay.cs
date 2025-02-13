﻿using DevExpress.ClipboardSource.SpreadsheetML;
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

namespace student_learning_outcomes_management
{
    public partial class frmSelectRCongTacgiangDay : DevExpress.XtraEditors.XtraForm
    {
        dbStudentLearningOutcomesManagementEntities data = new dbStudentLearningOutcomesManagementEntities();
        frmMain Parent;
        public frmSelectRCongTacgiangDay(frmMain parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmSelectRCongTacgiangDay_Load(object sender, EventArgs e)
        {
            load_cbx_khoa();

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

        private void cbx_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_khoa.SelectedValue != null)
            {
                string kh = cbx_khoa.SelectedValue.ToString().Trim();
                if (kh != "")
                {
                    btn_ctn.Enabled = true;
                    return;
                }
            }
            btn_ctn.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ctn_Click(object sender, EventArgs e)
        {
            if (cbx_khoa.SelectedValue != null)
            {
                string kh = cbx_khoa.SelectedValue.ToString().Trim();
                if (kh != "")
                {
                    frmReportCongTacGiangDay frm = new frmReportCongTacGiangDay(kh);
                    frm.MdiParent = Parent;
                    frm.Show();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Khóa học không hợp lệ!");
        }
    }
}