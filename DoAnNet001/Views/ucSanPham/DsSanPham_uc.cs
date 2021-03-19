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
using System.IO;
using DoAnNet001.Dao;
using DoAnNet001.Core;

namespace DoAnNet001.Views.ucSanPham
{
    public partial class DsSanPham_uc : UserControl
    {
        public DsSanPham_uc()
        {
            InitializeComponent();
            getdata();
            getloai();
            phanquyen();
            button1.Enabled = false;
        }
        string fileName;
        string anhnv = "";
        int i = 0;
        public static int masp;
        public void getdata()
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = new SanPhamModels().getSanPham();
            string query = "SELECT * FROM LoaiSanPham";
            Dataset.DaTa.getDataColumn(dataGridView1, query, "loaisp", "TenLoai", "MaLoai", "MaLoai");

        }
        public void getloai()
        {
            LoaiSanPhamModels.LoaiSP.getTenLoai(cb_LoaiSanPham);
        }
        public void phanquyen()
        {
            int phanquyen = DangNhapModels.DangNhapModelss.GetChucVu();
            if (phanquyen != 2 || phanquyen != 3)
            {
                btn_CapNhat.Enabled = false;
                btn_DoiAnh.Enabled = false;
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void reset()
        {
            txt_SoLuong.Text = "";
            txt_TenSanPham.Text = "";
            rTB_MoTa.Text = "";
            ptB_AnhSP.Image = null;

        }
        private void btn_DoiAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlg.FileName;
                    ptB_AnhSP.Image = Image.FromFile(fileName);
                }
                string[] arr = fileName.Split('\\');
                string anh = arr[arr.Length - 1];
                anh = anh.Split('.')[anh.Split('.').Length - 1];
                string anhNV = DateTime.Now.ToString("yyyyMMddhhmmssffff") + "." + anh;
                anhnv = anhNV;
                i++;
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể thêm ảnh");
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string tensp = txt_TenSanPham.Text;
                int soluong = int.Parse(txt_SoLuong.Text);
                int loaisp = int.Parse(cb_LoaiSanPham.SelectedValue.ToString());
                string mota = rTB_MoTa.Text;
               
                SanPham a = new SanPham();
                a.MaSp = int.Parse(lb_MaNhanVien.Text);
                a.TenSanPham = tensp;
                a.SoLuong = soluong;
                a.MoTa = mota;
                a.MaLoai = loaisp;
                if (i == 0)
                {
                    a.HinhAnh = anhnv;
                }
                else
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "JPeg Image|*.jpg|JPEG Image|*.png|Png Image|*.gif";
                    sfd.Title = "Save an Image File";
                    if (fileName != "")
                    {
                        string path = @"E:\HOC_IT\C# Winform\DoAnNet001\DoAnNet001\bin\Debug\anh\" + anhnv;
                        System.IO.FileStream fs = File.Create(path);
                        switch (sfd.FilterIndex)
                        {
                            case 1:
                                this.ptB_AnhSP.Image.Save(fs,
                                    System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;

                            case 2:
                                this.ptB_AnhSP.Image.Save(fs,
                                    System.Drawing.Imaging.ImageFormat.Png);
                                break;

                            case 3:
                                this.ptB_AnhSP.Image.Save(fs,
                                    System.Drawing.Imaging.ImageFormat.Gif);
                                break;

                        }
                        fs.Close();
                    }
                    a.HinhAnh = anhnv;
                }
                if (SanPhamModels.SanPhams.SuaSanPham(a))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                getdata();
                reset();
            }

            catch (Exception)
            {

                MessageBox.Show("Cập nhật không thành công kiểm tra lại thông tin của bạn");
            }
        }
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                if (i >= 0)
                {
                    anhnv = dataGridView1.Rows[i].Cells["HinhAnh"].Value.ToString();
                   

                    ptB_AnhSP.Image = Image.FromFile(Application.StartupPath + @"\anh\\" + dataGridView1.Rows[i].Cells["HinhAnh"].Value.ToString());
                    cb_LoaiSanPham.SelectedValue = dataGridView1.Rows[i].Cells["MaLoai"].Value == null ? "" : dataGridView1.Rows[i].Cells["MaLoai"].Value;
                    lb_MaNhanVien.Text = dataGridView1.Rows[i].Cells["MaSP"].Value==null? "" : dataGridView1.Rows[i].Cells["MaSP"].Value.ToString();
                    txt_TenSanPham.Text= dataGridView1.Rows[i].Cells["TenSanPham"].Value == null ? "" : dataGridView1.Rows[i].Cells["TenSanPham"].Value.ToString();
                    txt_SoLuong.Text = dataGridView1.Rows[i].Cells["SoLuong"].Value == null? "" :  dataGridView1.Rows[i].Cells["SoLuong"].Value.ToString();
                    rTB_MoTa.Text = dataGridView1.Rows[i].Cells["MoTa"].Value==null? "" : dataGridView1.Rows[i].Cells["MoTa"].Value.ToString();
                    button1.Enabled = true;
                    btn_DoiAnh.Enabled = true;
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
             string tensp = txt_Search.Text;
             dataGridView1.DataSource = SanPhamModels.SanPhams.TimKiemSanPham(tensp);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int masp = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    SanPhamModels.SanPhams.changeTinhTrang(masp, false);
                    SanPhamModels.SanPhams.changeTinhTrangCT(masp, false);
                }
            }
            getdata();
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            masp = int.Parse(lb_MaNhanVien.Text);
            dsChiTietSP ds = new dsChiTietSP();
            ds.Show();
        }

        private void btn_XuatEx_Click(object sender, EventArgs e)
        {
            string query = "SELECT SanPham.TenSanPham,LoaiSanPham.TenLoai,CTSanPham.KichCo,CTSanPham.MaSac,CTSanPham.ChatLieu,CTSanPham.GiaBan,CTSanPham.SoLuong  FROM SanPham, LoaiSanPham, CTSanPham " +
                            "WHERE SanPham.MaLoai = LoaiSanPham.MaLoai and SanPham.MaSp = CTSanPham.MaSp and SanPham.TinhTrang = '1' and CTSanPham.TinhTrang = '1' " +
                            "GROUP BY SanPham.TenSanPham,LoaiSanPham.TenLoai,CTSanPham.KichCo,CTSanPham.MaSac,CTSanPham.ChatLieu,CTSanPham.GiaBan,CTSanPham.SoLuong";
           
            CRp_SanPham sp = new CRp_SanPham();
            sp.SetDataSource(Dataset.DaTa.report(query));
            fRPTsp f = new fRPTsp();
            f.crystalReportViewer1.ReportSource = sp;
            f.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
