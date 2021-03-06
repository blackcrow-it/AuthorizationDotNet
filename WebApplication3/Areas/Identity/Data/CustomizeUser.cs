﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication3.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the CustomizeUser class
    public class CustomizeUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        public ICollection<CustomizeUserRole> UserRoles { get; set; }
    }
}
