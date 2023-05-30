namespace Nha_Sach_Desktop.UI
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaMoi = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKH2 = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.MaHd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batOnBookStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batOnBookStoreDataSet = new Nha_Sach_Desktop.BatOnBookStoreDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaKH2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(25, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Danh sách hóa đơn";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(144, 204);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(188, 28);
            this.txtTongTien.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tổng tiền";
            // 
            // txtMaMoi
            // 
            this.txtMaMoi.Location = new System.Drawing.Point(144, 68);
            this.txtMaMoi.Name = "txtMaMoi";
            this.txtMaMoi.Size = new System.Drawing.Size(188, 28);
            this.txtMaMoi.TabIndex = 11;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(617, 131);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(188, 28);
            this.txtSoLuong.TabIndex = 9;
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnXuat.Location = new System.Drawing.Point(521, 423);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(145, 33);
            this.btnXuat.TabIndex = 27;
            this.btnXuat.Text = "Xuất hóa đơn";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.ImageKey = "(none)";
            this.btnHuy.Location = new System.Drawing.Point(672, 423);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(58, 33);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(243, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "HÓA ĐƠN BÁN SÁCH";
            // 
            // txtTenKH2
            // 
            this.txtTenKH2.Location = new System.Drawing.Point(617, 97);
            this.txtTenKH2.Name = "txtTenKH2";
            this.txtTenKH2.Size = new System.Drawing.Size(188, 28);
            this.txtTenKH2.TabIndex = 8;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(617, 63);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(188, 28);
            this.txtTenSach.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(532, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(478, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(8, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(534, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHd,
            this.makh,
            this.TenKH,
            this.MaSach,
            this.TenSach,
            this.SoLuong,
            this.NgayLap,
            this.TongTien});
            this.dgvDSHD.Location = new System.Drawing.Point(27, 473);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.ReadOnly = true;
            this.dgvDSHD.RowHeadersWidth = 51;
            this.dgvDSHD.RowTemplate.Height = 24;
            this.dgvDSHD.Size = new System.Drawing.Size(795, 220);
            this.dgvDSHD.TabIndex = 29;
            this.dgvDSHD.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDSHD_RowHeaderMouseClick);
            // 
            // MaHd
            // 
            this.MaHd.DataPropertyName = "Mahd";
            this.MaHd.HeaderText = "Mã hóa đơn";
            this.MaHd.MinimumWidth = 6;
            this.MaHd.Name = "MaHd";
            this.MaHd.ReadOnly = true;
            this.MaHd.Width = 75;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "Makh";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            this.makh.Width = 75;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "Tenkh";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.Width = 125;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "Masach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 75;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "Tensach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "Soluong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 75;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "Ngaylap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Width = 75;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "Tongtien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 125;
            // 
            // batOnBookStoreDataSetBindingSource
            // 
            this.batOnBookStoreDataSetBindingSource.DataSource = this.batOnBookStoreDataSet;
            this.batOnBookStoreDataSetBindingSource.Position = 0;
            // 
            // batOnBookStoreDataSet
            // 
            this.batOnBookStoreDataSet.DataSetName = "BatOnBookStoreDataSet";
            this.batOnBookStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpNgayLapHD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.txtMaKH2);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMaMoi);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenKH2);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(17, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 258);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập hóa đơn";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(503, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 38);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(303, 17);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(188, 28);
            this.txtMaKH.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(153, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Mã khách hàng";
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.Location = new System.Drawing.Point(144, 170);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(188, 28);
            this.dtpNgayLapHD.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(6, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ngày lập";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(144, 102);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(188, 28);
            this.txtMaSach.TabIndex = 25;
            // 
            // txtMaKH2
            // 
            this.txtMaKH2.Location = new System.Drawing.Point(144, 136);
            this.txtMaKH2.Name = "txtMaKH2";
            this.txtMaKH2.Size = new System.Drawing.Size(188, 28);
            this.txtMaKH2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 116);
            this.panel1.TabIndex = 48;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(366, 187);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 46);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(478, 189);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 44);
            this.btnXoa.TabIndex = 54;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(581, 189);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 44);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(686, 188);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(119, 44);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.Text = " LƯU    ";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSHD);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDon";
            this.Text = "Hoá đơn bán sách";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaMoi;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH2;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaKH2;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource batOnBookStoreDataSetBindingSource;
        private BatOnBookStoreDataSet batOnBookStoreDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHd;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
    }
}