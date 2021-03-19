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
using System.IO;
using DoAnNet001.Core;

namespace DoAnNet001.Views.ucNhanVien
{
    public partial class ucHoSoNV : UserControl
    {
        public ucHoSoNV()
        {
            InitializeComponent();
            getdata();
            getChucVu();
            btn_DoiAnh.Enabled = false;
            btn_CapNhat.Enabled = false;
        }
        string fileName;
        string anhnv = "";
        int i = 0;
        public void getdata()
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = new NhanVienModels().getNhanVien();

        }
        public void getChucVu()
        {
            ChucVuModels.chucVu.getChucVu(cb_ChucVu, "TenChucVu", "MaChucVu");
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string tennv = txt_TenNhanVien.Text;
                string diachi = txt_DiaChi.Text;
                int sdt = int.Parse(txt_SoDienThoai.Text);
                DateTime ngaysinh = DateTime.Parse(txt_NgaySinh.Text);
                bool nghiviec = false;
                string chucvu = cb_ChucVu.SelectedValue.ToString();
                NhanVien a = new NhanVien();
                a.MaNV = int.Parse(lb_MaNhanVien.Text);
                a.NgaySinh = ngaysinh;
                a.MaChucVu = int.Parse(chucvu);
                a.SDT = sdt;
                a.TenNV = tennv;
                a.DiaChi = diachi;
                a.TinhTrang = nghiviec;
                if (rb_ChuaNghi.Checked == true)
                {
                    nghiviec = true;
                }
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
                                this.ptB_AnhNV.Image.Save(fs,
                                    System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;

                            case 2:
                                this.ptB_AnhNV.Image.Save(fs,
                                    System.Drawing.Imaging.ImageFormat.Png);
                                break;

                            case 3:
                                this.ptB_AnhNV.Image.Save(fs,
                                    System.Drawing.Imaging.ImageFormat.Gif);
                                break;

                        }
                        fs.Close();
                    }
                    a.HinhAnh = anhnv;
                }
                if (NhanVienModels.Nhanviens.SuaNhanVien(a))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                    getdata();
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
                    DateTime date = DateTime.Parse(dataGridView1.Rows[i].Cells["NgaySinh"].Value.ToString());
                    ptB_AnhNV.Image = Image.FromFile(Application.StartupPath + @"\anh\\" + dataGridView1.Rows[i].Cells["HinhAnh"].Value.ToString());
                    cb_ChucVu.SelectedValue = dataGridView1.Rows[i].Cells["MaChucVu"].Value;
                    lb_MaNhanVien.Text = dataGridView1.Rows[i].Cells["MaNV"].Value.ToString();
                    txt_NgaySinh.Text = date.ToString("MM/dd/yyyy");
                    txt_TenNhanVien.Text = dataGridView1.Rows[i].Cells["TenNhanVien"].Value.ToString();
                    txt_SoDienThoai.Text = dataGridView1.Rows[i].Cells["SDT"].Value.ToString();
                    txt_DiaChi.Text = dataGridView1.Rows[i].Cells["DiaChi"].Value.ToString();

                    if ((bool)dataGridView1.Rows[i].Cells["TinhTrang"].Value == true)
                    {
                        rb_ChuaNghi.Checked = true;
                        rb_DaNghi.Checked = false;
                    }
                    else
                    {
                        rb_ChuaNghi.Checked = true;
                        rb_DaNghi.Checked = true;
                    }
                    btn_DoiAnh.Enabled = true;
                    btn_CapNhat.Enabled = true;
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
            dataGridView1.DataSource = new NhanVienModels().SearchNV(tennv);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_MaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btn_DoiAnh_Click(object sender, EventArgs e)
        {
            try
            {
                 OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlg.FileName;
                    ptB_AnhNV.Image = Image.FromFile(fileName);
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

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void btn_XuatEx_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NhanVien WHERE TinhTrang = '1'";
            CRp_NhanVien sp = new CRp_NhanVien();
            sp.SetDataSource(Dataset.DaTa.report(query));
            FormCRp_NhanVien f = new FormCRp_NhanVien();
            f.crystalReportViewer1.ReportSource = sp;
            f.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rb_DaNghi_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
