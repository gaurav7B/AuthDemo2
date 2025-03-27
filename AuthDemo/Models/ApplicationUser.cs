using Microsoft.AspNetCore.Identity;

namespace AuthDemo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
