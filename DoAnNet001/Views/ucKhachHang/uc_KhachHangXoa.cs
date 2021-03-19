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

namespace DoAnNet001.Views.ucKhachHang
{
    public partial class uc_KhachHangXoa : UserControl
    {
        public uc_KhachHangXoa()
        {
            InitializeComponent();
            getdata();
        }
        protected void getdata()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = KhachHangModels.KhachsHang.getdata(false);
        }
        public void reset()
        {
            txt_DiaChi.Text = "";
            txt_SoDienThoai.Text = "";
            txt_TenKH.Text = "";
            txt_Search.Text = "";
            lb_MaLoai.Text = "";
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int makh = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    KhachHangModels.KhachsHang.XoaKH(makh,true);
                }
            }
            getdata();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (KhachHangModels.KhachsHang.timkiem(txt_Search.Text, false).Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng");
            }
            else
            {
              
                dataGridView1.DataSource = KhachHangModels.KhachsHang.timkiem(txt_Search.Text, false);
                reset();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
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
                    lb_MaLoai.Text = dataGridView1.Rows[i].Cells["MaKH"].Value == null ? " " : dataGridView1.Rows[i].Cells["MaKH"].Value.ToString();
                    txt_TenKH.Text =  dataGridView1.Rows[i].Cells["TenKH"].Value == null ? " " : dataGridView1.Rows[i].Cells["TenKH"].Value.ToString();
                    txt_SoDienThoai.Text = dataGridView1.Rows[i].Cells["SDT"].Value == null ? " " : dataGridView1.Rows[i].Cells["SDT"].Value.ToString();
                    txt_DiaChi.Text = dataGridView1.Rows[i].Cells["DiaChi"].Value == null ? " " : dataGridView1.Rows[i].Cells["DiaChi"].Value.ToString();
                   
                  
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã có lỗi xảy ra không thể hiển thị");
            }
        }
    }
}
