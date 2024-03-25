using EMSCT.DATA.Entities.Abstract;
using EMSCT.DATA.Enums;
using EMSCT.DATA.Repositories.Abstract.BaseRepos;
using EMSCT.INFRA.Context;
using Microsoft.EntityFrameworkCore;

namespace EMSCT.INFRA.Repositories.Concrete.BaseRepos
{
    public class BaseWriteRepository<T> : IBaseWriteRepository<T> where T : class, IBaseEntity, new()
    {
        private readonly AppDbContext _context;
        protected DbSet<T> _dbSet;

        public BaseWriteRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == entity.Id);
            entity.Status = Status.Deleted;
            entity.DeleteDate = DateTime.Now;
            return await SaveChangesAsync() > 0;
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
