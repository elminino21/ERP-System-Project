using Microsoft.EntityFrameworkCore;
using Newsboard.Services.AuthService.API.Models;

namespace Newsboard.Services.AuthService.API.Data
{
    public class DataContext: DbContext
    {
       public DataContext(DbContextOptions<DataContext> options): base(options){}
       
       public DbSet<User> Users { get; set; }
       public DbSet<Address> Addresses { get; set; }
    }
}