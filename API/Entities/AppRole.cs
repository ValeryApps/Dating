﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace api.entities
{
    public class AppRole:IdentityRole<int>
    {
        public ICollection<AppUserRole> AppUserRoles { get; set; }
    }
}