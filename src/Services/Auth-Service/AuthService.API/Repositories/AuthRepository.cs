using System.Threading.Tasks;
using Newsboard.Services.AuthService.API.Models;
/// <summary>
/// implements logic related to users DataBase Requested
/// </summary>
namespace Newsboard.Services.AuthService.API.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        public Task<User> ChangePassword(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Login(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Register(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}