namespace QuanLyHoatDongKhachSan.LoaiPhong
{
    partial class FormDanhSachLoaiPhong
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
            dtgDanhSachLoaiPhong = new DataGridView();
            btnThemMoi = new Button();
            btnXuatExcel = new Button();
            pictureBox1 = new PictureBox();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachLoaiPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachLoaiPhong
            // 
            dtgDanhSachLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachLoaiPhong.Location = new Point(3, 69);
            dtgDanhSachLoaiPhong.Name = "dtgDanhSachLoaiPhong";
            dtgDanhSachLoaiPhong.RowHeadersWidth = 51;
            dtgDanhSachLoaiPhong.RowTemplate.Height = 24;
            dtgDanhSachLoaiPhong.Size = new Size(1015, 615);
            dtgDanhSachLoaiPhong.TabIndex = 9;
            dtgDanhSachLoaiPhong.CellClick += dtgDanhSachLoaiPhong_CellClick;
            dtgDanhSachLoaiPhong.CellContentClick += dtgDanhSachLoaiPhong_CellContentClick;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.MediumSpringGreen;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnThemMoi.Location = new Point(794, 9);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(188, 37);
            btnThemMoi.TabIndex = 8;
            btnThemMoi.Text = "Thêm mới ";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnXuatExcel.Location = new Point(551, 9);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(167, 37);
            btnXuatExcel.TabIndex = 7;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search2;
            pictureBox1.Location = new Point(76, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13F);
            txtTimKiem.Location = new Point(121, 9);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(187, 32);
            txtTimKiem.TabIndex = 5;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // FormDanhSachLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 688);
            Controls.Add(dtgDanhSachLoaiPhong);
            Controls.Add(btnThemMoi);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Name = "FormDanhSachLoaiPhong";
            Text = "FormDanhSachLoaiPhong";
            Load += FormDanhSachLoaiPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachLoaiPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDanhSachLoaiPhong;
        private Button btnThemMoi;
        private Button btnXuatExcel;
        private PictureBox pictureBox1;
        private TextBox txtTimKiem;
    }
}