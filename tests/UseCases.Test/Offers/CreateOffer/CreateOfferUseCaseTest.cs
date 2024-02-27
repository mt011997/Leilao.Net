using Bogus;
using FluentAssertions;
using Leilao.API.Comunication.Requests;
using Leilao.API.Entities;
using Leilao.API.Interfaces;
using Leilao.API.Services;
using Leilao.API.UseCases.Offers.CreateOffer;
using Moq;

namespace UseCases.Test.Offers.CreateOffer;
public class CreateOfferUseCaseTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Succes(int itemId)
    {
        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(request => request.Price, f => f.Random.Decimal(1, 700)).Generate();

        var offerRepository = new Mock<IOfferRepository>();
        var loggedUser = new Mock<ILoggedUser>();
        loggedUser.Setup(i => i.User()).Returns(new User());

        var useCase = new CreateOfferUseCase(loggedUser.Object, offerRepository.Object);

        var act = () => useCase.Execute(itemId, request);

        act.Should().NotThrow();
    }
}
