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
    public class TransactionService : IService<BankTransactionDTO>
    {
        private TransactionRepository _repository;
        private IMapper _mapper;
        private IMapper _reverseMapper;

        public TransactionService(TransactionRepository repository)
        {
            _repository = repository;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BankTransactionDTO, BankTransaction>());
            _mapper = config.CreateMapper();
            config = new MapperConfiguration(cfg => cfg.CreateMap<BankTransaction, BankTransactionDTO>());
            _reverseMapper = config.CreateMapper();
        }

        public BankTransactionDTO Add(BankTransactionDTO entity)
        {
            entity.Id = _repository.Add(_mapper.Map<BankTransaction>(entity)).Id;
            return entity;
        }

        public void Delete(BankTransactionDTO entity)
        {
            _repository.Delete(_mapper.Map<BankTransaction>(entity));
        }

        public IEnumerable<BankTransactionDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<BankTransactionDTO>>(_repository.GetAll());
        }

        public BankTransactionDTO GetById(int id)
        {
            return _mapper.Map<BankTransactionDTO>(_repository.GetById(id));
        }

        public void Update(BankTransactionDTO entity)
        {
            _repository.Update(_mapper.Map<BankTransaction>(entity));
        }
    }
}
