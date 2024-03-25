using EMSCT.DATA.Entities.Abstract;
using EMSCT.DATA.Repositories.Abstract.BaseRepos;
using EMSCT.INFRA.Context;
using Microsoft.EntityFrameworkCore;

namespace EMSCT.INFRA.Repositories.Concrete.BaseRepos
{
    public class BaseWriteRepository<T> : IBaseWriteRepository<T> where T : class, IBaseEntity, new()
    {
        private readonly AppDbContext _context;
        protected DbSet<T> _dbSet;

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DetachEntityAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
