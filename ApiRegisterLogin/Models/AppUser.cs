using Microsoft.AspNetCore.Identity;

namespace ApiRegisterLogin.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
