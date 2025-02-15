using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CUAHANGMYPHAM.Program;

namespace CUAHANGMYPHAM
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        #region Events
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            string role = KiemTraDangNhap(username, password);

            if (!string.IsNullOrEmpty(role)) // Nếu có role -> Đăng nhập thành công
            {
                UserSession.Username = username;
                UserSession.Role = role;
                UserSession.LoginTime = DateTime.Now;

                //    //this.Hide();
                //    //frmHome formMain = new frmHome();
                //    //formMain.ShowDialog();
                //    //this.Show();
                    frmHome formMain = new frmHome();
                //    // Đăng ký sự kiện khi form chính đóng thì thoát ứng dụng
                formMain.FormClosed += (s, args) => this.Show();

                this.Hide(); // Ẩn form đăng nhập
                formMain.Show(); // Hiển thị form chính (KHÔNG DÙNG ShowDialog())
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string KiemTraDangNhap(string username, string password)
        {
            string role = string.Empty;
            string connectionString = "Data Source=.;Initial Catalog=CHMP;Integrated Security=True"; // Cấu hình kết nối

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT QuyenTrongHeThong FROM TaiKhoanDangNhap WHERE Usernames = @username AND Passwords = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            role = result.ToString(); // Trả về role nếu tài khoản hợp lệ
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return role; // Trả về role hoặc chuỗi rỗng nếu sai
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            object chkHienThiMatKhau = null;
            // Nếu CheckBox được chọn thì hiển thị mật khẩu, ngược lại thì ẩn bằng dấu *
            txtMatKhau.UseSystemPasswordChar = !ckbHienThi.Checked;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // Đảm bảo mật khẩu được ẩn khi form được tải
    txtMatKhau.UseSystemPasswordChar = true;
            // Đảm bảo CheckBox không được chọn mặc định
            ckbHienThi.Checked = false; 
        }
    }
}
