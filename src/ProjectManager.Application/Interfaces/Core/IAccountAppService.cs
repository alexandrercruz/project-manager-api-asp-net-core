using ProjectManager.Application.ViewModels.Core;
using ProjectManager.Domain.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProjectManager.Application.Interfaces.Core
{
    public interface IAccountAppService : IDisposable
    {
        void Register(AccountViewModel accountViewModel);

        IEnumerable<AccountViewModel> GetAll();

        AccountViewModel GetById(Guid id);

        void Update(AccountViewModel accountViewModel);

        void Remove(Guid id);

        IEnumerable<AccountViewModel> Find(Expression<Func<Account, bool>> predicate);

        AccountViewModel GetByEmail(string email);
    }
}