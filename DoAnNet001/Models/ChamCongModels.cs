using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNet001.Dao;

namespace DoAnNet001.Models
{
    class ChamCongModels
    {
        DoAnNetEntities1 db = new DoAnNetEntities1();

        private static ChamCongModels chucvu = null;

        internal static ChamCongModels chucVu
        {
            get
            {
                if (chucvu == null)
                {
                    chucvu = new ChamCongModels();
                }
                return chucvu;
            }
            set => chucvu = value;
        }
        public bool Them(ChamCong ch)
        {
            db.ChamCongs.Add(ch);
            db.SaveChanges();
            return true;
        }
        public bool Sua(ChamCong ch)
        {
            ChamCong cc = (from c in db.ChamCongs where c.MaNV == ch.MaNV && c.Cham == ch.Cham select c).SingleOrDefault();
            if (cc == null)
            {
                return false;
            }
            cc.Cham = ch.Cham;
            cc.MaNV = ch.MaNV;
            cc.NgayCham = ch.NgayCham;
            return true;
        }
    }
}
