namespace DoAnNet001
{
    partial class Index
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
            this.pnChinh = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnChinh
            // 
            this.pnChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChinh.Location = new System.Drawing.Point(0, 0);
            this.pnChinh.Margin = new System.Windows.Forms.Padding(4);
            this.pnChinh.Name = "pnChinh";
            this.pnChinh.Size = new System.Drawing.Size(1295, 680);
            this.pnChinh.TabIndex = 1;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 680);
            this.Controls.Add(this.pnChinh);
            this.Name = "Index";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChinh;
    }
}

