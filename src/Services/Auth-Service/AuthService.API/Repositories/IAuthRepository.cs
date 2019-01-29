using System.Threading.Tasks;
using Newsboard.Services.AuthService.API.Models;

namespace Newsboard.Services.AuthService.API.Repositories
{
    public interface IAuthRepository
    {
        Task<User> Register(User user); 
        Task<User> Login( User user);
        Task<User> ChangePassword(User user);
    }
}