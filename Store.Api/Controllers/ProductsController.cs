using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Store.Api.Dtos;
using Store.Core.Entities;
using Store.Core.Interfaces;
using Store.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IBaseEntityRepository<Product> _repository;
        private readonly IMapper _mapper;

        public ProductsController(IBaseEntityRepository<Product> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("")]
        public async Task<ActionResult<IReadOnlyList<ProductToReturnDto>>> GetProductsAsync()
        {
            var products = await _repository.GetEntitiesAsync(new ProductsWithTypesAndBrandsSpecification());

            return Ok(_mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDto>>(products));
        }

        [HttpGet("{id}")]
        public async Task<ProductToReturnDto> GetProductAsync(Guid id)
        {
            var product = await _repository.GetEntityWithSpec(new ProductsWithTypesAndBrandsSpecification(id));

            return _mapper.Map<Product, ProductToReturnDto>(product);
        }
    }
}
