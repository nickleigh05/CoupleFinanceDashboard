using Microsoft.EntityFrameworkCore;
using CoupleFinanceDashboard.Api.Models;

namespace CoupleFinanceDashboard.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {
    }
    public DbSet<Account> Accounts {get; set;}
    public DbSet<Partner> Partners {get; set;}

}