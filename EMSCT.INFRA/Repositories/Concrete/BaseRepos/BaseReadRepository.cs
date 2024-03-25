using EMSCT.DATA.Entities.Abstract;
using EMSCT.DATA.Repositories.Abstract.BaseRepos;
using EMSCT.INFRA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace EMSCT.INFRA.Repositories.Concrete.BaseRepos
{
    public class BaseReadRepository<T> : IBaseReadRepository<T> where T : class, IBaseEntity, new()
    {
        private readonly AppDbContext _context;
        protected DbSet<T> _dbSet;

        public BaseReadRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<bool> Any(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<T> GetDefault(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<List<T>> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public async Task<TResult> GetFilteredFirstOrDefault<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _dbSet;

            if (where != null)
                query = query.Where(where);

            if (include != null)
                query = include(query);

            if (orderBy != null)
                return await orderBy(query).Select(select).FirstOrDefaultAsync();

            else
                return await query.Select(select).FirstOrDefaultAsync();
        }

        public async Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _dbSet;

            if (where != null)
                query = query.Where(where);

            if (include != null)
                query = include(query);

            if (orderBy != null)
                return await orderBy(query).Select(select).ToListAsync();

            else
                return await query.Select(select).ToListAsync();
        }

        public async Task<T> GetSingleDefault(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.SingleOrDefaultAsync(expression);
        }
    }
}
