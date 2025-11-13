using ChopeeBurgerAPI.Entities;

namespace ChopeeBurgerAPI.DTOs
{
    public class CreateProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Sku { get; set; }
    }
}
