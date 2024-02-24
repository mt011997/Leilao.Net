using Leilao.API.Comunication.Requests;
using Leilao.API.Filters;
using Leilao.API.UseCases.Offers.CreateOffer;
using Microsoft.AspNetCore.Mvc;

namespace Leilao.API.Controllers;

//[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : LeilaoBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    [ServiceFilter(typeof(AuthenticationUserAttribute))]
    public IActionResult CreateOffer(
        [FromRoute] int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        
       var id = useCase.Execute(itemId, request);

       return Created(string.Empty, id);
    }
}
