using Microsoft.EntityFrameworkCore;
using ProjectManager.Domain.Entities.Core;
using ProjectManager.Domain.Interfaces.Core;
using ProjectManager.Infrastructure.Data.Context;
using System.Linq;

namespace ProjectManager.Infrastructure.Data.Repository.Core
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