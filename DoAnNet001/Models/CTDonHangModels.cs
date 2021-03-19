using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNet001.Dao;

namespace DoAnNet001.Models
{
    class CTDonHangModels
    {
        DoAnNetEntities1 db = new DoAnNetEntities1();
        private static CTDonHangModels CTdonhang = null;

        internal static CTDonHangModels CTDonHangCons
        {
            get
            {
                if (CTdonhang == null)
                {
                    CTdonhang = new CTDonHangModels();
                }
                return CTdonhang;
            }
            set => CTdonhang = value;
        }
        public List<CTDonHang> getdata(int id)
        {
            List<CTDonHang> listCT = (from c in db.CTDonHangs where c.MaCTDonHang == id orderby c.MaCTDonHang descending select c).ToList();
            return listCT;
        }
        public bool Them(CTDonHang ct)
        {
            db.CTDonHangs.Add(ct);
            db.SaveChanges();
            return true;
        }
        public bool suaDH(CTDonHang ct)
        {
            CTDonHang donhangct = (from c in db.CTDonHangs where c.MaCTDonHang == ct.MaCTDonHang select c).SingleOrDefault();
            if (donhangct == null)
            {
                return false;
            }
            donhangct.MaCTSp = ct.MaCTSp;
            donhangct.GiaTien = ct.GiaTien;
            donhangct.SoLuong = ct.SoLuong;
            donhangct.TongTien = ct.TongTien;
            db.SaveChanges();
            return true;
        }
        public bool XoaCTDon(int id)
        {
            CTDonHang donhangct = (from c in db.CTDonHangs where c.MaCTDonHang == id select c).SingleOrDefault();
            if (donhangct == null)
            {
                return false;
            }
            db.CTDonHangs.Remove(donhangct);
            db.SaveChanges();
            return true;
        }
        public int getLastMa()
        {
            CTDonHang ct = (from c in db.CTDonHangs orderby c.MaCTDonHang descending select c).Take(1).SingleOrDefault();
            return ct.MaCTDonHang;
        }
    }
}
