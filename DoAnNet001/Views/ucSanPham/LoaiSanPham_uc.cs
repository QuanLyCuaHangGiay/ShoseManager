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

namespace DoAnNet001.Views.ucSanPham
{
    public partial class LoaiSanPham_uc : UserControl
    {
        public LoaiSanPham_uc()
        {
            InitializeComponent();
            getdata();
            getMaLo();
        }
        protected void getdata()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = LoaiSanPhamModels.LoaiSP.getdata();

        }
        protected void getMaLo()
        {
            LoHangModels.chucVu.getmakhohang(cb_LoHang);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cb_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maloai = int.Parse(lb_MaLoai.Text);
                string tenloai = txt_TenLoai.Text;
                int soluong = int.Parse(txt_SoLuong.Text);
                string thuonghieu = txt_ThuongHieu.Text;
                int maLohang = int.Parse(cb_LoHang.SelectedValue.ToString());
                LoaiSanPham loaisp = new LoaiSanPham();
                loaisp.MaLoai = maloai;
                loaisp.TenLoai = tenloai;
                loaisp.SoLuong = soluong;
                loaisp.ThuongHieu = thuonghieu;
                loaisp.MaLoHang = maLohang;
                LoaiSanPhamModels.LoaiSP.SuaLoai(loaisp);
                getdata();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception)
            {

              MessageBox.Show("Không thể sửa ");
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i>=0)
            {
                lb_MaLoai.Text = dataGridView1.Rows[i].Cells["MaLoai"].Value == null ? " " : dataGridView1.Rows[i].Cells["MaLoai"].Value.ToString();
                txt_TenLoai.Text = dataGridView1.Rows[i].Cells["TenLoai"].Value == null ? " " : dataGridView1.Rows[i].Cells["TenLoai"].Value.ToString();
                txt_SoLuong.Text = dataGridView1.Rows[i].Cells["SoLuong"].Value == null ? " " : dataGridView1.Rows[i].Cells["SoLuong"].Value.ToString();
                txt_ThuongHieu.Text = dataGridView1.Rows[i].Cells["ThuongHieu"].Value == null ? " " : dataGridView1.Rows[i].Cells["ThuongHieu"].Value.ToString();
                cb_LoHang.SelectedValue = dataGridView1.Rows[i].Cells["MaLoHang"].Value == null ? " " : dataGridView1.Rows[i].Cells["MaLoHang"].Value;
            }
        }

        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoaiSanPhamModels.LoaiSP.searchLoai(txt_Search.Text);
        }

        private void btn_XuatEx_Click(object sender, EventArgs e)
        {
            string query = "SELECT * From LoaiSanPham  ";
            CRp_LoaiSanPham sp = new CRp_LoaiSanPham();
            sp.SetDataSource(Dataset.DaTa.report(query));
            fRPTsp f = new fRPTsp();
            f.crystalReportViewer1.ReportSource = sp;
            f.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
