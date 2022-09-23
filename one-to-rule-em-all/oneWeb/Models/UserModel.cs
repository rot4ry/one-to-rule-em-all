using System.ComponentModel.DataAnnotations;

namespace oneWeb.Models {
  public class UserModel {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Surname { get; set; }

    [Required]
    public string Email { get; set; } // regex pattern?

    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    [Required]
    public bool isAdmin { get; set; } = false;
  }
}
