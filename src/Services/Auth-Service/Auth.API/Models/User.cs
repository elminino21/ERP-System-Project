using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Auth.API.Models
{
    public class User: IdentityUser
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
       [Required] 
        public string PasswordSalt { get; set; }
        public Address Address { get; set; }
    }
}