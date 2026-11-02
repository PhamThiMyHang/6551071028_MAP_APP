namespace QuanLyHoatDongKhachSan.ChiTietTienNghi
{
    partial class FormSuaChiTietTienNghi
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
            txtSoLuong = new TextBox();
            label5 = new Label();
            label1 = new Label();
            btnThoat = new Button();
            LabelThemTienNghi = new Label();
            txtTenTN = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Moccasin;
            btnCapNhat.Font = new Font("Segoe UI", 12F);
            btnCapNhat.Location = new Point(180, 447);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 59);
            btnCapNhat.TabIndex = 37;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTenTN);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(92, 199);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(507, 172);
            panel1.TabIndex = 38;
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
            label5.Location = new Point(70, 32);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 16;
            label5.Text = "Tên tiện nghi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(101, 98);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 8;
            label1.Text = "Số lượng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(380, 447);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 39;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // LabelThemTienNghi
            // 
            LabelThemTienNghi.AutoSize = true;
            LabelThemTienNghi.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            LabelThemTienNghi.ForeColor = Color.FromArgb(192, 64, 0);
            LabelThemTienNghi.Location = new Point(26, 62);
            LabelThemTienNghi.Name = "LabelThemTienNghi";
            LabelThemTienNghi.Size = new Size(615, 40);
            LabelThemTienNghi.TabIndex = 40;
            LabelThemTienNghi.Text = "Cập nhật thông tin tiện nghi của loại phòng";
            // 
            // txtTenTN
            // 
            txtTenTN.AcceptsReturn = true;
            txtTenTN.Font = new Font("Segoe UI", 12F);
            txtTenTN.Location = new Point(214, 26);
            txtTenTN.Margin = new Padding(3, 4, 3, 4);
            txtTenTN.Name = "txtTenTN";
            txtTenTN.ReadOnly = true;
            txtTenTN.Size = new Size(211, 34);
            txtTenTN.TabIndex = 22;
            // 
            // FormSuaChiTietTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 569);
            Controls.Add(btnCapNhat);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(LabelThemTienNghi);
            Name = "FormSuaChiTietTienNghi";
            Text = "FormSuaChiTietTienNghi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCapNhat;
        private Panel panel1;
        private TextBox txtTenTN;
        private TextBox txtSoLuong;
        private Label label5;
        private Label label1;
        private Button btnThoat;
        private Label LabelThemTienNghi;
    }
}