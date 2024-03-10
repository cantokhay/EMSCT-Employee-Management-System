using EMSCT.DATA.Entities.BaseAbstract;

namespace EMSCT.DATA.AbstractRepos.BaseRepos
{
    public interface IBaseWriteRepository<T> where T : class, IBaseEntity, new()
    {
        Task<bool> Insert(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(Guid id);
        Task<int> SaveChangesAsync();
        void DetachEntity(T entity);
    }
}