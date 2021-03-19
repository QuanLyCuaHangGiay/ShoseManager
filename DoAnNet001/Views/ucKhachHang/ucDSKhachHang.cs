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

namespace DoAnNet001.Views.ucKhachHang
{
    public partial class ucDSKhachHang : UserControl
    {
        public ucDSKhachHang()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void reset()
        {
            txt_DiaChi.Text = "";
            txt_SoDienThoai.Text = "";
            txt_TenKH.Text = "";
            txt_Search.Text = "";
            lb_MaLoai.Text = "";
        }
        protected void getdata()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = KhachHangModels.KhachsHang.getdata(true);
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int makh = int.Parse(lb_MaLoai.Text);
                string diachi = txt_DiaChi.Text;
                string tenKH = txt_TenKH.Text;
                string sdt = txt_SoDienThoai.Text;
                KhachHang kh = new KhachHang();
                kh.MaKH = makh;
                kh.TenKH = tenKH;
                kh.DiaChi = diachi;
                kh.SoDienThoai = int.Parse(sdt);
                KhachHangModels.KhachsHang.SuaKH(kh);
                MessageBox.Show("Cập nhật thành công");
              
                getdata();  reset();
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể cập nhật");
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                if (i >= 0)
                {

                    lb_MaLoai.Text = dataGridView1.Rows[i].Cells["MaKH"].Value == null ? " " : dataGridView1.Rows[i].Cells["MaKH"].Value.ToString();
                    txt_TenKH.Text = dataGridView1.Rows[i].Cells["TenKH"].Value == null ? " " : dataGridView1.Rows[i].Cells["TenKH"].Value.ToString();
                    txt_SoDienThoai.Text = dataGridView1.Rows[i].Cells["SDT"].Value == null ? " " : dataGridView1.Rows[i].Cells["SDT"].Value.ToString();
                    txt_DiaChi.Text = dataGridView1.Rows[i].Cells["DiaChi"].Value == null ? " " : dataGridView1.Rows[i].Cells["DiaChi"].Value.ToString();

                   
                    btn_CapNhat.Enabled = true;
                    if(Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == false)
                    {
                        btn_Xoa.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã có lỗi xảy ra không thể hiển thị");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (KhachHangModels.KhachsHang.timkiem(txt_Search.Text, true).Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng");
            }
            else
            {
                dataGridView1.DataSource = KhachHangModels.KhachsHang.timkiem(txt_Search.Text,true);
            }
            reset();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void ucDSKhachHang_Load(object sender, EventArgs e)
        {
            getdata();
            btn_CapNhat.Enabled = false;
          
            btn_Xoa.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value )==true)
                {
                    int makh = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    KhachHangModels.KhachsHang.XoaKH(makh,false);
                }
            }
           
            getdata(); reset();
        }
    }
}
