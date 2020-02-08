using ProjectManager.Domain.Entities.Core;

namespace ProjectManager.Domain.Interfaces.Core
{
    public interface IAccountRepository : IRepository<Account>
    {
        Account GetByEmail(string email);
    }
}