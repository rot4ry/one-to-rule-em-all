using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oneWeb.Models {
  public class BookingModel {
    [Key]
    public int Id { get; set; }

    [ForeignKey("Id")]
    public int UserId { get; set; }

    [ForeignKey("Id")]
    public int HotelId { get; set; }

    [Required]
    public DateOnly DateStart { get; set; }
    
    [Required]
    public DateOnly DateEnd { get; set; }
  }
}
