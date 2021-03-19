using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNet001.Dao;
namespace DoAnNet001.Models
{
    class DangNhapModels
    {
        DoAnNetEntities1 giay = new DoAnNetEntities1();
        public static TaiKhoan session = new TaiKhoan();
        public static int phanquyen;
        private static DangNhapModels DangNhaps = null;

        internal static DangNhapModels DangNhapModelss
        {
            get
            {
                if (DangNhaps == null)
                {
                    DangNhaps = new DangNhapModels();
                }
                return DangNhaps;
            }
            set => DangNhaps = value;
        }

        public bool DangNhap(string taikhoan, string matkhau)
        {
            TaiKhoan a = (from c in giay.TaiKhoans where c.TaiKhoan1 == taikhoan && c.MatKhau == matkhau select c).SingleOrDefault();
            if (a == null)
            {
                return false;
            }
            else
            {
                session = a;
                return true;
            }

        }
        public int GetChucVu()
        {
            NhanVien nv = (from c in giay.NhanViens where c.MaNV == session.MaNV select c).SingleOrDefault();
            phanquyen = nv.MaChucVu.Value;
            if (phanquyen == 1)
            {
                return 1;
            }
            else if (phanquyen == 2)
            {
                return 2;
            }
            return 3;

        }
        public bool GetMk(string ten, int manhanvien, DateTime ngaysinh, int chucvu)
        {
            NhanVien nv = (from c in giay.NhanViens where c.MaChucVu == chucvu && c.TenNV == ten && c.MaNV == manhanvien && c.NgaySinh == ngaysinh select c).SingleOrDefault();
            if (nv == null)
            {
                return false;
            }
            phanquyen = nv.MaChucVu.Value;
            return true;
        }
    }
}
