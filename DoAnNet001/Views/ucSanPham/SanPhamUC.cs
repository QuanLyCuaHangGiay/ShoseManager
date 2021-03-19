using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Core;
using DoAnNet001.Views.ucHeThong;
using DoAnNet001.Models;

namespace DoAnNet001.Views.ucSanPham
{
    public partial class SanPhamUC : UserControl
    {
        ChangeColor a = new ChangeColor();
        ChangeForm form = new ChangeForm();
        public SanPhamUC()
        {
            InitializeComponent();
        }
        public void phanquyen()
        {
            int phanquyen = DangNhapModels.DangNhapModelss.GetChucVu();
            if (phanquyen == 2)
            {
              
            }
        }
        // sự kiện click 
        private void label4_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            LoaiSanPham_uc Loaisanpham = new LoaiSanPham_uc();
            form.changeUC(Loaisanpham, pnSanPham);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            int phanquyen = DangNhapModels.DangNhapModelss.GetChucVu();
            if (phanquyen != 2 || phanquyen != 3)
            {
                a.LabelClick(sender);
                ThemLoaiSP_uc LoaisanphamAdd = new ThemLoaiSP_uc();
                form.changeUC(LoaisanphamAdd, pnSanPham);
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            DsSanPham_uc dssanpham = new DsSanPham_uc();
            form.changeUC(dssanpham, pnSanPham);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int phanquyen = DangNhapModels.DangNhapModelss.GetChucVu();
            if (phanquyen != 2 || phanquyen != 3)
            {
                a.LabelClick(sender);
                ThemSP_uc ThemSanPham = new ThemSP_uc();
                form.changeUC(ThemSanPham, pnSanPham);
            }
        }

        private void pnThemNV_MouseClick(object sender, MouseEventArgs e)
        {

        }
        // sự kiện click của panel
        private void pnThemNV_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            LoaiSanPham_uc Loaisanpham = new LoaiSanPham_uc();
            form.changeUC(Loaisanpham, pnSanPham);
        }

        private void pnNVNghi_Click(object sender, EventArgs e)
        {
            int phanquyen = DangNhapModels.DangNhapModelss.GetChucVu();
            if (phanquyen != 2 || phanquyen != 3)
            {
                a.ColorClick(sender);
                ThemLoaiSP_uc LoaisanphamAdd = new ThemLoaiSP_uc();
                form.changeUC(LoaisanphamAdd, pnSanPham);
            }
        }

        private void pnHopDong_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            DsSanPham_uc dsSP = new DsSanPham_uc();
            form.changeUC(dsSP, pnSanPham);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            int phanquyen = DangNhapModels.DangNhapModelss.GetChucVu();
            if (phanquyen != 2 || phanquyen != 3)
            {
                a.ColorClick(sender);
                ThemSP_uc dsSP = new ThemSP_uc();
                form.changeUC(dsSP, pnSanPham);
            }
        }
        //Sự kiện hover của panel
        private void pnThemNV_MouseHover(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }

        private void pnNVNghi_MouseHover(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }

        private void pnHopDong_MouseHover(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }
        // hover của label
        private void label4_MouseHover(object sender, EventArgs e)
        {
            a.ColorHoverLabel(sender);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            a.ColorHoverLabel(sender);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            a.ColorHoverLabel(sender);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            a.ColorHoverLabel(sender);
        }
        // Sự kiện mouse leave của panel
        private void pnThemNV_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void pnNVNghi_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void pnHopDong_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }
        //Sự kiện mouse leave của label
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ucHethong1 he = new ucHethong1();
            form.change(he);
        }

        private void pnThemNV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            DSctSanPham ThemSanPham = new DSctSanPham();
            form.changeUC(ThemSanPham, pnSanPham);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            DSctSanPham dsSP = new DSctSanPham();
            form.changeUC(dsSP, pnSanPham);
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            a.ColorHoverLabel(sender);
            
        }

        private void pnSanPham_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
