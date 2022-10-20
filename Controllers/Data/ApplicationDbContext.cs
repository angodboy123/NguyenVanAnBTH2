using BTH2.Models;
using Microsoft.EntityFrameworkCore;
namespace BTH2.Data
{
public class ApplicationDbContext : DbContext
{
    public class ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
}
 {
    public DbSet<Student> Student { get; set; }
 }
}