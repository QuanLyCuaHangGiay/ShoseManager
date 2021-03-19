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

namespace DoAnNet001.Views.ucCaiDat
{
    public partial class CatDat_UC : UserControl
    {
        public CatDat_UC()
        {
            InitializeComponent();
        }
        ChangeColor a = new ChangeColor();
        ChangeForm form = new ChangeForm();
        private void label5_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
         
            ThongTinCaNhan_uc ds = new ThongTinCaNhan_uc();
            form.changeUC(ds, pnNhanVien);
        }

        private void pnNVNghi_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            ThongTinCaNhan_uc ds = new ThongTinCaNhan_uc();
            form.changeUC(ds, pnNhanVien);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            DoiMatKhau_uc ds = new DoiMatKhau_uc();
            form.changeUC(ds, pnNhanVien);
        }

        private void pnHopDong_Click(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            DoiMatKhau_uc ds = new DoiMatKhau_uc();
            form.changeUC(ds, pnNhanVien);
        }

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

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void pnNVNghi_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
