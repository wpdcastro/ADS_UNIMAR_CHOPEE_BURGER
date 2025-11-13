using ChopeeBurgerAPI.Bussiness.Interfaces.IRepository;
using ChopeeBurgerAPI.Data.Context;
using ChopeeBurgerAPI.DTOs.Filters;
using ChopeeBurgerAPI.Entities;

namespace ChopeeBurgerAPI.Data.Repostories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BaseContext _db;

        public ProductRepository(BaseContext baseContext)
        {
            _db = baseContext;
        }

        public Product FindById(Guid Id)
        {
            Product product = _db.Products
                .Select(p => p)
                .Where(p => p.Id == Id)
                .FirstOrDefault();

            if (product == null)
            {
                return null;
            }

            return product;
        }

        public Product FindBySku(string sku)
        {
            return _db.Products
                .Select(p => p)
                .Where(p => p.Sku == sku)
                .First(); 
        }

        public List<Product> GetProducts()
        {
            return _db.Products.Select(p => p).ToList();
        }

        public Paginator<Product> Paginate(FilterBase filter)
        {
            try
            {
                var query = _db.Products.Select(client => client);

                if (string.IsNullOrEmpty(filter.SearchText))
                {
                    query = query.Where(prod => prod.Description.Contains(filter.SearchText));
                }

                var list = query
                    .Skip((filter.Page - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .ToList();

                return new Paginator<Product>(list, filter.Page, filter.PageSize);
            }
            catch (Exception ex)
            {
                throw new Exception("Error paginating clients", ex);
            }
        }

        public void SaveProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }
    }
}
