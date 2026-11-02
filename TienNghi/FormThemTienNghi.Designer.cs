namespace QuanLyHoatDongKhachSan.TienNghi
{
    partial class FormThemTienNghi
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
            txtTenTN = new TextBox();
            label5 = new Label();
            label1 = new Label();
            txtMaTN = new TextBox();
            btnThoat = new Button();
            LabelThemTienNghi = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.Moccasin;
            btnThemMoi.Font = new Font("Segoe UI", 12F);
            btnThemMoi.Location = new Point(158, 396);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(137, 59);
            btnThemMoi.TabIndex = 29;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTenTN);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaTN);
            panel1.Location = new Point(70, 148);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(507, 172);
            panel1.TabIndex = 30;
            // 
            // txtTenTN
            // 
            txtTenTN.Font = new Font("Segoe UI", 12F);
            txtTenTN.Location = new Point(214, 88);
            txtTenTN.Margin = new Padding(3, 4, 3, 4);
            txtTenTN.Name = "txtTenTN";
            txtTenTN.Size = new Size(211, 34);
            txtTenTN.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(80, 33);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 16;
            label5.Text = "Mã tiện nghi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(79, 95);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 8;
            label1.Text = "Tên tiện nghi";
            // 
            // txtMaTN
            // 
            txtMaTN.Font = new Font("Segoe UI", 12F);
            txtMaTN.Location = new Point(214, 25);
            txtMaTN.Margin = new Padding(3, 4, 3, 4);
            txtMaTN.Name = "txtMaTN";
            txtMaTN.Size = new Size(211, 34);
            txtMaTN.TabIndex = 17;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(358, 396);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 31;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // LabelThemTienNghi
            // 
            LabelThemTienNghi.AutoSize = true;
            LabelThemTienNghi.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            LabelThemTienNghi.ForeColor = Color.FromArgb(192, 64, 0);
            LabelThemTienNghi.Location = new Point(210, 23);
            LabelThemTienNghi.Name = "LabelThemTienNghi";
            LabelThemTienNghi.Size = new Size(224, 40);
            LabelThemTienNghi.TabIndex = 32;
            LabelThemTienNghi.Text = "Thêm tiện nghi";
            // 
            // FormThemTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 569);
            Controls.Add(btnThemMoi);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(LabelThemTienNghi);
            Name = "FormThemTienNghi";
            Text = "FormSuaChiTietTienNghi";
            Load += FormSuaChiTietTienNghi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThemMoi;
        private Panel panel1;
        private TextBox txtTenTN;
        private Label label5;
        private Label label1;
        private TextBox txtMaTN;
        private Button btnThoat;
        private Label LabelThemTienNghi;
    }
}