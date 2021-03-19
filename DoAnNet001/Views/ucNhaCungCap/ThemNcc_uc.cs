using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Dao;
using DoAnNet001.Models;

namespace DoAnNet001.Views.ucNhaCungCap
{
    public partial class ThemNcc_uc : UserControl
    {
        public ThemNcc_uc()
        {
            InitializeComponent();
        }
        public void reset()
        {
            txt_DiaChi.Text = "";
            txt_SoDienThoai.Text = "";
            txt_TenNCC.Text = "";
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string tenncc = txt_TenNCC.Text;
                string sdt =txt_SoDienThoai.Text;
                string diachi = txt_DiaChi.Text;
               
               if(tenncc !="" && sdt !="" && diachi !="")
                {
                    NhaCungCap ncc = new NhaCungCap();
                    ncc.DiaChi = diachi;
                    ncc.SoDienThoai = sdt;
                    ncc.TenNcc = tenncc;
                    bool check = NhaCungCapModels.nhacungcapCons.themNCC(ncc);
                    if (check == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Điền thông tin chưa đầy đủ");
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi không thể thêm dữ liệu");
            }
           


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
