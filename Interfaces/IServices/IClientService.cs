using ChopeeBurgerAPI.DTOs.Filters;
using ChopeeBurgerAPI.Entities;

namespace ChopeeBurgerAPI.Bussiness.Interfaces.IServices
{
    public interface IClientService
    {
        public void SaveClient(Client dto);
        public Paginator<Client> Paginate(ClientFilter dto);
        public void Delete(Client dto);
        public Client FindById(Guid id);
    }
}
