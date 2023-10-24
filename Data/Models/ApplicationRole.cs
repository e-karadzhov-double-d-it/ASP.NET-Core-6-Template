using Microsoft.AspNetCore.Identity;

namespace Data.Models
{
    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}