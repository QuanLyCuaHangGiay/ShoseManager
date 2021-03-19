using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet001.Views.ucHeThong;
using DoAnNet001.Core;
using DoAnNet001.Dao;
using DoAnNet001.Models;

namespace DoAnNet001.Views.ucThongKe
{
    public partial class ThongKe_UC : UserControl
    {
        ChangeColor a = new ChangeColor();
        ChangeForm form = new ChangeForm();
        public ThongKe_UC()
        {
            InitializeComponent();
            getdata();
        }
        public void getdata()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = Dataset.DaTa.GetData();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ucHethong1 he = new ucHethong1();
            form.change(he);
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                int thang = int.Parse(txt_Thang.Text);
                if(thang >= 1 && thang <= 12)
                {
                   // ThongKe a = new ThongKe();
                   /// a.Thang = thang;
                   // check=ThongKeModels.TaiKhoanCons.addThang(a);
                }
               else
                {
                    MessageBox.Show("Bạn nhập tháng từ 1-12 ");
                }

                if (check == true)
                {
                    Dataset.DaTa.runProcedure("thongke_sanpham_nhap");
                    Dataset.DaTa.runProcedure("capnhat_soluong_ban");
                    Dataset.DaTa.runProcedure("thongke_doanhthu_nhap");
                    Dataset.DaTa.runProcedure("capnhat_doanhthu_ban");
                    Dataset.DaTa.runProcedure("capnhat_tong_doanhthu");
                    Dataset.DaTa.runProcedure("capnhat_sanpham_banchay");
                    Dataset.DaTa.runProcedure("capnhat_sanpham_bancham");
                    Dataset.DaTa.runProcedure("tong_hoadon");
                    txt_Thang.Text = null;
                }
                getdata();
            }
            catch (Exception)
            {

                MessageBox.Show("Bạn chưa nhập tháng");
            }
            
        }
    }
}
