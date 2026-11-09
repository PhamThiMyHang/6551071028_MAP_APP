namespace QuanLyHoatDongKhachSan.PhieuThue
{
    partial class FormSuaChiTietPhieuThue
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
            btnCapNhat = new Button();
            lbMaCTDP = new Label();
            cbTrangThaiCTDP = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(192, 255, 255);
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(457, 283);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 42;
            btnThoat.Tag = "34";
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(255, 192, 255);
            btnCapNhat.Font = new Font("Segoe UI", 12F);
            btnCapNhat.ForeColor = Color.Black;
            btnCapNhat.Location = new Point(178, 283);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 59);
            btnCapNhat.TabIndex = 41;
            btnCapNhat.Tag = "33";
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // lbMaCTDP
            // 
            lbMaCTDP.AutoSize = true;
            lbMaCTDP.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lbMaCTDP.ForeColor = Color.FromArgb(192, 64, 0);
            lbMaCTDP.Location = new Point(12, 20);
            lbMaCTDP.Name = "lbMaCTDP";
            lbMaCTDP.Size = new Size(809, 40);
            lbMaCTDP.TabIndex = 19;
            lbMaCTDP.Text = "Cập nhật thông tin chi tiết phiếu thuê  {mã CT phiếu thuê}";
            // 
            // cbTrangThaiCTDP
            // 
            cbTrangThaiCTDP.Font = new Font("Segoe UI", 13F);
            cbTrangThaiCTDP.FormattingEnabled = true;
            cbTrangThaiCTDP.Items.AddRange(new object[] { "Đang thuê", "Đã thanh toán" });
            cbTrangThaiCTDP.Location = new Point(319, 159);
            cbTrangThaiCTDP.Name = "cbTrangThaiCTDP";
            cbTrangThaiCTDP.Size = new Size(220, 38);
            cbTrangThaiCTDP.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(186, 163);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 44;
            label2.Text = "Trạng thái";
            // 
            // FormSuaChiTietPhieuThue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 365);
            Controls.Add(cbTrangThaiCTDP);
            Controls.Add(label2);
            Controls.Add(lbMaCTDP);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Name = "FormSuaChiTietPhieuThue";
            Text = "FormSuaChiTietPhieuThue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnCapNhat;
        private Label lbMaCTDP;
        private ComboBox cbTrangThaiCTDP;
        private Label label2;
    }
}