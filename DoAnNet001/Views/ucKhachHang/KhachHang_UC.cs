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

namespace DoAnNet001.Views.ucKhachHang
{
    public partial class KhachHang_UC : UserControl
    {
        ChangeColor a = new ChangeColor();
        ChangeForm form = new ChangeForm();
        public KhachHang_UC()
        {
            InitializeComponent();
        }
        // sự kiện click
        private void label2_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            ucDSKhachHang  khachhang = new ucDSKhachHang();
            form.changeUC(khachhang, pnNhanVien);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            ucThemKH themKH = new ucThemKH();
            form.changeUC(themKH, pnNhanVien);
        }

        private void pnNVNghi_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            ucThemKH themKH = new ucThemKH();
            form.changeUC(themKH, pnNhanVien);
        }

        private void pnHopDong_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            ucDSKhachHang khachhang = new ucDSKhachHang();
            form.changeUC(khachhang, pnNhanVien);
        }
        // sự kiện hover
        private void label5_MouseHover(object sender, EventArgs e)
        {
            a.ColorHoverLabel(sender);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            a.ColorHoverLabel(sender);
        }

        private void pnNVNghi_MouseHover(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }

        private void pnHopDong_MouseHover(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }
         // sự kiện mouse leave
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void pnNVNghi_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void pnHopDong_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pnHopDong_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }
        // sự kiện back
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ucHethong1 he = new ucHethong1();
            form.change(he);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            uc_KhachHangXoa khachhang = new uc_KhachHangXoa();
            form.changeUC(khachhang, pnNhanVien);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            uc_KhachHangXoa khachhang = new uc_KhachHangXoa();
            form.changeUC(khachhang, pnNhanVien);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }
    }
}
