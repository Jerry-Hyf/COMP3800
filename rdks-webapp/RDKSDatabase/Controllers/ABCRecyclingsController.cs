using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RDKSDatabase.Data;
using RDKSDatabase.Models;

namespace RDKSDatabase.Controllers
{
    public class ABCRecyclingsController : Controller
    {
        private readonly RDKSDatabaseContext _context;

        public ABCRecyclingsController(RDKSDatabaseContext context)
        {
            _context = context;
        }

        // GET: ABCRecyclings
        public async Task<IActionResult> Index()
        {
              return _context.ABCRecycling != null ? 
                          View(await _context.ABCRecycling.ToListAsync()) :
                          Problem("Entity set 'RDKSDatabaseContext.ABCRecycling'  is null.");
        }

        // GET: ABCRecyclings/Details/5
        public async Task<IActionResult> Details(DateTime? id)
        {
            if (id == null || _context.ABCRecycling == null)
            {
                return NotFound();
            }

            var aBCRecycling = await _context.ABCRecycling
                .FirstOrDefaultAsync(m => m.ABCDateID == id);
            if (aBCRecycling == null)
            {
                return NotFound();
            }

            return View(aBCRecycling);
        }

        // GET: ABCRecyclings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ABCRecyclings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ABCDateID,ABC_LOCATION,ABC_MATERIAL,TOTAL_POUND_NETWEIGHT,TOTAL_TONNAGE_NETWEIGHT,TOTAL_TONNAGE_MATERIAL,ABC_COMPLETED")] ABCRecycling aBCRecycling)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aBCRecycling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aBCRecycling);
        }

        // GET: ABCRecyclings/Edit/5
        public async Task<IActionResult> Edit(DateTime? id)
        {
            if (id == null || _context.ABCRecycling == null)
            {
                return NotFound();
            }

            var aBCRecycling = await _context.ABCRecycling.FindAsync(id);
            if (aBCRecycling == null)
            {
                return NotFound();
            }
            return View(aBCRecycling);
        }

        // POST: ABCRecyclings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DateTime? id, [Bind("ABCDateID,ABC_LOCATION,ABC_MATERIAL,TOTAL_POUND_NETWEIGHT,TOTAL_TONNAGE_NETWEIGHT,TOTAL_TONNAGE_MATERIAL,ABC_COMPLETED")] ABCRecycling aBCRecycling)
        {
            if (id != aBCRecycling.ABCDateID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aBCRecycling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ABCRecyclingExists(aBCRecycling.ABCDateID))
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
            return View(aBCRecycling);
        }

        // GET: ABCRecyclings/Delete/5
        public async Task<IActionResult> Delete(DateTime? id)
        {
            if (id == null || _context.ABCRecycling == null)
            {
                return NotFound();
            }

            var aBCRecycling = await _context.ABCRecycling
                .FirstOrDefaultAsync(m => m.ABCDateID == id);
            if (aBCRecycling == null)
            {
                return NotFound();
            }

            return View(aBCRecycling);
        }

        // POST: ABCRecyclings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(DateTime? id)
        {
            if (_context.ABCRecycling == null)
            {
                return Problem("Entity set 'RDKSDatabaseContext.ABCRecycling'  is null.");
            }
            var aBCRecycling = await _context.ABCRecycling.FindAsync(id);
            if (aBCRecycling != null)
            {
                _context.ABCRecycling.Remove(aBCRecycling);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ABCRecyclingExists(DateTime? id)
        {
          return (_context.ABCRecycling?.Any(e => e.ABCDateID == id)).GetValueOrDefault();
        }
    }
}
