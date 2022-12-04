using AutoMapper;
using MediatR;
using ShopAPI.Funcionality.Carts.Commands;
using ShopAPI.Funcionality.Carts.Dtos;
using ShopAPI.Funcionality.Common;
using ShopAPI.Models.Data;
using ShopAPI.Models.Entity;

namespace ShopAPI.Funcionality.Carts.Handlers;

public class CreateHandler : BaseHandler, IRequestHandler<CreateCommand, CreateUpdateCartResponseDto>
{
    public CreateHandler(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

    public async Task<CreateUpdateCartResponseDto> Handle(CreateCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Cart>(request);
        _dbContext.Carts.Add(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);

        var entityDto = _mapper.Map<CreateUpdateCartResponseDto>(entity);
        return entityDto;
    }
}
