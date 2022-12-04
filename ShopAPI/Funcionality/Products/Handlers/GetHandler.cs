using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Funcionality.Common;
using ShopAPI.Funcionality.Products.Dtos;
using ShopAPI.Funcionality.Products.Queries;
using ShopAPI.Models.Data;
using ShopAPI.Models.Entity;

namespace ShopAPI.Funcionality.Products.Handlers;

public class GetHandler : BaseHandler, IRequestHandler<GetByIdQuery, GetProductResponseDto>
{
    public GetHandler(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

    public async Task<GetProductResponseDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        Product productFromDb = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == request.Id);
        var response = _mapper.Map<GetProductResponseDto>(productFromDb);

        return response;
    }
}
