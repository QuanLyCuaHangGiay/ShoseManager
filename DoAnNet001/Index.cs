using DoAnNet001.Views.ucHeThong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNet001
{
    public partial class Index : Form
    {
        private static Index index;
        public Index()
        {
            InitializeComponent();
        }
        // lấy ra form chính
        public static Index Indexs
        {
            get
            {
                if (index == null)
                {
                    index = new Index();
                }
                return index;
            }
            //set => index = value;
        }
        // lấy ra panel chính
        public Panel panel
        {
            get
            {
                return this.pnChinh;
            }
            set
            {
                this.pnChinh = value;
            }
        }
        private void Index_Load(object sender, EventArgs e)
        {
            index = this;
            ucheThong ucDangNhap = new ucheThong();
            ucDangNhap.Dock = DockStyle.Fill;
            index.panel.Controls.Add(ucDangNhap);
            // hiển thị lên form nếu form ko bị chìm xuống tương tự như layer trong web 
            //index.panel.Controls["ucDangNhap"].BringToFront();
        }
    }
}
