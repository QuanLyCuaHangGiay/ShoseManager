using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Dao;
namespace DoAnNet001.Models
{
    class NhaCungCapModels
    {
        private static NhaCungCapModels nhacungcap = null;
        DoAnNetEntities1 db = new DoAnNetEntities1();
        internal static NhaCungCapModels nhacungcapCons
        {
            get
            {
                if (nhacungcap == null)
                {
                    nhacungcap = new NhaCungCapModels();
                }
                return nhacungcap;
            }
            set => nhacungcap = value;
        }
        public List<NhaCungCap> getdata(bool tinhtrang)
        {
            List<NhaCungCap> listNCC = (from c in db.NhaCungCaps where c.TinhTrang == tinhtrang orderby c.MaNcc descending select c).ToList();
            return listNCC;
        }
        public bool themNCC(NhaCungCap ncc)
        {
            ncc.TinhTrang = true;
            db.NhaCungCaps.Add(ncc);
            db.SaveChanges();
            return true;
        }
        public bool Sua(NhaCungCap ncc)
        {
            NhaCungCap nccs = (from c in db.NhaCungCaps where c.MaNcc == ncc.MaNcc select c).SingleOrDefault();
            if (nccs == null)
            {
                return false;
            }
            nccs.DiaChi = ncc.DiaChi;
            nccs.SoDienThoai = ncc.SoDienThoai;
            nccs.TenNcc = ncc.TenNcc;
            db.SaveChanges();
            return true;
        }

        public List<NhaCungCap> searchNcc(bool tinhtrang, string tenncc)
        {
            List<NhaCungCap> listNCC = (from c in db.NhaCungCaps where c.TinhTrang == tinhtrang && c.TenNcc == tenncc orderby c.MaNcc descending select c).ToList();
            return listNCC;
        }
        public bool removeNCC(int id,bool tinhtrang)
        {
            NhaCungCap ncc = (from c in db.NhaCungCaps where c.MaNcc == id select c).SingleOrDefault();
            if (ncc == null)
            {
                return false;
            }
            ncc.TinhTrang = tinhtrang;
            db.SaveChanges();
            return true;
        }
        public void getTens(ComboBox cb)
        {
            cb.DataSource = getdata(true);
            cb.DisplayMember = "TenNcc";
            cb.ValueMember = "MaNcc";
        }
    }
}
