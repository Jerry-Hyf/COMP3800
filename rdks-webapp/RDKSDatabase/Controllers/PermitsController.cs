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
    public class PermitsController : Controller
    {
        private readonly RDKSDatabaseContext _context;

        public PermitsController(RDKSDatabaseContext context)
        {
            _context = context;
        }

        // GET: Permits
        public async Task<IActionResult> Index()
        {
            var rDKSDatabaseContext = _context.Permit.Include(p => p.Material);
            return View(await rDKSDatabaseContext.ToListAsync());
        }

        // GET: Permits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Permit == null)
            {
                return NotFound();
            }

            var permit = await _context.Permit
                .Include(p => p.Material)
                .FirstOrDefaultAsync(m => m.PermitNumberPrefix == id);
            if (permit == null)
            {
                return NotFound();
            }

            return View(permit);
        }

        // GET: Permits/Create
        public IActionResult Create()
        {
            ViewData["MaterialCode"] = new SelectList(_context.Set<Material>(), "MaterialCode", "MaterialType");
            return View();
        }

        // POST: Permits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PermitId,PermitNumberPrefix,PermitNumber,FacilityCode,PermitApplicationDate,EstimatedVolume,units,EstimatedLoads,Frequency,Comments,ContaminateLoadsDate,ContaminateLoadsComments,ContaminatedLoads,PermitSentToOperatorAndWMF,PermitSavedOnServerAndFiled,HardCopyPermitSavedInFile,ApprovedBy,PermitClosedCardPermissionsRevolked,PermitStatus,PermitType,PermitFee,ExpirationDate,ApplicationFeeInvoiced,ApplicantName,ApplicantPhone,ApplicantEmail,Hauler,Hauler2,CUS_ID,WasteGenerator,MaterialCode")] Permit permit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(permit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaterialCode"] = new SelectList(_context.Set<Material>(), "MaterialCode", "MaterialType", permit.MaterialCode);
            return View(permit);
        }

        // GET: Permits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Permit == null)
            {
                return NotFound();
            }

            var permit = await _context.Permit.FindAsync(id);
            if (permit == null)
            {
                return NotFound();
            }
            ViewData["MaterialCode"] = new SelectList(_context.Set<Material>(), "MaterialCode", "MaterialType", permit.MaterialCode);
            return View(permit);
        }

        // POST: Permits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PermitId,PermitNumberPrefix,PermitNumber,FacilityCode,PermitApplicationDate,EstimatedVolume,units,EstimatedLoads,Frequency,Comments,ContaminateLoadsDate,ContaminateLoadsComments,ContaminatedLoads,PermitSentToOperatorAndWMF,PermitSavedOnServerAndFiled,HardCopyPermitSavedInFile,ApprovedBy,PermitClosedCardPermissionsRevolked,PermitStatus,PermitType,PermitFee,ExpirationDate,ApplicationFeeInvoiced,ApplicantName,ApplicantPhone,ApplicantEmail,Hauler,Hauler2,CUS_ID,WasteGenerator,MaterialCode")] Permit permit)
        {
            if (id != permit.PermitNumberPrefix)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(permit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PermitExists(permit.PermitNumberPrefix))
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
            ViewData["MaterialCode"] = new SelectList(_context.Set<Material>(), "MaterialCode", "MaterialType", permit.MaterialCode);
            return View(permit);
        }

        // GET: Permits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Permit == null)
            {
                return NotFound();
            }

            var permit = await _context.Permit
                .Include(p => p.Material)
                .FirstOrDefaultAsync(m => m.PermitNumberPrefix == id);
            if (permit == null)
            {
                return NotFound();
            }

            return View(permit);
        }

        // POST: Permits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Permit == null)
            {
                return Problem("Entity set 'RDKSDatabaseContext.Permit'  is null.");
            }
            var permit = await _context.Permit.FindAsync(id);
            if (permit != null)
            {
                _context.Permit.Remove(permit);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PermitExists(int id)
        {
          return (_context.Permit?.Any(e => e.PermitNumberPrefix == id)).GetValueOrDefault();
        }
    }
}
