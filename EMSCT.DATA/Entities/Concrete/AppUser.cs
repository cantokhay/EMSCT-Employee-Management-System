﻿using EMSCT.DATA.Entities.Abstract;
using EMSCT.DATA.Enums;
using Microsoft.AspNetCore.Identity;

namespace EMSCT.DATA.Entities.Concrete
{
    public class AppUser : IdentityUser, IBaseEntity
    {
        public AppUser()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string TCKN { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
