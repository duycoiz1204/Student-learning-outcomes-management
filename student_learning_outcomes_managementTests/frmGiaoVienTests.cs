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
    public class frmGiaoVienTests
    {

        [TestMethod()]
        public void createGV_correctInput()
        {
            String MaGV = "GV99";
            String TenGV = "Trần Trung Tín";
            String Hocvi = "Thạc sĩ";
            String SDT = "0462849572";
            String makhoa = "K001";

            frmGiaoVien gvF = new frmGiaoVien(MaGV, TenGV, Hocvi, SDT, makhoa);
            Boolean flag = gvF.handleError();

            Assert.IsTrue(flag);
        }
        [TestMethod()]
        public void createGV_emptyMaGV()
        {
            String MaGV = "";
            String TenGV = "Trần Trung Tín";
            String Hocvi = "Thạc sĩ";
            String SDT = "0462849572";
            String makhoa = "K001";

            frmGiaoVien gvF = new frmGiaoVien(MaGV,TenGV,Hocvi,SDT,makhoa);
            Boolean flag = gvF.handleError();

            Assert.IsFalse(flag);
        }

        
        [TestMethod()]
        public void create_checkLengthMaGV()
        {
            String MaGV = "GV996";
            String TenGV = "Trần Trung Tín";
            String Hocvi = "Thạc sĩ";
            String SDT = "0462849572";
            String makhoa = "K001";

            frmGiaoVien gvF = new frmGiaoVien(MaGV, TenGV, Hocvi, SDT, makhoa);
            Boolean flag = gvF.handleError();

            Assert.IsFalse(flag);
        }
        [TestMethod()]
        public void createGV_emptyTenGV()
        {
            String MaGV = "GV99";
            String TenGV = "";
            String Hocvi = "Thạc sĩ";
            String SDT = "0462849572";
            String makhoa = "K001";

            frmGiaoVien gvF = new frmGiaoVien(MaGV, TenGV, Hocvi, SDT, makhoa);
            Boolean flag = gvF.handleError();

            Assert.IsFalse(flag);
        }
        [TestMethod()]
        public void createGV_emptyHocVi()
        {
            String MaGV = "GV99";
            String TenGV = "Trần Trung Tín";
            String Hocvi = "";
            String SDT = "0462849572";
            String makhoa = "K001";

            frmGiaoVien gvF = new frmGiaoVien(MaGV, TenGV, Hocvi, SDT, makhoa);
            Boolean flag = gvF.handleError();

            Assert.IsFalse(flag);
        }
        [TestMethod()]
        public void createGV_emptySDT()
        {
            String MaGV = "GV99";
            String TenGV = "Trần Trung Tín";
            String Hocvi = "Thạc sĩ";
            String SDT = "";
            String makhoa = "K001";

            frmGiaoVien gvF = new frmGiaoVien(MaGV, TenGV, Hocvi, SDT, makhoa);
            Boolean flag = gvF.handleError();

            Assert.IsFalse(flag);
        }
        [TestMethod()]
        public void createGV_emptyKhoa()
        {
            String MaGV = "GV99";
            String TenGV = "Trần Trung Tín";
            String Hocvi = "Thạc sĩ";
            String SDT = "0462849572";
            String makhoa = "";

            frmGiaoVien gvF = new frmGiaoVien(MaGV, TenGV, Hocvi, SDT, makhoa);
            Boolean flag = gvF.handleError();

            Assert.IsFalse(flag);
        }
    }
}