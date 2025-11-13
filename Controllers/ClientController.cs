using ChopeeBurgerAPI.Bussiness.Interfaces.IServices;
using ChopeeBurgerAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ChopeeBurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost("Save")]
        public IActionResult Save(Client clientDTO)
        {
            try 
            {
                _clientService.SaveClient(clientDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Get")]
        public IActionResult Get([FromQuery] Guid Id)
        {
            try
            {
                _clientService.FindById(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}