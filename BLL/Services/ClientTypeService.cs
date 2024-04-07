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
    public class ClientTypeService : IService<ClientTypeDTO>
    {
        private ClientTypeRepository _repository;
        private IMapper _mapper;
        private IMapper _reverseMapper;

        public ClientTypeService(ClientTypeRepository repository)
        {
            _repository = repository;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ClientTypeDTO, ClientType>());
            _mapper = config.CreateMapper();
            config = new MapperConfiguration(cfg => cfg.CreateMap<ClientType, ClientTypeDTO>());
            _reverseMapper = config.CreateMapper();
        }

        public ClientTypeDTO Add(ClientTypeDTO entity)
        {
            entity.Id = _repository.Add(_mapper.Map<ClientType>(entity)).Id;
            return entity;
        }

        public void Delete(ClientTypeDTO entity)
        {
            _repository.Delete(_mapper.Map<ClientType>(entity));
        }

        public IEnumerable<ClientTypeDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<ClientTypeDTO>>(_repository.GetAll());
        }

        public ClientTypeDTO GetById(int id)
        {
            return _mapper.Map<ClientTypeDTO>(_repository.GetById(id));
        }

        public void Update(ClientTypeDTO entity)
        {
            _repository.Update(_reverseMapper.Map<ClientType>(entity));
        }
    }
}
