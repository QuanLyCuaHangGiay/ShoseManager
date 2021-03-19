using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Dao;
using DoAnNet001.Models;

namespace DoAnNet001.Views.ucCaiDat
{
    public partial class ThongTinCaNhan_uc : UserControl
    {
        public ThongTinCaNhan_uc()
        {
            InitializeComponent();
        }

        private void ThongTinCaNhan_uc_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void getdata()
        {
            int id = ucHeThong.ucheThong.maNV;
            NhanVien nv = NhanVienModels.Nhanviens.GetNhan(id);
            lb_MaNV.Text = nv.MaNV.ToString();
            lb_TenNV.Text = nv.TenNV;
            lb_NgaySinh.Text = nv.NgaySinh.ToString();
            lb_SoDienThoai.Text = nv.SDT.ToString();
            lb_ChucVu.Text = ChucVuModels.chucVu.getTenCV((int)nv.MaChucVu);
            lb_TongNgayCong.Text = nv.TongNgayCong.ToString();
            lb_Luong.Text = nv.Luong.ToString();
            pic_AnhNV.Image = Image.FromFile(Application.StartupPath + @"\anh\\" +nv.HinhAnh.ToString());
        }
    }
}
