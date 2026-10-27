using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace QuanLyHoatDongKhachSan.Models
{
    public partial class HotelManagementContext:DbContext
    {
        private const string ConnectionString = "Server=LAPTOP-06PJUKMP\\SQLEXPRESS;Database=HotelManagement;Trusted_Connection=True;TrustServerCertificate=True;";
        public HotelManagementContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
         }
        }

}
