using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Funcionality.Products.Dtos;
using ShopAPI.Funcionality.Products.Queries;
using ShopAPI.Models.Data;
using ShopAPI.Models.Entity;

namespace ShopAPI.Funcionality.Products.Handlers;

public class GetHandler : IRequestHandler<GetByIdQuery, GetProductResponseDto>
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetHandler(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<GetProductResponseDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        Product productFromDb = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == request.Id);
        var response = _mapper.Map<GetProductResponseDto>(productFromDb);

        return response;
    }
}
