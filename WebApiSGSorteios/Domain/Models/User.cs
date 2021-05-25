﻿using Microsoft.AspNetCore.Identity;

namespace Domain.Models
{
    public class User : IdentityUser<int>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
