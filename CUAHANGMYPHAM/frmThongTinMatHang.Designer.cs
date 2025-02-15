namespace CUAHANGMYPHAM
{
    partial class frmThongTinMatHang
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
            System.Windows.Forms.Label maMatHangLabel;
            System.Windows.Forms.Label tenMatHangLabel;
            System.Windows.Forms.Label maLoaiLabel;
            System.Windows.Forms.Label maThuongHieuLabel;
            System.Windows.Forms.Label maNhaCungCapLabel;
            System.Windows.Forms.Label giaNhapLabel;
            System.Windows.Forms.Label donViTinhLabel;
            System.Windows.Forms.Label soLuongTonLabel;
            System.Windows.Forms.Label moTaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.rbxMoTa = new System.Windows.Forms.RichTextBox();
            this.cbxDonViTinh = new System.Windows.Forms.ComboBox();
            this.cbxMaNCC = new System.Windows.Forms.ComboBox();
            this.cbxMaThuongHieu = new System.Windows.Forms.ComboBox();
            this.cbxMaLoai = new System.Windows.Forms.ComboBox();
            this.txtMaMatHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.sqlDataAdapter2 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.dgVThongTinDangNhap = new System.Windows.Forms.DataGridView();
            maMatHangLabel = new System.Windows.Forms.Label();
            tenMatHangLabel = new System.Windows.Forms.Label();
            maLoaiLabel = new System.Windows.Forms.Label();
            maThuongHieuLabel = new System.Windows.Forms.Label();
            maNhaCungCapLabel = new System.Windows.Forms.Label();
            giaNhapLabel = new System.Windows.Forms.Label();
            donViTinhLabel = new System.Windows.Forms.Label();
            soLuongTonLabel = new System.Windows.Forms.Label();
            moTaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVThongTinDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // maMatHangLabel
            // 
            maMatHangLabel.AutoSize = true;
            maMatHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMatHangLabel.Location = new System.Drawing.Point(28, 42);
            maMatHangLabel.Name = "maMatHangLabel";
            maMatHangLabel.Size = new System.Drawing.Size(202, 32);
            maMatHangLabel.TabIndex = 2;
            maMatHangLabel.Text = "Mã Mặt Hàng:";
            // 
            // tenMatHangLabel
            // 
            tenMatHangLabel.AutoSize = true;
            tenMatHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenMatHangLabel.Location = new System.Drawing.Point(28, 92);
            tenMatHangLabel.Name = "tenMatHangLabel";
            tenMatHangLabel.Size = new System.Drawing.Size(213, 32);
            tenMatHangLabel.TabIndex = 4;
            tenMatHangLabel.Text = "Tên Mặt Hàng:";
            // 
            // maLoaiLabel
            // 
            maLoaiLabel.AutoSize = true;
            maLoaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLoaiLabel.Location = new System.Drawing.Point(28, 149);
            maLoaiLabel.Name = "maLoaiLabel";
            maLoaiLabel.Size = new System.Drawing.Size(131, 32);
            maLoaiLabel.TabIndex = 6;
            maLoaiLabel.Text = "Mã Loại:";
            // 
            // maThuongHieuLabel
            // 
            maThuongHieuLabel.AutoSize = true;
            maThuongHieuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maThuongHieuLabel.Location = new System.Drawing.Point(28, 202);
            maThuongHieuLabel.Name = "maThuongHieuLabel";
            maThuongHieuLabel.Size = new System.Drawing.Size(246, 32);
            maThuongHieuLabel.TabIndex = 8;
            maThuongHieuLabel.Text = "Mã Thương Hiệu:";
            // 
            // maNhaCungCapLabel
            // 
            maNhaCungCapLabel.AutoSize = true;
            maNhaCungCapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maNhaCungCapLabel.Location = new System.Drawing.Point(28, 262);
            maNhaCungCapLabel.Name = "maNhaCungCapLabel";
            maNhaCungCapLabel.Size = new System.Drawing.Size(270, 32);
            maNhaCungCapLabel.TabIndex = 10;
            maNhaCungCapLabel.Text = "Mã Nhà Cung Cấp:";
            // 
            // giaNhapLabel
            // 
            giaNhapLabel.AutoSize = true;
            giaNhapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaNhapLabel.Location = new System.Drawing.Point(28, 319);
            giaNhapLabel.Name = "giaNhapLabel";
            giaNhapLabel.Size = new System.Drawing.Size(151, 32);
            giaNhapLabel.TabIndex = 12;
            giaNhapLabel.Text = "Giá Nhập:";
            // 
            // donViTinhLabel
            // 
            donViTinhLabel.AutoSize = true;
            donViTinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            donViTinhLabel.Location = new System.Drawing.Point(28, 373);
            donViTinhLabel.Name = "donViTinhLabel";
            donViTinhLabel.Size = new System.Drawing.Size(182, 32);
            donViTinhLabel.TabIndex = 14;
            donViTinhLabel.Text = "Đơn Vị Tính:";
            // 
            // soLuongTonLabel
            // 
            soLuongTonLabel.AutoSize = true;
            soLuongTonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongTonLabel.Location = new System.Drawing.Point(28, 432);
            soLuongTonLabel.Name = "soLuongTonLabel";
            soLuongTonLabel.Size = new System.Drawing.Size(213, 32);
            soLuongTonLabel.TabIndex = 16;
            soLuongTonLabel.Text = "Số Lượng Tồn:";
            // 
            // moTaLabel
            // 
            moTaLabel.AutoSize = true;
            moTaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            moTaLabel.Location = new System.Drawing.Point(28, 485);
            moTaLabel.Name = "moTaLabel";
            moTaLabel.Size = new System.Drawing.Size(107, 32);
            moTaLabel.TabIndex = 18;
            moTaLabel.Text = "Mô Tả:";
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoLuongTon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "GiaNhap", true));
            this.txtSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(319, 430);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(339, 34);
            this.txtSoLuongTon.TabIndex = 42;
            // 
            // rbxMoTa
            // 
            this.rbxMoTa.Location = new System.Drawing.Point(155, 511);
            this.rbxMoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbxMoTa.Name = "rbxMoTa";
            this.rbxMoTa.Size = new System.Drawing.Size(503, 142);
            this.rbxMoTa.TabIndex = 41;
            this.rbxMoTa.Text = "";
            // 
            // cbxDonViTinh
            // 
            this.cbxDonViTinh.FormattingEnabled = true;
            this.cbxDonViTinh.Location = new System.Drawing.Point(319, 375);
            this.cbxDonViTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDonViTinh.Name = "cbxDonViTinh";
            this.cbxDonViTinh.Size = new System.Drawing.Size(339, 33);
            this.cbxDonViTinh.TabIndex = 40;
            // 
            // cbxMaNCC
            // 
            this.cbxMaNCC.FormattingEnabled = true;
            this.cbxMaNCC.Location = new System.Drawing.Point(327, 261);
            this.cbxMaNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMaNCC.Name = "cbxMaNCC";
            this.cbxMaNCC.Size = new System.Drawing.Size(339, 33);
            this.cbxMaNCC.TabIndex = 39;
            // 
            // cbxMaThuongHieu
            // 
            this.cbxMaThuongHieu.FormattingEnabled = true;
            this.cbxMaThuongHieu.Location = new System.Drawing.Point(319, 204);
            this.cbxMaThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMaThuongHieu.Name = "cbxMaThuongHieu";
            this.cbxMaThuongHieu.Size = new System.Drawing.Size(339, 33);
            this.cbxMaThuongHieu.TabIndex = 38;
            // 
            // cbxMaLoai
            // 
            this.cbxMaLoai.FormattingEnabled = true;
            this.cbxMaLoai.Location = new System.Drawing.Point(319, 146);
            this.cbxMaLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMaLoai.Name = "cbxMaLoai";
            this.cbxMaLoai.Size = new System.Drawing.Size(339, 33);
            this.cbxMaLoai.TabIndex = 37;
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaMatHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "MaMatHang", true));
            this.txtMaMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMatHang.Location = new System.Drawing.Point(319, 39);
            this.txtMaMatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.Size = new System.Drawing.Size(339, 34);
            this.txtMaMatHang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(550, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 38);
            this.label2.TabIndex = 57;
            this.label2.Text = "THÔNG TIN MẶT HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, -42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 56;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "TenMatHang", true));
            this.txtTenMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMatHang.Location = new System.Drawing.Point(319, 95);
            this.txtTenMatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(339, 30);
            this.txtTenMatHang.TabIndex = 5;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGiaNhap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "GiaNhap", true));
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(319, 319);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(339, 34);
            this.txtGiaNhap.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.txtSoLuongTon);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.rbxMoTa);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.cbxDonViTinh);
            this.groupBox1.Controls.Add(this.cbxMaNCC);
            this.groupBox1.Controls.Add(this.cbxMaThuongHieu);
            this.groupBox1.Controls.Add(this.cbxMaLoai);
            this.groupBox1.Controls.Add(maMatHangLabel);
            this.groupBox1.Controls.Add(this.txtMaMatHang);
            this.groupBox1.Controls.Add(tenMatHangLabel);
            this.groupBox1.Controls.Add(this.txtTenMatHang);
            this.groupBox1.Controls.Add(maLoaiLabel);
            this.groupBox1.Controls.Add(maThuongHieuLabel);
            this.groupBox1.Controls.Add(maNhaCungCapLabel);
            this.groupBox1.Controls.Add(giaNhapLabel);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(donViTinhLabel);
            this.groupBox1.Controls.Add(soLuongTonLabel);
            this.groupBox1.Controls.Add(moTaLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(753, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(707, 751);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mặt hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(538, 685);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 43);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(251, 685);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 43);
            this.btnThem.TabIndex = 60;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(390, 685);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 43);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(80, 685);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(130, 43);
            this.btnCapNhat.TabIndex = 58;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // dgVThongTinDangNhap
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVThongTinDangNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVThongTinDangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVThongTinDangNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgVThongTinDangNhap.Location = new System.Drawing.Point(59, 160);
            this.dgVThongTinDangNhap.Name = "dgVThongTinDangNhap";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVThongTinDangNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgVThongTinDangNhap.RowHeadersWidth = 51;
            this.dgVThongTinDangNhap.RowTemplate.Height = 24;
            this.dgVThongTinDangNhap.Size = new System.Drawing.Size(660, 581);
            this.dgVThongTinDangNhap.TabIndex = 59;
            // 
            // frmThongTinMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1489, 892);
            this.Controls.Add(this.dgVThongTinDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongTinMatHang";
            this.Text = "frmThongTinMatHang";
            this.Load += new System.EventHandler(this.frmThongTinMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVThongTinDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.RichTextBox rbxMoTa;
        private System.Windows.Forms.ComboBox cbxDonViTinh;
        private System.Windows.Forms.ComboBox cbxMaNCC;
        private System.Windows.Forms.ComboBox cbxMaThuongHieu;
        private System.Windows.Forms.ComboBox cbxMaLoai;
        private System.Windows.Forms.TextBox txtMaMatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
        private System.Windows.Forms.DataGridView dgVThongTinDangNhap;
    }
}