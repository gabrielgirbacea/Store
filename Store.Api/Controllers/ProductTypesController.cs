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
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeRepository _repository;

        public ProductTypesController(IProductTypeRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<ProductType>>> GetProductTypesAsync()
        {
            var products = await _repository.GetProductTypesAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ProductType> GetProductAsync(Guid id)
        {
            return await _repository.GetProductTypeByIdAsync(id);
        }
    }
}
