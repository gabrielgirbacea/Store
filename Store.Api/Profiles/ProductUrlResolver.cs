using AutoMapper;
using Microsoft.Extensions.Configuration;
using Store.Api.Dtos;
using Store.Core.Entities;

namespace Store.Api.Profiles
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration _configuration;

        public ProductUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (string.IsNullOrWhiteSpace(source.PictureUrl))
            {
                return null;
            }

            return $"{_configuration["ApiUrl"]}{source.PictureUrl}";
        }
    }
}
