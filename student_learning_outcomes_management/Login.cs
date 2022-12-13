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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        Account db = new Account();
        frmMain parent = new frmMain();
        Boolean isExit = true;
        public Login(frmMain p)
        {
            InitializeComponent();
            parent = p;

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider.ClearErrors();
            Boolean isValid = true;
            if (txt_username.Text.Length == 0)
            {
                errorProvider.SetError(txt_username, "Vui lòng nhập tên đăng nhập!");
                isValid = false;
            }
            if (txt_pass.Text.Length == 0)
            {
                errorProvider.SetError(txt_username, "Vui lòng nhập mật khẩu!");
                isValid = false;
            }
            if (isValid)
            {
                if(db.tAccounts.Any(q => q.TaiKhoan.Trim()==txt_username.Text.Trim() && q.MatKhau.Trim() == txt_pass.Text.Trim()))
                {
                    parent.Show();
                    isExit = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác!");
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                parent.Close();
            }
        }
    }
}