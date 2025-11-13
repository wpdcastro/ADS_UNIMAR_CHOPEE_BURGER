using ChopeeBurgerAPI.Bussiness.Interfaces.IRepository;
using ChopeeBurgerAPI.Bussiness.Interfaces.IServices;
using ChopeeBurgerAPI.DTOs;
using ChopeeBurgerAPI.DTOs.Filters;
using ChopeeBurgerAPI.Entities;

namespace ChopeeBurgerAPI.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product FindById(Guid Id)
        { 
            try 
            { 
                return _productRepository.FindById(Id); 
            } 
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public void CreateProduct(CreateProductDTO productDto)
        {
            Product savedProduct = _productRepository.FindBySku(productDto.Sku);

            if (savedProduct != null)
            {
                throw new Exception("Produto já cadastrado.");
            }

            Product newProduct = new Product();
            newProduct.Sku = productDto.Sku;
            newProduct.Price = productDto.Price;
            newProduct.Description = productDto.Description;
            newProduct.Name = productDto.Name;

            _productRepository.SaveProduct(newProduct);
        }

        public Paginator<string> GetProducts(FilterBase filter)
        {
            Paginator<Product> paginator = _productRepository.Paginate(filter);

            List<string> result = new List<string>();

            foreach (Product product in paginator.Items)
            {
                result.Add(product.Name);
            }

            return new Paginator<string>(result, paginator.PageSize, paginator.PageOffset);
        }
    }
}
