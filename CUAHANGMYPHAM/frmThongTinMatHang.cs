using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUAHANGMYPHAM
{
    public partial class frmThongTinMatHang : Form
    {
        private string _maMatHang;
        private string _tenMatHang;

        public frmThongTinMatHang(string maMatHang, string tenMatHang)
        {
            InitializeComponent();
            _maMatHang = maMatHang;
            _tenMatHang = tenMatHang;
        }
        public frmThongTinMatHang()
        {
            InitializeComponent();
        }

        private void frmThongTinMatHang_Load(object sender, EventArgs e)
        {
            // Hiển thị dữ liệu lên các control trong form
            txtMaMatHang.Text = _maMatHang;
            txtTenMatHang.Text = _tenMatHang;
        }
    }
}
