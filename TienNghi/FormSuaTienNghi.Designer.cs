namespace QuanLyHoatDongKhachSan.TienNghi
{
    partial class FormSuaTienNghi
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
            txtTenTN = new TextBox();
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
            btnCapNhat.Location = new Point(235, 382);
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
            panel1.Controls.Add(txtTenTN);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(147, 134);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(507, 146);
            panel1.TabIndex = 34;
            // 
            // txtTenTN
            // 
            txtTenTN.Font = new Font("Segoe UI", 12F);
            txtTenTN.Location = new Point(186, 52);
            txtTenTN.Margin = new Padding(3, 4, 3, 4);
            txtTenTN.Name = "txtTenTN";
            txtTenTN.Size = new Size(211, 34);
            txtTenTN.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 55);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 8;
            label1.Text = "Tên tiện nghi";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(435, 382);
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
            LabelThemTienNghi.Location = new Point(285, 52);
            LabelThemTienNghi.Name = "LabelThemTienNghi";
            LabelThemTienNghi.Size = new Size(269, 40);
            LabelThemTienNghi.TabIndex = 36;
            LabelThemTienNghi.Text = "Cập nhật tiện nghi";
            // 
            // FormSuaTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCapNhat);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(LabelThemTienNghi);
            Name = "FormSuaTienNghi";
            Text = "FormThemTienNghi";
            Load += FormSuaTienNghi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCapNhat;
        private Panel panel1;
        private TextBox txtTenTN;
        private Label label1;
        private Button btnThoat;
        private Label LabelThemTienNghi;
    }
}