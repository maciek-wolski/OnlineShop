using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ShopAPI.Controllers.Common;

[ApiController]
public abstract class BaseController : ControllerBase
{
    protected readonly IMapper _mapper;
    protected readonly IMediator _mediator;

    public BaseController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }
}
