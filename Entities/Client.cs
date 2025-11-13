namespace ChopeeBurgerAPI.Entities
{
    public class Client : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual List<Sale> Sales { get; set; }

        public string GetFullName() 
        { 
            return FirstName + " " + this.LastName; 
        }
    }
}
