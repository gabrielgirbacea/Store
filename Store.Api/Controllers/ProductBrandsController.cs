using Microsoft.AspNetCore.Mvc;
using Store.Core.Entities;
using Store.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Store.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductBrandsController : ControllerBase
    {
        private readonly IBaseEntityRepository<ProductBrand> _repository;

        public ProductBrandsController(IBaseEntityRepository<ProductBrand> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }


        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<ProductBrand>>> GetProductBrandsAsync()
        {
            var products = await _repository.GetEntitiesAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ProductBrand> GetProductAsync(Guid id)
        {
            return await _repository.GetEntityByIdAsync(id);
        }
    }
}
