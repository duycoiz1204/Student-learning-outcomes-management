using Microsoft.VisualStudio.TestTools.UnitTesting;
using student_learning_outcomes_management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_learning_outcomes_management.Tests
{
    [TestClass()]
    public class frmKhoaTests
    {
        [TestMethod()]
        public void createKhoa_With_EmptyMaKhoa()
        {
            frmKhoa frm = new frmKhoa();
            frm.textEditMaKhoa.Text = "";
            frm.textEditTenKhoa.Text = "Eletricity";
            frm.textEditDiaChi.Text = "TPHCM";
            frm.textEditDienThoai.Text = "0977616905";

            bool flag = frm.createKhoa();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void createKhoa_With_EmptyTenKhoa()
        {
            frmKhoa frm = new frmKhoa();
            frm.textEditMaKhoa.Text = "K100";
            frm.textEditTenKhoa.Text = "";
            frm.textEditDiaChi.Text = "TPHCM";
            frm.textEditDienThoai.Text = "0977616905";

            bool flag = frm.createKhoa();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void createKhoa_With_EmptyDiaChi()
        {
            frmKhoa frm = new frmKhoa();
            frm.textEditMaKhoa.Text = "K100";
            frm.textEditTenKhoa.Text = "Eletricity";
            frm.textEditDiaChi.Text = "";
            frm.textEditDienThoai.Text = "0977616905";

            bool flag = frm.createKhoa();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void createKhoa_With_EmptyDienThoai()
        {
            frmKhoa frm = new frmKhoa();
            frm.textEditMaKhoa.Text = "K100";
            frm.textEditTenKhoa.Text = "Eletricity";
            frm.textEditDiaChi.Text = "TPHCM";
            frm.textEditDienThoai.Text = "";

            bool flag = frm.createKhoa();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void createKhoa_With_MaKhoaLength_OtherThan_Four()
        {
            frmKhoa frm = new frmKhoa();
            frm.textEditMaKhoa.Text = "K0000000000";
            frm.textEditTenKhoa.Text = "Eletricity";
            frm.textEditDiaChi.Text = "TPHCM";
            frm.textEditDienThoai.Text = "0977616905";

            bool flag = frm.createKhoa();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void createKhoa_With_ValidInput()
        {
            frmKhoa frm = new frmKhoa();
            frm.textEditMaKhoa.Text = "K006";
            frm.textEditTenKhoa.Text = "Eletricity";
            frm.textEditDiaChi.Text = "TPHCM";
            frm.textEditDienThoai.Text = "0977616905";

            bool flag = frm.validateForm();
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void updateKhoa_With_EmptyTenKhoa()
        {
            frmKhoa frm = new frmKhoa();
            frm.textEditMaKhoa.Text = "K100";
            frm.textEditTenKhoa.Text = "";
            frm.textEditDiaChi.Text = "TPHCM";
            frm.textEditDienThoai.Text = "0977616905";

            bool flag = frm.updateKhoa();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void updateKhoa_With_EmptyDiaChi()
        {
            frmKhoa frm = new frmKhoa();
            frm.textEditMaKhoa.Text = "K100";
            frm.textEditTenKhoa.Text = "Eletricity";
            frm.textEditDiaChi.Text = "";
            frm.textEditDienThoai.Text = "0977616905";

            bool flag = frm.updateKhoa();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void updateKhoa_With_EmptyDienThoai()
        {
            frmKhoa frm = new frmKhoa();
            frm.textEditMaKhoa.Text = "K100";
            frm.textEditTenKhoa.Text = "Eletricity";
            frm.textEditDiaChi.Text = "TPHCM";
            frm.textEditDienThoai.Text = "";

            bool flag = frm.updateKhoa();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void updateKhoa_With_ValidInput()
        {
            frmKhoa frm = new frmKhoa();
            frm.textEditMaKhoa.Text = "K006";
            frm.textEditTenKhoa.Text = "Eletricity";
            frm.textEditDiaChi.Text = "TPHCM";
            frm.textEditDienThoai.Text = "0977616905";

            bool flag = frm.validateForm();
            Assert.IsTrue(flag);
        }
    }
}