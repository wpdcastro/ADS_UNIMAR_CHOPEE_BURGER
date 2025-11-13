using ChopeeBurgerAPI.Bussiness.Interfaces.IRepository;
using ChopeeBurgerAPI.Data.Context;
using ChopeeBurgerAPI.DTOs.Filters;
using ChopeeBurgerAPI.Entities;

namespace ChopeeBurgerAPI.Data.Repostories
{
    public class ClientRepository : IClientRepository
    {
        private readonly BaseContext _db;

        public ClientRepository(BaseContext baseContext)
        {
            _db = baseContext;
        }

        public void Delete(Guid client)
        {
            _db.Clients.Remove(FindById(client));
        }

        public Client FindById(Guid Id)
        {
            return _db.Clients.Select(c => c).FirstOrDefault();
        }

        public Paginator<Client> Paginate(ClientFilter filter)
        {
            try
            {
                var query = _db.Clients.Select( client => client);

                if (string.IsNullOrEmpty(filter.FirstName))
                {
                    query = query.Where(client => client.FirstName.Contains(filter.FirstName));
                }

                var list = query
                    .Skip((filter.Page - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .ToList();

                return new Paginator<Client>(list, filter.Page, filter.PageSize);
            }
            catch (Exception ex)
            {
                throw new Exception("Error paginating clients", ex);
            }
        }

        public void Save(Client client)
        {
            _db.Clients.Add(client);
            _db.SaveChanges();
        }
    }
}
