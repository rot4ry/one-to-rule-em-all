using Microsoft.EntityFrameworkCore;
using oneWeb.Models;

namespace oneWeb.Database {
  public class OneDBContext : DbContext {
    public OneDBContext (DbContextOptions<OneDBContext> options) : base(options) {
    }

    public DbSet<HotelModel> Hotels { get; set; }
    
    // TODO: Add models
    //public DbSet<UserModel> Users { get; set; }
  }
}
