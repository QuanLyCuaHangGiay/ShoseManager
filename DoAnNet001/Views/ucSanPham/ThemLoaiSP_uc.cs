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

namespace DoAnNet001.Views.ucSanPham
{
    public partial class ThemLoaiSP_uc : UserControl
    {
        public ThemLoaiSP_uc()
        {
            InitializeComponent();
            getMaLoHang();
        }
        public void getMaLoHang()
        {
            LoHangModels.chucVu.getmakhohang(cb_ChucVu);
        }
        public void reset()
        {
            txt_TenLoai.Text = null;
            txt_ThuongHieu.Text = null;
            txt_SoLuong.Text = null;

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {




















































        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_TenLoai.Text != null && txt_ThuongHieu.Text != null && txt_SoLuong.Text!=null && cb_ChucVu.SelectedValue.ToString() !=null)
            {
                string TenLoai = txt_TenLoai.Text;
                int SoLuong;
                string ThuongHieu = txt_ThuongHieu.Text;
                int malohang = int.Parse(cb_ChucVu.SelectedValue.ToString());
                try
                {
                    SoLuong = int.Parse(txt_SoLuong.Text);
                    LoaiSanPham a = new LoaiSanPham();
                    a.TenLoai = TenLoai;
                    a.SoLuong = SoLuong;
                    a.MaLoHang = malohang;
                    a.ThuongHieu = ThuongHieu;
                    LoaiSanPhamModels.LoaiSP.ThemLoai(a);
                    MessageBox.Show("Thêm loại sản phẩm thành công ");
                    txt_SoLuong.Text = null;
                    txt_TenLoai.Text = null;
                    txt_ThuongHieu.Text = null;
                }
                catch (Exception)
                {

                    MessageBox.Show("Số lượng không được để kí tự ");
                }
              
               
            
               
            }
            else
            {
                MessageBox.Show("Chưa điền đủ thông tin");
            }
            
        }

        private void cb_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_ThuongHieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenLoai_TextChanged(object sender, EventArgs e)
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
