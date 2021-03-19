using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNet001.Dao;
namespace DoAnNet001.Models
{
    class CTPhieuNhapModels
    {
        DoAnNetEntities1 db = new DoAnNetEntities1();
        private static CTPhieuNhapModels CTphieunhap = null;

        internal static CTPhieuNhapModels CTPhieuNhapCons
        {
            get
            {
                if (CTphieunhap == null)
                {
                    CTphieunhap = new CTPhieuNhapModels();
                }
                return CTphieunhap;
            }
            set => CTphieunhap = value;
        }
        public List<CTPhieuNhap> getdata(string maphieunhap = null)
        {
            List<CTPhieuNhap> listCT = (from c in db.CTPhieuNhaps where c.MaPhieuNhap == int.Parse(maphieunhap) orderby c.MaCTPhieuNhap descending select c).ToList();
            return listCT;
        }
        public bool themCT(CTPhieuNhap cTPhieu)
        {
            db.CTPhieuNhaps.Add(cTPhieu);
            db.SaveChanges();
            return true;
        }
        public bool suaCT(CTPhieuNhap cTPhieu)
        {
            CTPhieuNhap phieunhap = (from c in db.CTPhieuNhaps where c.MaCTPhieuNhap == cTPhieu.MaCTPhieuNhap select c).SingleOrDefault();
            if (phieunhap == null)
            {
                return false;
            }
            phieunhap.MaCTPhieuNhap = cTPhieu.MaCTPhieuNhap;
            phieunhap.MaCTSp = cTPhieu.MaCTSp;
            phieunhap.MaPhieuNhap = cTPhieu.MaPhieuNhap;
            phieunhap.SoLuong = cTPhieu.SoLuong;
            phieunhap.TongTien = cTPhieu.SoLuong;
            phieunhap.GiaNhap = cTPhieu.GiaNhap;
            db.SaveChanges();
            return true;
        }
        public bool xoaCT(int id)
        {
            CTPhieuNhap phieunhap = (from c in db.CTPhieuNhaps where c.MaCTPhieuNhap == id select c).SingleOrDefault();
            if (phieunhap == null)
            {
                return false;
            }
            db.CTPhieuNhaps.Remove(phieunhap);
            db.SaveChanges();
            return true;
        }
        public int getma()
        {
            PhieuNhap a = (from c in db.PhieuNhaps orderby c.MaPhieuNhap descending select c).Take(1).SingleOrDefault();
            int ma = a.MaPhieuNhap;
            return ma;
        }
    }
}
