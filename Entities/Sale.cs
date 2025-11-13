namespace ChopeeBurgerAPI.Entities
{
    public class Sale : EntityBase
    {
        public int Quantity { get; set; }
        public float Price { get; set; }
        public Guid ProductId {  get; set; }
        public Product Product { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}
