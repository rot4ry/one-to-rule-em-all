using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using oneWeb.Models;

namespace oneWeb.Database {
  public class OneDBContext : IdentityDbContext <UserModel> {
    public OneDBContext (DbContextOptions<OneDBContext> options) : base(options) {
    }

    public DbSet<HotelModel> Hotels { get; set; }
    public DbSet<PhotoModel> Photos { get; set; }
    public DbSet<UserModel> Users { get; set; }
    public DbSet<BookingModel> Bookings { get; set; }
  }
}
