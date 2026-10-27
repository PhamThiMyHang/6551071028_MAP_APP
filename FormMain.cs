using QuanLyHoatDongKhachSan.DangNhap;

namespace QuanLyHoatDongKhachSan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            HienThiThongTinNguoiDung();
            HienThiTrangChu();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HienThiTrangChu();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Bnạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            this.Hide();
            using (var formLogin = new FormDangNhap())
            {
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    HienThiThongTinNguoiDung();
                    HienThiTrangChu();
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void HienThiThongTinNguoiDung()
        {
            lblTenNguoiDung.Text = FormDangNhap.TenNV_DangNhap;
            lblTenNguoiDung.Left = (panel2.Width - lblTenNguoiDung.Width) / 2;
        }

        private void XoaNoiDungPanelMain()
        {
            foreach (Control c in panelMain.Controls.Cast<Control>().ToList())
            {
                panelMain.Controls.Remove(c);
                c.Dispose();

            }
        }

        private void LoadUserControl(UserControl uc)
        {
            XoaNoiDungPanelMain();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void LoadFormCon(Form formCon)
        {
            XoaNoiDungPanelMain();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void HienThiTrangChu()
        {
            if(panelMain.Controls.Count ==  1 && panelMain.Controls[0] is FormTrangChu)
            {
                return; // Nếu FormTrangChu đã được hiển thị, không cần tải lại
            }
            LoadUserControl(new FormTrangChu());
        }

        private void HienThiDangPhatTrien(string tenChucNang)
        {
            /*  XoaNoiDungPanelMain();
              Label lbl = new Label();
              lbl.Text = $"Chức năng {tenChucNang} đang được phát triển.";
              lbl.Font = new Font("Arial", 16, FontStyle.Bold);
              lbl.ForeColor = Color.Red;
              lbl.AutoSize = true;
              lbl.Location = new Point((panelMain.Width - lbl.Width) / 2, (panelMain.Height - lbl.Height) / 2);
              panelMain.Controls.Add(lbl);

              */
            XoaNoiDungPanelMain();

            panelMain.Controls.Add(new Label
            {
                Dock = DockStyle.Fill,
                Text = $"Chức năng {tenChucNang} đang được phát triển.",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Red,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            }
                );
        }

        private void button13_Click(object sender, EventArgs e)
        {
            HienThiDangPhatTrien("Thống kê");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách tài khoản");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HienThiDangPhatTrien("Loại phòng");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách nhân viên");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách khách hàng");
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            Form formCon = new Phong.FormDanhSachPhong();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            XoaNoiDungPanelMain();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách tiện nghi");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách dịch vụ");
        }

        private void btnSoDoPhong_Click(object sender, EventArgs e)
        {
            Form formCon = new SoDoPhong.FormSoDoPhong();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;

            formCon.Dock = DockStyle.Fill;
            XoaNoiDungPanelMain();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách đặt phòng");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách hóa đơn");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
