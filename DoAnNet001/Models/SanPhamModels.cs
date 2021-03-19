using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Dao;
namespace DoAnNet001.Models
{
    class SanPhamModels
    {
        DoAnNetEntities1 giay = new DoAnNetEntities1();
        private static SanPhamModels sanphams = null;

        internal static SanPhamModels SanPhams
        {
            get
            {
                if (sanphams == null)
                {
                    sanphams = new SanPhamModels();
                }
                return sanphams;
            }
            set => sanphams = value;
        }
        
        public List<SanPham> getSanPham()
        {
            List<SanPham> Listsanpham = (from c in giay.SanPhams where c.TinhTrang == true select c).ToList();
            return Listsanpham;
        }


        public List<SanPham> getSanPhamDelete()
        {
            List<SanPham> Listsanpham = (from c in giay.SanPhams where c.TinhTrang == false select c).ToList();
            return Listsanpham;
        }

        public bool ThemSanPham(SanPham sp)
        {
            giay.SanPhams.Add(sp);
            giay.SaveChanges();
            return true;
        }

        public bool SuaSanPham(SanPham sp)
        {
            SanPham a = (from c in giay.SanPhams where c.MaSp == sp.MaSp select c).SingleOrDefault();
            if (a == null)
            {
                return false;
            }
            a.MaSp = sp.MaSp;
            a.HinhAnh = sp.HinhAnh;
            a.MaLoai = sp.MaLoai;
            a.MoTa = sp.MoTa;
            a.TenSanPham = sp.TenSanPham;
            a.SoLuong = sp.SoLuong;
            giay.SaveChanges();
            return true;
        }

        public bool XoaSanPham(int id)
        {
            SanPham sp = (from c in giay.SanPhams where c.MaSp == id select c).SingleOrDefault();
            if (sp == null)
            {
                return false;
            }
            giay.SanPhams.Remove(sp);
            giay.SaveChanges();
            return true;
        }

        public List<SanPham> TimKiemSanPham(string ten)
        {
            List<SanPham> Listsanpham = (from c in giay.SanPhams where c.TenSanPham == ten select c).ToList();
            return Listsanpham;
        }

        public void GetTenSP(ComboBox cb)
        {
            cb.DataSource = getSanPham();
            cb.DisplayMember = "TenSanPham";
            cb.ValueMember = "MaSp";
        }
        public void getTenSPwithMaL(ComboBox cb,int maloai,string value=null,string display = null)
        {
            cb.DataSource = (from c in giay.SanPhams where c.MaLoai == maloai select c).ToList();
            cb.DisplayMember = display;
            cb.ValueMember = value;
        }
        public void changeTinhTrang(int masp, bool tinhtrang)
        {
            SanPham a = (from c in giay.SanPhams where c.MaSp == masp select c ).SingleOrDefault();
            if(a!=null)
            {
                a.TinhTrang = tinhtrang;
                giay.SaveChanges();
            }
        }
        public string getTenSp(int ma)
        {
            SanPham sp = (from c in giay.SanPhams where c.MaSp == ma select c).SingleOrDefault();
            return sp.TenSanPham;
        }
        public int getLastMa()
        {
            SanPham sp = (from c in giay.SanPhams orderby c.MaSp descending select c).Take(1).SingleOrDefault();
            return sp.MaSp;
        }






        // viết cho phần chi tiết sản phẩm
        
        //public void getThongTin(ComboBox cb, string value,string display,int masp)
        //{
        //    List<CTSanPham> list = (from c in giay.CTSanPhams where c.MaSp == masp select c).ToList();
        //    cb.DataSource = list;
        //    cb.DisplayMember = display;
        //    cb.ValueMember = value;
        //}

