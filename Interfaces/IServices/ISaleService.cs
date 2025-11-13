using ChopeeBurgerAPI.Bussiness.Dtos;

namespace ChopeeBurgerAPI.Bussiness.Interfaces.IServices
{
    public interface ISaleService
    {
        public void Create(CreateSaleDto saleDto);
    }
}
