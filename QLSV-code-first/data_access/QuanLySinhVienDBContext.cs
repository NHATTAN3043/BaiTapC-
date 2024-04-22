using Microsoft.EntityFrameworkCore;
using QLSV_code_first.Models;

namespace QLSV_code_first.data_access
{
    public class QuanLySinhVienDBContext:DbContext
    {
        public QuanLySinhVienDBContext(DbContextOptions<QuanLySinhVienDBContext> options) :base(options)
        { }
        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<Lop> Lop { get; set; }

        public DbSet<SinhVien> SinhVien { get; set; }

    }
}
