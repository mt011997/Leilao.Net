using Leilao.API.Entities;

namespace Leilao.API.Interfaces;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}
