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
    public partial class NhaCungCap_UC : UserControl
    {
        public NhaCungCap_UC()
        {
            InitializeComponent();
            getdata();
            //btn_XuatEx.Enabled = false;
            btn_CapNhat.Enabled = false;
        }
        public void reset()
        {
            txt_DiaChi.Text = "";
            txt_SoDienThoai.Text = "";
            txt_TenNCC.Text = "";
            txt_Search.Text = "";
            lb_MaLoai.Text = "";
        }
        public void getdata()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = NhaCungCapModels.nhacungcapCons.getdata(true);
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                 NhaCungCap a = new NhaCungCap();
                a.DiaChi = txt_DiaChi.Text;
                a.MaNcc = int.Parse(lb_MaLoai.Text);
                a.SoDienThoai = txt_SoDienThoai.Text;
                a.TenNcc = txt_TenNCC.Text;
                
                bool check =NhaCungCapModels.nhacungcapCons.Sua(a);
                if(check == true)
                {
                    MessageBox.Show("Cập nhật thành công");
                    getdata();
                    reset();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi không thể cập nhật");
            }
           

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                if (i >= 0)
                {
                    lb_MaLoai.Text = dataGridView1.Rows[i].Cells["MaNcc"].Value == null ? " " : dataGridView1.Rows[i].Cells["MaNcc"].Value.ToString();
                    txt_SoDienThoai.Text = dataGridView1.Rows[i].Cells["SoDienThoai"].Value == null ? " " : dataGridView1.Rows[i].Cells["SoDienThoai"].Value.ToString();
                    txt_DiaChi.Text = dataGridView1.Rows[i].Cells["DiaChi"].Value == null ? " " : dataGridView1.Rows[i].Cells["DiaChi"].Value.ToString();
                    txt_TenNCC.Text = dataGridView1.Rows[i].Cells["TenNcc"].Value == null ? " " : dataGridView1.Rows[i].Cells["TenNcc"].Value.ToString();
                    //btn_XuatEx.Enabled = true;
                    btn_CapNhat.Enabled = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã có lỗi xảy ra không thể hiển thị");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (NhaCungCapModels.nhacungcapCons.searchNcc(true, txt_Search.Text).Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp");
            }
            else
            {
                dataGridView1.DataSource = NhaCungCapModels.nhacungcapCons.searchNcc(true, txt_Search.Text);
                reset();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int mancc = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    NhaCungCapModels.nhacungcapCons.removeNCC(mancc, false);
                }
            }

            getdata(); reset();
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            getdata();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_MaLoai_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_XuatEx_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_SoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
