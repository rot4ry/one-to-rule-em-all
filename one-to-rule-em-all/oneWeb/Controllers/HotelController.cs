using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using oneWeb.Database;
using oneWeb.Models;

namespace oneWeb.Controllers {
  public class HotelController: Controller {
    private readonly OneDBContext _dbContext;
    private readonly UserManager<UserModel> _userManager;
    private readonly SignInManager<UserModel> _signInManager;

    public HotelController (OneDBContext dbContext, UserManager<UserModel> userManager, SignInManager<UserModel> signInManager) {
      _dbContext = dbContext;
      _userManager = userManager;
      _signInManager = signInManager;
    }

    private bool AdminSignedIn () => _signInManager.IsSignedIn(User) && _userManager.GetUserAsync(User).Result.isAdmin;

    // GET: Hotel list
    public async Task<IActionResult> Index () {
      return View(await _dbContext.Hotels.ToListAsync());
    }

    // ------------------------------------------------------------
    // GET: Create hotel
    public IActionResult Create () {
      if (AdminSignedIn()) {
        return View();
      } else {
        return RedirectToAction("Index");
      }
    }
    
    // POST: Create hotel
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create (HotelModel hotel) {
      if (!AdminSignedIn()) {
        return RedirectToAction("Index");
      }

      if (ModelState.IsValid) {
        _dbContext.Add(hotel);
        // add photos?
        await _dbContext.SaveChangesAsync();

        return RedirectToAction("Index");
      } else {
        return View(hotel);
      }
    }

    // ------------------------------------------------------------
    // GET: Show hotel details
    // todo: use viewmodel to get photos?
    public async Task<IActionResult> Details (int? id) {
      if (id == null) {
        return NotFound();
      }

      HotelModel? hotel = await _dbContext.Hotels.FirstOrDefaultAsync(h => h.Id == id);
      if (hotel == null) {
        return NotFound();
      }

      return View(hotel);
    }

    // ------------------------------------------------------------
    // GET: Edit hotel
    public async Task<IActionResult> Edit (int? id) {
      if (!AdminSignedIn()) {
        return RedirectToAction("Index");
      }

      if (id == null) {
        return NotFound();
      }

      HotelModel? hotel = await _dbContext.Hotels.FirstOrDefaultAsync(h => h.Id == id);
      if (hotel == null) {
        return NotFound();
      }

      return View(hotel);
    }

    // POST: Update hotel
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit (int id, HotelModel hotel) {
      if (!AdminSignedIn()) {
        return RedirectToAction("Index");
      }

      if (id != hotel.Id) {
        return NotFound();
      }

      if (ModelState.IsValid) {
        try {
          _dbContext.Hotels.Update(hotel);
          await _dbContext.SaveChangesAsync();
        } catch (Exception e) {
          return NotFound();
        }
        
        return RedirectToAction("Index");
      }

      return View(hotel);
    }

    // ------------------------------------------------------------
    // GET: Delete hotel
    public async Task<IActionResult> Delete (int? id) {
      if (!AdminSignedIn()) {
        return RedirectToAction("Index");
      }

      if (id == null) {
        return NotFound();
      }
      
      HotelModel? hotel = await _dbContext.Hotels.FirstOrDefaultAsync(h => h.Id == id);
      if (hotel == null) {
        return NotFound();
      }

      return View(hotel);
    }

    // POST: Delete hotel
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteHotel (int? id) {
      if (!AdminSignedIn()) {
        return RedirectToAction("Index");
      }

      if (id == null) {
        return NotFound();
      }

      HotelModel? hotel = await _dbContext.Hotels.FindAsync(id);
      if (hotel == null) {
        return NotFound();
      }

      _dbContext.Hotels.Remove(hotel);
      await _dbContext.SaveChangesAsync();

      return RedirectToAction("Index");
    }
  }
}
