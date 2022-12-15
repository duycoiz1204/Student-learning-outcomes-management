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
    public class frmKhoaHocTests
    {
        [TestMethod()]
        public void validate_correct()
        {
            String makh = "KH99";
            String magv = "GV99";
            String mamh = "MH01";
            String start = "1/1/2023";
            String end = "1/4/2023";

            frmKhoaHoc kh = new frmKhoaHoc(makh, magv, mamh, start, end);
            Assert.IsTrue(kh.handleError());
        }

        [TestMethod()]
        public void validate_emptyMaKH()
        {
            String makh = "";
            String magv = "GV99";
            String mamh = "MH01";
            String start = "1/1/2023";
            String end = "1/4/2023";

            frmKhoaHoc kh = new frmKhoaHoc(makh, magv, mamh, start, end);
            Assert.IsFalse(kh.handleError());
        }

        [TestMethod()]
        public void validate_emptyMaMH()
        {
            String makh = "KH99";
            String magv = "GV99";
            String mamh = "";
            String start = "1/1/2023";
            String end = "1/4/2023";

            frmKhoaHoc kh = new frmKhoaHoc(makh, magv, mamh, start, end);
            Assert.IsFalse(kh.handleError());
        }

        [TestMethod()]
        public void validate_emptyMaGV()
        {
            String makh = "KH99";
            String magv = "";
            String mamh = "MH01";
            String start = "1/1/2023";
            String end = "1/4/2023";

            frmKhoaHoc kh = new frmKhoaHoc(makh, magv, mamh, start, end);
            Assert.IsFalse(kh.handleError());
        }

        [TestMethod()]
        public void validate_lengthMaKH()
        {
            String makh = "KH99123";
            String magv = "GV99";
            String mamh = "MH01";
            String start = "1/1/2023";
            String end = "1/4/2023";

            frmKhoaHoc kh = new frmKhoaHoc(makh, magv, mamh, start, end);
            Assert.IsFalse(kh.handleError());
        }

    }
}