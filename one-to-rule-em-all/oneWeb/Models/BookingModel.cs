using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oneWeb.Models {
  public class BookingModel {
    [Key]
    [DisplayName("ID rezerwacji")]
    public int Id { get; set; }

    [ForeignKey("Id")]
    [DisplayName("ID klienta")]
    public int UserId { get; set; }

    [ForeignKey("Id")]
    [DisplayName("ID hotelu")]
    public int HotelId { get; set; }

    [Required]
    [DisplayName("Rezerwacja od")]
    public DateTime DateStart { get; set; }
    
    [Required]
    [DisplayName("Rezerwacja do")]
    public DateTime DateEnd { get; set; }
  }
}
