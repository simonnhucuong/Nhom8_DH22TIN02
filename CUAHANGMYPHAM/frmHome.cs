using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using System.Collections;
using static CUAHANGMYPHAM.Program;


namespace CUAHANGMYPHAM
{
    public partial class frmHome : Form
    {
        private string _userRole;
        private string connectionString = "Data Source=IRIS;Initial Catalog=CHMP;Integrated Security=True;TrustServerCertificate=True";
        bool isAdmin = false; // Biến kiểm tra quyền Admin

        public object tabControl { get; private set; }

        public void SetRole(string role)
        {
            _userRole = role;
            AdjustTabControlBasedOnRole();
        }
        private void AdjustTabControlBasedOnRole()
        {
            TabControl tabControl = new TabControl();
            tabControl.TabPages.Add(tbpMatHang);
            try
            {
                // Ẩn tất cả các tab trước khi điều chỉnh
                tabControl.TabPages.Clear();

                if (_userRole == "Nhân Viên")
                {
                    // Chỉ cho phép truy cập các tab "Mặt Hàng" và "Bán Hàng"
                    tabControl.TabPages.Add(tbpMatHang);
                    tabControl.TabPages.Add(tbpBanHang);
                }
                else if (_userRole == "Admin")
                {
                    // Admin có quyền truy cập tất cả các tab
                    tabControl.TabPages.Add(tbpMatHang);
                    tabControl.TabPages.Add(tbpBanHang);
                    tabControl.TabPages.Add(tbpNhapHang);
                    tabControl.TabPages.Add(tbpThongKe);
                    tabControl.TabPages.Add(tbpThietLap);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi điều chỉnh tab: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public frmHome()
        {
            InitializeComponent();

            LoadMatHang();
            LoadHoaDon();
            this.isAdmin = isAdmin;

            txtVat.ReadOnly = true;
            txtTongTienNhap.ReadOnly = true;
            //this.cbxMaNhanVien.DropDown += new System.EventHandler(this.cbxMaNhanVien_DropDown);
            //this.cbxNhaCungCap.DropDown += new System.EventHandler(this.cbxNhaCungCap_DropDown);
            //this.cbxMaThuongHieu.DropDown += new System.EventHandler(this.cbxMaThuongHieu_DropDown);
            this.dtpNgayLap.ValueChanged += new System.EventHandler(this.dtpNgayLap_ValueChanged);
            this.txtVat.TextChanged += new System.EventHandler(this.txtVat_TextChanged);
            LoadData();
        }

        #region LoadData
        private void LoadData()
        {
            try
            {
                // Kiểm tra xem connectionString có null hoặc rỗng không
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null or empty.");
                }

                // Tạo và mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string query = "SELECT * FROM PhieuNhapHang";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPhieuNhap.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi liên quan đến SQL
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi chung
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        #endregion
        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadMatHang();
            if (!isAdmin)
            {
                btnSua.Enabled = false;

            }
            LoadHoaDon();

            AdjustTabControlBasedOnRole();
            //panel thông tin tài khoản
            lblUsername.Text = $"Xin chào: {UserSession.Username}";
            lblQuyen.Text = $"Quyền: {UserSession.Role}";
            lblThoiGian.Text = $"Thời gian đăng nhập: {UserSession.LoginTime:dd/MM/yyyy HH:mm:ss}";
        }


        #region MatHang


        #region MatHang_Methods+HoaDon_Methods
        private void LoadMatHang()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MatHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgVMatHang.DataSource = dt;
            }
        }
        private void LoadHoaDon()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM HoaDonBanHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable hd = new DataTable();
                adapter.Fill(hd);
                dgVHoaDon.DataSource = hd;
            }
        }

        #endregion

        #region MatHang_Events


        #endregion

        #endregion

        #region BanHang
        #region BanHang_Methods

        #endregion

        #region BanHang_Events

        #endregion

        #endregion

