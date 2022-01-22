using Microsoft.AspNetCore.Identity;
using System;

namespace SportsStore.Models
{
    public class AppUser : IdentityUser
    {
        public byte[] AvatarImage { get; set; } = new byte[0];
    }
}
