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
using DoAnNet001.Core;

namespace DoAnNet001.Views.ucDonHang
{
    public partial class uc_DonHang : UserControl
    {
        public uc_DonHang()
        {
            InitializeComponent();
          

        }
        public static int maDH ;
        public static string tenkh;
        private void button1_Click(object sender, EventArgs e)
        {

        }
        protected void getdata()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource =   DonHangModels.DonHangCons.getdata();
            string query1 = "SELECT * FROM KhachHang";
            string query2 = "SELECT * FROM NhanVien";
            Dataset.DaTa.getDataColumn(dataGridView1, query1, "kh", "TenKH", "MaKH", "MaKH");
            Dataset.DaTa.getDataColumn(dataGridView1, query2, "nv", "TenNV", "MaNV", "MaNV");
        }
        protected void getKhachHang()
        {
            KhachHangModels.KhachsHang.getTenKhachHang(cb_KhachHang);
        }
        protected void getNhanVien()
        {
            NhanVienModels.Nhanviens.getTen(cb_NVban);
        }
        protected void getLoHang()
        {
            LoHangModels.chucVu.getmakhohang(cb_LoHang);
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            DonHang dh = new DonHang();
            dh.MaKH = int.Parse(cb_KhachHang.SelectedValue.ToString());
            dh.NgayMua = DateTime.Parse(txtNgayMua.Text);
            dh.MaDonHang = int.Parse(lb_PhieuNhap.Text);
            dh.MaLoHang = int.Parse(cb_LoHang.SelectedValue.ToString());
            dh.SoLuong = int.Parse(txt_SoLuong.Text);
            bool check = DonHangModels.DonHangCons.SuaDonHang(dh);
            if(check == true)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            ThemCTdon ctdon = new ThemCTdon();
            ctdon.Show();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if(DonHangModels.DonHangCons.donhang(txt_Search.Text) == null )
            {
                MessageBox.Show("Khách hàng không tồn tại");
            }
            else
            {
                dataGridView1.DataSource = DonHangModels.DonHangCons.donhang(txt_Search.Text);
                btn_Xoa.Enabled = true;
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

                    maDH = int.Parse(dataGridView1.Rows[i].Cells["MaDonHang"].Value.ToString());
                    lb_PhieuNhap.Text = dataGridView1.Rows[i].Cells["MaDonHang"].Value == null ? " " : dataGridView1.Rows[i].Cells["MaDonHang"].Value.ToString();
                    txtNgayMua.Text = dataGridView1.Rows[i].Cells["NgayMua"].Value == null ? " " : dataGridView1.Rows[i].Cells["NgayMua"].Value.ToString();
                    txt_SoLuong.Text = dataGridView1.Rows[i].Cells["SoLuong"].Value == null ? " " : dataGridView1.Rows[i].Cells["SoLuong"].Value.ToString();
                    cb_KhachHang.SelectedValue = dataGridView1.Rows[i].Cells["MaKH"].Value == null ? " " : dataGridView1.Rows[i].Cells["MaKH"].Value;
                    cb_LoHang.SelectedValue = dataGridView1.Rows[i].Cells["MaLoHang"].Value == null ? " " : dataGridView1.Rows[i].Cells["MaLoHang"].Value;
                    cb_NVban.SelectedValue = dataGridView1.Rows[i].Cells["MaNV"].Value == null ? " " : dataGridView1.Rows[i].Cells["MaNV"].Value;
                    txt_TongTien.Text = dataGridView1.Rows[i].Cells["TongTien"].Value == null ? " " : dataGridView1.Rows[i].Cells["TongTien"].Value.ToString();
                    btn_Xoa.Enabled = true;
                    btn_CapNhat.Enabled = true;
                    btn_ChiTiet.Enabled = true;
                    tenkh = cb_KhachHang.Text;


                }
            }
            catch (Exception)
            {

               MessageBox.Show("Không thể ấn vui lòng chọn dòng khác");
            }
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_DonHang_Load(object sender, EventArgs e)
        {
            getdata();
            getKhachHang();
            getNhanVien();
            getLoHang();
            btn_ChiTiet.Enabled = false;
            btn_CapNhat.Enabled = false;
        }

        private void btn_XuatEx_Click(object sender, EventArgs e)
        {
            string query = "SELECT DonHang.MaDonHang,DonHang.NgayMua,DonHang.SoLuong,DonHang.TongTien,DonHang.MaLoHang,NhanVien.TenNV,KhachHang.TenKH " +
                           "FROM DonHang,KhachHang,NhanVien " +
                           "WHERE DonHang.MaKH = KhachHang.MaKH and NhanVien.MaNV = DonHang.MaNV";
            CRp_DsDonHang sp = new CRp_DsDonHang();
            sp.SetDataSource(Dataset.DaTa.report(query));
            RpForm_DonHang f = new RpForm_DonHang();
            f.crystalReportViewer1.ReportSource = sp;
            f.ShowDialog();

        }
    }
}
