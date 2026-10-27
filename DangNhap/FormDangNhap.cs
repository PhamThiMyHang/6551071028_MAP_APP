using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyHoatDongKhachSan.Models;
using Microsoft.EntityFrameworkCore;


namespace QuanLyHoatDongKhachSan.DangNhap
{


    public partial class FormDangNhap : Form
    {
        public static string MaNV_DangNhap = string.Empty;
        public static string TenNV_DangNhap = string.Empty;
        public static int CapDoQuyen_DangNhap;
        public FormDangNhap()
        {
            InitializeComponent();
            ActiveControl = txtMatKhau;
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (tenDangNhap.Length == 0 || matKhau.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnDangNhap.Enabled = false;    // tránh bấm nhiều lần khi đang chờ CSDL

            try
            {
                bool hopLe = await KiemTraDangNhapAsync(tenDangNhap, matKhau);

                if (hopLe)
                {
                    DialogResult = DialogResult.OK;    // Program.cs sẽ mở form chính, không Show ở đây
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDangNhap.Clear();
                    txtTenDangNhap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangNhap.Enabled = true;
            }
        }
        private async Task<bool> KiemTraDangNhapAsync(string tenDangNhap, string matKhau)
        {
            await using var db = new HotelManagementContext();

            // 1 câu truy vấn duy nhất: lấy tài khoản + tên nhân viên (JOIN qua navigation property)
            // DaXoa là bool? nên dùng "!= true" để chấp nhận cả giá trị NULL lẫn false
            var tk = await db.TaiKhoans
                .AsNoTracking()
                .Where(t => t.TenTk == tenDangNhap && t.DaXoa != true)
                .Select(t => new
                {
                    t.Password,
                    t.MaNv,
                    t.CapDoQuyen,
                    TenNv = t.MaNvNavigation.TenNv,
                    NhanVienDaXoa = t.MaNvNavigation.DaXoa
                })
                .FirstOrDefaultAsync();

            if (tk == null || tk.NhanVienDaXoa == true)
                return false;

            // So sánh mật khẩu phía C# (phân biệt hoa/thường) vì collation mặc định của SQL Server không phân biệt
            if (!string.Equals(tk.Password, matKhau, StringComparison.Ordinal))
                return false;

            MaNV_DangNhap = tk.MaNv;
            TenNV_DangNhap = tk.TenNv;
            CapDoQuyen_DangNhap = tk.CapDoQuyen;
            Tag = tk.TenNv;    // giữ cách cũ: truyền tên nhân viên qua Tag

            return true;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
