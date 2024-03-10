using EMSCT.DAL.ConcreteRepositories.BaseRepos;
using EMSCT.DAL.Context;
using EMSCT.DATA.Entities.Concrete;

namespace EMSCT.DAL.ConcreteRepositories.AppUserRepos
{
    public class AppUserReadRepository : BaseReadRepository<AppUser>
    {
        public AppUserReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
