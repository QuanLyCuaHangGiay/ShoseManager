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

namespace DoAnNet001.Views.ucNhanVien
{
    public partial class NhanVienUC : UserControl
    {
        ChangeColor a = new ChangeColor();
        ChangeForm form = new ChangeForm();
        public NhanVienUC()
        {
            InitializeComponent();
        }
       
       
        private void label4_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            ucThemNhanVien nhanvien = new ucThemNhanVien();
            form.changeUC(nhanvien, pnNhanVien);
        }
      
        private void pnThemNV_MouseClick(object sender, MouseEventArgs e)
        {

        }
       
   

       
        //sự kiện click
        private void label5_Click_1(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            ucNhanVienNghi nvnghi = new ucNhanVienNghi();
            form.changeUC(nvnghi, pnNhanVien);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            ucChamCong nvnghi = new ucChamCong();
            form.changeUC(nvnghi, pnNhanVien);
        }

        private void pnThemNV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnThemNV_Click_1(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            ucHoSoNV nhanvien = new ucHoSoNV();
            form.changeUC(nhanvien, pnNhanVien);
        }

        private void pnNVNghi_Click_1(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            ucThemNhanVien nhanvien = new ucThemNhanVien();
            form.changeUC(nhanvien, pnNhanVien);
        }

        private void pnHopDong_Click_1(object sender, EventArgs e)
        {
            a.ColorClick(sender);
            ucNhanVienNghi nvnghi = new ucNhanVienNghi();
            form.changeUC(nvnghi, pnNhanVien);
        }

        private void panel3_Click_1(object sender, EventArgs e)
        {

            a.ColorClick(sender);
            ucHoSoNV nhanvien = new ucHoSoNV();
            form.changeUC(nhanvien, pnNhanVien);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            a.LabelClick(sender);
            ucHoSoNV nhanvien = new ucHoSoNV();
            form.changeUC(nhanvien, pnNhanVien);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            ucHethong1 he = new ucHethong1();
            form.change(he);
        }


        //Sự kiện mouse leave của panel
        private void pnThemNV_MouseLeave_1(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void pnNVNghi_MouseLeave_1(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void pnHopDong_MouseLeave_1(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }

        private void panel3_MouseLeave_1(object sender, EventArgs e)
        {
            a.ColorNomal(sender);
        }
        //sự kiện hover của panel
        private void pnThemNV_MouseHover_1(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }

        private void pnNVNghi_MouseHover_1(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }

        private void pnHopDong_MouseHover_1(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }

        private void panel3_MouseHover_1(object sender, EventArgs e)
        {
            a.ColorHover(sender);
        }
        //sự kiện hover của label
        private void label3_MouseHover_1(object sender, EventArgs e)
        {
            a.ColorHoverLabel(sender);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            a.ColorHoverLabel(sender);
        }

        private void label5_MouseHover_1(object sender, EventArgs e)
        {
            a.ColorHoverLabel(sender);
        }

        private void label2_MouseHover_1(object sender, EventArgs e)
        {
            a.ColorHoverLabel(sender);
        }
        //sự kiện mouse leave của label
        private void label3_MouseLeave_1(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void label4_MouseLeave_1(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void label5_MouseLeave_1(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void label2_MouseLeave_1(object sender, EventArgs e)
        {
            a.ColorNomalLabel(sender);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnHopDong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
