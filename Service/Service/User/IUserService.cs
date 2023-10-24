using Data.Models;

namespace Service.Service.User
{
    public interface IUserService
    {
        Task<ApplicationUser> GetUserByIdAsync(string id);
    }
}
