using AutoMapper;
using MediatR;
using ShopAPI.Carts.Commands;
using ShopAPI.Carts.Dtos;
using ShopAPI.Models.Data;
using ShopAPI.Models.Entity;

namespace ShopAPI.Carts.Handlers;

public class CreateHandler : IRequestHandler<CreateCommand, CreateUpdateCartResponseDto>
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public CreateHandler(ApplicationDbContext context, IMapper mapper)
    {
        _dbContext = context;
        _mapper = mapper;
    }

    public async Task<CreateUpdateCartResponseDto> Handle(CreateCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Cart>(request);
        _dbContext.Carts.Add(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);

        var entityDto = _mapper.Map<CreateUpdateCartResponseDto>(entity);
        return entityDto;
    }
}
