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
using DoAnNet001.Core;

namespace DoAnNet001.Views.ucNhapHang
{
    public partial class dsPhieuNhap_uc : UserControl
    {
        public dsPhieuNhap_uc()
        {
            InitializeComponent();
            
            getNCC();
            getNhanVien();
            btn_CapNhat.Enabled = false;
            btn_ChiTiet.Enabled = false;
            btn_XuatEx.Enabled = false;

        }
        public static int maPhieuNhap; 
        public void getdata()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = PhieuNhapModels.phieunhapCons.getdata();
            string query = "SELECT * FROM NhaCungCap";
            string query1 = "SELECT * FROM NhanVien";
            Dataset.DaTa.getDataColumn(dataGridView1,query,"ncc","TenNcc","MaNcc","MaNcc");
            Dataset.DaTa.getDataColumn(dataGridView1, query1, "nhanvien", "TenNV", "MaNV", "MaNV");

        }
        public void getNhanVien()
        {
            NhanVienModels.Nhanviens.getTen(cb_NhanVienNhap);
        }
        public void getNCC()
        {
            NhaCungCapModels.nhacungcapCons.getTens(cb_NCC);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            maPhieuNhap = int.Parse(lb_PhieuNhap.Text);
            PhieuNhapCT phieunhap = new PhieuNhapCT();
            phieunhap.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                int i = e.RowIndex;
                if (i >= 0)
                {
                    lb_PhieuNhap.Text = dataGridView1.Rows[i].Cells["MaPhieuNhap1"].Value == null ? " " : dataGridView1.Rows[i].Cells["MaPhieuNhap1"].Value.ToString();
                    textBox1.Text = dataGridView1.Rows[i].Cells["NgayNhap"].Value == null ? " " : dataGridView1.Rows[i].Cells["NgayNhap"].Value.ToString();
                    txt_SoLuong.Text = dataGridView1.Rows[i].Cells["SoLuong"].Value == null ? " " : dataGridView1.Rows[i].Cells["SoLuong"].Value.ToString();
                    txt_TongTien.Text = dataGridView1.Rows[i].Cells["TongTien"].Value == null ? " " :dataGridView1.Rows[i].Cells["TongTien"].Value.ToString();
                    cb_NCC.SelectedValue = dataGridView1.Rows[i].Cells["MaNcc"].Value;
                    cb_NhanVienNhap.SelectedValue = dataGridView1.Rows[i].Cells["MaNV"].Value;
                    btn_Xoa.Enabled = true;
                    btn_CapNhat.Enabled = true;
                    btn_ChiTiet.Enabled = true;
                    btn_XuatEx.Enabled = true;
                }
           
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuNhap phieunhap = new PhieuNhap();
                phieunhap.MaPhieuNhap = int.Parse(lb_PhieuNhap.Text);
                try
                {
                    phieunhap.NgayNhap = DateTime.Parse(textBox1.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn nhập theo dạng Tháng/Ngày/Năm");
                }
                phieunhap.MaNcc = int.Parse(cb_NCC.SelectedValue.ToString());
                phieunhap.MaNV = int.Parse(cb_NhanVienNhap.SelectedValue.ToString());
                phieunhap.SoLuong = int.Parse(txt_SoLuong.Text);
                phieunhap.TongTien = float.Parse(txt_TongTien.Text);
                bool check = PhieuNhapModels.phieunhapCons.suaPhieu(phieunhap);

                if(check == true)
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                getdata();
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi không thể cập nhật");
            }
           
           

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse( txt_Search.Text);
            dataGridView1.DataSource = PhieuNhapModels.phieunhapCons.searchPhieu(date);
        }

        private void btn_XuatEx_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dsPhieuNhap_uc_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
