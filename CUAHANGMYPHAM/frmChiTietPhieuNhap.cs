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
    public partial class frmChiTietPhieuNhap : Form
    {
       
        // Constructor nhận tham số
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
       
        }

        private void frmChiTietPhieu_hap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHMPDataSet.ChiTietPhieuNhapHang' table. You can move, or remove it, as needed.
            this.chiTietPhieuNhapHangTableAdapter.Fill(this.cHMPDataSet.ChiTietPhieuNhapHang);

        }
    }
}
