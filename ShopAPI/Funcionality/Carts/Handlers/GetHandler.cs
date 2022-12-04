using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Funcionality.Carts.Dtos;
using ShopAPI.Funcionality.Carts.Queries;
using ShopAPI.Funcionality.Common;
using ShopAPI.Models.Data;
using ShopAPI.Models.Entity;

namespace ShopAPI.Funcionality.Carts.Handlers;

public class GetHandler : BaseHandler, IRequestHandler<GetByIdQuery, GetCartResponseDto>
{
    public GetHandler(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

    public async Task<GetCartResponseDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        Cart cartsFromDb = await _dbContext.Carts.FirstOrDefaultAsync(x => x.Id == request.Id);
        var response = _mapper.Map<GetCartResponseDto>(cartsFromDb);

        return response;
    }
}
