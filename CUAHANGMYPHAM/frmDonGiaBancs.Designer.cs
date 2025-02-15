namespace CUAHANGMYPHAM
{
    partial class frmDonGiaBancs
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
            System.Windows.Forms.Label donGiaLabel;
            System.Windows.Forms.Label thoiDiemCapNhatLabel;
            System.Windows.Forms.Label maMatHangLabel;
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maMatHangTextBox = new System.Windows.Forms.TextBox();
            this.donGiaTextBox = new System.Windows.Forms.TextBox();
            this.thoiDiemCapNhatDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.cHMPDataSet = new CUAHANGMYPHAM.CHMPDataSet();
            this.donGiaBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donGiaBanTableAdapter = new CUAHANGMYPHAM.CHMPDataSetTableAdapters.DonGiaBanTableAdapter();
            this.tableAdapterManager = new CUAHANGMYPHAM.CHMPDataSetTableAdapters.TableAdapterManager();
            this.donGiaBanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            donGiaLabel = new System.Windows.Forms.Label();
            thoiDiemCapNhatLabel = new System.Windows.Forms.Label();
            maMatHangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cHMPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaBanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            donGiaLabel.Location = new System.Drawing.Point(75, 301);
            donGiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(129, 31);
            donGiaLabel.TabIndex = 26;
            donGiaLabel.Text = "Don Gia:";
            // 
            // thoiDiemCapNhatLabel
            // 
            thoiDiemCapNhatLabel.AutoSize = true;
            thoiDiemCapNhatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            thoiDiemCapNhatLabel.Location = new System.Drawing.Point(75, 394);
            thoiDiemCapNhatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            thoiDiemCapNhatLabel.Name = "thoiDiemCapNhatLabel";
            thoiDiemCapNhatLabel.Size = new System.Drawing.Size(286, 31);
            thoiDiemCapNhatLabel.TabIndex = 28;
            thoiDiemCapNhatLabel.Text = "Thoi Diem Cap Nhat:";
            // 
            // maMatHangLabel
            // 
            maMatHangLabel.AutoSize = true;
            maMatHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMatHangLabel.Location = new System.Drawing.Point(75, 199);
            maMatHangLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            maMatHangLabel.Name = "maMatHangLabel";
            maMatHangLabel.Size = new System.Drawing.Size(195, 31);
            maMatHangLabel.TabIndex = 24;
            maMatHangLabel.Text = "Ma Mat Hang:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1005, 489);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 53);
            this.button3.TabIndex = 34;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(678, 489);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 53);
            this.button1.TabIndex = 32;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(461, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "ĐƠN GIÁ BÁN";
            // 
            // maMatHangTextBox
            // 
            this.maMatHangTextBox.Location = new System.Drawing.Point(81, 251);
            this.maMatHangTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maMatHangTextBox.Name = "maMatHangTextBox";
            this.maMatHangTextBox.Size = new System.Drawing.Size(427, 27);
            this.maMatHangTextBox.TabIndex = 25;
            // 
            // donGiaTextBox
            // 
            this.donGiaTextBox.Location = new System.Drawing.Point(81, 352);
            this.donGiaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.donGiaTextBox.Name = "donGiaTextBox";
            this.donGiaTextBox.Size = new System.Drawing.Size(427, 27);
            this.donGiaTextBox.TabIndex = 27;
            // 
            // thoiDiemCapNhatDateTimePicker
            // 
            this.thoiDiemCapNhatDateTimePicker.Location = new System.Drawing.Point(81, 458);
            this.thoiDiemCapNhatDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.thoiDiemCapNhatDateTimePicker.Name = "thoiDiemCapNhatDateTimePicker";
            this.thoiDiemCapNhatDateTimePicker.Size = new System.Drawing.Size(427, 27);
            this.thoiDiemCapNhatDateTimePicker.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(851, 489);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 53);
            this.button2.TabIndex = 33;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cHMPDataSet
            // 
            this.cHMPDataSet.DataSetName = "CHMPDataSet";
            this.cHMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donGiaBanBindingSource
            // 
            this.donGiaBanBindingSource.DataMember = "DonGiaBan";
            this.donGiaBanBindingSource.DataSource = this.cHMPDataSet;
            // 
            // donGiaBanTableAdapter
            // 
            this.donGiaBanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoPhanTableAdapter = null;
            this.tableAdapterManager.ChiTietHoaDonBanHangTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuChiTienTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuNhapHangTableAdapter = null;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.CongTacTableAdapter = null;
            this.tableAdapterManager.DonGiaBanTableAdapter = this.donGiaBanTableAdapter;
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
            // donGiaBanDataGridView
            // 
            this.donGiaBanDataGridView.AutoGenerateColumns = false;
            this.donGiaBanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donGiaBanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.donGiaBanDataGridView.DataSource = this.donGiaBanBindingSource;
            this.donGiaBanDataGridView.Location = new System.Drawing.Point(678, 199);
            this.donGiaBanDataGridView.Name = "donGiaBanDataGridView";
            this.donGiaBanDataGridView.RowHeadersWidth = 51;
            this.donGiaBanDataGridView.RowTemplate.Height = 24;
            this.donGiaBanDataGridView.Size = new System.Drawing.Size(450, 229);
            this.donGiaBanDataGridView.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaMatHang";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaMatHang";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn2.HeaderText = "DonGia";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ThoiDiemCapNhat";
            this.dataGridViewTextBoxColumn3.HeaderText = "ThoiDiemCapNhat";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // frmDonGiaBancs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.donGiaBanDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maMatHangTextBox);
            this.Controls.Add(this.donGiaTextBox);
            this.Controls.Add(this.thoiDiemCapNhatDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(donGiaLabel);
            this.Controls.Add(thoiDiemCapNhatLabel);
            this.Controls.Add(maMatHangLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDonGiaBancs";
            this.Text = "frmDonGiaBancs";
            this.Load += new System.EventHandler(this.frmDonGiaBancs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHMPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaBanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maMatHangTextBox;
        private System.Windows.Forms.TextBox donGiaTextBox;
        private System.Windows.Forms.DateTimePicker thoiDiemCapNhatDateTimePicker;
        private System.Windows.Forms.Button button2;
        private CHMPDataSet cHMPDataSet;
        private System.Windows.Forms.BindingSource donGiaBanBindingSource;
        private CHMPDataSetTableAdapters.DonGiaBanTableAdapter donGiaBanTableAdapter;
        private CHMPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView donGiaBanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}