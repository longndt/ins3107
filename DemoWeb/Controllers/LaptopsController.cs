using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoWeb.Data;
using DemoWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace DemoWeb.Controllers
{
    public class LaptopsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LaptopsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Laptops
        [Authorize(Roles = "Admin, Customer")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Laptop.Include(l => l.Category);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Laptops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptop = await _context.Laptop
                .Include(l => l.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laptop == null)
            {
                return NotFound();
            }

            return View(laptop);
        }

        // GET: Laptops/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name");
            return View();
        }

        // POST: Laptops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Quantity,Image,CategoryId")] Laptop laptop, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                //validate image is valid or not
                if (Image != null && Image.Length > 0)
                {
                    //set image file name
                    var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(Image.FileName);
                    //set image file location
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        //copy (upload) image file from orignal location to project folder
                        Image.CopyTo(stream);
                    }

                    //set image file name for book cover
                    laptop.Image = "/images/" + fileName;
                }
                _context.Add(laptop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", laptop.CategoryId);
            return View(laptop);
        }

        // GET: Laptops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptop = await _context.Laptop.FindAsync(id);
            if (laptop == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", laptop.CategoryId);
            return View(laptop);
        }

        // POST: Laptops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Quantity,Image,CategoryId")] Laptop laptop)
        {
            if (id != laptop.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laptop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaptopExists(laptop.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", laptop.CategoryId);
            return View(laptop);
        }

        // GET: Laptops/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptop = await _context.Laptop
                .Include(l => l.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laptop == null)
            {
                return NotFound();
            }

            return View(laptop);
        }

        // POST: Laptops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var laptop = await _context.Laptop.FindAsync(id);
            _context.Laptop.Remove(laptop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaptopExists(int id)
        {
            return _context.Laptop.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Search(string name)
        {
            var applicationDbContext = _context.Laptop.Include(l => l.Category).Where(lap => lap.Name.Contains(name));
            return View("Index", await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> SortPriceAsc()
        {
            var applicationDbContext = _context.Laptop.Include(l => l.Category).OrderBy(lap => lap.Price);
            return View("Index", await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> SortPriceDesc()
        {
            var applicationDbContext = _context.Laptop.Include(l => l.Category).OrderByDescending(lap => lap.Price);
            return View("Index", await applicationDbContext.ToListAsync());
        }
    }
}
