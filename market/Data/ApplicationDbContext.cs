
using market.Models;
using Microsoft.EntityFrameworkCore;

namespace market.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }

    public DbSet<Ad> ads { get; set; }

    public virtual DbSet<Users> Users { get; set; }

}
