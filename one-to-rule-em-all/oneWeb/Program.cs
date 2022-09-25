using Microsoft.EntityFrameworkCore;
using oneWeb.Database;
using Microsoft.AspNetCore.Identity;
using oneWeb.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<OneDBContext>(
  options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DBConnection")
  )
);

builder.Services.AddDefaultIdentity<UserModel>(options => options.SignIn.RequireConfirmedAccount = false) // true?
    .AddEntityFrameworkStores<OneDBContext>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// When ALL services registered (!!!)
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();;
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages(); // for Identity to work

app.Run();
