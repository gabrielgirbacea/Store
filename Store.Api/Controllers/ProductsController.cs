using Microsoft.AspNetCore.Mvc;
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

        public ProductsController(IBaseEntityRepository<Product> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsAsync()
        {
            var products = await _repository.GetEntitiesAsync(new ProductsWithTypesAndBrandsSpecification());

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProductAsync(Guid id)
        {
            return await _repository.GetEntityWithSpec(new ProductsWithTypesAndBrandsSpecification(id));
        }
    }
}
