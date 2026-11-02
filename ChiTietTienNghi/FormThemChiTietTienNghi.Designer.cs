namespace QuanLyHoatDongKhachSan.ChiTietTienNghi
{
    partial class FormThemChiTietTienNghi
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
            cbTenTN = new ComboBox();
            txtSoLuong = new TextBox();
            label5 = new Label();
            label1 = new Label();
            btnThoat = new Button();
            LabelThemTienNghi = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Moccasin;
            btnCapNhat.Font = new Font("Segoe UI", 12F);
            btnCapNhat.Location = new Point(176, 441);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 59);
            btnCapNhat.TabIndex = 33;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbTenTN);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(88, 193);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(507, 172);
            panel1.TabIndex = 34;
            // 
            // cbTenTN
            // 
            cbTenTN.FormattingEnabled = true;
            cbTenTN.Location = new Point(214, 32);
            cbTenTN.Name = "cbTenTN";
            cbTenTN.Size = new Size(214, 28);
            cbTenTN.TabIndex = 22;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 12F);
            txtSoLuong.Location = new Point(214, 88);
            txtSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(211, 34);
            txtSoLuong.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(67, 28);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 16;
            label5.Text = "Tên tiện nghi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(98, 94);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 8;
            label1.Text = "Số lượng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(376, 441);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 35;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // LabelThemTienNghi
            // 
            LabelThemTienNghi.AutoSize = true;
            LabelThemTienNghi.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            LabelThemTienNghi.ForeColor = Color.FromArgb(192, 64, 0);
            LabelThemTienNghi.Location = new Point(22, 56);
            LabelThemTienNghi.Name = "LabelThemTienNghi";
            LabelThemTienNghi.Size = new Size(631, 40);
            LabelThemTienNghi.TabIndex = 36;
            LabelThemTienNghi.Text = "Thêm mới thông tin tiện nghi của loại phòng";
            // 
            // FormThemChiTietTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 569);
            Controls.Add(btnCapNhat);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(LabelThemTienNghi);
            Name = "FormThemChiTietTienNghi";
            Text = "FormThemChiTietTienNghi";
            Load += FormThemChiTietTienNghi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCapNhat;
        private Panel panel1;
        private TextBox txtSoLuong;
        private Label label5;
        private Label label1;
        private Button btnThoat;
        private Label LabelThemTienNghi;
        private ComboBox cbTenTN;
    }
}