using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Newsboard.Services.AuthService.API.Models
{
    public class User: IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
       [Required] 
        public Address Address { get; set; }
        public string PasswordSalt { get; set; }
    }
}