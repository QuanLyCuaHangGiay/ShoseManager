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
    public partial class uc_ThemDonHang : UserControl
    {
        List<CTDonHang> listCT;
        List<Cart> cartList;
        int masp = 1;
        int even = 0;
        int change = 0;
        int soluongss = 0;
        double tongtien;
        private object crystalReportViewer1;

        public uc_ThemDonHang()
        {
            InitializeComponent();
            getKhachHang();
            getNhanVien();
            getLoHang();
            listCT = new List<CTDonHang>();
            cartList = new List<Cart>();
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void linkLB_ThemKH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }
        public void getKhachHang()
        {
            KhachHangModels.KhachsHang.getTenKhachHang(cb_KhachHang);
        }
        public void getNhanVien()
        {
            NhanVienModels.Nhanviens.getTen(cb_NVban);
        }
        public void getLoHang()
        {
            LoaiSanPhamModels.LoaiSP.getTenLoai(cb_LoaiSanPham);
        }
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
           

        }

        private void cb_LoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void cb_LoHang_MouseClick(object sender, MouseEventArgs e)
        {
            even = 1;
        }

        private void cb_LoHang_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_KichCo_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_MauSac_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void uc_ThemDonHang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            lb_TongTien.Text = tongtien.ToString();

        }
        private void cb_KhachHang_Click(object sender, EventArgs e)
        {
          
        }

        private void cb_LoaiSanPham_Click(object sender, EventArgs e)
        {
           
        }

        private void cb_LoaiSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
           

          
        }

        private void cb_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cb_KichCo_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_MauSac_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_SanPham_ValueMemberChanged(object sender, EventArgs e)
        {

           
        }

        private void cb_KichCo_SelectedValueChanged_1(object sender, EventArgs e)
        {
            

           
        }

        private void cb_MauSac_SelectedValueChanged_1(object sender, EventArgs e)
        {
            

          
        }

        private void cb_SanPham_SelectedValueChanged(object sender, EventArgs e)
        {                
           
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_ThanhToan_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void lb_TongTien_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cb_KhachHang_Click_1(object sender, EventArgs e)
        {
            even = 1;
            pn_ThongTinDonHang.Enabled = true;
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cartList.Remove(cartList[cartList.Count() - 1]);
            listCT.Remove(listCT[listCT.Count() - 1]);
            getdata();
            if (cartList.Count() == 0)
            {
                button3.Enabled = false;
            }
        }

        private void btn_ThanhToan_Click_2(object sender, EventArgs e)
        {
            int makh = int.Parse(cb_KhachHang.SelectedValue.ToString());
            int manv = int.Parse(cb_NVban.SelectedValue.ToString());
            int malohang = LoHangModels.chucVu.getMaLoHang(int.Parse(cb_LoaiSanPham.SelectedValue.ToString()));
            DonHang a = new DonHang();
            a.MaNV = manv;
            a.MaKH = makh;
            a.MaLoHang = malohang;
            a.SoLuong = soluongss;
            bool check = DonHangModels.DonHangCons.ThemDonHang(a);
            if (check == true)
            {
                foreach (CTDonHang item in listCT)
                {
                    item.MaDonHang = DonHangModels.DonHangCons.getLastMa();
                    CTDonHangModels.CTDonHangCons.Them(item);
                }
                MessageBox.Show("Thêm đơn hàng thành công");
                dataGridView1.DataSource = null;
                txt_SoLuong = null;
                string query1 = "SELECT KhachHang.TenKH,SanPham.TenSanPham,DonHang.TongTien,DonHang.SoLuong,DonHang.NgayMua,CTSanPham.ChatLieu,CTSanPham.KichCo,CTSanPham.MaSac,CTDonHang.TongTien,CTDonHang.GiaTien,CTDonHang.SoLuong " +
                               "FROM SanPham, DonHang, CTDonHang, KhachHang, CTSanPham " +
                               "where SanPham.MaSp = CTSanPham.MaSp and KhachHang.MaKH = DonHang.MaKH and CTSanPham.MaCTSp = CTDonHang.MaCTSp and DonHang.MaDonHang = CTDonHang.MaDonHang " +
                               "and DonHang.MaDonHang = '"+ DonHangModels.DonHangCons.getLastMa()+"'";
                CRp_DonHang sp = new CRp_DonHang();
                sp.SetDataSource(Dataset.DaTa.report(query1));
                RpForm_DonHang f = new RpForm_DonHang();
                f.crystalReportViewer1.ReportSource = sp;
                f.ShowDialog();
            }
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            btn_ThanhToan.Enabled = true;
        }

        private void cb_SanPham_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (change == 1)
            {
                masp = int.Parse(cb_SanPham.SelectedValue.ToString());
                SanPhamModels.SanPhams.getTinhChat(cb_KichCo, "KichCo", "KichCo", masp);
            }
        }

        private void cb_MauSac_SelectedValueChanged_2(object sender, EventArgs e)
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

        private void cb_KichCo_SelectedValueChanged_2(object sender, EventArgs e)
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

               MessageBox.Show("Thông tin chi tiết sản phẩm chưa được cập nhật");
            }
           
        }

        private void cb_LoaiSanPham_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (even == 1)
            {
                int maloai = int.Parse(cb_LoaiSanPham.SelectedValue.ToString());
                SanPhamModels.SanPhams.getTenSPwithMaL(cb_SanPham, maloai, "MaSP", "TenSanPham");
                change = 1;
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
                float gia = SanPhamModels.SanPhams.getGia(masp);
                int soluong = 0;
                try
                {
                    soluong = int.Parse(txt_SoLuong.Text);
                    CTDonHang a = new CTDonHang();
                    Cart giohang = new Cart(tensp, Mausac, Chatlieu, kichcos, gia, soluong, soluong * gia);
                    cartList.Add(giohang);
                    a.MaCTSp = SanPhamModels.SanPhams.getCTsp(chatlieu, kichco, mausac, masp);
                    a.SoLuong = soluong;
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

        private void linkLB_ThemKH_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemKhachHang them = new ThemKhachHang();
            them.Show();
        }

        private void cb_LoaiSanPham_Click_1(object sender, EventArgs e)
        {
            cb_KhachHang.Enabled = false;
        }
    }
}
