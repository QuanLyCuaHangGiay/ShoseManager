using DoAnNet001.Dao;
using DoAnNet001.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNet001.Views.ucDonHang
{
    public partial class ThemKhachHang : Form
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string tenKH = txt_TenKH.Text;
                string diachi = txt_DiaChi.Text;
                string sdt = txt_SoDienThoai.Text;
                KhachHang kh = new KhachHang();
                kh.TenKH = tenKH;
                kh.DiaChi = diachi;
                kh.SoDienThoai = int.Parse(sdt);
                KhachHangModels.KhachsHang.ThemKH(kh);

                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể thêm khách hàng");
            }
        }
    }
}