        #region NhapHang
        private void LoadComboBoxData(string query, ComboBox comboBox, string displayMember)
        {
            try
            {
                // Kiểm tra xem ComboBox có null không
                if (comboBox == null)
                {
                    throw new ArgumentNullException(nameof(comboBox), "ComboBox cannot be null.");
                }

                // Kiểm tra xem query có null hoặc rỗng không
                if (string.IsNullOrEmpty(query))
                {
                    throw new ArgumentException("Query cannot be null or empty.", nameof(query));
                }

                // Kiểm tra xem displayMember có null hoặc rỗng không
                if (string.IsNullOrEmpty(displayMember))
                {
                    throw new ArgumentException("DisplayMember cannot be null or empty.", nameof(displayMember));
                }

                // Tạo kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo và thực thi lệnh SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đọc dữ liệu từ cơ sở dữ liệu
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Kiểm tra xem có dữ liệu trả về không
                            if (reader.HasRows)
                            {
                                // Tạo một DataTable để lưu trữ dữ liệu
                                DataTable dataTable = new DataTable();
                                dataTable.Load(reader);

                                // Kiểm tra xem DataTable có dữ liệu không
                                if (dataTable.Rows.Count > 0)
                                {
                                    // Đảm bảo rằng displayMember tồn tại trong DataTable
                                    if (dataTable.Columns.Contains(displayMember))
                                    {
                                        // Gán dữ liệu vào ComboBox
                                        comboBox.Invoke((MethodInvoker)delegate {
                                            comboBox.DataSource = dataTable;
                                            comboBox.DisplayMember = displayMember;
                                            comboBox.ValueMember = "ID"; // Thay "ID" bằng tên cột chứa giá trị thực tế
                                        });
                                    }
                                    else
                                    {
                                        throw new ArgumentException($"DisplayMember '{displayMember}' does not exist in the data source.", nameof(displayMember));
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No data found.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No rows found.");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        #region NhapHang_Methods
        private void TinhTongGiaTriPhieuNhap()
        {
            // Kiểm tra xem giá trị trong textBox5 và textBox6 có hợp lệ không
            if (decimal.TryParse(txtVat.Text, out decimal tongTienNhap) && decimal.TryParse(txtTongTienNhap.Text, out decimal vat))
            {
                // Tính tổng giá trị phiếu nhập
                decimal tongGiaTriPhieuNhap = tongTienNhap + vat;

                // Hiển thị kết quả lên txtTongGiaTriPhieuNhap
                txtTongGiaTriPhieu.Text = tongGiaTriPhieuNhap.ToString("N2"); // Định dạng với 2 chữ số thập phân
            }
            else
            {
                // Nếu giá trị không hợp lệ, hiển thị 0
                txtTongGiaTriPhieu.Text = "0.00";
            }
        }
        #endregion

        #region NhapHang_Events

        private void tbpNhapHang_Click(object sender, EventArgs e)
        {

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO PhieuNhap (MaPhieuNhap, MaNhanVien, MaNhaCungCap, MaThuongHieu, NgayLap, TongTienVAT, TongTienNhap) VALUES (@MaPhieuNhap, @MaNhanVien, @MaNhaCungCap, @MaThuongHieu, @NgayLap, @TongTienVAT, @TongTienNhap)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", cbxMaPhieuNhap.Text);
                    cmd.Parameters.AddWithValue("@MaNhanVien", cbxMaNhanVien.Text);
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", cbxNhaCungCap.Text);
                    cmd.Parameters.AddWithValue("@MaThuongHieu", cbxMaThuongHieu.Text);
                    cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value);
                    cmd.Parameters.AddWithValue("@TongTienVAT", txtVat.Text);
                    cmd.Parameters.AddWithValue("@TongTienNhap", txtTongTienNhap.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tạo phiếu nhập hàng thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnChiTietPN_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một thể hiện của form frmPhieuNhap
                frmChiTietPhieuNhap frm = new frmChiTietPhieuNhap();
                frm.Show(); // Hoặc frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE PhieuNhap SET MaNhanVien = @MaNhanVien, MaNhaCungCap = @MaNhaCungCap, MaThuongHieu = @MaThuongHieu, NgayLap = @NgayLap, TongTienVAT = @TongTienVAT, TongTienNhap = @TongTienNhap WHERE MaPhieuNhap = @MaPhieuNhap";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaPhieuNhap", dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value);
                        cmd.Parameters.AddWithValue("@MaNhanVien", cbxMaNhanVien.Text);
                        cmd.Parameters.AddWithValue("@MaNhaCungCap", cbxNhaCungCap.Text);
                        cmd.Parameters.AddWithValue("@MaThuongHieu", cbxMaThuongHieu.Text);
                        cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value);
                        cmd.Parameters.AddWithValue("@TongTienVAT", txtVat.Text);
                        cmd.Parameters.AddWithValue("@TongTienNhap", txtTongTienNhap.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật phiếu nhập hàng thành công!");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập hàng để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE PhieuNhap SET MaNhanVien = @MaNhanVien, MaNhaCungCap = @MaNhaCungCap, MaThuongHieu = @MaThuongHieu, NgayLap = @NgayLap, TongTienVAT = @TongTienVAT, TongTienNhap = @TongTienNhap WHERE MaPhieuNhap = @MaPhieuNhap";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        //cmd.Parameters.AddWithValue("@MaPhieuNhap", dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value);
                        //cmd.Parameters.AddWithValue("@MaNhanVien", cbxMaNhanVien.Text);
                        //cmd.Parameters.AddWithValue("@MaNhaCungCap", cbxNhaCungCap.Text);
                        //cmd.Parameters.AddWithValue("@MaThuongHieu", cbxMaThuongHieu.Text);
                        cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value);
                        cmd.Parameters.AddWithValue("@TongTienVAT", txtVat.Text);
                        cmd.Parameters.AddWithValue("@TongTienNhap", txtTongTienNhap.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật phiếu nhập hàng thành công!");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập hàng để sửa.");
            }
        }

        private void cbxMaNhanVien_dropdown(object sender, EventArgs e)
        {
            LoadComboBoxData("select manhanvien from nhanvien", cbxMaNhanVien, "manhanvien");
        }

        private void cbxMaPhieuNhap_DropDown(object sender, EventArgs e)
        {

        }

        //private void cbxNhaCungCap_DropDown(object sender, EventArgs e)
        //{
        //    LoadComboBoxData("SELECT MaNhaCungCap FROM NhaCungCap", cbxNhaCungCap, "MaNhaCungCap");
        //}

        //private void cbxMaThuongHieu_DropDown(object sender, EventArgs e)
        //{
        //    LoadComboBoxData("SELECT MaThuongHieu FROM ThuongHieu", cbxMaThuongHieu, "MaThuongHieu");
        //}
        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayLap.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày lập không được vượt quá ngày hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayLap.Value = DateTime.Now; // Đặt lại giá trị về ngày hiện tại
            }
        }
        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtVat.Text, out decimal tongTienNhap))
            {
                // Tính toán VAT (10% của tổng tiền nhập)
                decimal vat = tongTienNhap * 0.1m;
                txtTongTienNhap.Text = vat.ToString("N2"); // Hiển thị với 2 chữ số thập phân
            }
            else
            {
                txtTongTienNhap.Text = "0.00"; // Nếu giá trị nhập vào không hợp lệ
            }
        }
        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #endregion

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKIem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM MatHang WHERE MaMatHang LIKE @TuKhoa OR TenMatHang LIKE @TuKhoa";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@TuKhoa", "%" + txtTimKIem.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgVMatHang.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm mặt hàng : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKIem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKIem.Text = "";
            LoadMatHang();
        }

        private void btnSuaMatHang_Click(object sender, EventArgs e)
        {
            if (isAdmin && dgVMatHang.SelectedRows.Count > 0)
            {
                this.Hide(); // Ẩn form hiện tại

                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow selectedRow = dgVMatHang.SelectedRows[0];
                string maMatHang = selectedRow.Cells["MaMatHang"].Value.ToString();
                string tenMatHang = selectedRow.Cells["TenMatHang"].Value.ToString();

                // Truyền dữ liệu vào form mới
                frmThongTinMatHang frm = new frmThongTinMatHang(maMatHang, tenMatHang);
                frm.ShowDialog(); // Hiển thị form mới (chờ đóng xong mới tiếp tục)

                this.Show(); // Hiện lại form cũ sau khi đóng form mới
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO HoaDonBanHang (MaNhanVien,MaHoaDon, NgayLap, MaKhachHang, TongGiaTriHoaDon) " +
                                   "VALUES (@MaNhanVien,@MaHoaDon, @NgayLap, @MaKhachHang, @TongGiaTriHoaDon)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                    cmd.Parameters.AddWithValue("@MaHoaDon", txtMaHoaDon.Text);
                    cmd.Parameters.AddWithValue("@NgayLap", dTNgayLap.Text);
                    cmd.Parameters.AddWithValue("@MaKhachHang", txtMaKhachHang.Text);
                    cmd.Parameters.AddWithValue("@TongGiaTriHoaDon", Convert.ToDecimal(txtTong.Text));

                    connection.Open();
                    int v = cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Thêm hóa đơn thành công!");
                    LoadHoaDon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM HoaDonBanHang WHERE MaNhanVien=@MaNhanVien";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Xóa thành công!");
                        LoadHoaDon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa Người Dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgVHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu không phải tiêu đề cột
            {
                DataGridViewRow row = dgVHoaDon.Rows[e.RowIndex];

                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value?.ToString();
                txtMaHoaDon.Text = row.Cells["MaHoaDon"].Value?.ToString();
                dTNgayLap.Text = row.Cells["NgayLap"].Value?.ToString();
                txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value?.ToString();
                txtTong.Text = row.Cells["TongGiaTriHoaDon"].Value?.ToString();
            }
        }

        private void tbpThietLap_Click(object sender, EventArgs e)
        {
            try
            {
                frmThietLap frm = new frmThietLap();
                frm.Show(); // Hoặc frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
