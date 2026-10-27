namespace QuanLyHoatDongKhachSan.LoaiPhong
{
    partial class FormThemLoaiPhong
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
            btnThemMoi = new Button();
            panel1 = new Panel();
            txtSoNguoiToiDa = new TextBox();
            txtSoGiuong = new TextBox();
            txtTenLP = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMaLoaiPhong = new TextBox();
            btnThoat = new Button();
            txtGiaGio = new TextBox();
            label4 = new Label();
            label6 = new Label();
            txtGiaNgay = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.Moccasin;
            btnThemMoi.Font = new Font("Segoe UI", 12F);
            btnThemMoi.Location = new Point(174, 504);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(137, 59);
            btnThemMoi.TabIndex = 14;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtGiaGio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtGiaNgay);
            panel1.Controls.Add(txtSoNguoiToiDa);
            panel1.Controls.Add(txtSoGiuong);
            panel1.Controls.Add(txtTenLP);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaLoaiPhong);
            panel1.Location = new Point(86, 40);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(507, 458);
            panel1.TabIndex = 15;
            // 
            // txtSoNguoiToiDa
            // 
            txtSoNguoiToiDa.Font = new Font("Segoe UI", 12F);
            txtSoNguoiToiDa.Location = new Point(203, 194);
            txtSoNguoiToiDa.Margin = new Padding(3, 4, 3, 4);
            txtSoNguoiToiDa.Name = "txtSoNguoiToiDa";
            txtSoNguoiToiDa.Size = new Size(211, 34);
            txtSoNguoiToiDa.TabIndex = 23;
            // 
            // txtSoGiuong
            // 
            txtSoGiuong.Font = new Font("Segoe UI", 12F);
            txtSoGiuong.Location = new Point(214, 261);
            txtSoGiuong.Margin = new Padding(3, 4, 3, 4);
            txtSoGiuong.Name = "txtSoGiuong";
            txtSoGiuong.Size = new Size(211, 34);
            txtSoGiuong.TabIndex = 22;
            // 
            // txtTenLP
            // 
            txtTenLP.Font = new Font("Segoe UI", 12F);
            txtTenLP.Location = new Point(203, 132);
            txtTenLP.Margin = new Padding(3, 4, 3, 4);
            txtTenLP.Name = "txtTenLP";
            txtTenLP.Size = new Size(211, 34);
            txtTenLP.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(63, 69);
            label5.Name = "label5";
            label5.Size = new Size(128, 28);
            label5.TabIndex = 16;
            label5.Text = "Mã số phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(37, 194);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 19;
            label3.Text = "Số người tối đa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(81, 264);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 18;
            label2.Text = "Số giường";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(26, 132);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 8;
            label1.Text = "Tên loại phòng";
            // 
            // txtMaLoaiPhong
            // 
            txtMaLoaiPhong.Font = new Font("Segoe UI", 12F);
            txtMaLoaiPhong.Location = new Point(203, 69);
            txtMaLoaiPhong.Margin = new Padding(3, 4, 3, 4);
            txtMaLoaiPhong.Name = "txtMaLoaiPhong";
            txtMaLoaiPhong.Size = new Size(211, 34);
            txtMaLoaiPhong.TabIndex = 17;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(374, 504);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnNutThoa_Click;
            // 
            // txtGiaGio
            // 
            txtGiaGio.Font = new Font("Segoe UI", 12F);
            txtGiaGio.Location = new Point(203, 400);
            txtGiaGio.Margin = new Padding(3, 4, 3, 4);
            txtGiaGio.Name = "txtGiaGio";
            txtGiaGio.Size = new Size(275, 34);
            txtGiaGio.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(101, 337);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 26;
            label4.Text = "Giá ngày";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(104, 404);
            label6.Margin = new Padding(3, 4, 3, 4);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
            label6.TabIndex = 27;
            label6.Text = "Giá giờ";
            // 
            // txtGiaNgay
            // 
            txtGiaNgay.Font = new Font("Segoe UI", 12F);
            txtGiaNgay.Location = new Point(203, 337);
            txtGiaNgay.Margin = new Padding(3, 4, 3, 4);
            txtGiaNgay.Name = "txtGiaNgay";
            txtGiaNgay.Size = new Size(275, 34);
            txtGiaNgay.TabIndex = 25;
            // 
            // FormThemLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 574);
            Controls.Add(btnThemMoi);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Name = "FormThemLoaiPhong";
            Text = "FormThemLoaiPhong";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThemMoi;
        private Panel panel1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMaLoaiPhong;
        private Button btnThoat;
        private TextBox txtTenLP;
        private TextBox txtSoGiuong;
        private TextBox txtSoNguoiToiDa;
        private TextBox txtGiaGio;
        private Label label4;
        private Label label6;
        private TextBox txtGiaNgay;
    }
}