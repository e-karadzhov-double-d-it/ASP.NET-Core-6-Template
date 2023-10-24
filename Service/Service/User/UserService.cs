using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Service.Service.User
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string id)
        {
            /*      var newUser = new ApplicationUser()
                  {
                      Email = "test@tes.com",
                      PasswordHash = Guid.NewGuid().ToString(),
                      AccessFailedCount = 0,
                      EmailConfirmed = true,
                      ConcurrencyStamp = Guid.NewGuid().ToString(),
                      UserName = Guid.NewGuid().ToString(),
                      PhoneNumber = Guid.NewGuid().ToString(),
                  };

                  await this.dbContext.AddAsync(newUser);
                  await this.dbContext.SaveChangesAsync();*/

            return await this.dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
