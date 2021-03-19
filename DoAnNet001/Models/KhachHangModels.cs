using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Dao;
namespace DoAnNet001.Models
{
    class KhachHangModels
    {
        DoAnNetEntities1 db = new DoAnNetEntities1();

        private static KhachHangModels khachHang = null;

        internal static KhachHangModels KhachsHang
        {
            get
            {
                if (khachHang == null)
                {
                    khachHang = new KhachHangModels();
                }
                return khachHang;
            }
            set => khachHang = value;
        }

        public List<KhachHang> getdata(bool tinhtrang)
        {
            List<KhachHang> listKH = (from c in db.KhachHangs where c.TinhTrang == tinhtrang orderby c.MaKH descending select c).ToList();
            return listKH;
        }
        public bool ThemKH(KhachHang kh)
        {
            kh.TinhTrang = true;
            db.KhachHangs.Add(kh);
            db.SaveChanges();
            return true;
        }
        public bool SuaKH(KhachHang kh)
        {
            KhachHang khs = (from c in db.KhachHangs where c.MaKH == kh.MaKH select c).SingleOrDefault();
            if (khs == null)
            {
                return false;
            }

            khs.MaKH = kh.MaKH;
            khs.DiaChi = kh.DiaChi;
            khs.SoDienThoai = kh.SoDienThoai;
            khs.TenKH = kh.TenKH;
            db.SaveChanges();
            return true;
        }
        public bool XoaKH(int id,bool tinhtrang)
        {
            KhachHang khs = (from c in db.KhachHangs where c.MaKH == id select c).SingleOrDefault();
            if (khs == null)
            {
                return false;
            }
            khs.TinhTrang = tinhtrang;
            db.SaveChanges();
            return true;
        }
        public List<KhachHang> timkiem(string tenkh, bool tinhtrang)
        {
            List<KhachHang> listKH = (from c in db.KhachHangs where c.TenKH == tenkh && c.TinhTrang == tinhtrang orderby c.MaKH descending select c).ToList();
            return listKH;
        }
        public void getTenKhachHang(ComboBox cb)
        {
            cb.DataSource = getdata(true);
            cb.DisplayMember = "TenKH";
            cb.ValueMember = "MaKH";
        }
    }
}
