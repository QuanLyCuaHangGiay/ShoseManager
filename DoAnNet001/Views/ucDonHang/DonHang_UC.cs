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

namespace DoAnNet001.Views.ucDonHang
{
    public partial class DonHang_UC : UserControl
    {
        public DonHang_UC()
        {
            InitializeComponent();
        }
        ChangeColor a = new ChangeColor();
        ChangeForm form = new ChangeForm();
        //Sự kiện click
        private void label5_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            uc_DonHang ds = new uc_DonHang();
            form.changeUC(ds, pnNhanVien);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            uc_ThemDonHang ds = new uc_ThemDonHang();
            form.changeUC(ds, pnNhanVien);
        }

        private void pnNVNghi_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            uc_DonHang ds = new uc_DonHang();
            form.changeUC(ds, pnNhanVien);
        }

        private void pnHopDong_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            uc_ThemDonHang ds = new uc_ThemDonHang();
            form.changeUC(ds, pnNhanVien);
        }
        //Sự kiện hover
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
        //sự kiện mouse leave
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

        private void pnHopDong_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ucHethong1 he = new ucHethong1();
            form.change(he);
        }
    }
}
