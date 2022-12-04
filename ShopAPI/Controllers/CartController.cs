using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Carts.Dtos;
using ShopAPI.Carts.Queries;
using ShopAPI.Controllers.Common;

namespace ShopAPI.Controllers;

public class CartController : BaseController
{
    public CartController(IMapper mapper, IMediator mediator) : base(mapper, mediator)
    {
    }

    [Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(GetCartResponseDto), 200)]
    [HttpPost("GetCartById")]
    public async Task<IActionResult> GetCartById([FromBody] GetCartByIdRequestDto request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetByIdQuery>(request);
        var response = await _mediator.Send(query, cancellationToken);

        return response is null ? NotFound("Cart not found!") : Ok(response);
    }
}
