using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication3.Areas.Identity.Data
{
    public class CustomizeRole : IdentityRole
    {
        public ICollection<CustomizeUserRole> UserRoles { get; set; }
        public CustomizeRole()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public CustomizeRole(string roleName)
            : this()
        {
            this.Name = roleName;
        }
    }
}
