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
    public class frmSinhVienTests
    {
        [TestMethod()]
        public void createSinhVien_correctInput()
        {
            string MaSinhVien = "12200099";
            string HoSinhVien = "Trần Bảo";
            string TenSinhVien = "Tín";
            string NgaySinh = "01/01/2002";
            int Phai = 1;
            string DienThoai = "0374920182";
            string DiaChi = "Mỹ Tho";
            string MaKhoa = "K001";

            frmSinhVien sv = new frmSinhVien(MaSinhVien, HoSinhVien, TenSinhVien, NgaySinh, Phai, DienThoai, DiaChi, MaKhoa);
            Assert.IsTrue(sv.validateForm());
        }

        [TestMethod()]
        public void createSinhVien_emptyHoSV()
        {
            string MaSinhVien = "12200099";
            string HoSinhVien = "";
            string TenSinhVien = "Tín";
            string NgaySinh = "01/01/2002";
            int Phai = 1;
            string DienThoai = "0374920182";
            string DiaChi = "Mỹ Tho";
            string MaKhoa = "K001";

            frmSinhVien sv = new frmSinhVien(MaSinhVien, HoSinhVien, TenSinhVien, NgaySinh, Phai, DienThoai, DiaChi, MaKhoa);
            Assert.IsFalse(sv.validateForm());
        }

        [TestMethod()]
        public void createSinhVien_EmptyTenSV()
        {
            string MaSinhVien = "12200099";
            string HoSinhVien = "Trần Bảo";
            string TenSinhVien = "";
            string NgaySinh = "01/01/2002";
            int Phai = 1;
            string DienThoai = "0374920182";
            string DiaChi = "Mỹ Tho";
            string MaKhoa = "K001";

            frmSinhVien sv = new frmSinhVien(MaSinhVien, HoSinhVien, TenSinhVien, NgaySinh, Phai, DienThoai, DiaChi, MaKhoa);
            Assert.IsFalse(sv.validateForm());
        }

        [TestMethod()]
        public void createSinhVien_emptyNgaySinh()
        {
            string MaSinhVien = "12200099";
            string HoSinhVien = "Trần Bảo";
            string TenSinhVien = "Tín";
            string NgaySinh = "";
            int Phai = 1;
            string DienThoai = "0374920182";
            string DiaChi = "Mỹ Tho";
            string MaKhoa = "K001";

            frmSinhVien sv = new frmSinhVien(MaSinhVien, HoSinhVien, TenSinhVien, NgaySinh, Phai, DienThoai, DiaChi, MaKhoa);
            Assert.IsFalse(sv.validateForm());
        }

        [TestMethod()]
        public void createSinhVien_emptyPhai()
        {
            string MaSinhVien = "12200099";
            string HoSinhVien = "Trần Bảo";
            string TenSinhVien = "Tín";
            string NgaySinh = "01/01/2002";
            int Phai = -1;
            string DienThoai = "0374920182";
            string DiaChi = "Mỹ Tho";
            string MaKhoa = "K001";

            frmSinhVien sv = new frmSinhVien(MaSinhVien, HoSinhVien, TenSinhVien, NgaySinh, Phai, DienThoai, DiaChi, MaKhoa);
            Assert.IsFalse(sv.validateForm());
        }


        [TestMethod()]
        public void createSinhVien_emptySDT()
        {
            string MaSinhVien = "12200099";
            string HoSinhVien = "Trần Bảo";
            string TenSinhVien = "Tín";
            string NgaySinh = "01/01/2002";
            int Phai = 1;
            string DienThoai = "";
            string DiaChi = "Mỹ Tho";
            string MaKhoa = "K001";

            frmSinhVien sv = new frmSinhVien(MaSinhVien, HoSinhVien, TenSinhVien, NgaySinh, Phai, DienThoai, DiaChi, MaKhoa);
            Assert.IsFalse(sv.validateForm());
        }

        [TestMethod()]
        public void createSinhVien_emptyDiaChi()
        {
            string MaSinhVien = "12200099";
            string HoSinhVien = "Trần Bảo";
            string TenSinhVien = "Tín";
            string NgaySinh = "01/01/2002";
            int Phai = 1;
            string DienThoai = "0374920182";
            string DiaChi = "";
            string MaKhoa = "K001";

            frmSinhVien sv = new frmSinhVien(MaSinhVien, HoSinhVien, TenSinhVien, NgaySinh, Phai, DienThoai, DiaChi, MaKhoa);
            Assert.IsFalse(sv.validateForm());
        }

        //[TestMethod()]
        //public void createSinhVien_emptyKhoa()
        //{
        //    string MaSinhVien = "12200099";
        //    string HoSinhVien = "Trần Bảo";
        //    string TenSinhVien = "Tín";
        //    string NgaySinh = "01/01/2002";
        //    int Phai = 1;
        //    string DienThoai = "0374920182";
        //    string DiaChi = "Mỹ Tho";
        //    string MaKhoa = "K001";

        //    frmSinhVien sv = new frmSinhVien(MaSinhVien, HoSinhVien, TenSinhVien, NgaySinh, Phai, DienThoai, DiaChi, MaKhoa);
        //    Assert.IsTrue(sv.validateForm());
        //}
    }
}