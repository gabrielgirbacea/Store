using AutoMapper;
using Store.Api.Dtos;
using Store.Core.Entities;

namespace Store.Api.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.Name))
                .ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand.Name))
                .ForMember(dest => dest.PictureUrl, opt => opt.MapFrom<ProductUrlResolver>());
        }
    }
}
