using ChopeeBurgerAPI.Bussiness.Dtos;
using ChopeeBurgerAPI.Bussiness.Interfaces.IRepository;
using ChopeeBurgerAPI.Bussiness.Interfaces.IServices;
using ChopeeBurgerAPI.DTOs.Filters;
using ChopeeBurgerAPI.Entities;

namespace ChopeeBurgerAPI.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client FindById(Guid Id)
        {
            try
            {
                Client client = _clientRepository.FindById(Id);
                if (client == null) throw new Exception("Invalid Client");
                return client;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SaveClient(Client dto)
        {
            try { 
                if (dto == null) throw new Exception("Invalid Data");
                if (string.IsNullOrEmpty(dto.FirstName)) throw new Exception("Invalid FirstName");
                if (string.IsNullOrEmpty(dto.LastName)) throw new Exception("Invalid LastName");
                if (string.IsNullOrEmpty(dto.Email)) throw new Exception("Invalid Email");

                _clientRepository.Save(dto);

            } catch(Exception error) {
                throw new Exception(error.Message);
            }
        }

        public void Delete(Client dto)
        {
            try {
                if (dto == null) throw new Exception("Invalid Client");
                Client client = _clientRepository.FindById(dto.Id);
                if (client == null) throw new Exception("Invalid Client");

                _clientRepository.Delete(dto.Id);

            } catch (Exception error) {
                throw new Exception(error.Message);
            }
        }

        public Paginator<Client> Paginate(ClientFilter filter)
        {
            try 
            {
                Paginator<Client> paginator = _clientRepository.Paginate(filter);
                return paginator;
            } 
            catch (Exception exception) 
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
