using Microsoft.EntityFrameworkCore;
using ProjectManager.Domain.Entities.Core;
using ProjectManager.Domain.Interfaces.Core;
using ProjectManager.Infrastructure.Context;
using System.Linq;

namespace ProjectManager.Infrastructure.Repository.Core
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(ProjectManagerContext context)
            : base(context)
        {
        }

        public Account GetByEmail(string email)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Email == email);
        }
    }
}