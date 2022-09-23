using Microsoft.EntityFrameworkCore;
using oneWeb.Models;

namespace oneWeb.Database {
  public class OneDBContext : DbContext {
    public OneDBContext (DbContextOptions<OneDBContext> options) : base(options) {
    }

    // TODO: Add models
    //public DbSet<HotelModel> Hotels { get; set; }
    //public DbSet<UserModel> Users { get; set; }
  }
}
