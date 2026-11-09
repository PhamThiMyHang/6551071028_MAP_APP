namespace QuanLyHoatDongKhachSan.PhieuThue
{
    partial class FormThuemDichVuPhongDaDung
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
            panel1 = new Panel();
            label5 = new Label();
            lbSoPhong = new Label();
            lbSoCTPhieu = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnThemDV = new Button();
            btnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbThanhTien = new Label();
            txtMaDV = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            cbTenDV = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbTenDV);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(txtMaDV);
            panel1.Controls.Add(lbThanhTien);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(53, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 323);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(193, 20);
            label5.Name = "label5";
            label5.Size = new Size(298, 40);
            label5.TabIndex = 34;
            label5.Text = "Thêm dịch vụ phòng";
            // 
            // lbSoPhong
            // 
            lbSoPhong.AutoSize = true;
            lbSoPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbSoPhong.ForeColor = Color.Red;
            lbSoPhong.Location = new Point(114, 106);
            lbSoPhong.Name = "lbSoPhong";
            lbSoPhong.Size = new Size(70, 28);
            lbSoPhong.TabIndex = 35;
            lbSoPhong.Text = "label1";
            // 
            // lbSoCTPhieu
            // 
            lbSoCTPhieu.AutoSize = true;
            lbSoCTPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbSoCTPhieu.ForeColor = Color.Blue;
            lbSoCTPhieu.Location = new Point(398, 106);
            lbSoCTPhieu.Name = "lbSoCTPhieu";
            lbSoCTPhieu.Size = new Size(70, 28);
            lbSoCTPhieu.TabIndex = 36;
            lbSoCTPhieu.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Phong;
            pictureBox1.Location = new Point(37, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "28";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PhieuThue;
            pictureBox2.Location = new Point(351, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "28";
            // 
            // btnThemDV
            // 
            btnThemDV.BackColor = Color.FromArgb(255, 192, 255);
            btnThemDV.Font = new Font("Segoe UI", 12F);
            btnThemDV.ForeColor = Color.Black;
            btnThemDV.Location = new Point(214, 511);
            btnThemDV.Name = "btnThemDV";
            btnThemDV.Size = new Size(137, 59);
            btnThemDV.TabIndex = 39;
            btnThemDV.Tag = "33";
            btnThemDV.Text = "Thêm dịch vụ";
            btnThemDV.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(192, 255, 255);
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(493, 511);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 40;
            btnThoat.Tag = "34";
            btnThoat.Text = "OK";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã dịch vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(329, 35);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(23, 136);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(337, 136);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 3;
            label4.Text = "DonGia";
            // 
            // lbThanhTien
            // 
            lbThanhTien.AutoSize = true;
            lbThanhTien.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbThanhTien.ForeColor = Color.Green;
            lbThanhTien.Location = new Point(219, 239);
            lbThanhTien.Name = "lbThanhTien";
            lbThanhTien.Size = new Size(141, 35);
            lbThanhTien.TabIndex = 4;
            lbThanhTien.Text = "Thành tiền";
            // 
            // txtMaDV
            // 
            txtMaDV.Font = new Font("Segoe UI", 13F);
            txtMaDV.Location = new Point(151, 27);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.ReadOnly = true;
            txtMaDV.Size = new Size(147, 36);
            txtMaDV.TabIndex = 36;
            txtMaDV.Tag = "36";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 13F);
            txtSoLuong.Location = new Point(151, 132);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(147, 36);
            txtSoLuong.TabIndex = 40;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 13F);
            txtDonGia.Location = new Point(462, 136);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(220, 36);
            txtDonGia.TabIndex = 42;
            // 
            // cbTenDV
            // 
            cbTenDV.Font = new Font("Segoe UI", 13F);
            cbTenDV.FormattingEnabled = true;
            cbTenDV.Location = new Point(462, 31);
            cbTenDV.Name = "cbTenDV";
            cbTenDV.Size = new Size(220, 38);
            cbTenDV.TabIndex = 38;
            // 
            // FormThuemDichVuPhongDaDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 574);
            Controls.Add(btnThoat);
            Controls.Add(btnThemDV);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbSoCTPhieu);
            Controls.Add(lbSoPhong);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "FormThuemDichVuPhongDaDung";
            Text = "Thêm dịch vụ đã dùng theo phòng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label lbSoPhong;
        private Label lbSoCTPhieu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnThemDV;
        private Button btnThoat;
        private TextBox txtSoLuong;
        private TextBox txtMaDV;
        private Label lbThanhTien;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbTenDV;
        private TextBox txtDonGia;
    }
}