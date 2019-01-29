using System.ComponentModel.DataAnnotations;

namespace Newsboard.Services.AuthService.API.Models
{
    public class Address
    {

    
    public int Id { get; set; }
    public User User { get; set; }
    [Required]
    public string Street { get; set; }
    [Required]
    public string City { get; set; }
        [Required]
     public string State { get; set; }
    [Required]
     public string Contry { get; set; }
    [Required]
     public int Zip { get; set; }

    }
}
