using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Dao;

namespace DoAnNet001.Models
{
    class NhanVienModels
    {
        DoAnNetEntities1 giay = new DoAnNetEntities1();
        private static NhanVienModels nhanvienss = null;

        internal static NhanVienModels Nhanviens
        {
            get
            {
                if (nhanvienss == null)
                {
                    nhanvienss = new NhanVienModels();
                }
                return nhanvienss;
            }
            set => nhanvienss = value;
        }
        public void getTen(ComboBox cb)
        {
            cb.DataSource = getNhanVien();
            cb.DisplayMember = "TenNV";
            cb.ValueMember = "MaNV";
        }
        public List<NhanVien> getNhanVien()
        {
            List<NhanVien> ListNhanvien = new List<NhanVien>();
            ListNhanvien = (from c in giay.NhanViens where c.TinhTrang == true select c).ToList();
            return ListNhanvien;
        }
        public bool SuaNhanVien(NhanVien nv)
        {
            NhanVien nhanvien = (from c in giay.NhanViens where c.MaNV == nv.MaNV select c).SingleOrDefault();
            if (nhanvien != null)
            {
                nhanvien.TenNV = nv.TenNV;
                nhanvien.NgaySinh = nv.NgaySinh;
                nhanvien.DiaChi = nv.DiaChi;
                nhanvien.HinhAnh = nv.HinhAnh;
                nhanvien.SDT = nv.SDT;
                nhanvien.TinhTrang = nv.TinhTrang;
                nhanvien.MaChucVu = nv.MaChucVu;
                giay.SaveChanges();
                return true;
            }
            return false;
        }
        public bool themNV(NhanVien nhanVien)
        {
            giay.NhanViens.Add(nhanVien);
            giay.SaveChanges();
            return true;
        }
        public bool xoa(int id)
        {
            NhanVien nv = (from c in giay.NhanViens where c.MaNV == id select c).SingleOrDefault();
            if (nv == null)
            {
                return false;
            }
            nv.TinhTrang = true;
            giay.SaveChanges();
            return true;
        }
        public List<NhanVien> SearchNV(string tennhanvien)
        {
            List<NhanVien> nhanviens = (from c in giay.NhanViens where c.TenNV == tennhanvien select c).ToList();
            return nhanviens;
        }
        public List<NhanVien> SearchNVNghi(string tennhanvien)
        {
            List<NhanVien> nhanviens = (from c in giay.NhanViens where c.TenNV == tennhanvien && c.TinhTrang == false select c).ToList();
            return nhanviens;
        }
        public List<NhanVien> getNVNghi()
        {
            List<NhanVien> listNghi = (from c in giay.NhanViens where c.TinhTrang == false select c).ToList();
            return listNghi;
        }
        public NhanVien GetNhan(int ma)
        {
            NhanVien nv = (from c in giay.NhanViens where c.MaNV == ma select c).SingleOrDefault();
            return nv;
        }
    }
}
