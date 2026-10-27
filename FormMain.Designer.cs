namespace QuanLyHoatDongKhachSan
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelTenKhachSan = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            lblTenNguoiDung = new Label();
            panel4 = new Panel();
            button10 = new Button();
            button9 = new Button();
            btnSoDoPhong = new Button();
            button11 = new Button();
            button12 = new Button();
            btnQuanLyPhong = new Button();
            button6 = new Button();
            button7 = new Button();
            button4 = new Button();
            button5 = new Button();
            btnTrangChu = new Button();
            button13 = new Button();
            panelMain = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(labelTenKhachSan);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1834, 92);
            panel1.TabIndex = 0;
            panel1.Tag = "0";
            panel1.Paint += panel1_Paint;
            // 
            // labelTenKhachSan
            // 
            labelTenKhachSan.AutoSize = true;
            labelTenKhachSan.BackColor = Color.Transparent;
            labelTenKhachSan.Font = new Font("Segoe UI Semibold", 18F);
            labelTenKhachSan.ForeColor = Color.LightSalmon;
            labelTenKhachSan.Location = new Point(66, 19);
            labelTenKhachSan.Name = "labelTenKhachSan";
            labelTenKhachSan.Size = new Size(312, 41);
            labelTenKhachSan.TabIndex = 1;
            labelTenKhachSan.Text = "Hotel Managemment";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MediumSeaGreen;
            pictureBox1.Image = Properties.Resources.Menu;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblTenNguoiDung);
            panel2.Location = new Point(1, 94);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 198);
            panel2.TabIndex = 1;
            panel2.Tag = "0";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Palatino Linotype", 13F);
            linkLabel1.ForeColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(0, 6);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 29);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Tag = "0";
            linkLabel1.Text = "Đăng xuất";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(101, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(3, 4, 3, 4);
            pictureBox2.Size = new Size(87, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "1";
            // 
            // lblTenNguoiDung
            // 
            lblTenNguoiDung.AutoSize = true;
            lblTenNguoiDung.BackColor = Color.Transparent;
            lblTenNguoiDung.Font = new Font("Microsoft Tai Le", 13F, FontStyle.Bold);
            lblTenNguoiDung.ForeColor = SystemColors.ActiveCaptionText;
            lblTenNguoiDung.Location = new Point(28, 159);
            lblTenNguoiDung.Name = "lblTenNguoiDung";
            lblTenNguoiDung.Size = new Size(176, 29);
            lblTenNguoiDung.TabIndex = 2;
            lblTenNguoiDung.Text = "Ten nguoi dung";
            lblTenNguoiDung.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Controls.Add(button10);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(btnSoDoPhong);
            panel4.Controls.Add(button11);
            panel4.Controls.Add(button12);
            panel4.Controls.Add(btnQuanLyPhong);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(btnTrangChu);
            panel4.Controls.Add(button13);
            panel4.Location = new Point(1, 289);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 1161);
            panel4.TabIndex = 4;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkCyan;
            button10.FlatAppearance.BorderColor = Color.DarkGray;
            button10.FlatAppearance.MouseDownBackColor = Color.Black;
            button10.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Microsoft Sans Serif", 13F);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Image = Properties.Resources.MenuDanhSachHoaDon1;
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(0, 295);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(307, 51);
            button10.TabIndex = 13;
            button10.Tag = "";
            button10.Text = "Danh sách hóa đơn";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkCyan;
            button9.FlatAppearance.BorderColor = Color.DarkGray;
            button9.FlatAppearance.MouseDownBackColor = Color.Black;
            button9.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 13F);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Image = Properties.Resources.MenuDatPhong;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(-3, 236);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(307, 51);
            button9.TabIndex = 12;
            button9.Tag = "";
            button9.Text = "Danh sách đặt phòng";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // btnSoDoPhong
            // 
            btnSoDoPhong.BackColor = Color.DarkCyan;
            btnSoDoPhong.FlatAppearance.BorderColor = Color.DarkGray;
            btnSoDoPhong.FlatAppearance.MouseDownBackColor = Color.Black;
            btnSoDoPhong.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnSoDoPhong.FlatStyle = FlatStyle.Flat;
            btnSoDoPhong.Font = new Font("Microsoft Sans Serif", 13F);
            btnSoDoPhong.ForeColor = SystemColors.ButtonHighlight;
            btnSoDoPhong.Image = Properties.Resources.MenuSoDoPhong;
            btnSoDoPhong.ImageAlign = ContentAlignment.MiddleLeft;
            btnSoDoPhong.Location = new Point(-1, 59);
            btnSoDoPhong.Margin = new Padding(3, 4, 3, 4);
            btnSoDoPhong.Name = "btnSoDoPhong";
            btnSoDoPhong.Size = new Size(307, 51);
            btnSoDoPhong.TabIndex = 5;
            btnSoDoPhong.Tag = "";
            btnSoDoPhong.Text = "Sơ đồ phòng";
            btnSoDoPhong.UseVisualStyleBackColor = false;
            btnSoDoPhong.Click += btnSoDoPhong_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.DarkCyan;
            button11.FlatAppearance.BorderColor = Color.DarkGray;
            button11.FlatAppearance.MouseDownBackColor = Color.Black;
            button11.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Microsoft Sans Serif", 13F);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Image = Properties.Resources.MenuQuanLyDichVu;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(-2, 354);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(307, 51);
            button11.TabIndex = 14;
            button11.Tag = "";
            button11.Text = "Danh sách dịch vụ";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.DarkCyan;
            button12.FlatAppearance.BorderColor = Color.DarkGray;
            button12.FlatAppearance.MouseDownBackColor = Color.Black;
            button12.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Microsoft Sans Serif", 13F);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Image = Properties.Resources.MenuTienNghi;
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(0, 413);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(307, 51);
            button12.TabIndex = 15;
            button12.Tag = "";
            button12.Text = "Danh sách tiện nghi";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // btnQuanLyPhong
            // 
            btnQuanLyPhong.BackColor = Color.DarkCyan;
            btnQuanLyPhong.FlatAppearance.BorderColor = Color.DarkGray;
            btnQuanLyPhong.FlatAppearance.MouseDownBackColor = Color.Black;
            btnQuanLyPhong.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnQuanLyPhong.FlatStyle = FlatStyle.Flat;
            btnQuanLyPhong.Font = new Font("Microsoft Sans Serif", 13F);
            btnQuanLyPhong.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyPhong.Image = Properties.Resources.MenuPhong;
            btnQuanLyPhong.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLyPhong.Location = new Point(-1, 118);
            btnQuanLyPhong.Margin = new Padding(3, 4, 3, 4);
            btnQuanLyPhong.Name = "btnQuanLyPhong";
            btnQuanLyPhong.Size = new Size(307, 51);
            btnQuanLyPhong.TabIndex = 6;
            btnQuanLyPhong.Tag = "";
            btnQuanLyPhong.Text = "Phòng";
            btnQuanLyPhong.UseVisualStyleBackColor = false;
            btnQuanLyPhong.Click += btnQuanLyPhong_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkCyan;
            button6.FlatAppearance.BorderColor = Color.DarkGray;
            button6.FlatAppearance.MouseDownBackColor = Color.Black;
            button6.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 13F);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = Properties.Resources.MenuQuanLyKhachHang;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 472);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(307, 51);
            button6.TabIndex = 9;
            button6.Tag = "";
            button6.Text = "Danh sách khách hàng";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkCyan;
            button7.FlatAppearance.BorderColor = Color.DarkGray;
            button7.FlatAppearance.MouseDownBackColor = Color.Black;
            button7.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 13F);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = Properties.Resources.MenuQuanLyNhanVien;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 531);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(307, 51);
            button7.TabIndex = 10;
            button7.Tag = "";
            button7.Text = "Danh sách nhân viên";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkCyan;
            button4.FlatAppearance.BorderColor = Color.DarkGray;
            button4.FlatAppearance.MouseDownBackColor = Color.Black;
            button4.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 13F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.MenuLoaiPhong;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-1, 177);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(307, 51);
            button4.TabIndex = 7;
            button4.Tag = "";
            button4.Text = "Loại phòng";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkCyan;
            button5.FlatAppearance.BorderColor = Color.DarkGray;
            button5.FlatAppearance.MouseDownBackColor = Color.Black;
            button5.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 13F);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = Properties.Resources.MenuQuanLyTaiKhoan;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-1, 590);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(307, 51);
            button5.TabIndex = 8;
            button5.Tag = "";
            button5.Text = "Danh sách tài khoản";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.DarkCyan;
            btnTrangChu.FlatAppearance.BorderColor = Color.DarkGray;
            btnTrangChu.FlatAppearance.MouseDownBackColor = Color.Black;
            btnTrangChu.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Microsoft Sans Serif", 13F);
            btnTrangChu.ForeColor = SystemColors.ButtonHighlight;
            btnTrangChu.Image = Properties.Resources.MenuTrangChu;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Margin = new Padding(3, 4, 3, 4);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(307, 51);
            btnTrangChu.TabIndex = 3;
            btnTrangChu.Tag = "";
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.DarkCyan;
            button13.FlatAppearance.BorderColor = Color.DarkGray;
            button13.FlatAppearance.MouseDownBackColor = Color.Black;
            button13.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Microsoft Sans Serif", 13F);
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Image = Properties.Resources.MenuThongKe;
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(0, 649);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new Size(307, 51);
            button13.TabIndex = 16;
            button13.Tag = "16";
            button13.Text = "Thống kê";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.Honeydew;
            panelMain.Location = new Point(311, 94);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1419, 1000);
            panelMain.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1727, 1008);
            Controls.Add(panelMain);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTenKhachSan;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel4;
        private Panel panelMain;
        private Label lblTenNguoiDung;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private Button button13;
        private Button btnTrangChu;
        private Button button4;
        private Button button5;
        private Button button12;
        private Button btnQuanLyPhong;
        private Button button6;
        private Button button7;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button btnSoDoPhong;
    }
}
