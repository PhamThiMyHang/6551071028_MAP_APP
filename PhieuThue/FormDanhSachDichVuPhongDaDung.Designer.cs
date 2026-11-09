namespace QuanLyHoatDongKhachSan.PhieuThue
{
    partial class FormDanhSachDichVuPhongDaDung
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
            btnThoat = new Button();
            btnThemDV = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbSoCTPhieu = new Label();
            lbSoPhong = new Label();
            label5 = new Label();
            dtgDanhSachDichVu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachDichVu).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(192, 255, 255);
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(437, 504);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 48;
            btnThoat.Tag = "34";
            btnThoat.Text = "OK";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnThemDV
            // 
            btnThemDV.BackColor = Color.FromArgb(255, 192, 255);
            btnThemDV.Font = new Font("Segoe UI", 12F);
            btnThemDV.ForeColor = Color.Black;
            btnThemDV.Location = new Point(158, 504);
            btnThemDV.Name = "btnThemDV";
            btnThemDV.Size = new Size(137, 59);
            btnThemDV.TabIndex = 47;
            btnThemDV.Tag = "33";
            btnThemDV.Text = "Thêm dịch vụ";
            btnThemDV.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PhieuThue;
            pictureBox2.Location = new Point(356, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "28";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Phong;
            pictureBox1.Location = new Point(42, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "28";
            // 
            // lbSoCTPhieu
            // 
            lbSoCTPhieu.AutoSize = true;
            lbSoCTPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbSoCTPhieu.ForeColor = Color.Blue;
            lbSoCTPhieu.Location = new Point(403, 104);
            lbSoCTPhieu.Name = "lbSoCTPhieu";
            lbSoCTPhieu.Size = new Size(70, 28);
            lbSoCTPhieu.TabIndex = 44;
            lbSoCTPhieu.Text = "label2";
            // 
            // lbSoPhong
            // 
            lbSoPhong.AutoSize = true;
            lbSoPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbSoPhong.ForeColor = Color.Red;
            lbSoPhong.Location = new Point(119, 104);
            lbSoPhong.Name = "lbSoPhong";
            lbSoPhong.Size = new Size(70, 28);
            lbSoPhong.TabIndex = 43;
            lbSoPhong.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(198, 18);
            label5.Name = "label5";
            label5.Size = new Size(386, 40);
            label5.TabIndex = 42;
            label5.Text = "Danh sách dịch vụ đã dùng";
            // 
            // dtgDanhSachDichVu
            // 
            dtgDanhSachDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachDichVu.Location = new Point(55, 177);
            dtgDanhSachDichVu.Name = "dtgDanhSachDichVu";
            dtgDanhSachDichVu.RowHeadersWidth = 51;
            dtgDanhSachDichVu.Size = new Size(672, 283);
            dtgDanhSachDichVu.TabIndex = 49;
            // 
            // FormDanhSachDichVuPhongDaDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(dtgDanhSachDichVu);
            Controls.Add(btnThoat);
            Controls.Add(btnThemDV);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbSoCTPhieu);
            Controls.Add(lbSoPhong);
            Controls.Add(label5);
            Name = "FormDanhSachDichVuPhongDaDung";
            Text = "FormDanhSachDichVuPhongDaDung";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachDichVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnThemDV;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbSoCTPhieu;
        private Label lbSoPhong;
        private Label label5;
        private DataGridView dtgDanhSachDichVu;
    }
}