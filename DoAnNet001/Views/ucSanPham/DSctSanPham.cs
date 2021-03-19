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
using DoAnNet001.Dao;

namespace DoAnNet001.Views.ucSanPham
{
    public partial class DSctSanPham : UserControl
    {
        int even = 0;
        public DSctSanPham()
        {
            InitializeComponent();
            getdata(true);
            getTenSP();
            btn_KhoiPhuc.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_CapNhat.Enabled = false;
        }
        public void reset()
        {
            txt_ChatLieu.Text = "";
            txt_GiaBan.Text = "";
            txt_KichCo.Text = "";
            txt_MauSac.Text = "";
        }
        public void getTenSP()
        {
            SanPhamModels.SanPhams.GetTenSP(comboBox1);
        }
        public void getdata(bool tinhtrang)
        {
            string query = "SELECT * FROM SanPham";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dataset.DaTa.getDataColumn(dataGridView1,query,"sanpham","TenSanPham","MaSp","MaSp");
            dataGridView1.DataSource = SanPhamModels.SanPhams.getAllCT(tinhtrang);
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(even ==1 )
            {
                string query = "SELECT * FROM SanPham";
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                string id = comboBox1.SelectedValue.ToString();
                Dataset.DaTa.getDataColumn(dataGridView1, query, "sanpham", "TenSanPham", "MaSp", "MaSp");
                dataGridView1.DataSource = SanPhamModels.SanPhams.getdataCT(id);
            }
           

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            even = 1;
        }

        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            getdata(true);
            btn_KhoiPhuc.Enabled = false;
            btn_Xoa.Enabled = true;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SanPham";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string id = comboBox1.SelectedValue.ToString();
            Dataset.DaTa.getDataColumn(dataGridView1, query, "sanpham", "TenSanPham", "MaSp", "MaSp");
            dataGridView1.DataSource = SanPhamModels.SanPhams.GetCTSPTen(txt_search.Text, SanPhamModels.SanPhams.getSanPham());
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int masp = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    SanPhamModels.SanPhams.changeTinhTrangCTs(masp, false);
                }
               
            }
            getdata(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SanPham";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dataset.DaTa.getDataColumn(dataGridView1, query, "sanpham", "TenSanPham", "MaSp", "MaSp");
            dataGridView1.DataSource = SanPhamModels.SanPhams.getAllCT(false);
            btn_KhoiPhuc.Enabled = true;
            btn_Xoa.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int masp = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    SanPhamModels.SanPhams.changeTinhTrangCTss(masp);
                }
                
            }
            getdata(false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if(btn_KhoiPhuc.Enabled == false)
            {
                btn_Xoa.Enabled = true;
            }
            else if(btn_KhoiPhuc.Enabled == true)
            {
                btn_Xoa.Enabled = false;
            }
            else if (btn_Xoa.Enabled == true)
            {
                btn_KhoiPhuc.Enabled = false;
            }
            else
            {
                btn_KhoiPhuc.Enabled = true;
            }
            int i = e.RowIndex;
            if(i>=0)
            {
                lb_MaChiTietSanPham.Text = dataGridView1.Rows[i].Cells["MaCTSp"].Value == null ? "" : dataGridView1.Rows[i].Cells["MaCTSp"].Value.ToString();
                txt_ChatLieu.Text = dataGridView1.Rows[i].Cells["ChatLieu"].Value == null ? "" : dataGridView1.Rows[i].Cells["ChatLieu"].Value.ToString();
                txt_GiaBan.Text = dataGridView1.Rows[i].Cells["GiaBan"].Value == null ? "" : dataGridView1.Rows[i].Cells["GiaBan"].Value.ToString();
                txt_KichCo.Text = dataGridView1.Rows[i].Cells["KichCo"].Value == null ? "" : dataGridView1.Rows[i].Cells["KichCo"].Value.ToString();
                txt_MauSac.Text = dataGridView1.Rows[i].Cells["MaSac"].Value == null ? "" : dataGridView1.Rows[i].Cells["MaSac"].Value.ToString();
                btn_CapNhat.Enabled = true;
            }
  
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            Dao.CTSanPham ctsp = new Dao.CTSanPham();
            ctsp.MaCTSp = int.Parse(lb_MaChiTietSanPham.Text);
            ctsp.KichCo = int.Parse(txt_KichCo.Text);
            ctsp.MaSac = txt_MauSac.Text;
            ctsp.ChatLieu = txt_ChatLieu.Text;
            ctsp.GiaBan = int.Parse(txt_GiaBan.Text);
            ctsp.MaSp = int.Parse(comboBox1.SelectedValue.ToString());
            if(SanPhamModels.SanPhams.SuaCTSP(ctsp))
            {
                MessageBox.Show("Cập nhật thành công");
                getdata(true);
                reset();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
