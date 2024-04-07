using AutoMapper;
using BLL.DTO;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ClientService : IService<ClientDTO>
    {
        private ClientRepository _repository;
        private IMapper _mapper;
        private IMapper _reverseMapper;

        public ClientService(ClientRepository repository)
        {
            _repository = repository;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ClientDTO, Client>());
            _mapper = config.CreateMapper();
            config = new MapperConfiguration(cfg => cfg.CreateMap<Client, ClientDTO>());
            _reverseMapper = config.CreateMapper();
        }

        public ClientDTO Add(ClientDTO entity)
        {
            entity.Id = _repository.Add(_mapper.Map<Client>(entity)).Id;
            return entity;
        }

        public void Delete(ClientDTO entity)
        {
            _repository.Delete(_mapper.Map<Client>(entity));
        }

        public IEnumerable<ClientDTO> GetAll()
        {
            return _reverseMapper.Map<IEnumerable<ClientDTO>>(_repository.GetAll());
        }

        public ClientDTO GetById(int id)
        {
            return _mapper.Map<ClientDTO>(_repository.GetById(id));
        }

        public void Update(ClientDTO entity)
        {
            _repository.Update(_mapper.Map<Client>(entity));
        }
    }
}
