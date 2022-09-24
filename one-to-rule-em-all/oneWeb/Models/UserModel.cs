using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Identity
namespace oneWeb.Models {
  public class UserModel {
    [Key]
    public int Id { get; set; }

    [Required]
    [DisplayName("Imię")]
    public string Name { get; set; }

    [Required]
    [DisplayName("Nazwisko")]
    public string Surname { get; set; }

    [Required]
    [DisplayName("Adres e-mail")]
    public string Email { get; set; } // regex pattern?

    [Required]
    [MinLength(6)]
    [DisplayName("Hasło")]
    public string Password { get; set; }

    [Required]
    [DisplayName("Admin")]
    public bool isAdmin { get; set; } = false;
  }
}
