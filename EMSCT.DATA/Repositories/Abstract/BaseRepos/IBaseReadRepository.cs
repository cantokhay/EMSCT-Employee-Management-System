using EMSCT.DATA.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace EMSCT.DATA.Repositories.Abstract.BaseRepos
{
    public interface IBaseReadRepository<T> where T : class, IBaseEntity, new()
    {
        Task<bool> Any(Expression<Func<T, bool>> expression);
        Task<T> GetDefault(Expression<Func<T, bool>> expression);
        Task<T> GetSingleDefault(Expression<Func<T, bool>> expression);
        Task<List<T>> GetDefaults(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<TResult> GetFilteredFirstOrDefault<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<List<TResult>> GetFilteredList<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }
}
