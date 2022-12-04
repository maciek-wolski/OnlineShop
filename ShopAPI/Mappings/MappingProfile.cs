﻿using AutoMapper;
using ShopAPI.Carts.Dtos;
using ShopAPI.Carts.Queries;
using ShopAPI.Models.Entity;

namespace ShopAPI.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Cart, GetCartResponseDto>();
        CreateMap<Cart, CreateUpdateCartResponseDto>();
        CreateMap<GetCartByIdRequestDto, GetByIdQuery>();
    }
}