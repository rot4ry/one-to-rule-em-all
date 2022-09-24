﻿using Microsoft.AspNetCore.Mvc;
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
    public async Task<IActionResult> Create (HotelModel hotel) {
      if (ModelState.IsValid) {
        _dbContext.Add(hotel);
        // add photos?
        await _dbContext.SaveChangesAsync();

        return RedirectToAction("Index");
      } else {
        return View(hotel);
      }
    }

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
