using AutoMapper;
using ProjectManager.Application.Interfaces.Core;
using ProjectManager.Application.ViewModels.Core;
using ProjectManager.Domain.Entities.Core;
using ProjectManager.Domain.Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProjectManager.Application.Services.Core
{
    public class AccountAppService : IAccountAppService
    {
        private readonly IMapper _mapper;
        private readonly IAccountRepository _accountRepository;

        public AccountAppService(IMapper mapper, IAccountRepository accountRepository)
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
        }

        public IEnumerable<AccountViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<AccountViewModel>>(_accountRepository.GetAll());
        }

        public AccountViewModel GetById(Guid id)
        {
            return _mapper.Map<AccountViewModel>(_accountRepository.GetById(id));
        }

        public void Register(AccountViewModel accountViewModel)
        {
            throw new NotImplementedException();
        }

        public void Update(AccountViewModel accountViewModel)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountViewModel> Find(Expression<Func<Account, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<AccountViewModel>>(_accountRepository.Find(predicate));
        }

        public AccountViewModel GetByEmail(string email)
        {
            return _mapper.Map<AccountViewModel>(_accountRepository.GetByEmail(email));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}