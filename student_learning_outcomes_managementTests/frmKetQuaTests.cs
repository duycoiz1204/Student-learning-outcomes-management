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
    public class frmKetQuaTests
    {
        [TestMethod()]
        public void validate_correct()
        {
            String masv = "12200002";
            String makh = "KH01";
            String diem = "8";
            String lanthi = "1";
            
            frmKetQua kq = new frmKetQua(masv,makh,diem,lanthi);
            Assert.IsTrue(kq.handleValidate());
        }

        [TestMethod()]
        public void validate_emptyMaSV()
        {
            String masv = "";
            String makh = "KH01";
            String diem = "8";
            String lanthi = "1";

            frmKetQua kq = new frmKetQua(masv, makh, diem, lanthi);
            Assert.IsFalse(kq.handleValidate());
        }

        [TestMethod()]
        public void validate_lengthMaSV()
        {
            String masv = "1220000212345";
            String makh = "KH01";
            String diem = "8";
            String lanthi = "1";

            frmKetQua kq = new frmKetQua(masv, makh, diem, lanthi);
            Assert.IsFalse(kq.handleValidate());
        }

        [TestMethod()]
        public void validate_emptyMaKH()
        {
            String masv = "12200002";
            String makh = "";
            String diem = "8";
            String lanthi = "1";

            frmKetQua kq = new frmKetQua(masv, makh, diem, lanthi);
            Assert.IsFalse(kq.handleValidate());
        }

        [TestMethod()]
        public void validate_lengthMaKH()
        {
            String masv = "12200002";
            String makh = "KH0123";
            String diem = "8";
            String lanthi = "1";

            frmKetQua kq = new frmKetQua(masv, makh, diem, lanthi);
            Assert.IsFalse(kq.handleValidate());
        }

        [TestMethod()]
        public void validate_emptyLanthi()
        {
            String masv = "12200002";
            String makh = "KH01";
            String diem = "8";
            String lanthi = "";

            frmKetQua kq = new frmKetQua(masv, makh, diem, lanthi);
            Assert.IsFalse(kq.handleValidate());
        }

        [TestMethod()]
        public void validate_LanthiLimit()
        {
            String masv = "12200002";
            String makh = "KH01";
            String diem = "8";
            String lanthi = "-1";

            frmKetQua kq = new frmKetQua(masv, makh, diem, lanthi);
            Assert.IsFalse(kq.handleValidate());
        }

        [TestMethod()]
        public void validate_emptyDiem()
        {
            String masv = "12200002";
            String makh = "KH01";
            String diem = "";
            String lanthi = "1";

            frmKetQua kq = new frmKetQua(masv, makh, diem, lanthi);
            Assert.IsFalse(kq.handleValidate());
        }

        [TestMethod()]
        public void validate_DiemUpperLimit()
        {
            String masv = "12200002";
            String makh = "KH01";
            String diem = "11";
            String lanthi = "1";

            frmKetQua kq = new frmKetQua(masv, makh, diem, lanthi);
            Assert.IsFalse(kq.handleValidate());
        }

        [TestMethod()]
        public void validate_DiemLowerLimit()
        {
            String masv = "12200002";
            String makh = "KH01";
            String diem = "8";
            String lanthi = "-1";

            frmKetQua kq = new frmKetQua(masv, makh, diem, lanthi);
            Assert.IsFalse(kq.handleValidate());
        }

    }
}