using AutoMapper;
using MediatR;
using ShopAPI.Funcionality.Common;
using ShopAPI.Funcionality.Products.Commands;
using ShopAPI.Funcionality.Products.Dtos;
using ShopAPI.Models.Data;
using ShopAPI.Models.Entity;

namespace ShopAPI.Funcionality.Products.Handlers;

public class CreateHandler : BaseHandler, IRequestHandler<CreateCommand, CreateUpdateProductResponseDto>
{
    public CreateHandler(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

    public async Task<CreateUpdateProductResponseDto> Handle(CreateCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Product>(request);
        _dbContext.Products.Add(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);

        var entityDto = _mapper.Map<CreateUpdateProductResponseDto>(entity);
        return entityDto;
    }
}
