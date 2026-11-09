namespace QuanLyHoatDongKhachSan.PhieuThue
{
    partial class FormChiTietPhieuThue
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
            lbSoPhieu = new Label();
            lbHoTenKH = new Label();
            lblThoiGianLP = new Label();
            lblHoTenNV = new Label();
            dtgDanhSachCTPT = new DataGridView();
            btnThoat = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachCTPT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lbSoPhieu
            // 
            lbSoPhieu.AutoSize = true;
            lbSoPhieu.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lbSoPhieu.ForeColor = Color.Black;
            lbSoPhieu.Location = new Point(211, 28);
            lbSoPhieu.Name = "lbSoPhieu";
            lbSoPhieu.Size = new Size(415, 40);
            lbSoPhieu.TabIndex = 43;
            lbSoPhieu.Text = "Chi tiết phiếu thuê (số phiếu)";
            // 
            // lbHoTenKH
            // 
            lbHoTenKH.AutoSize = true;
            lbHoTenKH.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbHoTenKH.ForeColor = Color.Navy;
            lbHoTenKH.Location = new Point(67, 108);
            lbHoTenKH.Name = "lbHoTenKH";
            lbHoTenKH.Size = new Size(219, 28);
            lbHoTenKH.TabIndex = 44;
            lbHoTenKH.Text = "Họ và tên khách hàng";
            // 
            // lblThoiGianLP
            // 
            lblThoiGianLP.AutoSize = true;
            lblThoiGianLP.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblThoiGianLP.ForeColor = Color.Navy;
            lblThoiGianLP.Location = new Point(372, 108);
            lblThoiGianLP.Name = "lblThoiGianLP";
            lblThoiGianLP.Size = new Size(196, 28);
            lblThoiGianLP.TabIndex = 45;
            lblThoiGianLP.Text = "Thời gian lập phiếu";
            // 
            // lblHoTenNV
            // 
            lblHoTenNV.AutoSize = true;
            lblHoTenNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHoTenNV.ForeColor = Color.Navy;
            lblHoTenNV.Location = new Point(672, 108);
            lblHoTenNV.Name = "lblHoTenNV";
            lblHoTenNV.Size = new Size(175, 28);
            lblHoTenNV.TabIndex = 46;
            lblHoTenNV.Text = "Họ tên nhân viên";
            // 
            // dtgDanhSachCTPT
            // 
            dtgDanhSachCTPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachCTPT.Location = new Point(40, 174);
            dtgDanhSachCTPT.Name = "dtgDanhSachCTPT";
            dtgDanhSachCTPT.RowHeadersWidth = 51;
            dtgDanhSachCTPT.Size = new Size(807, 188);
            dtgDanhSachCTPT.TabIndex = 47;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(192, 255, 255);
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(404, 412);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(131, 46);
            btnThoat.TabIndex = 48;
            btnThoat.Text = "button1";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Name;
            pictureBox1.Location = new Point(12, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.CalendarPick;
            pictureBox2.Location = new Point(317, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.NhanVien1;
            pictureBox3.Location = new Point(626, 98);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            // 
            // FormChiTietPhieuThue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 470);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnThoat);
            Controls.Add(dtgDanhSachCTPT);
            Controls.Add(lblHoTenNV);
            Controls.Add(lblThoiGianLP);
            Controls.Add(lbHoTenKH);
            Controls.Add(lbSoPhieu);
            Name = "FormChiTietPhieuThue";
            Text = "FormChiTietPhieuThue";
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachCTPT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSoPhieu;
        private Label lbHoTenKH;
        private Label lblThoiGianLP;
        private Label lblHoTenNV;
        private DataGridView dtgDanhSachCTPT;
        private Button btnThoat;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}