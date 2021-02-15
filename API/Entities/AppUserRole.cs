﻿using Microsoft.AspNetCore.Identity;

namespace api.entities
{
    public class AppUserRole:IdentityUserRole<int>
    {
        public AppUser AppUser { get; set; }
        public AppRole AppRole { get; set; }
    }
}