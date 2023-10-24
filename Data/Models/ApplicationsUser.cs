using Microsoft.AspNetCore.Identity;

namespace Data.Models
{
    public class ApplicationUser : IdentityUser<string>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}