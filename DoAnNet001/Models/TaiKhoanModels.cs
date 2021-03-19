using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNet001.Dao;
namespace DoAnNet001.Models
{
    class TaiKhoanModels
    {
        DoAnNetEntities1 db = new DoAnNetEntities1();
        private static TaiKhoanModels taiKhoan = null;

        internal static TaiKhoanModels TaiKhoanCons
        {
            get
            {
                if (taiKhoan == null)
                {
                    taiKhoan = new TaiKhoanModels();
                }
                return taiKhoan;
            }
            set => taiKhoan = value;
        }
        public bool DoiMK(TaiKhoan tk)
        {
            TaiKhoan tkh = (from c in db.TaiKhoans where c.TaiKhoan1 == tk.TaiKhoan1 select c).SingleOrDefault();
            if (tkh == null)
            {
                return false;
            }
            tkh.MatKhau = tk.MatKhau;
           
            db.SaveChanges();
            return true;
        }
        public bool GetPass(string tk,string mk)
        {
            TaiKhoan tks = (from c in db.TaiKhoans where c.TaiKhoan1 == tk && c.MatKhau == mk select c).SingleOrDefault();
            if(tks == null)
            {
                return false;
            }
            return true;
        }
        public int getMaNV(string tk)
        {
            TaiKhoan taikkhoan = (from c in db.TaiKhoans where c.TaiKhoan1 == tk select c).SingleOrDefault();
            return (int)taikkhoan.MaNV;
        }

    }
}
