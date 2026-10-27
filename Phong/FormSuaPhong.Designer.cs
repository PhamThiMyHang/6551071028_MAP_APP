namespace QuanLyHoatDongKhachSan.Phong
{
    partial class FormSuaPhong
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
            btnCapNhat = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbTrangThaiPhong = new ComboBox();
            cbTinhTrangDonDep = new ComboBox();
            cbLoaiPhong = new ComboBox();
            txtGhiChu = new TextBox();
            btnThoat = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Moccasin;
            btnCapNhat.Font = new Font("Segoe UI", 12F);
            btnCapNhat.Location = new Point(157, 493);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 59);
            btnCapNhat.TabIndex = 14;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbTrangThaiPhong);
            panel1.Controls.Add(cbTinhTrangDonDep);
            panel1.Controls.Add(cbLoaiPhong);
            panel1.Controls.Add(txtGhiChu);
            panel1.Location = new Point(65, 100);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(507, 375);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(113, 230);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 20;
            label4.Text = "Ghi chú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(83, 101);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 19;
            label3.Text = "Loại phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(10, 170);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 18;
            label2.Text = "Tình trạng dọn dẹp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(28, 39);
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
            cbTrangThaiPhong.Location = new Point(208, 36);
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
            cbTinhTrangDonDep.Location = new Point(208, 170);
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
            cbLoaiPhong.Location = new Point(208, 101);
            cbLoaiPhong.Margin = new Padding(3, 4, 3, 4);
            cbLoaiPhong.Name = "cbLoaiPhong";
            cbLoaiPhong.Size = new Size(275, 36);
            cbLoaiPhong.TabIndex = 12;
            cbLoaiPhong.Text = "Loại phòng";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI", 12F);
            txtGhiChu.Location = new Point(203, 230);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(275, 119);
            txtGhiChu.TabIndex = 15;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(357, 493);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(123, 30);
            label5.Name = "label5";
            label5.Size = new Size(371, 40);
            label5.TabIndex = 15;
            label5.Text = "Cập nhật thông tin phòng";
            // 
            // FormSuaPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 568);
            Controls.Add(label5);
            Controls.Add(btnCapNhat);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Name = "FormSuaPhong";
            Padding = new Padding(3, 4, 3, 4);
            Text = "FormSuaPhong";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCapNhat;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbTrangThaiPhong;
        private ComboBox cbTinhTrangDonDep;
        private ComboBox cbLoaiPhong;
        private TextBox txtGhiChu;
        private Button btnThoat;
        private Label label5;
    }
}