using DellChallenge.D1.Api.Dal;
using DellChallenge.D1.Api.Dto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DellChallenge.D1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        [EnableCors("AllowReactCors")]
        public ActionResult<IEnumerable<ProductDto>> Get()
        {
            return Ok(_productsService.GetAll());
        }

        [HttpGet("{id:int}")]
        [EnableCors("AllowReactCors")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            try
            {
                var result = await _productsService.GetProductByIdAsync(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        [EnableCors("AllowReactCors")]
        public ActionResult<ProductDto> Post([FromBody] NewProductDto newProduct)
        {
            var addedProduct = _productsService.Add(newProduct);
            return Ok(addedProduct);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _productsService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id:int}")]
        [EnableCors("AllowReactCors")]
        public async Task<IActionResult> Put(int id, [FromBody] NewProductDto newProduct)
        {
            await _productsService.UpdateAsync(id, newProduct);
            return Accepted();
        }
    }
}
