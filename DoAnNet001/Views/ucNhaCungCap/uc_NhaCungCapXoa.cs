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

namespace DoAnNet001.Views.ucNhaCungCap
{
    public partial class uc_NhaCungCapXoa : UserControl
    {
        public uc_NhaCungCapXoa()
        {
            InitializeComponent();
            getdata();
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
            dataGridView1.DataSource = NhaCungCapModels.nhacungcapCons.getdata(false);
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int mancc = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    NhaCungCapModels.nhacungcapCons.removeNCC(mancc, true);
                }
            }
            getdata();
            reset();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (NhaCungCapModels.nhacungcapCons.searchNcc(true, txt_Search.Text).Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp");
            }
            else
            {
                dataGridView1.DataSource = NhaCungCapModels.nhacungcapCons.searchNcc(false, txt_Search.Text);
                reset();
            }
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
                   // btn_XuatEx.Enabled = true;
                  
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã có lỗi xảy ra không thể hiển thị");
            }
        }

        private void btn_XuatEx_Click(object sender, EventArgs e)
        {

        }
    }
}
