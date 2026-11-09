namespace QuanLyHoatDongKhachSan.TaiKhoan
{
    partial class FormDanhSachTaiKhoan
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
            dtgDanhSachTaiKhoan = new DataGridView();
            btnThemMoi = new Button();
            btnXuatExcel = new Button();
            pictureBox1 = new PictureBox();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTaiKhoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachTaiKhoan
            // 
            dtgDanhSachTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachTaiKhoan.Location = new Point(25, 91);
            dtgDanhSachTaiKhoan.Name = "dtgDanhSachTaiKhoan";
            dtgDanhSachTaiKhoan.RowHeadersWidth = 51;
            dtgDanhSachTaiKhoan.RowTemplate.Height = 24;
            dtgDanhSachTaiKhoan.Size = new Size(1015, 615);
            dtgDanhSachTaiKhoan.TabIndex = 29;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.LightPink;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnThemMoi.Location = new Point(816, 31);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(188, 37);
            btnThemMoi.TabIndex = 28;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnXuatExcel.Location = new Point(573, 31);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(167, 37);
            btnXuatExcel.TabIndex = 27;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search2;
            pictureBox1.Location = new Point(98, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13F);
            txtTimKiem.Location = new Point(143, 31);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(187, 32);
            txtTimKiem.TabIndex = 25;
            // 
            // FormDanhSachTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 681);
            Controls.Add(dtgDanhSachTaiKhoan);
            Controls.Add(btnThemMoi);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Name = "FormDanhSachTaiKhoan";
            Text = "FormDanhSachTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTaiKhoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDanhSachTaiKhoan;
        private Button btnThemMoi;
        private Button btnXuatExcel;
        private PictureBox pictureBox1;
        private TextBox txtTimKiem;
    }
}