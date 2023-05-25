namespace Nha_Sach_Desktop.UI
{
    partial class frmBaoCaoTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoTonKho));
            this.dgvBaoCaoTon = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toncuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoTon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaoCaoTon
            // 
            this.dgvBaoCaoTon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBaoCaoTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.ts,
            this.ton,
            this.TongNhap,
            this.TongBan,
            this.toncuoi});
            this.dgvBaoCaoTon.Location = new System.Drawing.Point(15, 233);
            this.dgvBaoCaoTon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBaoCaoTon.Name = "dgvBaoCaoTon";
            this.dgvBaoCaoTon.RowHeadersWidth = 51;
            this.dgvBaoCaoTon.Size = new System.Drawing.Size(1017, 224);
            this.dgvBaoCaoTon.TabIndex = 48;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // ts
            // 
            this.ts.DataPropertyName = "TenSach";
            this.ts.HeaderText = "Tên Sách";
            this.ts.MinimumWidth = 6;
            this.ts.Name = "ts";
            this.ts.Width = 295;
            // 
            // ton
            // 
            this.ton.DataPropertyName = "TonDau";
            this.ton.HeaderText = "Tồn Đầu";
            this.ton.MinimumWidth = 6;
            this.ton.Name = "ton";
            this.ton.Width = 75;
            // 
            // TongNhap
            // 
            this.TongNhap.DataPropertyName = "TongNhap";
            this.TongNhap.HeaderText = "Tổng nhập";
            this.TongNhap.MinimumWidth = 6;
            this.TongNhap.Name = "TongNhap";
            this.TongNhap.Width = 85;
            // 
            // TongBan
            // 
            this.TongBan.DataPropertyName = "TongBan";
            this.TongBan.HeaderText = "Tổng bán";
            this.TongBan.MinimumWidth = 6;
            this.TongBan.Name = "TongBan";
            this.TongBan.Width = 80;
            // 
            // toncuoi
            // 
            this.toncuoi.DataPropertyName = "TonCuoi";
            this.toncuoi.HeaderText = "Tồn cuối";
            this.toncuoi.MinimumWidth = 6;
            this.toncuoi.Name = "toncuoi";
            this.toncuoi.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(400, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 45;
            this.label1.Text = "BÁO CÁO TỒN KHO";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label62.Location = new System.Drawing.Point(15, 190);
            this.label62.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(135, 40);
            this.label62.TabIndex = 44;
            this.label62.Text = "Báo cáo tồn kho:\r\n\r\n";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 138);
            this.panel1.TabIndex = 46;
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.Aquamarine;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(619, 465);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(250, 52);
            this.btnXuat.TabIndex = 43;
            this.btnXuat.Text = "XUẤT BÁO CÁO";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(877, 465);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 52);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "  THOÁT  ";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 537);
            this.Controls.Add(this.dgvBaoCaoTon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.btnXuat);
            this.Name = "frmBaoCaoTonKho";
            this.Text = "frmBaoCaoTonKho";
            this.Load += new System.EventHandler(this.frmBaoCaoTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaoCaoTon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn toncuoi;
        private System.Windows.Forms.Button btnThoat;
    }
}