namespace CUAHANGMYPHAM
{
    partial class frmChiTietPhieuNhap
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label maMatHangLabel;
            System.Windows.Forms.Label tenMatHangLabel;
            System.Windows.Forms.Label maLoaiLabel;
            System.Windows.Forms.Label giaNhapLabel;
            System.Windows.Forms.Label donViTinhLabel;
            System.Windows.Forms.Label soLuongTonLabel;
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPN = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txMatMatHang = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.giaNhapTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTonTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtNhanVienNhap = new System.Windows.Forms.TextBox();
            this.txtMaPheuNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.chiTietPhieuNhapHangBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cHMPDataSet = new CUAHANGMYPHAM.CHMPDataSet();
            this.matHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietPhieuNhapHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietPhieuNhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chiTietPhieuNhapHangTableAdapter = new CUAHANGMYPHAM.CHMPDataSetTableAdapters.ChiTietPhieuNhapHangTableAdapter();
            this.tableAdapterManager = new CUAHANGMYPHAM.CHMPDataSetTableAdapters.TableAdapterManager();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            label6 = new System.Windows.Forms.Label();
            maMatHangLabel = new System.Windows.Forms.Label();
            tenMatHangLabel = new System.Windows.Forms.Label();
            maLoaiLabel = new System.Windows.Forms.Label();
            giaNhapLabel = new System.Windows.Forms.Label();
            donViTinhLabel = new System.Windows.Forms.Label();
            soLuongTonLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPN)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuNhapHangBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHMPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuNhapHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuNhapHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(32, 381);
            label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(115, 25);
            label6.TabIndex = 36;
            label6.Text = "Thành tiền";
            // 
            // maMatHangLabel
            // 
            maMatHangLabel.AutoSize = true;
            maMatHangLabel.Location = new System.Drawing.Point(32, 49);
            maMatHangLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            maMatHangLabel.Name = "maMatHangLabel";
            maMatHangLabel.Size = new System.Drawing.Size(137, 25);
            maMatHangLabel.TabIndex = 0;
            maMatHangLabel.Text = "Mã mặt hàng";
            // 
            // tenMatHangLabel
            // 
            tenMatHangLabel.AutoSize = true;
            tenMatHangLabel.Location = new System.Drawing.Point(32, 101);
            tenMatHangLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            tenMatHangLabel.Name = "tenMatHangLabel";
            tenMatHangLabel.Size = new System.Drawing.Size(145, 25);
            tenMatHangLabel.TabIndex = 2;
            tenMatHangLabel.Text = "Tên mặt hàng";
            // 
            // maLoaiLabel
            // 
            maLoaiLabel.AutoSize = true;
            maLoaiLabel.Location = new System.Drawing.Point(32, 154);
            maLoaiLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            maLoaiLabel.Name = "maLoaiLabel";
            maLoaiLabel.Size = new System.Drawing.Size(82, 25);
            maLoaiLabel.TabIndex = 4;
            maLoaiLabel.Text = "Mã loại";
            // 
            // giaNhapLabel
            // 
            giaNhapLabel.AutoSize = true;
            giaNhapLabel.Location = new System.Drawing.Point(32, 215);
            giaNhapLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            giaNhapLabel.Name = "giaNhapLabel";
            giaNhapLabel.Size = new System.Drawing.Size(99, 25);
            giaNhapLabel.TabIndex = 10;
            giaNhapLabel.Text = "Giá nhập";
            // 
            // donViTinhLabel
            // 
            donViTinhLabel.AutoSize = true;
            donViTinhLabel.Location = new System.Drawing.Point(32, 272);
            donViTinhLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            donViTinhLabel.Name = "donViTinhLabel";
            donViTinhLabel.Size = new System.Drawing.Size(114, 25);
            donViTinhLabel.TabIndex = 12;
            donViTinhLabel.Text = "Đơn vị tính";
            // 
            // soLuongTonLabel
            // 
            soLuongTonLabel.AutoSize = true;
            soLuongTonLabel.Location = new System.Drawing.Point(32, 324);
            soLuongTonLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            soLuongTonLabel.Name = "soLuongTonLabel";
            soLuongTonLabel.Size = new System.Drawing.Size(134, 25);
            soLuongTonLabel.TabIndex = 14;
            soLuongTonLabel.Text = "Số lượng tồn";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MintCream;
            this.groupBox3.Controls.Add(this.dgvChiTietPN);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(-2, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1507, 904);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            // 
            // dgvChiTietPN
            // 
            this.dgvChiTietPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPN.Location = new System.Drawing.Point(82, 619);
            this.dgvChiTietPN.Name = "dgvChiTietPN";
            this.dgvChiTietPN.RowHeadersWidth = 51;
            this.dgvChiTietPN.RowTemplate.Height = 24;
            this.dgvChiTietPN.Size = new System.Drawing.Size(1359, 247);
            this.dgvChiTietPN.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(maMatHangLabel);
            this.groupBox2.Controls.Add(this.txMatMatHang);
            this.groupBox2.Controls.Add(tenMatHangLabel);
            this.groupBox2.Controls.Add(this.txt);
            this.groupBox2.Controls.Add(maLoaiLabel);
            this.groupBox2.Controls.Add(giaNhapLabel);
            this.groupBox2.Controls.Add(this.giaNhapTextBox);
            this.groupBox2.Controls.Add(donViTinhLabel);
            this.groupBox2.Controls.Add(soLuongTonLabel);
            this.groupBox2.Controls.Add(this.soLuongTonTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(732, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(710, 445);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(279, 154);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(373, 33);
            this.comboBox4.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "SoLuongTon", true));
            this.textBox1.Location = new System.Drawing.Point(279, 381);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 30);
            this.textBox1.TabIndex = 37;
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(470, 324);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(8);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(182, 30);
            this.numericUpDown1.TabIndex = 35;
            // 
            // txMatMatHang
            // 
            this.txMatMatHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "MaMatHang", true));
            this.txMatMatHang.Location = new System.Drawing.Point(279, 44);
            this.txMatMatHang.Margin = new System.Windows.Forms.Padding(8);
            this.txMatMatHang.Name = "txMatMatHang";
            this.txMatMatHang.Size = new System.Drawing.Size(373, 30);
            this.txMatMatHang.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "TenMatHang", true));
            this.txt.Location = new System.Drawing.Point(279, 101);
            this.txt.Margin = new System.Windows.Forms.Padding(8);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(373, 30);
            this.txt.TabIndex = 3;
            // 
            // giaNhapTextBox
            // 
            this.giaNhapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "GiaNhap", true));
            this.giaNhapTextBox.Location = new System.Drawing.Point(279, 215);
            this.giaNhapTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.giaNhapTextBox.Name = "giaNhapTextBox";
            this.giaNhapTextBox.Size = new System.Drawing.Size(373, 30);
            this.giaNhapTextBox.TabIndex = 11;
            // 
            // soLuongTonTextBox
            // 
            this.soLuongTonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "SoLuongTon", true));
            this.soLuongTonTextBox.Location = new System.Drawing.Point(279, 272);
            this.soLuongTonTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.soLuongTonTextBox.Name = "soLuongTonTextBox";
            this.soLuongTonTextBox.Size = new System.Drawing.Size(373, 30);
            this.soLuongTonTextBox.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(575, 477);
            this.button5.Margin = new System.Windows.Forms.Padding(8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 55);
            this.button5.TabIndex = 42;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhaCungCap);
            this.groupBox1.Controls.Add(this.txtNhanVienNhap);
            this.groupBox1.Controls.Add(this.txtMaPheuNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(82, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(606, 275);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "TenMatHang", true));
            this.txtNhaCungCap.Location = new System.Drawing.Point(233, 101);
            this.txtNhaCungCap.Margin = new System.Windows.Forms.Padding(8);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(357, 30);
            this.txtNhaCungCap.TabIndex = 42;
            // 
            // txtNhanVienNhap
            // 
            this.txtNhanVienNhap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "TenMatHang", true));
            this.txtNhanVienNhap.Location = new System.Drawing.Point(233, 157);
            this.txtNhanVienNhap.Margin = new System.Windows.Forms.Padding(8);
            this.txtNhanVienNhap.Name = "txtNhanVienNhap";
            this.txtNhanVienNhap.Size = new System.Drawing.Size(357, 30);
            this.txtNhanVienNhap.TabIndex = 41;
            // 
            // txtMaPheuNhap
            // 
            this.txtMaPheuNhap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "TenMatHang", true));
            this.txtMaPheuNhap.Location = new System.Drawing.Point(233, 49);
            this.txtMaPheuNhap.Margin = new System.Windows.Forms.Padding(8);
            this.txtMaPheuNhap.Name = "txtMaPheuNhap";
            this.txtMaPheuNhap.Size = new System.Drawing.Size(357, 30);
            this.txtMaPheuNhap.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mã phiếu nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nhân viên nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ngày nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(265, 204);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(8);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(293, 30);
            this.dtpNgayNhap.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nhà cung cấp";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(424, 477);
            this.button3.Margin = new System.Windows.Forms.Padding(8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 55);
            this.button3.TabIndex = 40;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(258, 477);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 55);
            this.button2.TabIndex = 39;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(82, 477);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 55);
            this.button1.TabIndex = 38;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(539, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(381, 38);
            this.label11.TabIndex = 35;
            this.label11.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // chiTietPhieuNhapHangBindingSource2
            // 
            this.chiTietPhieuNhapHangBindingSource2.DataMember = "ChiTietPhieuNhapHang";
            this.chiTietPhieuNhapHangBindingSource2.DataSource = this.cHMPDataSet;
            // 
            // cHMPDataSet
            // 
            this.cHMPDataSet.DataSetName = "CHMPDataSet";
            this.cHMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matHangBindingSource1
            // 
            this.matHangBindingSource1.DataMember = "MatHang";
            // 
            // chiTietPhieuNhapHangBindingSource1
            // 
            this.chiTietPhieuNhapHangBindingSource1.DataMember = "ChiTietPhieuNhapHang";
            // 
            // chiTietPhieuNhapHangBindingSource
            // 
            this.chiTietPhieuNhapHangBindingSource.DataMember = "ChiTietPhieuNhapHang";
            // 
            // chiTietPhieuNhapHangTableAdapter
            // 
            this.chiTietPhieuNhapHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoPhanTableAdapter = null;
            this.tableAdapterManager.ChiTietHoaDonBanHangTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuChiTienTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuNhapHangTableAdapter = this.chiTietPhieuNhapHangTableAdapter;
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
            // frmChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1505, 928);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmChiTietPhieuNhap";
            this.Text = "frmChiTietPhieuNhap";
            this.Load += new System.EventHandler(this.frmChiTietPhieu_hap_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuNhapHangBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHMPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuNhapHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuNhapHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource chiTietPhieuNhapHangBindingSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txMatMatHang;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox giaNhapTextBox;
        private System.Windows.Forms.TextBox soLuongTonTextBox;
        private System.Windows.Forms.BindingSource matHangBindingSource1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource chiTietPhieuNhapHangBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox4;
        private CHMPDataSet cHMPDataSet;
        private System.Windows.Forms.BindingSource chiTietPhieuNhapHangBindingSource2;
        private CHMPDataSetTableAdapters.ChiTietPhieuNhapHangTableAdapter chiTietPhieuNhapHangTableAdapter;
        private CHMPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvChiTietPN;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.TextBox txtNhanVienNhap;
        private System.Windows.Forms.TextBox txtMaPheuNhap;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}