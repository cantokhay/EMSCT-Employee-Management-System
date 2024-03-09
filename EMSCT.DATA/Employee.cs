using Microsoft.AspNetCore.Identity;

namespace EMSCT.DATA
{
    public class Employee : IdentityUser, IBaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
        public Gender Gender { get; set; }
        public string Password { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
