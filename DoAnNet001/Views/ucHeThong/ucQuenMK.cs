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
using DoAnNet001.Core;

namespace DoAnNet001.Views.ucHeThong
{
    public partial class ucQuenMK : UserControl
    {

        ChangeForm changess = new ChangeForm();
        public ucQuenMK()
        {
            InitializeComponent();
            ChucVuModels.chucVu.getChucVu(cb_ChucVu, "TenChucVu", "MaChucVu");
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tennv = txt_TenNv.Text;
                int manv = int.Parse(txt_MaNV.Text);
                DateTime ngaysinh = DateTime.Parse(txt_NgaySinh.Text);
                int chuvu = int.Parse(cb_ChucVu.SelectedValue.ToString());
                if (DangNhapModels.DangNhapModelss.GetMk(tennv, manv, ngaysinh, chuvu))
                {
                    ucHethong1 HeThong = new ucHethong1();
                    changess.change(HeThong);
                }
                else
                {
                    MessageBox.Show("Đăng nhập không đúng ");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi phát sinh ");
            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            ucheThong dangnhap = new ucheThong();
            dangnhap.Dock = DockStyle.Fill;
            Index.Indexs.panel.Controls.Add(dangnhap);
            //Index.Indexs.panel.Controls["quenMK"].BringToFront();
            foreach (ucQuenMK item in Index.Indexs.panel.Controls.OfType<ucQuenMK>())
            {
                Index.Indexs.panel.Controls.Remove(item);
            }
        }
    }
}
