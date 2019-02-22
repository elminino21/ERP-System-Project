using System.Threading.Tasks;
using Auth.API.Data;
using Auth.API.Models;
/// <summary>
/// implements logic related to users DataBase Requested
/// </summary>
namespace Auth.API.Repositories 
{
    public class AuthRepository : IAuthRepository
    {
        private  DataContext _dbContext;
        public AuthRepository(DataContext dbContext)
        {
            _dbContext = dbContext;

        }

        public Task<User> ChangePassword(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Login(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Register(User user, Address address)
        {
            throw new System.NotImplementedException();
        }
    }
}