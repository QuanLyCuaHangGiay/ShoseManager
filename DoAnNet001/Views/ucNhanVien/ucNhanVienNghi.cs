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

namespace DoAnNet001.Views.ucNhanVien
{
    public partial class ucNhanVienNghi : UserControl
    {
        public ucNhanVienNghi()
        {
            InitializeComponent();
            getChucVu();
            getdata();
        }
        public void getChucVu()
        {
            ChucVuModels.chucVu.getChucVu(cb_ChucVu, "TenChucVu", "MaChucVu");
        }
        public void getdata()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = NhanVienModels.Nhanviens.getNVNghi();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (NhanVienModels.Nhanviens.xoa(int.Parse(lb_MaNhanVien.Text)))
            {
                
                txt_DiaChi.Text = "";
                txt_NgaySinh.Text = "";
                txt_Search.Text = "";
                txt_SoDienThoai.Text = "";
                txt_TenNhanVien.Text = "";
                ptB_AnhNV.Image = null;
            }
            getdata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                if (i >= 0)
                {

                    DateTime date = DateTime.Parse(dataGridView1.Rows[i].Cells["NgaySinh"].Value.ToString());
                    ptB_AnhNV.Image = Image.FromFile(Application.StartupPath + @"\anh\\" + dataGridView1.Rows[i].Cells["HinhAnh"].Value.ToString());
                    cb_ChucVu.SelectedValue = dataGridView1.Rows[i].Cells["MaChucVu"].Value;
                    lb_MaNhanVien.Text = dataGridView1.Rows[i].Cells["MaNV"].Value == null ? " " : dataGridView1.Rows[i].Cells["MaNV"].Value.ToString();
                    txt_NgaySinh.Text = date.ToString("MM/dd/yyyy");
                    txt_TenNhanVien.Text = dataGridView1.Rows[i].Cells["TenNhanVien"].Value == null ? " " : dataGridView1.Rows[i].Cells["TenNhanVien"].Value.ToString();
                    txt_SoDienThoai.Text = dataGridView1.Rows[i].Cells["SDT"].Value == null ? " " : dataGridView1.Rows[i].Cells["SDT"].Value.ToString();
                    txt_DiaChi.Text = dataGridView1.Rows[i].Cells["DiaChi"].Value == null ? " " : dataGridView1.Rows[i].Cells["DiaChi"].Value.ToString();
                    btn_Xoa.Enabled = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại");
            }
           
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tennv = txt_Search.Text;
            dataGridView1.DataSource = new NhanVienModels().SearchNVNghi(tennv);
        }

        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void btn_XuatEx_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
