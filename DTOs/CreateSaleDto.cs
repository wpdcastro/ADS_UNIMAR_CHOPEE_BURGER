namespace ChopeeBurgerAPI.Bussiness.Dtos
{
    public class CreateSaleDto
    {
        public float Price { get; set; }
        public Guid ClientId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
