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

namespace DoAnNet001.Views.ucNhaCungCap
{
    public partial class HangCungCap_uc : UserControl
    {
        ChangeColor a = new ChangeColor();
        ChangeForm form = new ChangeForm();
        public HangCungCap_uc()
        {
            InitializeComponent();
        }
        //Sự kiện click
        private void label4_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            NhaCungCap_UC ncc = new NhaCungCap_UC();
            form.changeUC(ncc, pnNhanVien);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            ThemNcc_uc ThemNcc = new ThemNcc_uc();
            form.changeUC(ThemNcc, pnNhanVien);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            uc_NhaCungCapXoa nhanvien = new uc_NhaCungCapXoa();
           form.changeUC(nhanvien, pnNhanVien);
        }

        private void pnNVNghi_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            NhaCungCap_UC ncc = new NhaCungCap_UC();
            form.changeUC(ncc, pnNhanVien);
        }

        private void pnHopDong_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnHopDong_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            ThemNcc_uc ThemNcc = new ThemNcc_uc();
            form.changeUC(ThemNcc, pnNhanVien);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            uc_NhaCungCapXoa ThemNcc = new uc_NhaCungCapXoa();
            form.changeUC(ThemNcc, pnNhanVien);
        }
        // sự kiện hover
        private void pnNVNghi_MouseHover(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void pnHopDong_MouseHover(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

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
        // sự kiện MouseLeave
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ucHethong1 he = new ucHethong1();
            form.change(he);
        }

        private void pnNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
