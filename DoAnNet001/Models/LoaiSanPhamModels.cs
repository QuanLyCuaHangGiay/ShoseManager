using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Dao;
namespace DoAnNet001.Models
{
    class LoaiSanPhamModels
    {
        DoAnNetEntities1 db = new DoAnNetEntities1();
        private static LoaiSanPhamModels Loaisp = null;

        internal static LoaiSanPhamModels LoaiSP
        {
            get
            {
                if (Loaisp == null)
                {
                    Loaisp = new LoaiSanPhamModels();
                }
                return Loaisp;
            }
            set => Loaisp = value;
        }

        public List<LoaiSanPham> getdata()
        {
            List<LoaiSanPham> loaisanpham = (from c in db.LoaiSanPhams orderby c.MaLoai descending select c).ToList();
            return loaisanpham;
        }
        public bool ThemLoai(LoaiSanPham loaisp)
        {
            db.LoaiSanPhams.Add(loaisp);
            db.SaveChanges();
            return true;
        }
        public bool SuaLoai(LoaiSanPham loaisp)
        {
            LoaiSanPham sp = (from c in db.LoaiSanPhams where c.MaLoai == loaisp.MaLoai select c).SingleOrDefault();
            if (sp == null)
            {
                return false;
            }
            sp.MaLoai = loaisp.MaLoai;
            sp.TenLoai = loaisp.TenLoai;
            sp.ThuongHieu = loaisp.ThuongHieu;
            sp.MaLoHang = loaisp.MaLoHang;
            sp.SoLuong = loaisp.SoLuong;

            return true;
        }
        public bool XoaLoai(int id)
        {
            LoaiSanPham loaisp = (from c in db.LoaiSanPhams where c.MaLoai == id select c).SingleOrDefault();
            if (loaisp == null)
            {
                return false;
            }
            db.LoaiSanPhams.Remove(loaisp);
            db.SaveChanges();
            return true;
        }
        public void getTenLoai(ComboBox cb)
        {
            cb.DataSource = getdata();
            cb.DisplayMember = "TenLoai";
            cb.ValueMember = "MaLoai";
        }
        public List<LoaiSanPham> searchLoai(string Tenloai)
        {
            List<LoaiSanPham> listLoai = (from c in db.LoaiSanPhams where c.TenLoai == Tenloai select c).ToList();
            return listLoai;
        }
    }
}
