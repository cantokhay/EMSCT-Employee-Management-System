using EMSCT.DAL.ConcreteRepositories.BaseRepos;
using EMSCT.DAL.Context;
using EMSCT.DATA.Entities.Concrete;

namespace EMSCT.DAL.ConcreteRepositories.AppUserRepos
{
    public class AppUserWriteRepository : BaseWriteRepository<AppUser>
    {
        public AppUserWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
