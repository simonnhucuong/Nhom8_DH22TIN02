namespace CUAHANGMYPHAM
{
    partial class frmChiTietHoaDon
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
            System.Windows.Forms.Label maHoaDonLabel;
            System.Windows.Forms.Label maMatHangLabel;
            System.Windows.Forms.Label soLuongBanLabel;
            System.Windows.Forms.Label donGiaBanLabel;
            System.Windows.Forms.Label thanhTienLabel;
            this.donGiaBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHoaDonBanHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonBanHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maHoaDonTextBox = new System.Windows.Forms.TextBox();
            this.maMatHangTextBox = new System.Windows.Forms.TextBox();
            this.donGiaBanTextBox = new System.Windows.Forms.TextBox();
            this.thanhTienTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cHMPDataSet = new CUAHANGMYPHAM.CHMPDataSet();
            this.chiTietHoaDonBanHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHoaDonBanHangTableAdapter = new CUAHANGMYPHAM.CHMPDataSetTableAdapters.ChiTietHoaDonBanHangTableAdapter();
            this.tableAdapterManager = new CUAHANGMYPHAM.CHMPDataSetTableAdapters.TableAdapterManager();
            this.chiTietHoaDonBanHangDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            maHoaDonLabel = new System.Windows.Forms.Label();
            maMatHangLabel = new System.Windows.Forms.Label();
            soLuongBanLabel = new System.Windows.Forms.Label();
            donGiaBanLabel = new System.Windows.Forms.Label();
            thanhTienLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBanHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHMPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBanHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBanHangDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maHoaDonLabel
            // 
            maHoaDonLabel.AutoSize = true;
            maHoaDonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maHoaDonLabel.Location = new System.Drawing.Point(335, 113);
            maHoaDonLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            maHoaDonLabel.Name = "maHoaDonLabel";
            maHoaDonLabel.Size = new System.Drawing.Size(139, 25);
            maHoaDonLabel.TabIndex = 72;
            maHoaDonLabel.Text = "Ma Hoa Don:";
            // 
            // maMatHangLabel
            // 
            maMatHangLabel.AutoSize = true;
            maMatHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMatHangLabel.Location = new System.Drawing.Point(335, 181);
            maMatHangLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            maMatHangLabel.Name = "maMatHangLabel";
            maMatHangLabel.Size = new System.Drawing.Size(148, 25);
            maMatHangLabel.TabIndex = 75;
            maMatHangLabel.Text = "Ma Mat Hang:";
            // 
            // soLuongBanLabel
            // 
            soLuongBanLabel.AutoSize = true;
            soLuongBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongBanLabel.Location = new System.Drawing.Point(333, 246);
            soLuongBanLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            soLuongBanLabel.Name = "soLuongBanLabel";
            soLuongBanLabel.Size = new System.Drawing.Size(156, 25);
            soLuongBanLabel.TabIndex = 77;
            soLuongBanLabel.Text = "So Luong Ban:";
            // 
            // donGiaBanLabel
            // 
            donGiaBanLabel.AutoSize = true;
            donGiaBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            donGiaBanLabel.Location = new System.Drawing.Point(333, 308);
            donGiaBanLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            donGiaBanLabel.Name = "donGiaBanLabel";
            donGiaBanLabel.Size = new System.Drawing.Size(141, 25);
            donGiaBanLabel.TabIndex = 78;
            donGiaBanLabel.Text = "Don Gia Ban:";
            // 
            // thanhTienLabel
            // 
            thanhTienLabel.AutoSize = true;
            thanhTienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            thanhTienLabel.Location = new System.Drawing.Point(335, 384);
            thanhTienLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            thanhTienLabel.Name = "thanhTienLabel";
            thanhTienLabel.Size = new System.Drawing.Size(130, 25);
            thanhTienLabel.TabIndex = 80;
            thanhTienLabel.Text = "Thanh Tien:";
            // 
            // donGiaBanBindingSource
            // 
            this.donGiaBanBindingSource.DataMember = "DonGiaBan";
            // 
            // chiTietHoaDonBanHangBindingSource
            // 
            this.chiTietHoaDonBanHangBindingSource.DataMember = "ChiTietHoaDonBanHang";
            // 
            // hoaDonBanHangBindingSource
            // 
            this.hoaDonBanHangBindingSource.DataMember = "HoaDonBanHang";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(825, 241);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(8);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(290, 30);
            this.numericUpDown1.TabIndex = 84;
            // 
            // maHoaDonTextBox
            // 
            this.maHoaDonTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.maHoaDonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietHoaDonBanHangBindingSource, "MaHoaDon", true));
            this.maHoaDonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maHoaDonTextBox.Location = new System.Drawing.Point(589, 113);
            this.maHoaDonTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.maHoaDonTextBox.Name = "maHoaDonTextBox";
            this.maHoaDonTextBox.Size = new System.Drawing.Size(526, 30);
            this.maHoaDonTextBox.TabIndex = 74;
            // 
            // maMatHangTextBox
            // 
            this.maMatHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietHoaDonBanHangBindingSource, "MaMatHang", true));
            this.maMatHangTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maMatHangTextBox.Location = new System.Drawing.Point(589, 176);
            this.maMatHangTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.maMatHangTextBox.Name = "maMatHangTextBox";
            this.maMatHangTextBox.Size = new System.Drawing.Size(526, 30);
            this.maMatHangTextBox.TabIndex = 76;
            // 
            // donGiaBanTextBox
            // 
            this.donGiaBanTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.donGiaBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietHoaDonBanHangBindingSource, "DonGiaBan", true));
            this.donGiaBanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGiaBanTextBox.Location = new System.Drawing.Point(589, 303);
            this.donGiaBanTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.donGiaBanTextBox.Name = "donGiaBanTextBox";
            this.donGiaBanTextBox.Size = new System.Drawing.Size(526, 30);
            this.donGiaBanTextBox.TabIndex = 79;
            // 
            // thanhTienTextBox
            // 
            this.thanhTienTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.thanhTienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietHoaDonBanHangBindingSource, "ThanhTien", true));
            this.thanhTienTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhTienTextBox.Location = new System.Drawing.Point(589, 379);
            this.thanhTienTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.thanhTienTextBox.Name = "thanhTienTextBox";
            this.thanhTienTextBox.Size = new System.Drawing.Size(526, 30);
            this.thanhTienTextBox.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(582, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 39);
            this.label1.TabIndex = 69;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // cHMPDataSet
            // 
            this.cHMPDataSet.DataSetName = "CHMPDataSet";
            this.cHMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietHoaDonBanHangBindingSource1
            // 
            this.chiTietHoaDonBanHangBindingSource1.DataMember = "ChiTietHoaDonBanHang";
            this.chiTietHoaDonBanHangBindingSource1.DataSource = this.cHMPDataSet;
            // 
            // chiTietHoaDonBanHangTableAdapter
            // 
            this.chiTietHoaDonBanHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoPhanTableAdapter = null;
            this.tableAdapterManager.ChiTietHoaDonBanHangTableAdapter = this.chiTietHoaDonBanHangTableAdapter;
            this.tableAdapterManager.ChiTietPhieuChiTienTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuNhapHangTableAdapter = null;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.CongTacTableAdapter = null;
            this.tableAdapterManager.DonGiaBanTableAdapter = null;
            this.tableAdapterManager.DonViTinhTableAdapter = null;
            this.tableAdapterManager.HoaDonBanHangTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.MatHangTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuChiTienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapHangTableAdapter = null;
            this.tableAdapterManager.ProductArchiveTableAdapter = null;
            this.tableAdapterManager.TaiKhoanDangNhapTableAdapter = null;
            this.tableAdapterManager.ThuongHieuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CUAHANGMYPHAM.CHMPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chiTietHoaDonBanHangDataGridView
            // 
            this.chiTietHoaDonBanHangDataGridView.AutoGenerateColumns = false;
            this.chiTietHoaDonBanHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiTietHoaDonBanHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.chiTietHoaDonBanHangDataGridView.DataSource = this.chiTietHoaDonBanHangBindingSource1;
            this.chiTietHoaDonBanHangDataGridView.Location = new System.Drawing.Point(177, 532);
            this.chiTietHoaDonBanHangDataGridView.Name = "chiTietHoaDonBanHangDataGridView";
            this.chiTietHoaDonBanHangDataGridView.RowHeadersWidth = 51;
            this.chiTietHoaDonBanHangDataGridView.RowTemplate.Height = 24;
            this.chiTietHoaDonBanHangDataGridView.Size = new System.Drawing.Size(1083, 220);
            this.chiTietHoaDonBanHangDataGridView.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHoaDon";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHoaDon";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaMatHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaMatHang";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuongBan";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoLuongBan";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DonGiaBan";
            this.dataGridViewTextBoxColumn4.HeaderText = "DonGiaBan";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ThanhTien";
            this.dataGridViewTextBoxColumn5.HeaderText = "ThanhTien";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1133, 457);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 44);
            this.button7.TabIndex = 90;
            this.button7.Text = "Xóa";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(957, 457);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 44);
            this.button6.TabIndex = 89;
            this.button6.Text = "Lưu";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(763, 457);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 44);
            this.button5.TabIndex = 88;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1516, 803);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.chiTietHoaDonBanHangDataGridView);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(maHoaDonLabel);
            this.Controls.Add(this.maHoaDonTextBox);
            this.Controls.Add(maMatHangLabel);
            this.Controls.Add(this.maMatHangTextBox);
            this.Controls.Add(soLuongBanLabel);
            this.Controls.Add(donGiaBanLabel);
            this.Controls.Add(this.donGiaBanTextBox);
            this.Controls.Add(thanhTienLabel);
            this.Controls.Add(this.thanhTienTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmChiTietHoaDon";
            this.Text = "frmChiTietHoaDon";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donGiaBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBanHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHMPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBanHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBanHangDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource donGiaBanBindingSource;
        private System.Windows.Forms.BindingSource chiTietHoaDonBanHangBindingSource;
        private System.Windows.Forms.BindingSource hoaDonBanHangBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox maHoaDonTextBox;
        private System.Windows.Forms.TextBox maMatHangTextBox;
        private System.Windows.Forms.TextBox donGiaBanTextBox;
        private System.Windows.Forms.TextBox thanhTienTextBox;
        private System.Windows.Forms.Label label1;
        private CHMPDataSet cHMPDataSet;
        private System.Windows.Forms.BindingSource chiTietHoaDonBanHangBindingSource1;
        private CHMPDataSetTableAdapters.ChiTietHoaDonBanHangTableAdapter chiTietHoaDonBanHangTableAdapter;
        private CHMPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView chiTietHoaDonBanHangDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}