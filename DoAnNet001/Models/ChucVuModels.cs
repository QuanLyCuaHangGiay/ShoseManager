using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Dao;
namespace DoAnNet001.Models
{
    class ChucVuModels
    {
        DoAnNetEntities1 giay = new DoAnNetEntities1();

        private static ChucVuModels chucvu = null;

        internal static ChucVuModels chucVu
        {
            get
            {
                if (chucvu == null)
                {
                    chucvu = new ChucVuModels();
                }
                return chucvu;
            }
            set => chucvu = value;
        }
        public void getChucVu(ComboBox cb, string tenchucvu, string machucvu)
        {
            List<ChucVu> chucvu = (from c in giay.ChucVus select c).ToList();
            cb.DataSource = chucvu;
            cb.DisplayMember = tenchucvu;
            cb.ValueMember = machucvu;

        }
        public List<ChucVu> getdata()
        {
            List<ChucVu> list = (from c in giay.ChucVus orderby c.MaChucVu descending select c).ToList();
            return list;
        }
        public string getTenCV(int id)
        {
            ChucVu chucvus = (from c in giay.ChucVus where c.MaChucVu == id select c).SingleOrDefault();
            return chucvus.TenChucVu;
        }
    }
}
