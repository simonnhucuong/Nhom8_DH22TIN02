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
    public partial class frmNhapLoaiHang : Form
    {

        private string connectionString = "Data Source=IRIS;Initial Catalog=CHMP;Integrated Security=True;TrustServerCertificate=True";
        public frmNhapLoaiHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void frmNhapLoaiHangcs_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #region Method
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM LoaiHang";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLoaiHang.DataSource = dt;
            }

        }
        // Hàm tạo mã loại tự động
        private string GenerateMaLoai()
        {
            string maLoai = "LH001"; // Giá trị mặc định
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 1 MaLoai FROM LoaiHang ORDER BY MaLoai DESC";
                SqlCommand cmd = new SqlCommand(query, connection);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string lastMaLoai = result.ToString();
                    int number = int.Parse(lastMaLoai.Substring(2)) + 1;
                    maLoai = "LH" + number.ToString("D3"); // Định dạng LH001, LH002...
                }
            }
            return maLoai;
        }
        #endregion

        #region Events
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string maLoai = GenerateMaLoai(); // Tạo mã mới
                    string query;

                    if (dgvLoaiHang.SelectedRows.Count > 0) // Cập nhật nếu có dòng được chọn
                    {
                        query = "UPDATE LoaiHang SET TenLoai = @TenLoai WHERE MaLoai = @MaLoai";
                    }
                    else // Thêm mới
                    {
                        query = "INSERT INTO LoaiHang (MaLoai, TenLoai) VALUES (@MaLoai, @TenLoai)";
                    }

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                    cmd.Parameters.AddWithValue("@TenLoai", txtTenLoai.Text);
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
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenLoai.Clear();
            txtMaLoai.Clear();
            txtGhiChu.Clear();
            dgvLoaiHang.ClearSelection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLoaiHang.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM LoaiHang WHERE MaLoai = @MaLoai";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@MaLoai", dgvLoaiHang.SelectedRows[0].Cells["MaLoai"].Value);
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
        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu không phải tiêu đề cột
            {
                DataGridViewRow row = dgvLoaiHang.Rows[e.RowIndex];

                txtMaLoai.Text = row.Cells["MaLoai"].Value?.ToString();
                txtTenLoai.Text = row.Cells["TenLoai"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            }
        }
        #endregion


    }
}
