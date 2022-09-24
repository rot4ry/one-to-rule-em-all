using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using oneWeb.Database;
using oneWeb.Models;

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

    // POST: Create hotel
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create ([Bind("Id,Name")] HotelModel hotel) {
      if (ModelState.IsValid) {
        _dbContext.Add(hotel);

        await _dbContext.SaveChangesAsync();

        return RedirectToAction("Index");
      } else {
        return View(hotel);
      }
    }

    // TODO:
    // Change return types!
    public IActionResult Details (int? id) {
      return View();
    }

    // TODO
    // Change return types!
    public IActionResult Edit (int? id) {
      return View();
    }

    // TODO
    // Change return types!
    public IActionResult Delete (int? id) {
      return View();
    }
  }
}
