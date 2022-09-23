using Microsoft.EntityFrameworkCore;
using oneWeb.Models;

namespace oneWeb.Database {
  public class OneDBContext : DbContext {
    public OneDBContext (DbContextOptions<OneDBContext> options) : base(options) {
    }

    // done
    public DbSet<HotelModel> Hotels { get; set; }
    public DbSet<PhotoModel> Photos { get; set; }
    public DbSet<UserModel> Users { get; set; }
    
    // todo
    public DbSet<BookingModel> Bookings { get; set; }
  }
}
