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

namespace DoAnNet001.Views.ucSanPham
{
    public partial class dsChiTietSP : Form
    {
        public dsChiTietSP()
        {
            InitializeComponent();
        }

        private void dsChiTietSP_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void getdata()
        {
            int masp = DsSanPham_uc.masp;
            lb_MaSp.Text = masp.ToString();
            lb_TenSp.Text = SanPhamModels.SanPhams.getTenSp(masp);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = SanPhamModels.SanPhams.getdataCT(masp.ToString());
           
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
