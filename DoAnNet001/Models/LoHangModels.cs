using DoAnNet001.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNet001.Models
{
    class LoHangModels
    {
        DoAnNetEntities1 db = new DoAnNetEntities1();

        private static LoHangModels lohang = null;

        internal static LoHangModels chucVu
        {
            get
            {
                if (lohang == null)
                {
                    lohang = new LoHangModels();
                }
                return lohang;
            }
            set => lohang = value;
        }
        public List<KhoHang> getdata()
        {
            List<KhoHang> khohangs = (from c in db.KhoHangs orderby c.MaLoHang descending select c).ToList();
            return khohangs;
        }
        public void getmakhohang(ComboBox cb)
        {
            cb.DataSource = getdata();
            cb.DisplayMember = "MaLoHang";
            cb.ValueMember = "MaLoHang";
        }
        public int getMaLoHang(int Maloai)
        {
            LoaiSanPham a = (from c in db.LoaiSanPhams where c.MaLoai == Maloai select c).SingleOrDefault();
            if(a!=null)
            {
                KhoHang kho = (from c in db.KhoHangs where c.MaLoHang == a.MaLoHang orderby c.NgayNhap ascending select c).Take(1).SingleOrDefault(); 
                    return kho.MaLoHang;
            }
            else
            {
                return 0;
            }
           
        }
        public void themLoHang(KhoHang kh)
        {
            db.KhoHangs.Add(kh);
            db.SaveChanges();
        }
    }
}
