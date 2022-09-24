using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using oneWeb.Database;

namespace oneWeb.Controllers {
  public class HotelController: Controller {
    private readonly OneDBContext _dbContext;

    public HotelController (OneDBContext dbContext) {
      _dbContext = dbContext;
    }

    // GET: Hotel list
    public async Task<IActionResult> Index () {
      return View(await _dbContext.Hotels.ToListAsync());
    }

    // GET: Create hotel
    public IActionResult Create () {
      return View();
    }

    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Create ([Bind("Id,Name")] HotelModel hotel) {
    //  if (ModelState.IsValid) {
    //    _context.Hotels.Add(category);
    //    await _context.SaveChangesAsync();
    //    return RedirectToAction(nameof(Index));
    //  }
    //  return View(hotel);
    //}
  }
}
