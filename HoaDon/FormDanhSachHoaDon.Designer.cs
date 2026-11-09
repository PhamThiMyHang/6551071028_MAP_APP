namespace QuanLyHoatDongKhachSan.HoaDon
{
    partial class FormDanhSachHoaDon
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
            dtgDanhSachHoaDon = new DataGridView();
            btnXuatExcel = new Button();
            pictureBox1 = new PictureBox();
            txtTimKiem = new TextBox();
            dtpNgayLap = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachHoaDon
            // 
            dtgDanhSachHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachHoaDon.Location = new Point(14, 72);
            dtgDanhSachHoaDon.Name = "dtgDanhSachHoaDon";
            dtgDanhSachHoaDon.RowHeadersWidth = 51;
            dtgDanhSachHoaDon.RowTemplate.Height = 24;
            dtgDanhSachHoaDon.Size = new Size(1015, 615);
            dtgDanhSachHoaDon.TabIndex = 29;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnXuatExcel.Location = new Point(826, 10);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(167, 37);
            btnXuatExcel.TabIndex = 27;
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
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13F);
            txtTimKiem.Location = new Point(132, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(187, 32);
            txtTimKiem.TabIndex = 25;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(427, 14);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(250, 27);
            dtpNgayLap.TabIndex = 30;
            // 
            // FormDanhSachHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 694);
            Controls.Add(dtpNgayLap);
            Controls.Add(dtgDanhSachHoaDon);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Name = "FormDanhSachHoaDon";
            Text = "FormDanhSachHoaDon";
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDanhSachHoaDon;
        private Button btnXuatExcel;
        private PictureBox pictureBox1;
        private TextBox txtTimKiem;
        private DateTimePicker dtpNgayLap;
    }
}