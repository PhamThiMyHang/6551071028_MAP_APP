namespace QuanLyHoatDongKhachSan.TaiKhoan
{
    partial class FormThemTaiKhoan
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
            label5 = new Label();
            panel1 = new Panel();
            txtMatKhau = new TextBox();
            txtTenTK = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            btnThoat = new Button();
            btnThemMoi = new Button();
            cbMaNV = new ComboBox();
            cbCapDoQuyen = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(147, 24);
            label5.Name = "label5";
            label5.Size = new Size(365, 40);
            label5.TabIndex = 28;
            label5.Text = "Thêm thông tin tài khoản";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbCapDoQuyen);
            panel1.Controls.Add(cbMaNV);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenTK);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(64, 87);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(554, 292);
            panel1.TabIndex = 30;
            panel1.Paint += panel1_Paint;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(232, 212);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(272, 34);
            txtMatKhau.TabIndex = 41;
            // 
            // txtTenTK
            // 
            txtTenTK.Font = new Font("Segoe UI", 12F);
            txtTenTK.Location = new Point(232, 82);
            txtTenTK.Margin = new Padding(3, 4, 3, 4);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(263, 34);
            txtTenTK.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(41, 28);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 16;
            label1.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(42, 157);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 19;
            label3.Text = "Cấp độ quyền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(83, 215);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 18;
            label2.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(42, 88);
            label6.Name = "label6";
            label6.Size = new Size(128, 28);
            label6.TabIndex = 8;
            label6.Text = "Tên Tài khoản";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(355, 416);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 31;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.Moccasin;
            btnThemMoi.Font = new Font("Segoe UI", 12F);
            btnThemMoi.Location = new Point(155, 416);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(137, 59);
            btnThemMoi.TabIndex = 29;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            // 
            // cbMaNV
            // 
            cbMaNV.Font = new Font("Segoe UI", 12F);
            cbMaNV.FormattingEnabled = true;
            cbMaNV.Items.AddRange(new object[] { "Người quản trị hệ thống", "Quản lý khách sạn", "Nhân viên" });
            cbMaNV.Location = new Point(232, 25);
            cbMaNV.Margin = new Padding(3, 4, 3, 4);
            cbMaNV.Name = "cbMaNV";
            cbMaNV.Size = new Size(272, 36);
            cbMaNV.TabIndex = 43;
            // 
            // cbCapDoQuyen
            // 
            cbCapDoQuyen.Font = new Font("Segoe UI", 12F);
            cbCapDoQuyen.FormattingEnabled = true;
            cbCapDoQuyen.Items.AddRange(new object[] { "3", "2", "1", "0" });
            cbCapDoQuyen.Location = new Point(232, 149);
            cbCapDoQuyen.Margin = new Padding(3, 4, 3, 4);
            cbCapDoQuyen.Name = "cbCapDoQuyen";
            cbCapDoQuyen.Size = new Size(272, 36);
            cbCapDoQuyen.TabIndex = 46;
            // 
            // FormThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 488);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(btnThemMoi);
            Name = "FormThemTaiKhoan";
            Text = "FormThemTaiKhoan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel panel1;
        private ComboBox cbMaNV;
        private TextBox txtMatKhau;
        private TextBox txtTenTK;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Button btnThoat;
        private Button btnThemMoi;
        private ComboBox cbCapDoQuyen;
    }
}