using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShawlGalore.Data;
using ShawlGalore.Models;

namespace ShawlGalore.Controllers
{
    public class ShawlsController : Controller
    {
        private readonly ShawlGaloreContext _context;

        public ShawlsController(ShawlGaloreContext context)
        {
            _context = context;
        }

        // GET: Shawls
        // GET: Movies
        public async Task<IActionResult> Index(string shawlOccasion, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> occasionQuery = from m in _context.Shawl
                                               orderby m.Occasion
                                               select m.Occasion;

            var shawls = from m in _context.Shawl
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                shawls = shawls.Where(s => s.Material.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(shawlOccasion))
            {
                shawls = shawls.Where(x => x.Occasion == shawlOccasion);
            }

            var shawlOccasionVM = new ShawlOccasionViewModel
            {
                Occasions = new SelectList(await occasionQuery.Distinct().ToListAsync()),
                Shawls = await shawls.ToListAsync()
            };

            return View(shawlOccasionVM);
        }

        // GET: Shawls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shawl = await _context.Shawl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shawl == null)
            {
                return NotFound();
            }

            return View(shawl);
        }

        // GET: Shawls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shawls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image,Material,Color,Design,Occasion,Size,Price")] Shawl shawl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shawl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shawl);
        }

        // GET: Shawls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shawl = await _context.Shawl.FindAsync(id);
            if (shawl == null)
            {
                return NotFound();
            }
            return View(shawl);
        }

        // POST: Shawls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,Material,Color,Design,Occasion,Size,Price")] Shawl shawl)
        {
            if (id != shawl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shawl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShawlExists(shawl.Id))
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
            return View(shawl);
        }

        // GET: Shawls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shawl = await _context.Shawl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shawl == null)
            {
                return NotFound();
            }

            return View(shawl);
        }

        // POST: Shawls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shawl = await _context.Shawl.FindAsync(id);
            _context.Shawl.Remove(shawl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShawlExists(int id)
        {
            return _context.Shawl.Any(e => e.Id == id);
        }
    }
}
