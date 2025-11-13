using ChopeeBurgerAPI.DTOs.Filters;
using ChopeeBurgerAPI.Entities;

namespace ChopeeBurgerAPI.Bussiness.Interfaces.IRepository
{
    public interface IProductRepository
    {
        public Product FindById(Guid Id);
        public Product FindBySku(string sku);
        public void SaveProduct(Product product);
        public List<Product> GetProducts();
        public Paginator<Product> Paginate(FilterBase filter);
    }
}
