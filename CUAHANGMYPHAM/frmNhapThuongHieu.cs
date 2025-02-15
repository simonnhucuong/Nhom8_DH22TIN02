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
namespace CUAHANGMYPHAM
{
    public partial class frmNhapThuongHieu : Form
    {
        private string connectionString = "Data Source=IRIS;Initial Catalog=CHMP;Integrated Security=True;TrustServerCertificate=True";
        public frmNhapThuongHieu()
        {
            InitializeComponent();
            LoadData();
        }
        #region Method
        private void frmNhapThuongHieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ThuongHieu";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvThuongHieu.DataSource = dt;
            }

        }
        // Hàm tạo mã loại tự động
        private string GenerateMaThuongHieu()
        {
            string maTH = "TH001"; // Giá trị mặc định
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 1 MatThuongHieu FROM ThuongHieu ORDER BY MatThuongHieu DESC";
                SqlCommand cmd = new SqlCommand(query, connection);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string lastMaTH = result.ToString();
                    int number = int.Parse(lastMaTH.Substring(2)) + 1;
                    maTH = "TH" + number.ToString("D3"); // Định dạng LH001, LH002...
                }
            }
            return maTH;
        }

        #endregion

        #region
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string maTH = GenerateMaThuongHieu(); // Tạo mã mới
                    string query;

                    if (dgvThuongHieu.SelectedRows.Count > 0) // Cập nhật nếu có dòng được chọn
                    {
                        query = "UPDATE ThuongHieu SET TenThuongHieu = @TenThuongHieu WHERE MaThuongHieu = @MaThuongHieu";
                    }
                    else // Thêm mới
                    {
                        query = "INSERT INTO ThuongHieu (MaThuongHieu, TenThuongHieu) VALUES (@MaThuongHieu, @TenThuongHieu)";
                    }

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaThuongHieu", maTH);
                    cmd.Parameters.AddWithValue("@TenThuongHieu", txtTenThuongHieu.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Lưu dữ liệu thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThuongHieu.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM ThuongHieu WHERE MaThuongHieu = @MaThuongHieu";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@MaThuongHieu", dgvThuongHieu.SelectedRows[0].Cells["MaLoai"].Value);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Xóa thành công!");
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại hàng để xóa.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void dgvThuongHieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu không phải tiêu đề cột
            {
              
                if (e.RowIndex >= 0) // Kiểm tra nếu không phải tiêu đề cột
                {
                    DataGridViewRow row = dgvThuongHieu.Rows[e.RowIndex];

                    txtMaThuongHieu.Text = row.Cells["MaThuongHieu"].Value?.ToString();
                    txtTenThuongHieu.Text = row.Cells["TenThuongHieu"].Value?.ToString();
                    txtXuatXu.Text = row.Cells["XuatXu"].Value?.ToString();
                }
            }
        }
        #endregion
    }
}
