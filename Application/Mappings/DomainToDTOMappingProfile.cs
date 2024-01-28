using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings;

public class DomainToDTOMappingProfile : Profile
{
    public DomainToDTOMappingProfile()
    {
        CreateMap<Product, ProductDTO>().ReverseMap();
    }
}
