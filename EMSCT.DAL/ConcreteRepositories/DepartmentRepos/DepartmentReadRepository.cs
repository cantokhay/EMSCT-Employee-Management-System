using EMSCT.DAL.ConcreteRepositories.BaseRepos;
using EMSCT.DAL.Context;
using EMSCT.DATA.Entities.Concrete;

namespace EMSCT.DAL.ConcreteRepositories.DepartmentRepos
{
    public class DepartmentReadRepository : BaseReadRepository<Department>
    {
        public DepartmentReadRepository(AppDbContext context) : base(context) { }

    }
}
