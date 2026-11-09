namespace QuanLyHoatDongKhachSan.PhieuThue
{
    partial class FormDanhSachPhieuThue
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
            dtgDanhSachPhieuThue = new DataGridView();
            btnDatPhong = new Button();
            btnXuatExcel = new Button();
            pictureBox1 = new PictureBox();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhieuThue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachPhieuThue
            // 
            dtgDanhSachPhieuThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachPhieuThue.Location = new Point(14, 72);
            dtgDanhSachPhieuThue.Name = "dtgDanhSachPhieuThue";
            dtgDanhSachPhieuThue.RowHeadersWidth = 51;
            dtgDanhSachPhieuThue.RowTemplate.Height = 24;
            dtgDanhSachPhieuThue.Size = new Size(1015, 615);
            dtgDanhSachPhieuThue.TabIndex = 24;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.LightPink;
            btnDatPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnDatPhong.Location = new Point(805, 12);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(188, 37);
            btnDatPhong.TabIndex = 23;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnXuatExcel.Location = new Point(562, 12);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(167, 37);
            btnXuatExcel.TabIndex = 22;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search2;
            pictureBox1.Location = new Point(87, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13F);
            txtTimKiem.Location = new Point(132, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(187, 32);
            txtTimKiem.TabIndex = 20;
            // 
            // FormDanhSachPhieuThue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 694);
            Controls.Add(dtgDanhSachPhieuThue);
            Controls.Add(btnDatPhong);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Name = "FormDanhSachPhieuThue";
            Text = "FormDanhSachPhieuThue";
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhieuThue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDanhSachPhieuThue;
        private Button btnDatPhong;
        private Button btnXuatExcel;
        private PictureBox pictureBox1;
        private TextBox txtTimKiem;
    }
}