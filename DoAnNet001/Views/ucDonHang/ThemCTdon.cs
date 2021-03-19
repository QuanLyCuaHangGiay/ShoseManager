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

namespace DoAnNet001.Views.ucDonHang
{
    public partial class ThemCTdon : Form
    {
        public ThemCTdon()
        {
            InitializeComponent();
            getdata();
        }

        private void ThemCTdon_Load(object sender, EventArgs e)
        {
            
        }
        string table = "CThoadon";
        public void getdata()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lb_DonHang.Text = ucDonHang.uc_DonHang.maDH.ToString();
            lb_TenKH.Text = ucDonHang.uc_DonHang.tenkh.ToString();
            int id = ucDonHang.uc_DonHang.maDH;
            string query = "SELECT * FROM CTDonHang WHERE MaDonHang = " + id;
            string query3 = "SELECT * FROM CTSanPham";
            string query2 = "SELECT SanPham.TenSanPham,CTSanPham.MaCTSp FROM SanPham,CTSanPham WHERE SanPham.MaSp = CTSanPham.MaSp GROUP BY SanPham.TenSanPham,CTSanPham.MaCTSp";
            Dataset.DaTa.getDataSet(dataGridView1, query, table);
            Dataset.DaTa.getDataColumn(dataGridView1, query2, "sanphamm", "TenSanPham", "MaCTSp", "SanPham");
            Dataset.DaTa.getDataColumn(dataGridView1, query3, "ctsp", "KichCo", "MaCTSp", "KichCo");
            Dataset.DaTa.getDataColumn(dataGridView1, query3, "ctsp1", "MaSac", "MaCTSp", "MaSac");
            Dataset.DaTa.getDataColumn(dataGridView1, query3, "ctsp2", "ChatLieu", "MaCTSp", "ChatLieu");
        }
        private void bth_Luu_Click(object sender, EventArgs e)
        {
            string query3 = "SELECT * FROM CTSanPham";
            Dataset.DaTa.updates(query3, "CThoadon");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
