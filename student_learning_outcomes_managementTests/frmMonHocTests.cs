using Microsoft.VisualStudio.TestTools.UnitTesting;
using student_learning_outcomes_management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_learning_outcomes_management.Tests
{
    [TestClass()]
    public class frmMonHocTests
    {
        [TestMethod()]
        public void createMonHoc_With_EmptyMaMonHoc()
        {
            frmMonHoc frm = new frmMonHoc();
            frm.textEditMaMonHoc.Text = "";
            frm.textEditTenMonHoc.Text = "Graphics Design";
            frm.textEditSoTietLyThuyet.Text = "10";
            frm.textEditSoTietThucHanh.Text = "10";

            bool flag = frm.createMonHoc();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void createMonHoc_With_EmptyTenMonHoc()
        {
            frmMonHoc frm = new frmMonHoc();
            frm.textEditMaMonHoc.Text = "MH21";
            frm.textEditTenMonHoc.Text = "";
            frm.textEditSoTietLyThuyet.Text = "10";
            frm.textEditSoTietThucHanh.Text = "10";

            bool flag = frm.createMonHoc();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void createMonHoc_With_EmptySoTietLyThuyet()
        {
            frmMonHoc frm = new frmMonHoc();
            frm.textEditMaMonHoc.Text = "MH21";
            frm.textEditTenMonHoc.Text = "Graphics Design";
            frm.textEditSoTietLyThuyet.Text = "";
            frm.textEditSoTietThucHanh.Text = "10";

            bool flag = frm.createMonHoc();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void createMonHoc_With_EmptySoTietThucHanh()
        {
            frmMonHoc frm = new frmMonHoc();
            frm.textEditMaMonHoc.Text = "MH21";
            frm.textEditTenMonHoc.Text = "Graphics Design";
            frm.textEditSoTietLyThuyet.Text = "10";
            frm.textEditSoTietThucHanh.Text = "";

            bool flag = frm.createMonHoc();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void createMonHoc_With_MaMonHocLength_OrtherThan_Four()
        {
            frmMonHoc frm = new frmMonHoc();
            frm.textEditMaMonHoc.Text = "MH2100000000";
            frm.textEditTenMonHoc.Text = "Graphics Design";
            frm.textEditSoTietLyThuyet.Text = "10";
            frm.textEditSoTietThucHanh.Text = "10";

            bool flag = frm.createMonHoc();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void createMonHoc_With_ValidInput()
        {
            frmMonHoc frm = new frmMonHoc();
            frm.textEditMaMonHoc.Text = "MH21";
            frm.textEditTenMonHoc.Text = "Graphics Design";
            frm.textEditSoTietLyThuyet.Text = "10";
            frm.textEditSoTietThucHanh.Text = "10";

            bool flag = frm.validateForm();
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void updateMonHoc_With_EmptyTenMonHoc()
        {
            frmMonHoc frm = new frmMonHoc();
            frm.textEditMaMonHoc.Text = "MH21";
            frm.textEditTenMonHoc.Text = "";
            frm.textEditSoTietLyThuyet.Text = "10";
            frm.textEditSoTietThucHanh.Text = "10";

            bool flag = frm.updateMonHoc();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void updateMonHocMonHoc_With_EmptySoTietLyThuyet()
        {
            frmMonHoc frm = new frmMonHoc();
            frm.textEditMaMonHoc.Text = "MH21";
            frm.textEditTenMonHoc.Text = "Graphics Design";
            frm.textEditSoTietLyThuyet.Text = "";
            frm.textEditSoTietThucHanh.Text = "10";

            bool flag = frm.updateMonHoc();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void updateMonHoc_With_EmptySoTietThucHanh()
        {
            frmMonHoc frm = new frmMonHoc();
            frm.textEditMaMonHoc.Text = "MH21";
            frm.textEditTenMonHoc.Text = "Graphics Design";
            frm.textEditSoTietLyThuyet.Text = "10";
            frm.textEditSoTietThucHanh.Text = "";

            bool flag = frm.updateMonHoc();
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void updateMonHoc_With_ValidInput()
        {
            frmMonHoc frm = new frmMonHoc();
            frm.textEditMaMonHoc.Text = "MH21";
            frm.textEditTenMonHoc.Text = "Graphics Design";
            frm.textEditSoTietLyThuyet.Text = "10";
            frm.textEditSoTietThucHanh.Text = "10";

            bool flag = frm.validateForm();
            Assert.IsTrue(flag);
        }
    }
}