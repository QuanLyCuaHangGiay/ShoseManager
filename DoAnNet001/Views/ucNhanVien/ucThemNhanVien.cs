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

namespace DoAnNet001.Views.ucNhanVien
{
    public partial class ucThemNhanVien : UserControl
    {
        public ucThemNhanVien()
        {
            InitializeComponent();
            getChucVu();
        }
        public void getChucVu()
        {
            ChucVuModels.chucVu.getChucVu(cb_ChucVu, "TenChucVu", "MaChucVu");
        }
        string anhnv;
        string fileName;
        private void button1_Click(object sender, EventArgs e)
        {
            try
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

                string tennv = txt_TenNV.Text;
                DateTime ngaysinh = DateTime.Parse(txt_NgaySinh.Text);
                string diachi = txt_DiaChi.Text;
                int sdt = int.Parse(txt_SDT.Text);
                string value = cb_ChucVu.SelectedValue.ToString();
                NhanVien a = new NhanVien();
                a.TenNV = tennv;
                a.SDT = sdt;
                a.TinhTrang = true;
                a.HinhAnh = anhnv;
                a.DiaChi = diachi;
                a.NgaySinh = ngaysinh;
                a.MaChucVu = int.Parse(value);
                if (NhanVienModels.Nhanviens.themNV(a))
                {
                    txt_DiaChi.Text = "";
                    txt_NgaySinh.Text = "";
                    txt_SDT.Text = "";
                    txt_TenNV.Text = "";
                    ptB_AnhNV.Image = null;
                    MessageBox.Show("Thêm nhân viên thành công");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Không thể thêm nhân viên");
            }


        }

        private void btn_ThemAnh_Click(object sender, EventArgs e)
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
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể thêm ảnh");
            }
           
        }
    }
}
