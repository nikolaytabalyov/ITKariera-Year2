using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CampRating.Data;
using CampRating.Models;

namespace CampRating.Controllers
{
    public class CampingSitesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CampingSitesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CampingSites
        public async Task<IActionResult> Index()
        {
            return View(await _context.CampingSites.ToListAsync());
        }

        // GET: CampingSites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campingSite = await _context.CampingSites
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campingSite == null)
            {
                return NotFound();
            }

            return View(campingSite);
        }

        // GET: CampingSites/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CampingSites/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Latitude,Longitude,PhotoUrl")] CampingSite campingSite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campingSite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campingSite);
        }

        // GET: CampingSites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campingSite = await _context.CampingSites.FindAsync(id);
            if (campingSite == null)
            {
                return NotFound();
            }
            return View(campingSite);
        }

        // POST: CampingSites/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Latitude,Longitude,PhotoUrl")] CampingSite campingSite)
        {
            if (id != campingSite.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campingSite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampingSiteExists(campingSite.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(campingSite);
        }

        // GET: CampingSites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campingSite = await _context.CampingSites
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campingSite == null)
            {
                return NotFound();
            }

            return View(campingSite);
        }

        // POST: CampingSites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campingSite = await _context.CampingSites.FindAsync(id);
            if (campingSite != null)
            {
                _context.CampingSites.Remove(campingSite);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampingSiteExists(int id)
        {
            return _context.CampingSites.Any(e => e.Id == id);
        }
    }
}
