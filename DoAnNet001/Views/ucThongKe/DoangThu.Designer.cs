namespace DoAnNet001.Views.ucThongKe
{
    partial class DoangThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.txt_Thang = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanPhamTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanPhamBanChay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_CapNhat);
            this.panel1.Controls.Add(this.txt_Thang);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 498);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tháng:";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Location = new System.Drawing.Point(638, 97);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(82, 31);
            this.btn_CapNhat.TabIndex = 2;
            this.btn_CapNhat.Text = "Thống kê";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            // 
            // txt_Thang
            // 
            this.txt_Thang.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Thang.Location = new System.Drawing.Point(350, 102);
            this.txt_Thang.Name = "txt_Thang";
            this.txt_Thang.Size = new System.Drawing.Size(252, 26);
            this.txt_Thang.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Thang,
            this.SoLuongNhap,
            this.SoLuongXuat,
            this.SoLuongDonHang,
            this.TongXuat,
            this.TongNhap,
            this.DoanhThu,
            this.SanPhamTon,
            this.SanPhamBanChay});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1036, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số lượng sản phẩm nhập";
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.DataPropertyName = "SoLuongXuat";
            this.SoLuongXuat.HeaderText = "Số lượng sản phẩm xuất";
            this.SoLuongXuat.Name = "SoLuongXuat";
            // 
            // SoLuongDonHang
            // 
            this.SoLuongDonHang.DataPropertyName = "SoLuongDonHang";
            this.SoLuongDonHang.HeaderText = "Số lượng đơn hàng";
            this.SoLuongDonHang.Name = "SoLuongDonHang";
            // 
            // TongXuat
            // 
            this.TongXuat.DataPropertyName = "TongXuat";
            this.TongXuat.HeaderText = "Doanh thu xuất";
            this.TongXuat.Name = "TongXuat";
            // 
            // TongNhap
            // 
            this.TongNhap.DataPropertyName = "TongNhap";
            this.TongNhap.HeaderText = "Doanh thu nhập";
            this.TongNhap.Name = "TongNhap";
            // 
            // DoanhThu
            // 
            this.DoanhThu.DataPropertyName = "DoanhThu";
            this.DoanhThu.HeaderText = "Doanh thu";
            this.DoanhThu.Name = "DoanhThu";
            // 
            // SanPhamTon
            // 
            this.SanPhamTon.DataPropertyName = "SanPhamTon";
            this.SanPhamTon.HeaderText = "Sản phẩm tồn";
            this.SanPhamTon.Name = "SanPhamTon";
            // 
            // SanPhamBanChay
            // 
            this.SanPhamBanChay.DataPropertyName = "SanPhamBanChay";
            this.SanPhamBanChay.HeaderText = "Sản phẩm bán chạy";
            this.SanPhamBanChay.Name = "SanPhamBanChay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thống kê doanh thu";
            // 
            // DoangThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DoangThu";
            this.Size = new System.Drawing.Size(1036, 498);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.TextBox txt_Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPhamTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPhamBanChay;
        private System.Windows.Forms.Label label2;
    }
}
