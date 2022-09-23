using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oneWeb.Models {
  public class PhotoModel {
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("Id")] // test?
    public int HotelId { get; set; }

    [Required]
    public string PhotoPath { get; set; }
  }
}
