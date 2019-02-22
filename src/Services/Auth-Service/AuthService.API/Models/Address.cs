using System.ComponentModel.DataAnnotations;
/// <summary>
/// classes is need for localize user information
/// </summary>
namespace Newsboard.Services.AuthService.API.Models
{
    public class Address
    {

    
    public int Id { get; set; }
   
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
     public int UserId { get; set; }
     public User User { get; set; }

    }
}
