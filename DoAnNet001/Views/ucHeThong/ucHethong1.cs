using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Views.ucNhanVien;
using DoAnNet001.Core;
using DoAnNet001.Models;
using DoAnNet001.Views.ucSanPham;
using DoAnNet001.Views.ucNhaCungCap;
using DoAnNet001.Views.ucKhachHang;
using DoAnNet001.Views.ucDonHang;
using DoAnNet001.Views.ucNhapHang;

namespace DoAnNet001.Views.ucHeThong
{
  
    public partial class ucHethong1 : UserControl
    {
        ChangeForm change = new ChangeForm();
        public ucHethong1()
        {
            InitializeComponent();
            phanquyen();
        }
        protected void phanquyen()
        {
            int phanquyen = DangNhapModels.DangNhapModelss.GetChucVu();
            if (phanquyen == 2)
            {
                //btnCaiDat.Enabled = false;
                //btnNhapHang.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
                btnNhaCungCap.Enabled = false;
            }
            else if (phanquyen == 3)
            {
                btnNhanVien.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
                btnKhachHang.Enabled = false;
                btnDonHang.Enabled = false;
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Clear_Panel()
        {
            panel1.Controls.Clear();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)

        {
            Clear_Panel();
            NhanVienUC nhanvien = new NhanVienUC();
           
            change.changeUC(nhanvien, panel1);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Clear_Panel();
            KhachHang_UC khachhang = new KhachHang_UC();
            change.changeUC(khachhang, panel1);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            Clear_Panel();
            NhapHang_UC NhapHang = new NhapHang_UC();
            change.changeUC(NhapHang, panel1);
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            Clear_Panel();
            DonHang_UC DonHang = new DonHang_UC();
            change.changeUC(DonHang, panel1);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            Clear_Panel();
            SanPhamUC sanPham = new SanPhamUC();
            change.changeUC(sanPham, panel1);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {

            Clear_Panel();
            HangCungCap_uc nhacc = new HangCungCap_uc();
            change.changeUC(nhacc, panel1);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {

            Clear_Panel();
            ucCaiDat.CatDat_UC catDat_ = new ucCaiDat.CatDat_UC();
            change.changeUC(catDat_, panel1);
        }

      

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ucheThong dangnhap = new ucheThong();
                change.change(dangnhap);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Clear_Panel();
            ucThongKe.ThongKe_UC thongKe_ = new ucThongKe.ThongKe_UC();
            change.changeUC(thongKe_, panel1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}




