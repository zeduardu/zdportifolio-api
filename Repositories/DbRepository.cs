using Microsoft.EntityFrameworkCore;
using ZdportifolioApi.Models;

namespace ZdportifolioApi.Repositories;

public class DbRepository : DbContext
{
    public DbRepository(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Article>? Articles { get; set; }
}