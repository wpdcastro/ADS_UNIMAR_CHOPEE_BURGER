using ChopeeBurgerAPI.DTOs;
using ChopeeBurgerAPI.DTOs.Filters;
using ChopeeBurgerAPI.Entities;

namespace ChopeeBurgerAPI.Bussiness.Interfaces.IServices
{
    public interface IProductService
    {
        public Product FindById(Guid Id);
        public Paginator<string> GetProducts(FilterBase filter);
        public void CreateProduct(CreateProductDTO newProduct);
    }
}
