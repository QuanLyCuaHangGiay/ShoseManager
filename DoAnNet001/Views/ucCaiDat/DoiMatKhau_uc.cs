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

namespace DoAnNet001.Views.ucCaiDat
{
    public partial class DoiMatKhau_uc : UserControl
    {
        public DoiMatKhau_uc()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string id = ucHeThong.ucheThong.tentk;
            string oldPass = txt_MKHienTai.Text;
            string newPass = txt_NewPass.Text;
            string rePass = txt_NhapLai.Text;
            if(TaiKhoanModels.TaiKhoanCons.GetPass(id,oldPass))
            {
                if(newPass.Equals(rePass))
                {
                    TaiKhoan a = new TaiKhoan();
                    a.MatKhau = newPass;
                    a.TaiKhoan1 = id;
                    TaiKhoanModels.TaiKhoanCons.DoiMK(a);
                    MessageBox.Show("Cập nhật thành công ");
                }
                else
                {
                    MessageBox.Show("Nhập mật khẩu mới không trùng khớp");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu sai ");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
