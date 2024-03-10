using EMSCT.DATA.Enums;
using Microsoft.AspNetCore.Identity;

namespace EMSCT.DATA.Entities
{
    public class Employee : IdentityUser, IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }

        public Department Department { get; set; }
    }
}
