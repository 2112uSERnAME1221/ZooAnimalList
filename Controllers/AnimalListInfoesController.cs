using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZooAnimalList.Data;
using ZooAnimalList.Models;



namespace ZooAnimalList.Controllers
{
    public class AnimalListInfoesController : Controller
    {
        private readonly ZooAnimalListContext _context;

        public AnimalListInfoesController(ZooAnimalListContext context)
        {
            _context = context;
        }

        // GET: AnimalListInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AnimalListInfo.ToListAsync());
        }

        // GET: AnimalListInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalListInfo = await _context.AnimalListInfo
                .FirstOrDefaultAsync(m => m.AnimalId == id);
            if (animalListInfo == null)
            {
                return NotFound();
            }

            return View(animalListInfo);
        }

        // GET: AnimalListInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnimalListInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AnimalId,Name,Species,Wieght,Gender,Status")] AnimalListInfo animalListInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(animalListInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(animalListInfo);
        }

        // GET: AnimalListInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalListInfo = await _context.AnimalListInfo.FindAsync(id);
            if (animalListInfo == null)
            {
                return NotFound();
            }
            return View(animalListInfo);
        }

        // POST: AnimalListInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AnimalId,Name,Species,Wieght,Gender,Status")] AnimalListInfo animalListInfo)
        {
            if (id != animalListInfo.AnimalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(animalListInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimalListInfoExists(animalListInfo.AnimalId))
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
            return View(animalListInfo);
        }

        // GET: AnimalListInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalListInfo = await _context.AnimalListInfo
                .FirstOrDefaultAsync(m => m.AnimalId == id);
            if (animalListInfo == null)
            {
                return NotFound();
            }

            return View(animalListInfo);
        }

        // POST: AnimalListInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var animalListInfo = await _context.AnimalListInfo.FindAsync(id);
            if (animalListInfo != null)
            {
                _context.AnimalListInfo.Remove(animalListInfo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimalListInfoExists(int id)
        {
            return _context.AnimalListInfo.Any(e => e.AnimalId == id);
        }
    }
}
