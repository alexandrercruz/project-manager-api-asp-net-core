using ProjectManager.Domain.Interfaces;
using ProjectManager.Infrastructure.Data.Context;

namespace ProjectManager.Infrastructure.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectManagerContext _context;

        public UnitOfWork(ProjectManagerContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}