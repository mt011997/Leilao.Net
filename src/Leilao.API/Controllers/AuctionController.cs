﻿using Leilao.API.Entities;
using Leilao.API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace Leilao.API.Controllers;

public class AuctionController : LeilaoBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
    {
        var result = useCase.Execute();

        if(result is null) {
            return NoContent();
        }

        return Ok(result);
    }

}
