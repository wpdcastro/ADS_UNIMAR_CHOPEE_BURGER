using ChopeeBurgerAPI.DTOs.Filters;
using ChopeeBurgerAPI.Entities;

namespace ChopeeBurgerAPI.Bussiness.Interfaces.IRepository
{
    public interface IClientRepository
    {
        public Client FindById(Guid Id);
        public void Save(Client client);
        public void Delete(Guid client);
        public Paginator<Client> Paginate(ClientFilter filter);
    }
}
