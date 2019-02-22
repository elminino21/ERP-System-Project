using System.Threading.Tasks;
using Auth.API.Models;

namespace Auth.API.Repositories
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, Address address); 
        Task<User> Login( User user);
        Task<User> ChangePassword(User user);
    }
}