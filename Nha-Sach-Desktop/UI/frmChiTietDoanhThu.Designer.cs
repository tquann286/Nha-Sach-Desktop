namespace Nha_Sach_Desktop.UI
{
    partial class frmChiTietDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietDoanhThu));
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.batOnBookStoreDataSet = new Nha_Sach_Desktop.BatOnBookStoreDataSet();
            this.batOnBookStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCTDT = new System.Windows.Forms.DataGridView();
            this.batOnBookStoreDataSet1 = new Nha_Sach_Desktop.BatOnBookStoreDataSet1();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new Nha_Sach_Desktop.BatOnBookStoreDataSet1TableAdapters.SACHTableAdapter();
            this.batOnBookStoreDataSet2 = new Nha_Sach_Desktop.BatOnBookStoreDataSet2();
            this.sACHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter1 = new Nha_Sach_Desktop.BatOnBookStoreDataSet2TableAdapters.SACHTableAdapter();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(831, 365);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(203, 52);
            this.btnThoat.TabIndex = 53;
            this.btnThoat.Text = "  THOÁT  ";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 138);
            this.panel1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(402, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "CHI TIẾT DOANH THU";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label62.Location = new System.Drawing.Point(17, 193);
            this.label62.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(74, 40);
            this.label62.TabIndex = 50;
            this.label62.Text = "Tháng 5:\r\n\r\n";
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.Aquamarine;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(831, 248);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(203, 52);
            this.btnXuat.TabIndex = 49;
            this.btnXuat.Text = "IN BÁO CÁO";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // batOnBookStoreDataSet
            // 
            this.batOnBookStoreDataSet.DataSetName = "BatOnBookStoreDataSet";
            this.batOnBookStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // batOnBookStoreDataSetBindingSource
            // 
            this.batOnBookStoreDataSetBindingSource.DataSource = this.batOnBookStoreDataSet;
            this.batOnBookStoreDataSetBindingSource.Position = 0;
            // 
            // dgvCTDT
            // 
            this.dgvCTDT.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvCTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.tensach,
            this.soluong,
            this.tongtien});
            this.dgvCTDT.Location = new System.Drawing.Point(21, 236);
            this.dgvCTDT.Name = "dgvCTDT";
            this.dgvCTDT.RowHeadersWidth = 51;
            this.dgvCTDT.RowTemplate.Height = 24;
            this.dgvCTDT.Size = new System.Drawing.Size(724, 204);
            this.dgvCTDT.TabIndex = 54;
            // 
            // batOnBookStoreDataSet1
            // 
            this.batOnBookStoreDataSet1.DataSetName = "BatOnBookStoreDataSet1";
            this.batOnBookStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.batOnBookStoreDataSet1;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // batOnBookStoreDataSet2
            // 
            this.batOnBookStoreDataSet2.DataSetName = "BatOnBookStoreDataSet2";
            this.batOnBookStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHBindingSource1
            // 
            this.sACHBindingSource1.DataMember = "SACH";
            this.sACHBindingSource1.DataSource = this.batOnBookStoreDataSet2;
            // 
            // sACHTableAdapter1
            // 
            this.sACHTableAdapter1.ClearBeforeFill = true;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "TenKH";
            this.masach.HeaderText = "Tên khách hàng";
            this.masach.MinimumWidth = 6;
            this.masach.Name = "masach";
            this.masach.Width = 125;
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "Tensach";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.MinimumWidth = 6;
            this.tensach.Name = "tensach";
            this.tensach.Width = 125;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "Soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 125;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "Tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.Width = 145;
            // 
            // frmChiTietDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 537);
            this.Controls.Add(this.dgvCTDT);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.btnXuat);
            this.Name = "frmChiTietDoanhThu";
            this.Text = "Chi tiết doanh thu";
            this.Load += new System.EventHandler(this.frmChiTietDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.BindingSource batOnBookStoreDataSetBindingSource;
        private BatOnBookStoreDataSet batOnBookStoreDataSet;
        private System.Windows.Forms.DataGridView dgvCTDT;
        private BatOnBookStoreDataSet1 batOnBookStoreDataSet1;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private BatOnBookStoreDataSet1TableAdapters.SACHTableAdapter sACHTableAdapter;
        private BatOnBookStoreDataSet2 batOnBookStoreDataSet2;
        private System.Windows.Forms.BindingSource sACHBindingSource1;
        private BatOnBookStoreDataSet2TableAdapters.SACHTableAdapter sACHTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
    }
}