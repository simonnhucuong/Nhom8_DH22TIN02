namespace CUAHANGMYPHAM
{
    partial class frmThietLap
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
            System.Windows.Forms.Label lblMaNhanVien;
            System.Windows.Forms.Label lblTenNhanVien;
            System.Windows.Forms.Label lblNgaySinh;
            System.Windows.Forms.Label lblGioiTinh;
            System.Windows.Forms.Label lblDienThoai;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblSoTaiKhoan;
            this.label12 = new System.Windows.Forms.Label();
            this.dgVTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnThoatTaiKhoan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaNhanVientab2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBxThuocQuyen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chBHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHMPDataSet = new CUAHANGMYPHAM.CHMPDataSet();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblQuanLiNhanVien = new System.Windows.Forms.Label();
            this.gBxHienThi = new System.Windows.Forms.GroupBox();
            this.dgVNhanVien = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.gBxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.chBxGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoTaiKhoan = new System.Windows.Forms.TextBox();
            this.nhanVienTableAdapter = new CUAHANGMYPHAM.CHMPDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new CUAHANGMYPHAM.CHMPDataSetTableAdapters.TableAdapterManager();
            this.chmpDataSet1 = new CUAHANGMYPHAM.CHMPDataSet();
            this.taiKhoanDangNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chmpDataSet2 = new CUAHANGMYPHAM.CHMPDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            lblMaNhanVien = new System.Windows.Forms.Label();
            lblTenNhanVien = new System.Windows.Forms.Label();
            lblNgaySinh = new System.Windows.Forms.Label();
            lblGioiTinh = new System.Windows.Forms.Label();
            lblDienThoai = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblSoTaiKhoan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVTaiKhoan)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHMPDataSet)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            this.gBxHienThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVNhanVien)).BeginInit();
            this.gBxThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chmpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDangNhapBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chmpDataSet2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(533, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(369, 38);
            this.label12.TabIndex = 17;
            this.label12.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // dgVTaiKhoan
            // 
            this.dgVTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVTaiKhoan.Location = new System.Drawing.Point(54, 62);
            this.dgVTaiKhoan.Name = "dgVTaiKhoan";
            this.dgVTaiKhoan.RowHeadersWidth = 51;
            this.dgVTaiKhoan.RowTemplate.Height = 24;
            this.dgVTaiKhoan.Size = new System.Drawing.Size(614, 409);
            this.dgVTaiKhoan.TabIndex = 0;
            this.dgVTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVTaiKhoan_CellContentClick);
            // 
            // btnThoatTaiKhoan
            // 
            this.btnThoatTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatTaiKhoan.Location = new System.Drawing.Point(560, 581);
            this.btnThoatTaiKhoan.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoatTaiKhoan.Name = "btnThoatTaiKhoan";
            this.btnThoatTaiKhoan.Size = new System.Drawing.Size(124, 57);
            this.btnThoatTaiKhoan.TabIndex = 12;
            this.btnThoatTaiKhoan.Text = "Thoát";
            this.btnThoatTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThoatTaiKhoan.Click += new System.EventHandler(this.btnThoatTaiKhoan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(351, 581);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 57);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(89, 581);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(5);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(145, 57);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaNhanVientab2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cBxThuocQuyen);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.chBHienThiMatKhau);
            this.groupBox3.Controls.Add(this.txtXacNhanMatKhau);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMatKhau);
            this.groupBox3.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(48, 126);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(636, 426);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txtMaNhanVientab2
            // 
            this.txtMaNhanVientab2.Location = new System.Drawing.Point(303, 119);
            this.txtMaNhanVientab2.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaNhanVientab2.Name = "txtMaNhanVientab2";
            this.txtMaNhanVientab2.Size = new System.Drawing.Size(276, 30);
            this.txtMaNhanVientab2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã nhân viên";
            // 
            // cBxThuocQuyen
            // 
            this.cBxThuocQuyen.FormattingEnabled = true;
            this.cBxThuocQuyen.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cBxThuocQuyen.Location = new System.Drawing.Point(303, 186);
            this.cBxThuocQuyen.Margin = new System.Windows.Forms.Padding(5);
            this.cBxThuocQuyen.Name = "cBxThuocQuyen";
            this.cBxThuocQuyen.Size = new System.Drawing.Size(276, 33);
            this.cBxThuocQuyen.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thuộc quyền";
            // 
            // chBHienThiMatKhau
            // 
            this.chBHienThiMatKhau.AutoSize = true;
            this.chBHienThiMatKhau.Location = new System.Drawing.Point(303, 386);
            this.chBHienThiMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.chBHienThiMatKhau.Name = "chBHienThiMatKhau";
            this.chBHienThiMatKhau.Size = new System.Drawing.Size(201, 29);
            this.chBHienThiMatKhau.TabIndex = 13;
            this.chBHienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.chBHienThiMatKhau.UseVisualStyleBackColor = true;
            this.chBHienThiMatKhau.CheckedChanged += new System.EventHandler(this.chBHienThiMatKhau_CheckedChanged);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(303, 308);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(276, 30);
            this.txtXacNhanMatKhau.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 318);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Xác nhận mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(303, 246);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(276, 30);
            this.txtMatKhau.TabIndex = 7;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(303, 62);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(276, 30);
            this.txtTenTaiKhoan.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên  tài khoản ";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.cHMPDataSet;
            // 
            // cHMPDataSet
            // 
            this.cHMPDataSet.DataSetName = "CHMPDataSet";
            this.cHMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabNhanVien.BackColor = System.Drawing.Color.MintCream;
            this.tabNhanVien.Controls.Add(this.txtTimKiem);
            this.tabNhanVien.Controls.Add(this.btnTim);
            this.tabNhanVien.Controls.Add(this.lblQuanLiNhanVien);
            this.tabNhanVien.Controls.Add(this.gBxHienThi);
            this.tabNhanVien.Controls.Add(this.btnThoat);
            this.tabNhanVien.Controls.Add(this.btnXoa);
            this.tabNhanVien.Controls.Add(this.btnSua);
            this.tabNhanVien.Controls.Add(this.btnThem);
            this.tabNhanVien.Controls.Add(this.lblTimKiem);
            this.tabNhanVien.Controls.Add(this.gBxThongTinChiTiet);
            this.tabNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNhanVien.Location = new System.Drawing.Point(4, 37);
            this.tabNhanVien.Margin = new System.Windows.Forms.Padding(5);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(5);
            this.tabNhanVien.Size = new System.Drawing.Size(1544, 717);
            this.tabNhanVien.TabIndex = 0;
            this.tabNhanVien.Text = "Danh Sách Nhân Viên     ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTimKiem.Location = new System.Drawing.Point(844, 117);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(343, 38);
            this.txtTimKiem.TabIndex = 19;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(1248, 118);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(110, 33);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblQuanLiNhanVien
            // 
            this.lblQuanLiNhanVien.AutoSize = true;
            this.lblQuanLiNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLiNhanVien.Location = new System.Drawing.Point(524, 47);
            this.lblQuanLiNhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuanLiNhanVien.Name = "lblQuanLiNhanVien";
            this.lblQuanLiNhanVien.Size = new System.Drawing.Size(367, 38);
            this.lblQuanLiNhanVien.TabIndex = 16;
            this.lblQuanLiNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // gBxHienThi
            // 
            this.gBxHienThi.Controls.Add(this.dgVNhanVien);
            this.gBxHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxHienThi.Location = new System.Drawing.Point(728, 186);
            this.gBxHienThi.Margin = new System.Windows.Forms.Padding(5);
            this.gBxHienThi.Name = "gBxHienThi";
            this.gBxHienThi.Padding = new System.Windows.Forms.Padding(5);
            this.gBxHienThi.Size = new System.Drawing.Size(775, 460);
            this.gBxHienThi.TabIndex = 15;
            this.gBxHienThi.TabStop = false;
            this.gBxHienThi.Text = "Hiển thị thông tin";
            // 
            // dgVNhanVien
            // 
            this.dgVNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVNhanVien.Location = new System.Drawing.Point(40, 89);
            this.dgVNhanVien.Name = "dgVNhanVien";
            this.dgVNhanVien.RowHeadersWidth = 51;
            this.dgVNhanVien.RowTemplate.Height = 24;
            this.dgVNhanVien.Size = new System.Drawing.Size(637, 243);
            this.dgVNhanVien.TabIndex = 0;
            this.dgVNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVNhanVien_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(548, 612);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 57);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(371, 612);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 57);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(205, 612);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(127, 57);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(45, 612);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 57);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(723, 126);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(99, 25);
            this.lblTimKiem.TabIndex = 5;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // gBxThongTinChiTiet
            // 
            this.gBxThongTinChiTiet.Controls.Add(this.chBxGioiTinh);
            this.gBxThongTinChiTiet.Controls.Add(lblMaNhanVien);
            this.gBxThongTinChiTiet.Controls.Add(this.txtMaNhanVien);
            this.gBxThongTinChiTiet.Controls.Add(lblTenNhanVien);
            this.gBxThongTinChiTiet.Controls.Add(this.txtTenNhanVien);
            this.gBxThongTinChiTiet.Controls.Add(lblNgaySinh);
            this.gBxThongTinChiTiet.Controls.Add(this.dtpNgaySinh);
            this.gBxThongTinChiTiet.Controls.Add(lblGioiTinh);
            this.gBxThongTinChiTiet.Controls.Add(lblDienThoai);
            this.gBxThongTinChiTiet.Controls.Add(this.txtDienThoai);
            this.gBxThongTinChiTiet.Controls.Add(lblEmail);
            this.gBxThongTinChiTiet.Controls.Add(this.txtEmail);
            this.gBxThongTinChiTiet.Controls.Add(lblSoTaiKhoan);
            this.gBxThongTinChiTiet.Controls.Add(this.txtSoTaiKhoan);
            this.gBxThongTinChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxThongTinChiTiet.Location = new System.Drawing.Point(45, 126);
            this.gBxThongTinChiTiet.Margin = new System.Windows.Forms.Padding(5);
            this.gBxThongTinChiTiet.Name = "gBxThongTinChiTiet";
            this.gBxThongTinChiTiet.Padding = new System.Windows.Forms.Padding(5);
            this.gBxThongTinChiTiet.Size = new System.Drawing.Size(627, 462);
            this.gBxThongTinChiTiet.TabIndex = 0;
            this.gBxThongTinChiTiet.TabStop = false;
            this.gBxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // chBxGioiTinh
            // 
            this.chBxGioiTinh.FormattingEnabled = true;
            this.chBxGioiTinh.Location = new System.Drawing.Point(247, 222);
            this.chBxGioiTinh.Name = "chBxGioiTinh";
            this.chBxGioiTinh.Size = new System.Drawing.Size(202, 33);
            this.chBxGioiTinh.TabIndex = 19;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Location = new System.Drawing.Point(40, 65);
            lblMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new System.Drawing.Size(148, 25);
            lblMaNhanVien.TabIndex = 0;
            lblMaNhanVien.Text = "Mã  nhân viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(247, 60);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(343, 30);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Location = new System.Drawing.Point(31, 123);
            lblTenNhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new System.Drawing.Size(150, 25);
            lblTenNhanVien.TabIndex = 2;
            lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(247, 121);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(343, 30);
            this.txtTenNhanVien.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new System.Drawing.Point(49, 180);
            lblNgaySinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new System.Drawing.Size(108, 25);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(247, 175);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(5);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(343, 30);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new System.Drawing.Point(57, 236);
            lblGioiTinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new System.Drawing.Size(91, 25);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new System.Drawing.Point(49, 290);
            lblDienThoai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new System.Drawing.Size(109, 25);
            lblDienThoai.TabIndex = 8;
            lblDienThoai.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(247, 286);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(5);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(343, 30);
            this.txtDienThoai.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(67, 348);
            lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(72, 25);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(247, 343);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 30);
            this.txtEmail.TabIndex = 11;
            // 
            // lblSoTaiKhoan
            // 
            lblSoTaiKhoan.AutoSize = true;
            lblSoTaiKhoan.Location = new System.Drawing.Point(40, 401);
            lblSoTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            lblSoTaiKhoan.Size = new System.Drawing.Size(133, 25);
            lblSoTaiKhoan.TabIndex = 12;
            lblSoTaiKhoan.Text = "Số tài khoản";
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(247, 399);
            this.txtSoTaiKhoan.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(343, 30);
            this.txtSoTaiKhoan.TabIndex = 13;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DonViTinhTableAdapter = null;
            this.tableAdapterManager.HoaDonBanHangTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.MatHangTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuChiTienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapHangTableAdapter = null;
            this.tableAdapterManager.ProductArchiveTableAdapter = null;
            this.tableAdapterManager.TaiKhoanDangNhapTableAdapter = null;
            this.tableAdapterManager.ThuongHieuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CUAHANGMYPHAM.CHMPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chmpDataSet1
            // 
            this.chmpDataSet1.DataSetName = "CHMPDataSet";
            this.chmpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanDangNhapBindingSource
            // 
            this.taiKhoanDangNhapBindingSource.DataMember = "TaiKhoanDangNhap";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgVTaiKhoan);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(732, 126);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(755, 512);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hiển thị thông tin";
            // 
            // chmpDataSet2
            // 
            this.chmpDataSet2.DataSetName = "CHMPDataSet";
            this.chmpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MintCream;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btnThoatTaiKhoan);
            this.tabPage2.Controls.Add(this.btnHuy);
            this.tabPage2.Controls.Add(this.btnDangKy);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(1544, 717);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Tạo Tài Khoản   ";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabNhanVien);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(500, 0);
            this.tabControl1.Location = new System.Drawing.Point(5, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1552, 758);
            this.tabControl1.TabIndex = 3;
            // 
            // frmThietLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 775);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmThietLap";
            this.Text = "frmThietLap";
            this.Load += new System.EventHandler(this.frmThietLap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVTaiKhoan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHMPDataSet)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            this.gBxHienThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVNhanVien)).EndInit();
            this.gBxThongTinChiTiet.ResumeLayout(false);
            this.gBxThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chmpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDangNhapBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chmpDataSet2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgVTaiKhoan;
        private System.Windows.Forms.Button btnThoatTaiKhoan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaNhanVientab2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBxThuocQuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chBHienThiMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private CHMPDataSet cHMPDataSet;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblQuanLiNhanVien;
        private System.Windows.Forms.GroupBox gBxHienThi;
        private System.Windows.Forms.DataGridView dgVNhanVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.GroupBox gBxThongTinChiTiet;
        private System.Windows.Forms.ComboBox chBxGioiTinh;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoTaiKhoan;
        private CHMPDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private CHMPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CHMPDataSet chmpDataSet1;
        private System.Windows.Forms.BindingSource taiKhoanDangNhapBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private CHMPDataSet chmpDataSet2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}