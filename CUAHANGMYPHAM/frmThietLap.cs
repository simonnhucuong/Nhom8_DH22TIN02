using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CUAHANGMYPHAM
{
    public partial class frmThietLap : Form
    {
        string connectionString = @"Data Source=IRIS;Initial Catalog=CHMP;Integrated Security=True;Trust Server Certificate=True";
        public frmThietLap()
        {
            InitializeComponent();
            LoadNhanVien();
            LoadTaiKhoan();
        }
        #region method
        
       
        #endregion
        #region Events
        private void frmThietLap_Load(object sender, EventArgs e)
        {
            chBxGioiTinh.Items.Add("Nam");
            chBxGioiTinh.Items.Add("Nữ");
            chBHienThiMatKhau.Checked = false;
        }
        private void LoadTaiKhoan()
        {
            // Đảm bảo mật khẩu bị ẩn ngay khi form khởi động
            txtMatKhau.UseSystemPasswordChar = true;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;

            // Đặt checkbox mặc định là chưa được tick
            chBHienThiMatKhau.Checked = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TaiKhoanDangNhap";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable f2 = new DataTable();
                adapter.Fill(f2);
                dgVTaiKhoan.DataSource = f2;
            }
        }
        private void LoadNhanVien()
        {
            // Load lên dữ liệu người dùng từ cơ sở dữ liệu, thành bảng dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhanVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgVNhanVien.DataSource = dt;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string GIOITINH = chBxGioiTinh.SelectedItem.ToString();

                    string query = "INSERT INTO NhanVien (MaNhanVien,TenNhanVien, NgaySinh, GioiTinh, DienThoai,Email,SoTaiKhoan) " +
                                   "VALUES (@MaNhanVien,@TenNhanVien, @NgaySinh, @GioiTinh, @DienThoai, @Email, @SoTaiKhoan)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                    cmd.Parameters.AddWithValue("@TenNhanVien", txtTenNhanVien.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", chBxGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@SoTaiKhoan", txtSoTaiKhoan.Text);

                    connection.Open();
                    int v = cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Thêm Người Dùng thành công!");
                    LoadNhanVien(); // Load lại danh sách Người Dùng sau khi thêm mới
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nhanVienDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0) // Kiểm tra nếu không phải tiêu đề cột
            //{
            //    DataGridViewRow row = dgVNhanVien.Rows[e.RowIndex];

            //    txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value?.ToString();
            //    txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value?.ToString();
            //    dtpNgaySinh.Text = row.Cells["NgaySinh"].Value?.ToString();
            //    txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();

            //    chBxGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
            //    txtEmail.Text = row.Cells["Email"].Value?.ToString();
            //    txtSoTaiKhoan.Text = row.Cells["SoTaiKhoan"].Value?.ToString();
            //}
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {

            //        string GIOITINH = chBxGioiTinh.SelectedItem.ToString();

            //        string query = "UPDATE NhanVien SET MaNhanVien=@MaNhanVien, TenNhanVien=@TenNhanVien, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DienThoai=@DienThoai, Email=@Email, SoTaiKhoan=@SoTaiKhoan " +
            //                       "WHERE SoTaiKhoan=@SoTaiKhoan";



            //        // MaNhanVien,TenNhanVien, NgaySinh, GioiTinh, DienThoai,Email,SoTaiKhoan


            //        SqlCommand cmd = new SqlCommand(query, connection);
            //        cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
            //        cmd.Parameters.AddWithValue("@TenNhanVien", txtTenNhanVien.Text);
            //        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Text);
            //        cmd.Parameters.AddWithValue("@GioiTinh", chBxGioiTinh.Text);
            //        cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);

            //    }
            //}
        }
        #endregion

        private void dgVNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu không phải tiêu đề cột
            {
                DataGridViewRow row = dgVNhanVien.Rows[e.RowIndex];

                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value?.ToString();
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value?.ToString();
                dtpNgaySinh.Text = row.Cells["NgaySinh"].Value?.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();

                chBxGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtSoTaiKhoan.Text = row.Cells["SoTaiKhoan"].Value?.ToString();



            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string GIOITINH = chBxGioiTinh.SelectedItem.ToString();

                    string query = "UPDATE NhanVien SET MaNhanVien=@MaNhanVien, TenNhanVien=@TenNhanVien, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DienThoai=@DienThoai, Email=@Email, SoTaiKhoan=@SoTaiKhoan " +
                                   "WHERE SoTaiKhoan=@SoTaiKhoan";



                    // MaNhanVien,TenNhanVien, NgaySinh, GioiTinh, DienThoai,Email,SoTaiKhoan


                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                    cmd.Parameters.AddWithValue("@TenNhanVien", txtTenNhanVien.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", chBxGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@SoTaiKhoan", txtSoTaiKhoan.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Cập nhật thông tin Người Dùng thành công!");
                    LoadNhanVien();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM NhanVien WHERE MaNhanVien=@MaNhanVien";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Xóa Người Dùng thành công!");
                        LoadNhanVien();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa Người Dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM NhanVien WHERE MaNhanVien LIKE @TuKhoa OR TenNhanVien LIKE @TuKhoa OR DienThoai LIKE @TuKhoa";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@TuKhoa", "%" + txtTimKiem.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgVNhanVien.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTimKiem.Text = "";
            LoadNhanVien();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng thực hiện nếu mật khẩu không trùng khớp
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string ThuocQuyen = cBxThuocQuyen.SelectedItem.ToString();

                    string query = "INSERT INTO TaiKhoanDangNhap (Usernames,MaNhanVien, QuyenTrongHeThong, Passwords) " +
                                   "VALUES (@Usernames,@MaNhanVien, @QuyenTrongHeThong, @Passwords)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Usernames", txtTenTaiKhoan.Text);
                    cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVientab2.Text);
                    cmd.Parameters.AddWithValue("@QuyenTrongHeThong", cBxThuocQuyen.Text);
                    cmd.Parameters.AddWithValue("@Passwords", txtMatKhau.Text);

                    connection.Open();
                    int v = cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Đăng ký tài khoản thành công !");
                    LoadTaiKhoan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký tài khoản : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy tài khoản  này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM TaiKhoanDangNhap WHERE MaNhanVien=@MaNhanVien";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVientab2.Text);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Hủy tài khoản thành công!");
                        LoadTaiKhoan();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hủy tài khoản : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoatTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void chBHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            bool hienThi = chBHienThiMatKhau.Checked;
            txtMatKhau.UseSystemPasswordChar = !hienThi;
            txtXacNhanMatKhau.UseSystemPasswordChar = !hienThi;
        }

        private void dgVTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu không phải tiêu đề cột
            {
                DataGridViewRow row = dgVTaiKhoan.Rows[e.RowIndex];

                txtTenTaiKhoan.Text = row.Cells["Usernames"].Value?.ToString();
                txtMaNhanVientab2.Text = row.Cells["MaNhanVien"].Value?.ToString();
                cBxThuocQuyen.Text = row.Cells["QuyenTrongHeThong"].Value?.ToString();
                txtMatKhau.Text = row.Cells["Passwords"].Value?.ToString();
            }
        }
    }
}