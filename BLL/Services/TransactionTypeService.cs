using AutoMapper;
using BLL.DTO;
using DAL.Models;
using DAL.Repositories;
using System.Collections.Generic;

namespace BLL.Services
{
    public class TransactionTypeService : IService<TransactionTypeDTO>
    {
        private TransactionTypeRepository _repository;
        private IMapper _mapper;
        private IMapper _reverseMapper;

        public TransactionTypeService(TransactionTypeRepository repository)
        {
            _repository = repository;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TransactionTypeDTO, TransactionType>());
            _mapper = config.CreateMapper();
            config = new MapperConfiguration(cfg => cfg.CreateMap<TransactionType, TransactionTypeDTO>());
            _reverseMapper = config.CreateMapper();
        }

        public TransactionTypeDTO Add(TransactionTypeDTO entity)
        {
            entity.Id = _repository.Add(_mapper.Map<TransactionType>(entity)).Id;
            return entity;
        }

        public void Delete(TransactionTypeDTO entity)
        {
            _repository.Delete(_mapper.Map<TransactionType>(entity));
        }

        public IEnumerable<TransactionTypeDTO> GetAll()
        {
            return _reverseMapper.Map<IEnumerable<TransactionTypeDTO>>(_repository.GetAll());
        }

        public TransactionTypeDTO GetById(int id)
        {
            return _reverseMapper.Map<TransactionTypeDTO>(_repository.GetById(id));
        }

        public void Update(TransactionTypeDTO entity)
        {
            _repository.Update(_mapper.Map<TransactionType>(entity));
        }
    }
}
