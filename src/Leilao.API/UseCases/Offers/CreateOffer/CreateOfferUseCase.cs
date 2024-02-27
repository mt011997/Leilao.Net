using Leilao.API.Comunication.Requests;
using Leilao.API.Entities;
using Leilao.API.Interfaces;
using Leilao.API.Services;

namespace Leilao.API.UseCases.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly ILoggedUser _loggedUser;
    private readonly IOfferRepository _repository;

    public CreateOfferUseCase(ILoggedUser loggedUser, IOfferRepository repository)
    {
        _repository = repository;
        _loggedUser = loggedUser;
    }
 
    public int Execute(int itemId, RequestCreateOfferJson request)
    {
        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id,
        };

        _repository.Add(offer);

        return offer.Id;
    }
}
