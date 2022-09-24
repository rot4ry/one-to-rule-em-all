using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace oneWeb.Models {
  public class HotelModel {
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MinLength(5)]
    [DisplayName("Hotel")]
    public string Name { get; set; }

    [Required]
    [DisplayName("Kraj")]
    public string Country { get; set; }

    [Required]
    [DisplayName("Miasto")]
    public string City { get; set; }

    // street / building number
    [Required]
    [DisplayName("Ulica i numer budynku")]
    public string Address { get; set; }
  }
}
