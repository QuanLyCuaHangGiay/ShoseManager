namespace DoAnNet001.Views.ucNhapHang
{
    partial class PhieuNhapCT
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
            this.label4 = new System.Windows.Forms.Label();
            this.lb_MaPhieuNhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sanpham = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaSac = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ChatLieu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCTPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(660, 350);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 20;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // bth_Luu
            // 
            this.bth_Luu.Location = new System.Drawing.Point(567, 350);
            this.bth_Luu.Name = "bth_Luu";
            this.bth_Luu.Size = new System.Drawing.Size(75, 23);
            this.bth_Luu.TabIndex = 19;
            this.bth_Luu.Text = "Lưu ";
            this.bth_Luu.UseVisualStyleBackColor = true;
            this.bth_Luu.Click += new System.EventHandler(this.bth_Luu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Thông tin chi tiết:";
            // 
            // lb_MaPhieuNhap
            // 
            this.lb_MaPhieuNhap.AutoSize = true;
            this.lb_MaPhieuNhap.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaPhieuNhap.Location = new System.Drawing.Point(139, 57);
            this.lb_MaPhieuNhap.Name = "lb_MaPhieuNhap";
            this.lb_MaPhieuNhap.Size = new System.Drawing.Size(97, 21);
            this.lb_MaPhieuNhap.TabIndex = 17;
            this.lb_MaPhieuNhap.Text = "Tên sản phẩm";
            this.lb_MaPhieuNhap.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thông tin phiếu nhập";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sanpham,
            this.KichCo,
            this.MaSac,
            this.ChatLieu,
            this.SoLuong,
            this.GiaNhap,
            this.TongTien,
            this.MaPhieuNhap,
            this.MaCTPhieuNhap});
            this.dataGridView1.Location = new System.Drawing.Point(24, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 233);
            this.dataGridView1.TabIndex = 14;
            // 
            // sanpham
            // 
            this.sanpham.DataPropertyName = "MaCTSp";
            this.sanpham.HeaderText = "Sản phẩm";
            this.sanpham.Name = "sanpham";
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
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            this.MaPhieuNhap.Visible = false;
            // 
            // MaCTPhieuNhap
            // 
            this.MaCTPhieuNhap.DataPropertyName = "MaCTPhieuNhap";
            this.MaCTPhieuNhap.HeaderText = "Mã chi tiết phiếu nhập";
            this.MaCTPhieuNhap.Name = "MaCTPhieuNhap";
            this.MaCTPhieuNhap.Visible = false;
            // 
            // PhieuNhapCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 375);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.bth_Luu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_MaPhieuNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PhieuNhapCT";
            this.Text = "PhieuNhapCT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button bth_Luu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_MaPhieuNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn sanpham;
        private System.Windows.Forms.DataGridViewComboBoxColumn KichCo;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSac;
        private System.Windows.Forms.DataGridViewComboBoxColumn ChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTPhieuNhap;
    }
}