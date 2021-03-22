namespace DoAnNet001.Views.ucDonHang
{
    partial class ThemCTdon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.bth_Luu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SanPham = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaSac = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ChatLieu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCTDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_DonHang = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(670, 345);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 20;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // bth_Luu
            // 
            this.bth_Luu.Location = new System.Drawing.Point(561, 345);
            this.bth_Luu.Name = "bth_Luu";
            this.bth_Luu.Size = new System.Drawing.Size(75, 23);
            this.bth_Luu.TabIndex = 19;
            this.bth_Luu.Text = "Lưu ";
            this.bth_Luu.UseVisualStyleBackColor = true;
            this.bth_Luu.Click += new System.EventHandler(this.bth_Luu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thông tin đơn hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SanPham,
            this.KichCo,
            this.MaSac,
            this.ChatLieu,
            this.MaDonHang,
            this.MaCTDonHang,
            this.SoLuong,
            this.GiaTien,
            this.TongTien});
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 187);
            this.dataGridView1.TabIndex = 14;
            // 
            // SanPham
            // 
            this.SanPham.DataPropertyName = "MaCTSp";
            this.SanPham.HeaderText = "Sản phẩm";
            this.SanPham.Name = "SanPham";
            // 
            // KichCo
            // 
            this.KichCo.DataPropertyName = "MaCTSp";
            this.KichCo.HeaderText = "Kích cỡ";
            this.KichCo.Name = "KichCo";
            // 
            // MaSac
            // 
            this.MaSac.DataPropertyName = "MaCTSp";
            this.MaSac.HeaderText = "Màu sắc";
            this.MaSac.Name = "MaSac";
            // 
            // ChatLieu
            // 
            this.ChatLieu.DataPropertyName = "MaCTSp";
            this.ChatLieu.HeaderText = "Chất liệu";
            this.ChatLieu.Name = "ChatLieu";
            // 
            // MaDonHang
            // 
            this.MaDonHang.DataPropertyName = "MaDonHang";
            this.MaDonHang.HeaderText = "Mã đơn hàng";
            this.MaDonHang.Name = "MaDonHang";
            this.MaDonHang.Visible = false;
            // 
            // MaCTDonHang
            // 
            this.MaCTDonHang.DataPropertyName = "MaCTDonHang";
            this.MaCTDonHang.HeaderText = "Mã chi tiết đơn hàng";
            this.MaCTDonHang.Name = "MaCTDonHang";
            this.MaCTDonHang.Visible = false;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá tiền ";
            this.GiaTien.Name = "GiaTien";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenKH.Location = new System.Drawing.Point(221, 79);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(37, 21);
            this.lb_TenKH.TabIndex = 25;
            this.lb_TenKH.Text = "Tên ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Thông tin chi tiết:";
            // 
            // lb_DonHang
            // 
            this.lb_DonHang.AutoSize = true;
            this.lb_DonHang.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DonHang.Location = new System.Drawing.Point(221, 43);
            this.lb_DonHang.Name = "lb_DonHang";
            this.lb_DonHang.Size = new System.Drawing.Size(37, 21);
            this.lb_DonHang.TabIndex = 22;
            this.lb_DonHang.Text = "Tên ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Mã đơn hàng:";
            // 
            // ThemCTdon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 380);
            this.Controls.Add(this.lb_TenKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_DonHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.bth_Luu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThemCTdon";
            this.Text = "ThemCTdon";
            this.Load += new System.EventHandler(this.ThemCTdon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button bth_Luu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewComboBoxColumn KichCo;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSac;
        private System.Windows.Forms.DataGridViewComboBoxColumn ChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_DonHang;
        private System.Windows.Forms.Label label7;
    }
}