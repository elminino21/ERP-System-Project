using Auth.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth.API.Data
{
    public class DataContext: DbContext
    {
       public DataContext(DbContextOptions<DataContext> options): base(options){}
       
       public DbSet<User> Users { get; set; }
       public DbSet<Address> Addresses { get; set; }
    }
}