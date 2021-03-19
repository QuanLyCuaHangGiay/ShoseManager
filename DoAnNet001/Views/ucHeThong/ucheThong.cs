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
using DoAnNet001.Models;
namespace DoAnNet001.Views.ucHeThong
{
    public partial class ucheThong : UserControl
    {
        ChangeForm changess = new ChangeForm();
        public ucheThong()
        {
            InitializeComponent();
        }
        public static int maNV;
        public static string tentk;
        //private void btn_DangNhap_Click(object sender, EventArgs e)
        //{
        //    string tk = txt_TaiKhoan.Text;
        //    string mk = txt_MatKhau.Text;
        //    if (DangNhapModels.DangNhapModelss.DangNhap(tk, mk))
        //    {
        //        tentk = tk;
        //        maNV = TaiKhoanModels.TaiKhoanCons.getMaNV(tk);
        //        ucHethong1 HeThong = new ucHethong1();
        //        changess.change(HeThong);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
        //    }
        //}


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tk = txt_TaiKhoan.Text;
            string mk = txt_MatKhau.Text;
            if (DangNhapModels.DangNhapModelss.DangNhap(tk, mk))
            {
                tentk = tk;
                maNV = TaiKhoanModels.TaiKhoanCons.getMaNV(tk);
                ucHethong1 HeThong = new ucHethong1();
                changess.change(HeThong);
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucQuenMK quenMK = new ucQuenMK();
            changess.change(quenMK);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //private void btn_Thoat_Click(object sender, EventArgs e)
        //{
        //    DialogResult dr = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (dr == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //}



        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    ucQuenMK quenMK = new ucQuenMK();
        //    changess.change(quenMK);
        //}
    }
}
