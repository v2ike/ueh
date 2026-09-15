using Microsoft.EntityFrameworkCore;
using UEHTeamUp.API.Entities; // Namespace chứa class Course.cs

namespace UEHTeamUp.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Khai báo tập hợp Courses ánh xá tương ứng với bảng Courses trong CSDL
    public DbSet<Course> Courses { get; set; }
}