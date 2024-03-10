using EMSCT.DAL.ConcreteRepositories.BaseRepos;
using EMSCT.DAL.Context;
using EMSCT.DATA.Entities.Concrete;

namespace EMSCT.DAL.ConcreteRepositories.DepartmentRepos
{
    public class DepartmentWriteRepository : BaseWriteRepository<Department>
    {
        public DepartmentWriteRepository(AppDbContext context) : base(context) { }

    }
}
