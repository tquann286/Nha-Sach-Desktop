﻿namespace Nha_Sach_Desktop.UI
{
    partial class frmBaoCaoDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoDoanhThu));
            this.dgvBCDT = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label62 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.batOnBookStoreDataSet = new Nha_Sach_Desktop.BatOnBookStoreDataSet();
            this.batOnBookStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBCDT
            // 
            this.dgvBCDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thang,
            this.DoanhThu});
            this.dgvBCDT.Location = new System.Drawing.Point(37, 215);
            this.dgvBCDT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBCDT.Name = "dgvBCDT";
            this.dgvBCDT.RowHeadersWidth = 51;
            this.dgvBCDT.Size = new System.Drawing.Size(697, 218);
            this.dgvBCDT.TabIndex = 55;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(780, 381);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(182, 52);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "  THOÁT  ";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 114);
            this.panel1.TabIndex = 53;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.SystemColors.Control;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label62.Location = new System.Drawing.Point(33, 178);
            this.label62.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(154, 20);
            this.label62.TabIndex = 51;
            this.label62.Text = "Báo cáo doanh thu:";
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.Aquamarine;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(780, 302);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(182, 52);
            this.btnXuat.TabIndex = 50;
            this.btnXuat.Text = "IN BÁO CÁO";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(395, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 52;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnChiTiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(124)))), ((int)(((byte)(35)))));
            this.btnChiTiet.Location = new System.Drawing.Point(780, 215);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(182, 55);
            this.btnChiTiet.TabIndex = 56;
            this.btnChiTiet.Text = "CHI TIẾT";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
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
            // Thang
            // 
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            this.Thang.Width = 125;
            // 
            // DoanhThu
            // 
            this.DoanhThu.HeaderText = "Doanh Thu";
            this.DoanhThu.MinimumWidth = 6;
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.Width = 125;
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 462);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.dgvBCDT);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCaoDoanhThu";
            this.Text = "frmBaoCaoDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batOnBookStoreDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBCDT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnChiTiet;
        private BatOnBookStoreDataSet batOnBookStoreDataSet;
        private System.Windows.Forms.BindingSource batOnBookStoreDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
    }
}