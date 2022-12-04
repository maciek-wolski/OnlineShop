using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Funcionality.Carts.Dtos;
using ShopAPI.Funcionality.Carts.Queries;
using ShopAPI.Models.Data;
using ShopAPI.Models.Entity;

namespace ShopAPI.Funcionality.Carts.Handlers;

public class GetHandler : IRequestHandler<GetByIdQuery, GetCartResponseDto>
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetHandler(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<GetCartResponseDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        Cart cartsFromDb = await _dbContext.Carts.FirstOrDefaultAsync(x => x.Id == request.Id);
        var response = _mapper.Map<GetCartResponseDto>(cartsFromDb);

        return response;
    }
}
