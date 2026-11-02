namespace QuanLyHoatDongKhachSan.ChiTietTienNghi
{
    partial class FormDanhSachChiTietTienNghi
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
            dtgDanhSachTienNghiTheoLoaiPhong = new DataGridView();
            btnThoat = new Button();
            btnCapNhat = new Button();
            label5 = new Label();
            lblTenLoaiPhong = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTienNghiTheoLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachTienNghiTheoLoaiPhong
            // 
            dtgDanhSachTienNghiTheoLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachTienNghiTheoLoaiPhong.Location = new Point(12, 149);
            dtgDanhSachTienNghiTheoLoaiPhong.Name = "dtgDanhSachTienNghiTheoLoaiPhong";
            dtgDanhSachTienNghiTheoLoaiPhong.RowHeadersWidth = 51;
            dtgDanhSachTienNghiTheoLoaiPhong.RowTemplate.Height = 24;
            dtgDanhSachTienNghiTheoLoaiPhong.Size = new Size(1015, 469);
            dtgDanhSachTienNghiTheoLoaiPhong.TabIndex = 15;
            dtgDanhSachTienNghiTheoLoaiPhong.CellClick += dtgDanhSachTienNghiTheoLoaiPhong_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(604, 623);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 29;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Moccasin;
            btnCapNhat.Font = new Font("Segoe UI", 12F);
            btnCapNhat.Location = new Point(404, 623);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 59);
            btnCapNhat.TabIndex = 28;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(316, 25);
            label5.Name = "label5";
            label5.Size = new Size(394, 40);
            label5.TabIndex = 30;
            label5.Text = "Danh sách tiện nghi hiện có";
            // 
            // lblTenLoaiPhong
            // 
            lblTenLoaiPhong.AutoSize = true;
            lblTenLoaiPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTenLoaiPhong.ForeColor = Color.Blue;
            lblTenLoaiPhong.Location = new Point(431, 93);
            lblTenLoaiPhong.Name = "lblTenLoaiPhong";
            lblTenLoaiPhong.Size = new Size(152, 28);
            lblTenLoaiPhong.TabIndex = 31;
            lblTenLoaiPhong.Text = "Tên loại phòng";
            // 
            // FormDanhSachChiTietTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 694);
            Controls.Add(lblTenLoaiPhong);
            Controls.Add(label5);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(dtgDanhSachTienNghiTheoLoaiPhong);
            Name = "FormDanhSachChiTietTienNghi";
            Text = "FormDanhSachChiTietTienNghi";
            Load += FormDanhSachChiTietTienNghi_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTienNghiTheoLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDanhSachTienNghiTheoLoaiPhong;
        private Button btnThoat;
        private Button btnCapNhat;
        private Label label5;
        private Label lblTenLoaiPhong;
    }
}