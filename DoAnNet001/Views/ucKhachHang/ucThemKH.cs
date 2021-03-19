using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Models;
using DoAnNet001.Dao;

namespace DoAnNet001.Views.ucKhachHang
{
    public partial class ucThemKH : UserControl
    {
        public ucThemKH()
        {
            InitializeComponent();
        }
        protected void reset()
        {
            txt_DiaChi.Text = "";
            txt_SoDienThoai.Text = "";
            txt_TenKH.Text = "";
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
                reset();
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể thêm khách hàng");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_SoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
