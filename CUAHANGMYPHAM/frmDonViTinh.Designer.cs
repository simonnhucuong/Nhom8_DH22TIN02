namespace CUAHANGMYPHAM
{
    partial class frmDonViTinh
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
            System.Windows.Forms.Label maMatHangLabel;
            System.Windows.Forms.Label label2;
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maMatHangTextBox = new System.Windows.Forms.TextBox();
            this.donGiaTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cHMPDataSet = new CUAHANGMYPHAM.CHMPDataSet();
            this.donViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donViTinhTableAdapter = new CUAHANGMYPHAM.CHMPDataSetTableAdapters.DonViTinhTableAdapter();
            this.tableAdapterManager = new CUAHANGMYPHAM.CHMPDataSetTableAdapters.TableAdapterManager();
            this.donViTinhDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            donGiaLabel = new System.Windows.Forms.Label();
            maMatHangLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cHMPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(995, 484);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 53);
            this.button3.TabIndex = 45;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(668, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 53);
            this.button1.TabIndex = 43;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(476, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 42;
            this.label1.Text = "ĐƠN VỊ TÍNH";
            // 
            // maMatHangTextBox
            // 
            this.maMatHangTextBox.Location = new System.Drawing.Point(71, 246);
            this.maMatHangTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maMatHangTextBox.Name = "maMatHangTextBox";
            this.maMatHangTextBox.Size = new System.Drawing.Size(427, 27);
            this.maMatHangTextBox.TabIndex = 37;
            // 
            // donGiaTextBox
            // 
            this.donGiaTextBox.Location = new System.Drawing.Point(71, 347);
            this.donGiaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.donGiaTextBox.Name = "donGiaTextBox";
            this.donGiaTextBox.Size = new System.Drawing.Size(427, 27);
            this.donGiaTextBox.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(841, 484);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 53);
            this.button2.TabIndex = 44;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            donGiaLabel.Location = new System.Drawing.Point(65, 296);
            donGiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(164, 31);
            donGiaLabel.TabIndex = 38;
            donGiaLabel.Text = "Tên Đơn vị:";
            // 
            // maMatHangLabel
            // 
            maMatHangLabel.AutoSize = true;
            maMatHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMatHangLabel.Location = new System.Drawing.Point(65, 194);
            maMatHangLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            maMatHangLabel.Name = "maMatHangLabel";
            maMatHangLabel.Size = new System.Drawing.Size(157, 31);
            maMatHangLabel.TabIndex = 36;
            maMatHangLabel.Text = "Mã Đơn Vị:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(65, 413);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(195, 31);
            label2.TabIndex = 47;
            label2.Text = "Mã Mặt Hàng:";
            // 
            // cHMPDataSet
            // 
            this.cHMPDataSet.DataSetName = "CHMPDataSet";
            this.cHMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donViTinhBindingSource
            // 
            this.donViTinhBindingSource.DataMember = "DonViTinh";
            this.donViTinhBindingSource.DataSource = this.cHMPDataSet;
            // 
            // donViTinhTableAdapter
            // 
            this.donViTinhTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DonGiaBanTableAdapter = null;
            this.tableAdapterManager.DonViTinhTableAdapter = this.donViTinhTableAdapter;
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
            // donViTinhDataGridView
            // 
            this.donViTinhDataGridView.AutoGenerateColumns = false;
            this.donViTinhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donViTinhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.donViTinhDataGridView.DataSource = this.donViTinhBindingSource;
            this.donViTinhDataGridView.Location = new System.Drawing.Point(668, 194);
            this.donViTinhDataGridView.Name = "donViTinhDataGridView";
            this.donViTinhDataGridView.RowHeadersWidth = 51;
            this.donViTinhDataGridView.RowTemplate.Height = 24;
            this.donViTinhDataGridView.Size = new System.Drawing.Size(450, 220);
            this.donViTinhDataGridView.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaDonVi";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaDonVi";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenDonVi";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenDonVi";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaMatHang";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaMatHang";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 484);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 27);
            this.textBox1.TabIndex = 49;
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.donViTinhDataGridView);
            this.Controls.Add(label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maMatHangTextBox);
            this.Controls.Add(this.donGiaTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(donGiaLabel);
            this.Controls.Add(maMatHangLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDonViTinh";
            this.Text = "frmDonViTinh";
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHMPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maMatHangTextBox;
        private System.Windows.Forms.TextBox donGiaTextBox;
        private System.Windows.Forms.Button button2;
        private CHMPDataSet cHMPDataSet;
        private System.Windows.Forms.BindingSource donViTinhBindingSource;
        private CHMPDataSetTableAdapters.DonViTinhTableAdapter donViTinhTableAdapter;
        private CHMPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView donViTinhDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textBox1;
    }
}