        public void getTinhChat(ComboBox cb, string value,string display,int masp,string kc = null,string mausac=null,string chatlieu =null)
        {
            try
            {
                List<CTSanPham> list;
                if (kc != null)
                {
                    int kichco = int.Parse(kc);
                    if (mausac != null)
                    {
                        if (chatlieu != null)
                        {
                            list = (from c in giay.CTSanPhams where c.MaSp == masp && c.KichCo == kichco && c.MaSac == mausac && c.ChatLieu == chatlieu select c).ToList();
                        }
                        else
                        {
                            list = (from c in giay.CTSanPhams where c.MaSp == masp && c.KichCo == kichco && c.MaSac == mausac select c).ToList();
                        }

                    }
                    else
                    {
                        list = (from c in giay.CTSanPhams where c.MaSp == masp && c.KichCo == kichco select c).ToList();
                    }
                }
                else
                {
                    list = (from c in giay.CTSanPhams where c.MaSp == masp select c).ToList();
                }
                cb.DataSource = list;
                cb.DisplayMember = display;
                cb.ValueMember = value;
            }
            catch (Exception e)
            {

                e.ToString() ;
            }
            
        }
        public int getCTsp(string chatlieu,int kichco, string mausac,int masp)
        {
            CTSanPham ctsp = (from c in giay.CTSanPhams where c.MaSac == mausac && c.KichCo == kichco && c.ChatLieu == chatlieu && c.MaSp == masp select c).SingleOrDefault();
            if(ctsp == null)
            {
                return 0;
            }
            return ctsp.MaCTSp;
        }
        public List<CTSanPham> getdataCT(string masp = null)
        {
            int ma = int.Parse(masp);
            List<CTSanPham> list = (from c in giay.CTSanPhams where c.MaSp == ma select c).ToList();
            return list;
        }
        public List<CTSanPham> getAllCT(bool tinhtrang)
        {
            List<CTSanPham> list = (from c in giay.CTSanPhams where c.TinhTrang == tinhtrang select c).ToList();
            return list;
        }
        public int getMaCTsp(int masp, string mausac, float kichthuoc,string chatlieu)
        {
            CTSanPham a = (from c in giay.CTSanPhams where 
                                    c.MaSp == masp && 
                                    c.MaSac == mausac && 
                                    c.KichCo == kichthuoc && 
                                    c.ChatLieu == chatlieu select c).SingleOrDefault();
            return a.MaCTSp;
        }
        public float getGia(int masp)
        {
            CTSanPham ap = (from c in giay.CTSanPhams where c.MaCTSp == masp select c).SingleOrDefault();
            return (float)ap.GiaBan;
        }

        public void changeTinhTrangCT(int masp,bool tinhtrang)
        {
            List<CTSanPham> listCT = (from c in giay.CTSanPhams where c.MaSp == masp select c).ToList();
            foreach (CTSanPham item in listCT)
            {
                item.TinhTrang = tinhtrang;
                giay.SaveChanges();
            }
        }

        public List<CTSanPham> GetCTSPTen(string ten, List<SanPham> list )
        {
            list = (from c in giay.SanPhams where c.TenSanPham == ten select c).ToList();
            List<CTSanPham> ctsp = new List<CTSanPham>();
            foreach (SanPham item in list)
            {
                ctsp = (from c in giay.CTSanPhams where c.MaSp == item.MaSp select c).ToList();
            }
          
            return ctsp;
        }
        public void changeTinhTrangCTs(int masp, bool tinhtrang)
        {
            CTSanPham a = (from c in giay.CTSanPhams where c.MaCTSp == masp select c).SingleOrDefault();
            if(a!=null)
            {
                a.TinhTrang = tinhtrang;
                giay.SaveChanges();
            }
        }
        public void changeTinhTrangCTss(int masp)
        {
            CTSanPham a = (from c in giay.CTSanPhams where c.MaCTSp == masp select c).SingleOrDefault();
            if (a != null)
            {
                a.TinhTrang = true;
                giay.SaveChanges();
            }
        }
        public bool SuaCTSP(CTSanPham a)
        {
            CTSanPham ct = (from c in giay.CTSanPhams where c.MaCTSp == a.MaCTSp select c).SingleOrDefault();
            if(ct != null)
            {
                ct.MaCTSp = a.MaCTSp;
                ct.MaSp = a.MaSp;
                ct.KichCo = a.KichCo;
                ct.MaSac = a.MaSac;
                ct.ChatLieu = a.ChatLieu;
                ct.GiaBan = a.GiaBan;
                ct.SoLuong = a.SoLuong;
                giay.SaveChanges();
                return true;
            }
            return false;
        }
        public void ThemCT(CTSanPham ct)
        {
            giay.CTSanPhams.Add(ct);
            giay.SaveChanges();
        }
    }

}
