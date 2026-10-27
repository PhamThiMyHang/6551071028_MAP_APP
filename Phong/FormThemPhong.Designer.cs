namespace QuanLyHoatDongKhachSan.Phong
{
    partial class FormThemPhong
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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbTrangThaiPhong = new ComboBox();
            cbTinhTrangDonDep = new ComboBox();
            cbLoaiPhong = new ComboBox();
            txtGhiChu = new TextBox();
            txtMaPhong = new TextBox();
            btnThemMoi = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(332, 502);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbTrangThaiPhong);
            panel1.Controls.Add(cbTinhTrangDonDep);
            panel1.Controls.Add(cbLoaiPhong);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(txtMaPhong);
            panel1.Location = new Point(44, 38);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(507, 458);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(60, 65);
            label5.Name = "label5";
            label5.Size = new Size(128, 28);
            label5.TabIndex = 16;
            label5.Text = "Mã số phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(110, 319);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 20;
            label4.Text = "Ghi chú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(78, 190);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 19;
            label3.Text = "Loại phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(5, 259);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 18;
            label2.Text = "Tình trạng dọn dẹp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(23, 128);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 8;
            label1.Text = "Trạng thái phòng";
            // 
            // cbTrangThaiPhong
            // 
            cbTrangThaiPhong.Font = new Font("Segoe UI", 12F);
            cbTrangThaiPhong.FormattingEnabled = true;
            cbTrangThaiPhong.Items.AddRange(new object[] { "Bình thường", "Đang sửa chữa" });
            cbTrangThaiPhong.Location = new Point(203, 125);
            cbTrangThaiPhong.Margin = new Padding(3, 4, 3, 4);
            cbTrangThaiPhong.Name = "cbTrangThaiPhong";
            cbTrangThaiPhong.Size = new Size(275, 36);
            cbTrangThaiPhong.TabIndex = 9;
            cbTrangThaiPhong.Text = "Trạng thái phòng";
            // 
            // cbTinhTrangDonDep
            // 
            cbTinhTrangDonDep.Font = new Font("Segoe UI", 12F);
            cbTinhTrangDonDep.FormattingEnabled = true;
            cbTinhTrangDonDep.Items.AddRange(new object[] { "Đã dọn dẹp", "Chưa dọn" });
            cbTinhTrangDonDep.Location = new Point(203, 256);
            cbTinhTrangDonDep.Margin = new Padding(3, 4, 3, 4);
            cbTinhTrangDonDep.Name = "cbTinhTrangDonDep";
            cbTinhTrangDonDep.Size = new Size(275, 36);
            cbTinhTrangDonDep.TabIndex = 10;
            cbTinhTrangDonDep.Text = "Tình trạng dọn dẹp";
            // 
            // cbLoaiPhong
            // 
            cbLoaiPhong.Font = new Font("Segoe UI", 12F);
            cbLoaiPhong.FormattingEnabled = true;
            cbLoaiPhong.Location = new Point(203, 190);
            cbLoaiPhong.Margin = new Padding(3, 4, 3, 4);
            cbLoaiPhong.Name = "cbLoaiPhong";
            cbLoaiPhong.Size = new Size(275, 36);
            cbLoaiPhong.TabIndex = 12;
            cbLoaiPhong.Text = "Loại phòng";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI", 12F);
            txtGhiChu.Location = new Point(203, 319);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(275, 119);
            txtGhiChu.TabIndex = 15;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Font = new Font("Segoe UI", 12F);
            txtMaPhong.Location = new Point(203, 69);
            txtMaPhong.Margin = new Padding(3, 4, 3, 4);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(211, 34);
            txtMaPhong.TabIndex = 17;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.Moccasin;
            btnThemMoi.Font = new Font("Segoe UI", 12F);
            btnThemMoi.Location = new Point(132, 502);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(137, 59);
            btnThemMoi.TabIndex = 1;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // FormThemPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 578);
            Controls.Add(btnThemMoi);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Name = "FormThemPhong";
            Padding = new Padding(3, 4, 3, 4);
            Text = "FormThemPhong";
            Load += FormThemPhong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThoat;
        private Panel panel1;
        private Button btnThemMoi;
        private ComboBox cbLoaiPhong;
        private TextBox txtGhiChu;
        private TextBox txtMaPhong;
        private Label label1;
        private ComboBox cbTrangThaiPhong;
        private ComboBox cbTinhTrangDonDep;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}