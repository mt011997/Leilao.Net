using Leilao.API.Entities;
using Leilao.API.Interfaces;

namespace Leilao.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly LeilaoDbContext _dbContext;

    public OfferRepository(LeilaoDbContext context)
    {
        _dbContext = context;
    }

    public void Add(Offer offer)
    {

        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}
