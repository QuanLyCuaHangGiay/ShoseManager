using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNet001.Dao;
namespace DoAnNet001.Models
{
    class DonHangModels
    {
        DoAnNetEntities1 db = new DoAnNetEntities1();
        private static DonHangModels DonHang = null;

        internal static DonHangModels DonHangCons
        {
            get
            {
                if (DonHang == null)
                {
                    DonHang = new DonHangModels();
                }
                return DonHang;
            }
            set => DonHang = value;
        }

        public List<DonHang> getdata()
        {
            List<DonHang> donhang = (from c in db.DonHangs orderby c.MaDonHang descending select c).ToList();
            return donhang;
        }
        public bool ThemDonHang(DonHang dh)
        {
            db.DonHangs.Add(dh);
            db.SaveChanges();
            return true;
        }
        public bool SuaDonHang(DonHang dh)
        {
            DonHang donhang = (from c in db.DonHangs where c.MaDonHang == dh.MaDonHang select c).SingleOrDefault();
            if (donhang == null)
            {
                return false;
            }
            donhang.MaDonHang = dh.MaDonHang;
            donhang.MaKH = dh.MaKH;
            donhang.MaLoHang = dh.MaLoHang;
            donhang.NgayMua = dh.NgayMua;
            donhang.SoLuong = dh.SoLuong;
            donhang.MaNV = dh.MaNV;
            donhang.TongTien = dh.TongTien;
            db.SaveChanges();
            return true;
        }
        public bool Xoa(int id)
        {
            DonHang donhang = (from c in db.DonHangs where c.MaDonHang == id select c).SingleOrDefault();
            if (donhang == null)
            {
                return false;
            }
            db.DonHangs.Remove(donhang);
            db.SaveChanges();
            return true;

        }
        // tìm kiếm đơn hàng theo tên khách hàng
        public List<DonHang> donhang (string tenkh)
        {
            List<KhachHang> a = (from c in db.KhachHangs where c.TenKH == tenkh select c).ToList();
            List<DonHang> listDH =  new List<DonHang>();
            foreach (KhachHang item in a)
            {

                listDH = (from c in db.DonHangs where c.MaKH == item.MaKH select c).ToList();
              
                return listDH;
            }
            return null;
           
        }
        // lấy mã đơn hàng cuối cùng
        public int getLastMa()
        {
            DonHang a = (from c in db.DonHangs orderby c.MaDonHang descending select c).Take(1).SingleOrDefault();
            return a.MaDonHang;
        }
    }
}
