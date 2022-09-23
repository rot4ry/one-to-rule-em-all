using System.ComponentModel.DataAnnotations;

namespace oneWeb.Models {
  public class HotelModel {
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MinLength(5)]
    public string HotelName { get; set; }
    
    [Required]
    public string Country { get; set; }
    
    [Required]
    public string City { get; set; }

    // street / building number
    [Required]
    public string Address { get; set; }
  }
}
