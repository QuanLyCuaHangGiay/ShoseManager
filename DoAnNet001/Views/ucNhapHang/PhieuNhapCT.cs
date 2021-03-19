using DoAnNet001.Core;
using DoAnNet001.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNet001.Views.ucNhapHang
{
    public partial class PhieuNhapCT : Form
    {
        public PhieuNhapCT()
        {
            InitializeComponent();
            getdata();
            //bth_Luu.Enabled = false;
        }
        public void getdata()
        {
            lb_MaPhieuNhap.Text = dsPhieuNhap_uc.maPhieuNhap.ToString();
            int id = dsPhieuNhap_uc.maPhieuNhap;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string query = "SELECT * FROM CTPhieuNhap WHERE MaPhieuNhap = "+id;
            string query2 = "SELECT * FROM CTSanPham";
            string query3 = "SELECT SanPham.TenSanPham,CTSanPham.MaCTSp FROM SanPham,CTSanPham WHERE SanPham.MaSp = CTSanPham.MaSp GROUP BY SanPham.TenSanPham,CTSanPham.MaCTSp "; 
            Dataset.DaTa.getDataSet(dataGridView1,query,"ctphieunhap");
            Dataset.DaTa.getDataColumn(dataGridView1, query3, "sanpham", "TenSanPham", "MaCTSp", "sanpham");
            Dataset.DaTa.getDataColumn(dataGridView1, query2, "mausac", "MaSac", "MaCTSp", "MaSac");
            Dataset.DaTa.getDataColumn(dataGridView1, query2, "kickco", "KichCo", "MaCTSp", "KichCo");
            Dataset.DaTa.getDataColumn(dataGridView1, query2, "chatlieu", "ChatLieu", "MaCTSp", "ChatLieu");

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bth_Luu_Click(object sender, EventArgs e)
        {
            Dataset.DaTa.updates("ctphieunhap");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
