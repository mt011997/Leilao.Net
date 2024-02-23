using Leilao.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leilao.API.Repositories;

public class LeilaoDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=D:\\Downloads\\leilaoDbNLW.db");    
    }
}
