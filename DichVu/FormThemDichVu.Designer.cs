namespace QuanLyHoatDongKhachSan.DichVu
{
    partial class FormThemDichVu
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
            cbLoaiDV = new ComboBox();
            label4 = new Label();
            txtSoLuongConLai = new TextBox();
            txtDonGia = new TextBox();
            txtTenDV = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMaDV = new TextBox();
            btnThoat = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.Moccasin;
            btnThemMoi.Font = new Font("Segoe UI", 12F);
            btnThemMoi.Location = new Point(176, 490);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(137, 59);
            btnThemMoi.TabIndex = 17;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbLoaiDV);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSoLuongConLai);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(txtTenDV);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaDV);
            panel1.Location = new Point(88, 91);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(507, 393);
            panel1.TabIndex = 18;
            // 
            // cbLoaiDV
            // 
            cbLoaiDV.FormattingEnabled = true;
            cbLoaiDV.Location = new Point(214, 160);
            cbLoaiDV.Name = "cbLoaiDV";
            cbLoaiDV.Size = new Size(211, 28);
            cbLoaiDV.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(22, 299);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 26;
            label4.Text = "Số lượng còn lại";
            // 
            // txtSoLuongConLai
            // 
            txtSoLuongConLai.Font = new Font("Segoe UI", 12F);
            txtSoLuongConLai.Location = new Point(214, 293);
            txtSoLuongConLai.Margin = new Padding(3, 4, 3, 4);
            txtSoLuongConLai.Name = "txtSoLuongConLai";
            txtSoLuongConLai.Size = new Size(275, 34);
            txtSoLuongConLai.TabIndex = 25;
            txtSoLuongConLai.KeyPress += txtSoLuongConLai_KeyPress;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 12F);
            txtDonGia.Location = new Point(214, 218);
            txtDonGia.Margin = new Padding(3, 4, 3, 4);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(211, 34);
            txtDonGia.TabIndex = 22;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // txtTenDV
            // 
            txtTenDV.Font = new Font("Segoe UI", 12F);
            txtTenDV.Location = new Point(214, 88);
            txtTenDV.Margin = new Padding(3, 4, 3, 4);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(211, 34);
            txtTenDV.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(77, 29);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 16;
            label5.Text = "Mã dịch vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(60, 153);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 19;
            label3.Text = "Loại dịch vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(95, 224);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 18;
            label2.Text = "Đơn giá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(76, 91);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 8;
            label1.Text = "Tên dịch vụ";
            // 
            // txtMaDV
            // 
            txtMaDV.Font = new Font("Segoe UI", 12F);
            txtMaDV.Location = new Point(214, 25);
            txtMaDV.Margin = new Padding(3, 4, 3, 4);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(211, 34);
            txtMaDV.TabIndex = 17;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(376, 490);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 19;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(192, 64, 0);
            label6.Location = new Point(210, 26);
            label6.Name = "label6";
            label6.Size = new Size(257, 40);
            label6.TabIndex = 28;
            label6.Text = "Thông tin dịch vụ";
            label6.Click += label6_Click;
            // 
            // FormThemDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 574);
            Controls.Add(label6);
            Controls.Add(btnThemMoi);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Name = "FormThemDichVu";
            Text = "Thêm dịch vụ";
            Load += FormThemDichVu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThemMoi;
        private Panel panel1;
        private TextBox txtGiaGio;
        private Label label4;
        private TextBox txtSoLuongConLai;
        private TextBox txtSoNguoiToiDa;
        private TextBox txtDonGia;
        private TextBox txtTenDV;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMaDV;
        private Button btnThoat;
        private ComboBox cbLoaiDV;
        private Label label6;
    }
}