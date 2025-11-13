using ChopeeBurgerAPI.Bussiness.Dtos;
using ChopeeBurgerAPI.Bussiness.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ChopeeBurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _saleService;
        public SaleController(ISaleService saleService) 
        { 
            _saleService = saleService;
        }

        [HttpPost(Name = "CreateSale")]
        public IActionResult Create(CreateSaleDto saleDto)
        {
            try
            {
                _saleService.Create(saleDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
