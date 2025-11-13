namespace ChopeeBurgerAPI.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Sku { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; } 
        public virtual List<Sale> Sales { get; set; }
    }
}
