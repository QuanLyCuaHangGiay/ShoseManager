using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNet001.Dao;
namespace DoAnNet001.Models
{
    class PhieuNhapModels
    {
        DoAnNetEntities1 db = new DoAnNetEntities1();
        private static PhieuNhapModels phieunhap = null;

        internal static PhieuNhapModels phieunhapCons
        {
            get
            {
                if (phieunhap == null)
                {
                    phieunhap = new PhieuNhapModels();
                }
                return phieunhap;
            }
            set => phieunhap = value;
        }
        public List<PhieuNhap> getdata()
        {
            List<PhieuNhap> listPN = (from c in db.PhieuNhaps orderby c.NgayNhap descending select c).ToList();
            return listPN;
        }
        public bool themPhieu(PhieuNhap phieu)
        {
            db.PhieuNhaps.Add(phieu);
            db.SaveChanges();
            return true;
        }
        public bool suaPhieu(PhieuNhap phieu)
        {
            PhieuNhap phieunhap = (from c in db.PhieuNhaps where c.MaPhieuNhap == phieu.MaPhieuNhap select c).SingleOrDefault();
            if (phieunhap == null)
            {
                return false;
            }
            phieunhap.MaPhieuNhap = phieu.MaPhieuNhap; ;
            phieunhap.NgayNhap = phieu.NgayNhap;
            phieunhap.MaNcc = phieu.MaNcc;
            phieunhap.MaNV = phieu.MaNV;

            return true;
        }
        public List<PhieuNhap> searchPhieu(DateTime ngaynhap)
        {
            List<PhieuNhap> list = (from c in db.PhieuNhaps where c.NgayNhap == ngaynhap select c).ToList();
            return list;
        }
        public int getLastMa()
        {
            PhieuNhap Phieu = (from c in db.PhieuNhaps orderby c.MaPhieuNhap descending select c).Take(1).SingleOrDefault();

            return Phieu.MaPhieuNhap;
        }
    }
}
