using EMSCT.DATA.Entities.Abstract;
using EMSCT.DATA.Enums;

namespace EMSCT.DATA.Entities.Concrete
{
    public class Department : IBaseEntity
    {
        public Department()
        {
            Employees = new HashSet<AppUser>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

        public ICollection<AppUser> Employees { get; set; }

    }
}
