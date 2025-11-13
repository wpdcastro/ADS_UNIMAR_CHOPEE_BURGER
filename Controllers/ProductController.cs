using ChopeeBurgerAPI.Bussiness.Interfaces.IServices;
using ChopeeBurgerAPI.DTOs;
using ChopeeBurgerAPI.DTOs.Filters;
using ChopeeBurgerAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ChopeeBurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("GetProducts")]
        public IActionResult GetProducts([FromBody] FilterBase filter)
        {
            try
            {
                Paginator<string> products = _productService.GetProducts(filter);
                return Ok(products);
            } 
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public IActionResult CreateProduct([FromBody] CreateProductDTO newProduct)
        {
            try
            {
                _productService.CreateProduct(newProduct);
                return Ok();
            } 
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
