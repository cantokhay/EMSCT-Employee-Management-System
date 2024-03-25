using EMSCT.DATA.Entities.Abstract;

namespace EMSCT.DATA.Repositories.Abstract.BaseRepos
{
    public interface IBaseWriteRepository<T> where T : class, IBaseEntity, new()
    {
        Task<bool> InsertAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid id);
        Task<int> SaveChangesAsync();
        void DetachEntityAsync(T entity);
    }
}