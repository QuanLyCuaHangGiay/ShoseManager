using DoAnNet001.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNet001.Models
{
    class ThongKeModels
    {
        DoAnNetEntities1 db = new DoAnNetEntities1();
        private static ThongKeModels thongke = null;

        internal static ThongKeModels TaiKhoanCons
        {
            get
            {
                if (thongke == null)
                {
                    thongke = new ThongKeModels();
                }
                return thongke;
            }
            set => thongke = value;
        }
        //public List<ThongKe> getdata()
        //{
        //    List<ThongKe> thongke = (from c in db.ThongKes orderby c.id descending select c).ToList();
        //    return thongke;
        //}
        //public bool addThang(ThongKe a)
        //{
        //    db.ThongKes.Add(a);
        //    db.SaveChanges();
        //    return true;
        //}
       
    }
}
