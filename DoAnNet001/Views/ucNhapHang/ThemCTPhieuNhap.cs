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
using DoAnNet001.Core;

namespace DoAnNet001.Views.ucNhapHang
{
    public partial class ThemCTPhieuNhap : Form
    {
        public ThemCTPhieuNhap()
        {
            InitializeComponent();
            getdata();
        }
        public void getdata()
        {
            int maphieunhap = CTPhieuNhapModels.CTPhieuNhapCons.getma();
            string query = "SELECT * FORM CTPhieuNhap WHERE MaPhieuNhap = " + maphieunhap;
            Dataset.DaTa.getDataSet(dataGridView1, query, "ctphieunhap");
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
