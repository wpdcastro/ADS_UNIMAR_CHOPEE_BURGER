using ChopeeBurgerAPI.Bussiness.Dtos;
using ChopeeBurgerAPI.Bussiness.Interfaces.IRepository;
using ChopeeBurgerAPI.Bussiness.Interfaces.IServices;
using ChopeeBurgerAPI.Entities;

namespace ChopeeBurgerAPI.Services
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IProductService _productService;

        public SaleService(ISaleRepository saleRepository, IClientRepository clientRepository, IProductService productService)
        {
            _saleRepository = saleRepository;
            _clientRepository = clientRepository;
            _productService = productService;
        }

        public void Create(CreateSaleDto saleDto)
        {
            try 
            {
                if (saleDto == null)
                {
                    throw new Exception("Objeto invalido");
                }

                Client clientOld = _clientRepository.FindById(saleDto.ClientId);

                if (clientOld == null)
                {
                    throw new Exception("Cliente invalido");
                }

                Product productOld = _productService.FindById(saleDto.ProductId);

                if (productOld == null)
                {
                    throw new Exception("Produto invalido");
                }

                if (productOld.Stock < saleDto.Quantity)
                {
                    throw new Exception("Estoque invalido");
                }

                Sale newSale = new Sale();
                newSale.Quantity = saleDto.Quantity;
                newSale.ProductId = saleDto.ProductId;
                newSale.ClientId = saleDto.ClientId;
                newSale.Price = saleDto.Price;

                _saleRepository.Save(newSale);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
