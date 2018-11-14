using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication3.Areas.Identity.Data
{
    public class CustomizeUserRole : IdentityUserRole<string>
    {
        public virtual CustomizeUser User { get; set; }
        public virtual CustomizeRole Role { get; set; }
    }
}
