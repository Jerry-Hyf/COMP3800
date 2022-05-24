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
    /// <summary>
    /// This class is the controller for permit model
    /// </summary>
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
              return _context.Permit != null ? 
                          View(await _context.Permit.ToListAsync()) :
                          Problem("Entity set 'RDKSDatabaseContext.Permit'  is null.");
        }

        // GET: Permits/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Permit == null)
            {
                return NotFound();
            }

            var permit = await _context.Permit
                .FirstOrDefaultAsync(m => m.PermitId == id);
            if (permit == null)
            {
                return NotFound();
            }

            return View(permit);
        }

        // GET: Permits/Create
        public IActionResult Create()
        {
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
            return View(permit);
        }

        // GET: Permits/Edit/5
        public async Task<IActionResult> Edit(string id)
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
            return View(permit);
        }

        // POST: Permits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PermitId,PermitNumberPrefix,PermitNumber,FacilityCode,PermitApplicationDate,EstimatedVolume,units,EstimatedLoads,Frequency,Comments,ContaminateLoadsDate,ContaminateLoadsComments,ContaminatedLoads,PermitSentToOperatorAndWMF,PermitSavedOnServerAndFiled,HardCopyPermitSavedInFile,ApprovedBy,PermitClosedCardPermissionsRevolked,PermitStatus,PermitType,PermitFee,ExpirationDate,ApplicationFeeInvoiced,ApplicantName,ApplicantPhone,ApplicantEmail,Hauler,Hauler2,CUS_ID,WasteGenerator,MaterialCode")] Permit permit)
        {
            if (id != permit.PermitId)
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
                    if (!PermitExists(permit.PermitId))
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
            return View(permit);
        }

        // GET: Permits/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Permit == null)
            {
                return NotFound();
            }

            var permit = await _context.Permit
                .FirstOrDefaultAsync(m => m.PermitId == id);
            if (permit == null)
            {
                return NotFound();
            }

            return View(permit);
        }

        // POST: Permits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
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

        private bool PermitExists(string id)
        {
          return (_context.Permit?.Any(e => e.PermitId == id)).GetValueOrDefault();
        }
    }
}
