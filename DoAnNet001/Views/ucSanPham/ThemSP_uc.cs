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

namespace DoAnNet001.Views.ucSanPham
{
    public partial class ThemSP_uc : UserControl
    {
        public ThemSP_uc()
        {
            InitializeComponent();
            getMaLoai();
            panel2.Enabled = false;
            btn_HoanTat.Enabled = false;
            btn_CapNhat.Enabled = false;
            btn_Xoa.Enabled = false;
            listCT = new List<Dao.CTSanPham>();
        }
        string anhnv;
        string fileName;
        List<Dao.CTSanPham> listCT;
        public void getMaLoai()
        {
            LoaiSanPhamModels.LoaiSP.getTenLoai(cb_MaLoai);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
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
                            this.pictureBox1.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            this.pictureBox1.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Png);
                            break;

                        case 3:
                            this.pictureBox1.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                    }
                    fs.Close();
                }

                SanPham a = new SanPham();
                a.MaLoai = int.Parse(cb_MaLoai.SelectedValue.ToString());
                a.TenSanPham = txt_TenSP.Text;
                a.MoTa = rTB_MoTa.Text;
                a.SoLuong = 12;
                a.TinhTrang = true;
                a.HinhAnh = anhnv;
                if (SanPhamModels.SanPhams.ThemSanPham(a))
                {
                    txt_TenSP.Text = "";
                    rTB_MoTa.Text = "";
                    pictureBox1.Image = null;
                    MessageBox.Show("Thêm sản phẩm thành công");
                    panel2.Enabled = true;
                    if (panel2.Enabled == true)
                    {
                        int id = SanPhamModels.SanPhams.getLastMa();
                        lb_TenSp.Text = SanPhamModels.SanPhams.getTenSp(id);
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Không thể thêm sản phẩm");
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
                    pictureBox1.Image = Image.FromFile(fileName);
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
        public void getdatas()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listCT;

        }
        private void btn_TiepTuc_Click(object sender, EventArgs e)
        {
            try
            {
                int id = SanPhamModels.SanPhams.getLastMa();
                Dao.CTSanPham a = new Dao.CTSanPham();
                a.KichCo = int.Parse(txt_KichCo.Text);
                a.MaSac = txt_MauSac.Text;
                a.GiaBan = int.Parse(txt_GiaBan.Text);

                a.ChatLieu = txt_ChatLieu.Text;
                listCT.Add(a);
                btn_Xoa.Enabled = true;
                btn_HoanTat.Enabled = true;
                txt_ChatLieu.Text = "";
                txt_GiaBan.Text = "";
                txt_KichCo.Text = "";
                txt_MauSac.Text = "";
                comboBox1.Enabled = false;
                getdatas();
            }
            catch (Exception)
            {

                MessageBox.Show("Bạn chưa điền đủ thông tin");
            }
           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //if(i>=0)
            //{
            //    txt_KichCo.Text = dataGridView1.Rows[i].Cells["KichCo"].Value == null ? "" : dataGridView1.Rows[i].Cells["KichCo"].Value.ToString();
            //    txt_ChatLieu.Text = dataGridView1.Rows[i].Cells["KichCo"].Value == null ? "" : dataGridView1.Rows[i].Cells["KichCo"].Value.ToString();
            //}
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            listCT.Remove(listCT[listCT.Count() - 1]);
            getdatas();
            if (listCT.Count() == 0)
            {
                btn_Xoa.Enabled = false;
            }
            
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            btn_CapNhat.Enabled = true;
            btn_TiepTuc.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            comboBox1.Enabled = true;
            btn_ThemAnh.Enabled = false;
            cb_MaLoai.Enabled = false;
            txt_TenSP.Enabled = false;
            btn_Them.Enabled = false;
            rTB_MoTa.Enabled = false;
            SanPhamModels.SanPhams.GetTenSP(comboBox1);
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if(comboBox1.Enabled == true)
            {
                foreach (Dao.CTSanPham item in listCT)
                {
                    item.MaSp = int.Parse(comboBox1.SelectedValue.ToString());
                    item.TinhTrang = true;
                    SanPhamModels.SanPhams.ThemCT(item);
                   
                }
                MessageBox.Show("Thêm thành công");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = null;
                panel2.Enabled = false;
                comboBox1.Enabled = false;
                btn_ThemAnh.Enabled = true;
                cb_MaLoai.Enabled = true;
                txt_TenSP.Enabled = true;
                btn_Them.Enabled = true;
                rTB_MoTa.Enabled = true;
            }
            else
            {
                foreach (Dao.CTSanPham item in listCT)
                {
                    item.MaSp = SanPhamModels.SanPhams.getLastMa();
                     item.TinhTrang = true;
                    SanPhamModels.SanPhams.ThemCT(item);
                }
                MessageBox.Show("Thêm thành công");
                dataGridView1.DataSource = null;
                panel2.Enabled = false;
                comboBox1.Enabled = false;
                btn_ThemAnh.Enabled = true;
                cb_MaLoai.Enabled = true;
                txt_TenSP.Enabled = true;
                btn_Them.Enabled = true;
                rTB_MoTa.Enabled = true;
            }
        }
    }
}
