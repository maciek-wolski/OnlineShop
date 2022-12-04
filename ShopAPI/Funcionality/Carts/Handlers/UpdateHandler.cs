using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Funcionality.Carts.Commands;
using ShopAPI.Funcionality.Carts.Dtos;
using ShopAPI.Funcionality.Common;
using ShopAPI.Models.Data;

namespace ShopAPI.Funcionality.Carts.Handlers;

public class UpdateHandler : BaseHandler, IRequestHandler<UpdateCommand, GetCartResponseDto>
{
    public UpdateHandler(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

    public async Task<GetCartResponseDto> Handle(UpdateCommand request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Carts.FirstOrDefaultAsync(x => x.Id == request.Id);

        if (entity is not null)
        {
            entity.ModificationDate = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync();
        }

        var response = _mapper.Map<GetCartResponseDto>(entity);
        return response;
    }
}
