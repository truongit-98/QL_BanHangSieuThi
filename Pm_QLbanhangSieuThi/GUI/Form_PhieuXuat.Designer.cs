﻿namespace GUI
{
    partial class Form_PhieuXuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbSohieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNguoigiao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKhoNhap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.dtgvDsHangXuat = new System.Windows.Forms.DataGridView();
            this.btnGhiSo = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.dateTimePickerNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDiaDiem = new System.Windows.Forms.TextBox();
            this.btnDsPhieuXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số chứng từ:";
            // 
            // txbSohieu
            // 
            this.txbSohieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSohieu.Location = new System.Drawing.Point(131, 12);
            this.txbSohieu.Name = "txbSohieu";
            this.txbSohieu.Size = new System.Drawing.Size(100, 20);
            this.txbSohieu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày HĐ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Người nhận hàng:";
            // 
            // txbNguoigiao
            // 
            this.txbNguoigiao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNguoigiao.Location = new System.Drawing.Point(131, 88);
            this.txbNguoigiao.Name = "txbNguoigiao";
            this.txbNguoigiao.Size = new System.Drawing.Size(197, 20);
            this.txbNguoigiao.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kho xuất:";
            // 
            // cbKhoNhap
            // 
            this.cbKhoNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoNhap.FormattingEnabled = true;
            this.cbKhoNhap.Location = new System.Drawing.Point(131, 122);
            this.cbKhoNhap.Name = "cbKhoNhap";
            this.cbKhoNhap.Size = new System.Drawing.Size(197, 21);
            this.cbKhoNhap.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã NV:";
            // 
            // txbMaNV
            // 
            this.txbMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMaNV.Location = new System.Drawing.Point(496, 83);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.ReadOnly = true;
            this.txbMaNV.Size = new System.Drawing.Size(186, 20);
            this.txbMaNV.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên NV:";
            // 
            // txbTenNV
            // 
            this.txbTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTenNV.Location = new System.Drawing.Point(496, 122);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.ReadOnly = true;
            this.txbTenNV.Size = new System.Drawing.Size(186, 20);
            this.txbTenNV.TabIndex = 14;
            // 
            // dtgvDsHangXuat
            // 
            this.dtgvDsHangXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dtgvDsHangXuat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvDsHangXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsHangXuat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgvDsHangXuat.EnableHeadersVisualStyles = false;
            this.dtgvDsHangXuat.Location = new System.Drawing.Point(29, 190);
            this.dtgvDsHangXuat.Name = "dtgvDsHangXuat";
            this.dtgvDsHangXuat.Size = new System.Drawing.Size(743, 207);
            this.dtgvDsHangXuat.TabIndex = 15;
            this.dtgvDsHangXuat.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDsHangNhap_CellValueChanged);
            // 
            // btnGhiSo
            // 
            this.btnGhiSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhiSo.Location = new System.Drawing.Point(690, 404);
            this.btnGhiSo.Name = "btnGhiSo";
            this.btnGhiSo.Size = new System.Drawing.Size(83, 26);
            this.btnGhiSo.TabIndex = 16;
            this.btnGhiSo.Text = "Ghi sổ";
            this.btnGhiSo.UseVisualStyleBackColor = true;
            this.btnGhiSo.Click += new System.EventHandler(this.btnGhiSo_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Location = new System.Drawing.Point(689, 436);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(83, 26);
            this.btnHuyBo.TabIndex = 17;
            this.btnHuyBo.Text = "Huỷ bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // dateTimePickerNgayLapPhieu
            // 
            this.dateTimePickerNgayLapPhieu.Location = new System.Drawing.Point(131, 47);
            this.dateTimePickerNgayLapPhieu.Name = "dateTimePickerNgayLapPhieu";
            this.dateTimePickerNgayLapPhieu.Size = new System.Drawing.Size(197, 20);
            this.dateTimePickerNgayLapPhieu.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Địa điểm:";
            // 
            // txbDiaDiem
            // 
            this.txbDiaDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDiaDiem.Location = new System.Drawing.Point(131, 151);
            this.txbDiaDiem.Name = "txbDiaDiem";
            this.txbDiaDiem.Size = new System.Drawing.Size(197, 20);
            this.txbDiaDiem.TabIndex = 21;
            // 
            // btnDsPhieuXuat
            // 
            this.btnDsPhieuXuat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDsPhieuXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDsPhieuXuat.Image = global::GUI.Properties.Resources.Data_View_Details_icon__1_;
            this.btnDsPhieuXuat.Location = new System.Drawing.Point(228, 12);
            this.btnDsPhieuXuat.Name = "btnDsPhieuXuat";
            this.btnDsPhieuXuat.Size = new System.Drawing.Size(21, 21);
            this.btnDsPhieuXuat.TabIndex = 23;
            this.btnDsPhieuXuat.UseVisualStyleBackColor = false;
            this.btnDsPhieuXuat.Click += new System.EventHandler(this.btnDsPhieuXuat_Click);
            // 
            // Form_PhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 481);
            this.Controls.Add(this.btnDsPhieuXuat);
            this.Controls.Add(this.txbDiaDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerNgayLapPhieu);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnGhiSo);
            this.Controls.Add(this.dtgvDsHangXuat);
            this.Controls.Add(this.txbTenNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbKhoNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbNguoigiao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSohieu);
            this.Controls.Add(this.label1);
            this.Name = "Form_PhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQL_NhapKho";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSohieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNguoigiao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKhoNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.DataGridView dtgvDsHangXuat;
        private System.Windows.Forms.Button btnGhiSo;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLapPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDiaDiem;
        private System.Windows.Forms.Button btnDsPhieuXuat;
    }
}