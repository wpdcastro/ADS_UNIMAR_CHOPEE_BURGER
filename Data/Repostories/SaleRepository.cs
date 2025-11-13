using ChopeeBurgerAPI.Bussiness.Interfaces.IRepository;
using ChopeeBurgerAPI.Data.Context;
using ChopeeBurgerAPI.Entities;

namespace ChopeeBurgerAPI.Data.Repostories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly BaseContext _db;

        public SaleRepository(BaseContext baseContext)
        {
            _db = baseContext;
        }
        public void Save(Sale sale)
        {
            _db.Sales.Add(sale);
            _db.SaveChanges();
        }
    }
}
