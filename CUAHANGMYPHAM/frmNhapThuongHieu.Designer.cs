namespace CUAHANGMYPHAM
{
    partial class frmNhapThuongHieu
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
            System.Windows.Forms.Label lblMaThuongHieu;
            System.Windows.Forms.Label tenThuongHieuLabel;
            System.Windows.Forms.Label xuatXuLabel;
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.txtMaThuongHieu = new System.Windows.Forms.TextBox();
            this.txtTenThuongHieu = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThuongHieu = new System.Windows.Forms.DataGridView();
            lblMaThuongHieu = new System.Windows.Forms.Label();
            tenThuongHieuLabel = new System.Windows.Forms.Label();
            xuatXuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaThuongHieu
            // 
            lblMaThuongHieu.AutoSize = true;
            lblMaThuongHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMaThuongHieu.Location = new System.Drawing.Point(66, 144);
            lblMaThuongHieu.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            lblMaThuongHieu.Name = "lblMaThuongHieu";
            lblMaThuongHieu.Size = new System.Drawing.Size(179, 25);
            lblMaThuongHieu.TabIndex = 43;
            lblMaThuongHieu.Text = "Mã Thương Hiệu:";
            // 
            // tenThuongHieuLabel
            // 
            tenThuongHieuLabel.AutoSize = true;
            tenThuongHieuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenThuongHieuLabel.Location = new System.Drawing.Point(66, 202);
            tenThuongHieuLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            tenThuongHieuLabel.Name = "tenThuongHieuLabel";
            tenThuongHieuLabel.Size = new System.Drawing.Size(187, 25);
            tenThuongHieuLabel.TabIndex = 45;
            tenThuongHieuLabel.Text = "Tên Thương Hiệu:";
            // 
            // xuatXuLabel
            // 
            xuatXuLabel.AutoSize = true;
            xuatXuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xuatXuLabel.Location = new System.Drawing.Point(66, 258);
            xuatXuLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            xuatXuLabel.Name = "xuatXuLabel";
            xuatXuLabel.Size = new System.Drawing.Size(93, 25);
            xuatXuLabel.TabIndex = 47;
            xuatXuLabel.Text = "Xuất xứ:";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXuatXu.Location = new System.Drawing.Point(282, 256);
            this.txtXuatXu.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(328, 27);
            this.txtXuatXu.TabIndex = 2;
            // 
            // txtMaThuongHieu
            // 
            this.txtMaThuongHieu.BackColor = System.Drawing.Color.White;
            this.txtMaThuongHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuongHieu.Location = new System.Drawing.Point(282, 142);
            this.txtMaThuongHieu.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtMaThuongHieu.Name = "txtMaThuongHieu";
            this.txtMaThuongHieu.Size = new System.Drawing.Size(328, 27);
            this.txtMaThuongHieu.TabIndex = 0;
            // 
            // txtTenThuongHieu
            // 
            this.txtTenThuongHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThuongHieu.Location = new System.Drawing.Point(282, 200);
            this.txtTenThuongHieu.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtTenThuongHieu.Name = "txtTenThuongHieu";
            this.txtTenThuongHieu.Size = new System.Drawing.Size(328, 27);
            this.txtTenThuongHieu.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(459, 345);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(151, 49);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(272, 345);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 49);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(71, 345);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(151, 49);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(409, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 38);
            this.label1.TabIndex = 39;
            this.label1.Text = "NHẬP THƯƠNG HIỆU";
            // 
            // dgvThuongHieu
            // 
            this.dgvThuongHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuongHieu.Location = new System.Drawing.Point(667, 144);
            this.dgvThuongHieu.Name = "dgvThuongHieu";
            this.dgvThuongHieu.RowHeadersWidth = 51;
            this.dgvThuongHieu.RowTemplate.Height = 24;
            this.dgvThuongHieu.Size = new System.Drawing.Size(468, 250);
            this.dgvThuongHieu.TabIndex = 6;
            this.dgvThuongHieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuongHieu_CellContentClick);
            // 
            // frmNhapThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1182, 508);
            this.Controls.Add(this.dgvThuongHieu);
            this.Controls.Add(lblMaThuongHieu);
            this.Controls.Add(tenThuongHieuLabel);
            this.Controls.Add(xuatXuLabel);
            this.Controls.Add(this.txtXuatXu);
            this.Controls.Add(this.txtMaThuongHieu);
            this.Controls.Add(this.txtTenThuongHieu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNhapThuongHieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Thương Hiệu";
            this.Load += new System.EventHandler(this.frmNhapThuongHieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.TextBox txtMaThuongHieu;
        private System.Windows.Forms.TextBox txtTenThuongHieu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThuongHieu;
    }
}