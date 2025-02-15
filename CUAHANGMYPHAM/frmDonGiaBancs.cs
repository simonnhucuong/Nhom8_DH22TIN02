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
    public partial class frmDonGiaBancs : Form
    {
        public frmDonGiaBancs()
        {
            InitializeComponent();
        }

        private void donGiaBanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.donGiaBanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHMPDataSet);

        }

        private void frmDonGiaBancs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHMPDataSet.DonGiaBan' table. You can move, or remove it, as needed.
            this.donGiaBanTableAdapter.Fill(this.cHMPDataSet.DonGiaBan);

        }
    }
}
