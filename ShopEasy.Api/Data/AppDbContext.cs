using Microsoft.EntityFrameworkCore;
using ShopEasy.Api.Models;

namespace ShopEasy.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}