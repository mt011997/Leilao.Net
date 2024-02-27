
using Leilao.API.Entities;
using Leilao.API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Leilao.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly LeilaoDbContext _dbContext;

    public AuctionRepository(LeilaoDbContext dbContext) => _dbContext = dbContext;

    public Auction? GetCurrent()
    {
        var today = DateTime.Now;

        return _dbContext
          .Auctions
          .Include(auction => auction.Items)
          .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}


