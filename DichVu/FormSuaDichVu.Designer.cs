namespace QuanLyHoatDongKhachSan.DichVu
{
    partial class FormSuaDichVu
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
            btnCapNhat = new Button();
            panel1 = new Panel();
            cbLoaiDV = new ComboBox();
            txtTenDV = new TextBox();
            txtDonGia = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSoLuongConLai = new TextBox();
            btnThoat = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(133, 21);
            label5.Name = "label5";
            label5.Size = new Size(389, 40);
            label5.TabIndex = 23;
            label5.Text = " Cập nhật thông tin dịch vụ";
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Moccasin;
            btnCapNhat.Font = new Font("Segoe UI", 12F);
            btnCapNhat.Location = new Point(166, 504);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 59);
            btnCapNhat.TabIndex = 21;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbLoaiDV);
            panel1.Controls.Add(txtTenDV);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSoLuongConLai);
            panel1.Location = new Point(74, 91);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(507, 375);
            panel1.TabIndex = 20;
            // 
            // cbLoaiDV
            // 
            cbLoaiDV.FormattingEnabled = true;
            cbLoaiDV.Items.AddRange(new object[] { "Dịch vụ giặt ủi quần áo", "", "Dịch vụ xe đưa đón", "Dịch vụ cho thuê xe máy tự lái", "Dịch vụ đặt vé máy bay", "Tour du lịch", "Dịch vụ trông trẻ", "Bơi 4 mùa", "Dịch vụ karaoke", "Dịch vụ phục vụ phòng 24/24", "Dịch vụ thu đối ngoại tệ", "Nhà hàng", "Dịch vụ hội họp", "Dịch vụ spa" });
            cbLoaiDV.Location = new Point(206, 113);
            cbLoaiDV.Name = "cbLoaiDV";
            cbLoaiDV.Size = new Size(275, 28);
            cbLoaiDV.TabIndex = 28;
            // 
            // txtTenDV
            // 
            txtTenDV.Font = new Font("Segoe UI", 12F);
            txtTenDV.Location = new Point(208, 33);
            txtTenDV.Margin = new Padding(3, 4, 3, 4);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(275, 34);
            txtTenDV.TabIndex = 27;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 12F);
            txtDonGia.Location = new Point(208, 175);
            txtDonGia.Margin = new Padding(3, 4, 3, 4);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(275, 34);
            txtDonGia.TabIndex = 25;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(47, 40);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 21;
            label6.Text = "Tên dịch vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 251);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 20;
            label4.Text = "Số lượng còn lại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(75, 181);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 19;
            label3.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(40, 107);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 18;
            label2.Text = "Loại dịch vụ";
            // 
            // txtSoLuongConLai
            // 
            txtSoLuongConLai.Font = new Font("Segoe UI", 12F);
            txtSoLuongConLai.Location = new Point(211, 245);
            txtSoLuongConLai.Margin = new Padding(3, 4, 3, 4);
            txtSoLuongConLai.Name = "txtSoLuongConLai";
            txtSoLuongConLai.Size = new Size(275, 34);
            txtSoLuongConLai.TabIndex = 15;
            txtSoLuongConLai.KeyPress += txtSoLuongConLai_KeyPress;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(366, 504);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormSuaDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 569);
            Controls.Add(label5);
            Controls.Add(btnCapNhat);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Name = "FormSuaDichVu";
            Text = "FormSuaDichVu";
            Load += FormSuaDichVu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnCapNhat;
        private Panel panel1;
        private TextBox txtTenDV;
        private TextBox txtDonGia;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSoLuongConLai;
        private Button btnThoat;
        private ComboBox cbLoaiDV;
    }
}