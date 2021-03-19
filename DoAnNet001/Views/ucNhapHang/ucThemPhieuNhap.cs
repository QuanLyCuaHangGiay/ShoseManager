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

namespace DoAnNet001.Views.ucNhapHang
{
    public partial class ucThemPhieuNhap : UserControl
    {
        List<CTPhieuNhap> listCT;
        List<Cart> cartList;
        int masp = 1;
        int even = 0;
        int change = 0;
        int soluongss = 0;
        double tongtien;
        public ucThemPhieuNhap()
        {
            InitializeComponent();
            getNCC();
            getTenNhanVien();
            listCT = new List<CTPhieuNhap>();
            cartList = new List<Cart>();
            pn_ThongTin.Enabled = false;
        }
        public void getNCC()
        {
            NhaCungCapModels.nhacungcapCons.getTens(cbNhaCungCap);
        }
        public void getTenNhanVien()
        {
            NhanVienModels.Nhanviens.getTen(cb_TenNhanVien);
        }
        public void getdata()
        {
            tongtien = 0;
            foreach (Cart item in cartList)
            {
                tongtien += item.Giatien;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cartList;
            //lb_TongTien.Text = tongtien.ToString();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuNhap phieunhap = new PhieuNhap();
                phieunhap.MaNV = int.Parse(cb_TenNhanVien.SelectedValue.ToString());
                phieunhap.MaNcc = int.Parse(cbNhaCungCap.SelectedValue.ToString());
                try
                {
                    phieunhap.NgayNhap = DateTime.Parse(txt_NgayNhap.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("nhập ngày theo tháng-năm-ngày");
                }
                bool check = PhieuNhapModels.phieunhapCons.suaPhieu(phieunhap);
                if(check==true)
                {
                    MessageBox.Show("Thêm phiếu nhập thành công");
                }
                else
                {
                    MessageBox.Show("Thêm phiếu nhập thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi hãy thử lại");
            }
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string mausac = cb_MauSac.SelectedValue.ToString();
                int kichco = int.Parse(cb_KichCo.SelectedValue.ToString());
                string chatlieu = cb_ChatLieu.SelectedValue.ToString();
                int masp = int.Parse(cb_SanPham.SelectedValue.ToString());
                // viết cho phần hiển thị sản phẩm
                string tensp = cb_SanPham.Text;
                string Mausac = cb_MauSac.Text;
                string Chatlieu = cb_ChatLieu.Text;
                int kichcos = int.Parse(cb_KichCo.Text);
                float gia = float.Parse(txtGiaNhap.Text);
                int soluong = 0;
            try
            {
                soluong = int.Parse(txt_SoLuong.Text);
                    CTPhieuNhap a = new CTPhieuNhap();
                    Cart giohang = new Cart(tensp, Mausac, Chatlieu, kichcos, gia, soluong, soluong * gia);
                    cartList.Add(giohang);
                    a.MaCTSp = SanPhamModels.SanPhams.getCTsp(chatlieu, kichco, mausac, masp);
                    a.SoLuong = soluong;
                    a.GiaNhap = gia;
                    listCT.Add(a);
                    soluongss++;
                    txt_SoLuong.Text = null;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    foreach (Cart item in cartList)
                    {
                        tongtien += item.Giatien;
                    }
                    getdata();

        }
                catch (Exception)
                {

                    MessageBox.Show("Số lượng không được để trống và chỉ được nhập số");
                }


}
            catch (Exception)
            {

                MessageBox.Show("Không thể thêm sản phẩm");
            }
        }

        private void txt_NgayNhap_TextChanged(object sender, EventArgs e)
        {
            pn_ThongTin.Enabled = true;
            if(pn_ThongTin.Enabled == true)
            {
                LoaiSanPhamModels.LoaiSP.getTenLoai(cb_LoaiSanPham);
                even = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cartList.Remove(cartList[cartList.Count() - 1]);
            getdata();
            if (cartList.Count() == 0)
            {
                button3.Enabled = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            btn_ThanhToan.Enabled = true;
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int MaNcc = int.Parse(cbNhaCungCap.SelectedValue.ToString());
                int manv = int.Parse(cb_TenNhanVien.SelectedValue.ToString());
                DateTime ngaynhap = DateTime.Parse(txt_NgayNhap.Text);
                PhieuNhap a = new PhieuNhap();
                a.NgayNhap = ngaynhap;
                a.MaNV = manv;
                a.MaNcc = MaNcc;
                a.SoLuong = soluongss;
                bool check = PhieuNhapModels.phieunhapCons.themPhieu(a);
                if (check == true)
                {
                    foreach (CTPhieuNhap item in listCT)
                    {
                        item.MaPhieuNhap = PhieuNhapModels.phieunhapCons.getLastMa();
                        CTPhieuNhapModels.CTPhieuNhapCons.themCT(item);
                    }
                    int mapn = PhieuNhapModels.phieunhapCons.getLastMa();
                    KhoHang kh = new KhoHang();
                    kh.MaPhieuNhap = mapn;
                    kh.NgayNhap = DateTime.Now;
                    LoHangModels.chucVu.themLoHang(kh);
                    MessageBox.Show("Thêm phiếu nhập thành công");
                    pn_ThongTin.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bạn nhập ngày không đúng yêu cầu ");
            }
           
        }

        private void cb_LoaiSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            if(even == 1 )
            {
                int maloai = int.Parse(cb_LoaiSanPham.SelectedValue.ToString());
                SanPhamModels.SanPhams.getTenSPwithMaL(cb_SanPham, maloai, "MaSP", "TenSanPham");
                change = 1;
            }
        }

        private void cb_SanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            if (change == 1)
            {
                masp = int.Parse(cb_SanPham.SelectedValue.ToString());
                SanPhamModels.SanPhams.getTinhChat(cb_KichCo, "KichCo", "KichCo", masp);
            }
        }

        private void cb_KichCo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string kichco = null;
                if (change == 1)
                {

                    masp = int.Parse(cb_SanPham.SelectedValue.ToString());
                    kichco = cb_KichCo.SelectedValue.ToString();
                    SanPhamModels.SanPhams.getTinhChat(cb_MauSac, "MaSac", "MaSac", masp, kichco);



                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể cập nhật kích cỡ");
            }
           
        }

        private void cb_MauSac_SelectedValueChanged(object sender, EventArgs e)
        {
            string kichco = null, mausac = null;
            if (change == 1)
            {
                masp = int.Parse(cb_SanPham.SelectedValue.ToString());
                kichco = cb_KichCo.SelectedValue.ToString();
                mausac = cb_MauSac.SelectedValue.ToString();
                SanPhamModels.SanPhams.getTinhChat(cb_ChatLieu, "ChatLieu", "ChatLieu", masp, kichco, mausac);


            }
        }
    }
}
