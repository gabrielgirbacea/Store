using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Api.Errors;
using Store.Core.Entities;
using Store.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Api.Controllers
{
    public class ProductTypesController : BaseApiController
    {
        private readonly IBaseEntityRepository<ProductType> _repository;

        public ProductTypesController(IBaseEntityRepository<ProductType> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<ProductType>>> GetProductTypesAsync()
        {
            var products = await _repository.GetEntitiesAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductType>> GetProductAsync(Guid id)
        {
            return Ok(await _repository.GetEntityByIdAsync(id));
        }
    }
}
